using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary
{
    public class ConnectionStringSQLite : ConnectionString
    {
        public string Database { get; set; }

        public ConnectionStringSQLite(string database)
        {
            Database = database;
        }

        override public string ToString()
        {
            return  "Data Source = " + Database;
        }
    }
}

