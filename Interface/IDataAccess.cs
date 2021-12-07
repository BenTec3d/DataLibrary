using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataLibrary
{
    public interface IDataAccess
    {
        public ConnectionString Cs { get; set; }
        public Task<List<T>> LoadData<T>(string sql);
        public Task SaveData<T>(string sql, T parameters);
        public void Open();
    }
}