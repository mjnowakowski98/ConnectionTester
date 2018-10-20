﻿using System;
using System.Reflection;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Configuration;
using System.IO;

using ConnectionInterface;


namespace ConnectionTester {
	public partial class MainForm : Form {
		private List<ConnectionType> connectionTypes;
		private ConnectionType currentConnectionType;

		public MainForm() {
			InitializeComponent();
			connectionTypes = new List<ConnectionType>();
			currentConnectionType = null;
		}

		protected void OnConnectionEvent(object sender, ConnectionEventArgs e) {
			switch(e.EventEnum) {
				case EventType.Connected:
					SetConnectedUI();
					break;
				case EventType.Disconnected:
					SetDisconnectedUI(true);
					break;
				default:
					break;
			}

			tbResponses.Text = currentConnectionType.CurrentConnection.Log;
		}

		// Load configured libraries
		private void LoadConnectionLibs() {
			connectionTypes.Clear(); // Clear loaded ConnectionTypes
			tsConnectionType.TabPages.Clear(); // Clear loaded UI
			tsConnectionType.SelectedIndex = -1;

			// Iterate through each line in ConnectionLibs.settings
			foreach (SettingsProperty libSetting in Properties.ConnectionLibs.Default.Properties) {
				// Load the setting specified dll
				Assembly connectionDLL = null;
				try { connectionDLL = Assembly.LoadFrom(@Properties.Settings.Default.ConnectionLibrariesDir + libSetting.DefaultValue); }
				catch (FileNotFoundException err) { // Tell user the library is invalid
					MessageBox.Show(err.Message, "Error: " + libSetting.DefaultValue + " not found");
					continue; // Skip this setting
				}

				tsConnectionType.TabPages.Add(libSetting.Name, libSetting.Name); // Add new tab using setting name as key/title
				TabPage connectionTab = tsConnectionType.TabPages[libSetting.Name]; // Get reference to the new page
				connectionTab.AutoScroll = true; // Allow page to scroll

				foreach (Type type in connectionDLL.GetExportedTypes()) { // Iterate through public types in dll (should only have Connection, assume someone made more)
					if (typeof(Connection).IsAssignableFrom(type)) {
						connectionTypes.Add(new ConnectionType(type, libSetting.Name)); // Register Connection derived class
						Connection tmp = (Connection)Activator.CreateInstance(type, new object[] { null, null, null });
						UserControl control = tmp.GetUIControl(); // Get control singleton instance
						control.Dock = DockStyle.Fill; // Fill page with control (up to control to implement proper scaling)
						connectionTab.Controls.Add(control); // Add control to page
					}
				}
			}

			if (tsConnectionType.TabCount > 0) tsConnectionType.SelectedIndex = 0;
		}

		private void FillConnectionsList() {
			cbConnections.SelectedIndex = -1;
			cbConnections.Items.Clear(); // Clear current list
			// Populate with connection names
			cbConnections.Items.AddRange(currentConnectionType.ConnectionNames.ToArray());
			cbConnections.SelectedIndex = cbConnections.Items.Count - 1;
		}

		// Setup buttons for a connected connection
		private void SetConnectedUI() {
			btnConnect.Enabled = false;
			btnDisconnect.Enabled = true;
			btnSendMessage.Enabled = true;
		}

		// Setup buttons for a disconnected or no connection
		private void SetDisconnectedUI(bool connectionSelected) {
			if(connectionSelected) { // Diconnected
				btnConnect.Enabled = true;
				btnDisconnect.Enabled = false;
				btnSendMessage.Enabled = false;
			} else { // No connection
				btnConnect.Enabled = false;
				btnDisconnect.Enabled = false;
				btnSendMessage.Enabled = false;
			}
		}

		// Set active connection type
		private void SetCurrentConnectionType() {
			int ndx = connectionTypes.Count;
			while (--ndx >= 0) { // Find associated ConnectionType
				if (connectionTypes[ndx].TypeKey == tsConnectionType.SelectedTab.Text) {
					currentConnectionType = connectionTypes[ndx]; // Set active
					break;
				}
			}

			FillConnectionsList(); // Fill the connections list
		}

		#region formevents
		private void MainForm_Load(object sender, EventArgs e) {
			LoadConnectionLibs(); // Load configured libraries
		}

		// Connect to the server using specified settings through connection implementation
		private void btnConnect_Click(object sender, EventArgs e) {
			if (currentConnectionType == null) return; // Note: Maybe change null detection
			if (currentConnectionType.CurrentConnection == null) return;
			currentConnectionType.CurrentConnection.Connect();
		}

		// Disconnect from server using connection implementation
		private void btnDisconnect_Click(object sender, EventArgs e) {
			if (currentConnectionType == null) return; // Note: Maybe change null detection
			if (currentConnectionType.CurrentConnection == null) return;
			currentConnectionType.CurrentConnection.Disconnect();
		}

		// Send to server using ConnectionType implementation
		private void btnSendMessage_Click(object sender, EventArgs e) {
			if(currentConnectionType.CurrentConnection != null)
				currentConnectionType.CurrentConnection.Send();
		}

		// Show connection libraries dialog
		private void btnConnectionLibs_Click(object sender, EventArgs e) {
			DialogResult dr = new DialogResult(); // Instantiate object to get DialogResults
			ConnectionLibs dialog = new ConnectionLibs();
			dr = dialog.ShowDialog(); // Show the dialog
			if (dr == DialogResult.Yes) LoadConnectionLibs(); // Reload libraries
		}

		// Add connection to connection type
		private void btnAddConnection_Click(object sender, EventArgs e) {
			DialogResult dr;
			NewConnection dialog = new NewConnection(currentConnectionType);
			dr = dialog.ShowDialog(); // Show NewConnection dialog
			if (dr != DialogResult.OK) return;

			currentConnectionType.CurrentConnection.ConnectionEvent += OnConnectionEvent; // Register event handler
			FillConnectionsList(); // Does what it says
			// Set current type active connection to new connection
			cbConnections.SelectedIndex = cbConnections.Items.IndexOf(currentConnectionType.CurrentConnection.ConnectionName);
		}

		// Remove selected connection from connection type
		private void btnDeleteConnection_Click(object sender, EventArgs e) {
			currentConnectionType.RemoveConnection(cbConnections.Text);
			cbConnections.SelectedIndex = currentConnectionType.NumConnections - 1;
			FillConnectionsList();
		}

		// Set active connection type
		private void tsConnectionType_SelectedIndexChanged(object sender, EventArgs e) { SetCurrentConnectionType(); }
		#endregion

		// Set active connection
		private void cbConnections_SelectedIndexChanged(object sender, EventArgs e) {
			currentConnectionType.SetCurrentConnectionByName(cbConnections.Text); // Set the current connection for the current connection type
			if (currentConnectionType.CurrentConnection != null) { // If set to a valid connection
				tbConnectTo.Text = currentConnectionType.CurrentConnection.HostName;
				tbPortNum.Text = currentConnectionType.CurrentConnection.Port.ToString();
				tbResponses.Text = currentConnectionType.CurrentConnection.Log;

				if(currentConnectionType.CurrentConnection.IsConnected) SetConnectedUI(); // Is currently connected
				else SetDisconnectedUI(true); // Is not connected
			} else { // Set to invalid connection
				tbConnectTo.Clear();
				tbPortNum.Clear();
				tbResponses.Clear();
				SetDisconnectedUI(false);
			}
		}
	}
}
