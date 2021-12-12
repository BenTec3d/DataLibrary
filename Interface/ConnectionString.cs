using System.Collections.Generic;

namespace DataLibrary
{
    abstract public class ConnectionString
    {
        abstract override public string ToString();
        abstract public List<string> GetProperties();
    }
}
