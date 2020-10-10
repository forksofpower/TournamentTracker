using System;
using System.Collections.Generic;
using System.Text;
using TrackerLibrary.DataAccess;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();
        public static void InitializeConnections(bool database, bool textFile)
        {
            if (database)
            {
                // TODO: setup the sql connector properly
                SQLConnector sql = new SQLConnector();
                Connections.Add(sql);
            }
            if (textFile)
            {
                // TODO: setup the text connector properly
                TextConnector text = new TextConnector();
                Connections.Add(text);
            }
        }
    }
}
