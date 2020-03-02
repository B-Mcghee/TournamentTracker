using System;
using System.Collections.Generic;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> Connections { get; private set; }

        public static void InitializeConnections(bool database, bool textFiles)
        {
            if (database)
            {
                //TODO - initialize database
            }

            if (textFiles)
            {
                //TODO - create text file
            }
        }
    }
}
