using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary
{
    public class ConnectionStringMySQL : ConnectionString
    {
        public string Server { get; set; }
        public string UserId { get; set; }
        public string Password { get; set; }
        public string Database { get; set; }

        public ConnectionStringMySQL(string server, string userId, string password)
        {
            Server = server;
            UserId = userId;
            Password = password;
            Database = null;
        }
        public ConnectionStringMySQL(string server, string userId, string password, string database)
        {
            Server = server;
            UserId = userId;
            Password = password;
            Database = database;
        }

        override public string ToString()
        {
            if (Database == null)
            {
                return string.Format("server={0};userid={1};password={2};", Server, UserId, Password);
            }
            else
            {
                return string.Format("server={0};userid={1};password={2};database={3}", Server, UserId, Password, Database);
            }
        }
    }
}
