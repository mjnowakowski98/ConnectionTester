using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ConnectionInterface; // Reference from ConnectionInterface.dll (Solution link)

namespace ConnectionTester {
	// Container for all connections of the derived type
	public class ConnectionType {
		#region internalvars
		private List<Connection> connections; // List of connections
		private Connection currentConnection;
		private Type derivedType; // Connection type
		private String typeKey;

		private UserControl uiControl;
		#endregion

		public ConnectionType(Type type, String key, UserControl control) {
			connections = new List<Connection>();
			connections.Add(new NoConnection());
			currentConnection = connections[0];
			derivedType = type; // Set type
			typeKey = key; // Key to select connection type
			uiControl = control; // UI for creating requests
		}

		~ConnectionType() {
			foreach (Connection connection in connections)
				connection.Disconnect();
		}

		// Readonly
		// Connection type
		public Type DerivedType {
			get { return derivedType; }
		}

		// Key to match ConnectionType
		public String TypeKey {
			get { return typeKey; }
		}

		// User set names of connections
		public List<String> ConnectionNames {
			get {
				List<String> namesList = new List<string>();
				foreach (Connection connection in connections)
					namesList.Add(connection.ConnectionName);	

				return namesList;
			}
		}

		// Active connection
		public Connection CurrentConnection {
			get { return currentConnection; }
		}

		public int CurrentConnectionNdx {
			get { return connections.IndexOf(currentConnection); }
		}

		public int NumConnections {
			get { return connections.Count; }
		}

		public UserControl UIControl {
			get { return uiControl; }
		}

		#region modifiermethods
		// Gets collection index by connection name
		public int GetConnectionNdxByName(String name) {
			int ndx = connections.Count;
			while (--ndx > -1) // Decrement count until found or out-of-bounds
				if (connections[ndx].ConnectionName == name) break;

			return ndx;
		}

		public void SetCurrentConnectionByName(String connectionName) {
			int ndx = GetConnectionNdxByName(connectionName);
			if (ndx >= 0) currentConnection = connections[ndx];
			else currentConnection = null;
		}

		public void SetNoConnection() { currentConnection = new NoConnection(); }

		// Create a new connection
		public bool AddConnection(String name, String hostName, int port) {
			bool success = true;
			for (int i = 0; i < connections.Count; i++) { // Make sure name is unique
				if (connections[i].ConnectionName == name) {
					success = false;
					break;
				}
			}

			if (success) { // Create new instance of derived type
				dynamic newInstance = Activator.CreateInstance(derivedType, new object[] { name, hostName, port});
				if (typeof(NoConnection).IsAssignableFrom(connections[0].GetType()) && connections.Count == 1)
					connections.RemoveAt(0);
				connections.Add(newInstance);
				currentConnection = newInstance;
			}

			return success;
		}

		// Remove connection by index
		public void RemoveConnection(int ndx) {
			if (ndx < 0 || ndx >= connections.Count) return;
			connections[ndx].Disconnect();
			connections.RemoveAt(ndx);
			if (connections.Count <= 0) connections.Add(new NoConnection());
		}

		// Remove connection by name
		public void RemoveConnection(String name) {
			int ndx = GetConnectionNdxByName(name);
			RemoveConnection(ndx);	// No need to duplicate
		}
		#endregion
	}
}
