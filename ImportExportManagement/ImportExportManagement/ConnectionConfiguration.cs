﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace ImportExportManagement
{
    class ConnectionConfiguration
    {
        public static string ConnectionString(string name) {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;

        }
    }
}
