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

        public override List<string> GetProperties()
        {
            List<string> properties = new List<string>();
            properties.Add(Database);
            return properties;
        }
    }
}

