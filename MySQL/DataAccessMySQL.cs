using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using MySql.Data.MySqlClient;

namespace DataLibrary
{
    public class DataAccessMySQL : IDataAccess
    {
        public ConnectionString Cs { get; set; }

        public async Task<List<T>> LoadData<T>(string sql)
        {
            using IDbConnection connection = new MySqlConnection(Cs.ToString());
            var rows = await connection.QueryAsync<T>(sql);
            return rows.ToList();
        }

        public Task SaveData<T>(string sql, T parameters)
        {
            using IDbConnection connection = new MySqlConnection(Cs.ToString());
            return connection.ExecuteAsync(sql, parameters);
        }

        public void Open()
        {
            using IDbConnection connection = new MySqlConnection(Cs.ToString());
            connection.Open();
        }
    }
}
