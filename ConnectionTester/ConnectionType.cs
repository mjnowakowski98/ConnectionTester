using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ConnectionInterface; // Reference from ConnectionInterface.dll (Solution link)

namespace ConnectionTester {
	// Container for all connections of the derived type
	class ConnectionType {
		#region internalvars
		private List<Connection> connections; // List of connections
		private Type derivedType; // Connection type
		#endregion

		public ConnectionType(Type type) {
			connections = new List<Connection>();
			derivedType = type; // Set type
		}

		// Readonly
		// Connection type
		public Type DerivedType {
			get { return derivedType; }
		}

		#region modifiermethods
		// Gets collection index by connection name
		public int GetConnectionNdxByName(String name) {
			int ndx = connections.Count;
			while (--ndx > -1) // Decrement count until found or out-of-bounds
				if (connections[ndx].ConnectionName == name) break;

			return ndx;
		}

		// Create a new connection
		public bool AddConnection(String name, String hostName, int port) {
			bool success = true;
			for(int i = 0; i < connections.Count; i++) // Make sure name is unique
				if (connections[i].ConnectionName == name) success = false;

			if (success) { // Create new instance of derived type
				dynamic newInstance = Activator.CreateInstance(derivedType);
				connections.Add(newInstance);
			}

			return success;
		}

		// Remove connection by index
		public void RemoveConnection(int ndx) {
			if (ndx < 0 | ndx >= connections.Count) return;
			connections[ndx].Disconnect();
			connections.RemoveAt(ndx);
		}

		// Remove connection by name
		public void RemoveConnection(String name) {
			int ndx = GetConnectionNdxByName(name);
			RemoveConnection(ndx);	// No need to duplicate
		}
		#endregion
	}
}
