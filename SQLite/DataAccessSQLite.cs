using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Data.Sqlite;

namespace DataLibrary
{
    public class DataAccessSQLite : IDataAccess
    {
        public ConnectionString Cs { get; set; }

        public async Task<List<T>> LoadData<T>(string sql)
        {
            using IDbConnection connection = new SqliteConnection(Cs.ToString());
            var rows = await connection.QueryAsync<T>(sql);
            return rows.ToList();
        }
        public async Task<List<T>> LoadData<T>(IEnumerable<string> sql)
        {
            using IDbConnection connection = new SqliteConnection(Cs.ToString());
            List<T> result = new();
            foreach (string s in sql)
            {
                result.AddRange((await connection.QueryAsync<T>(s)).ToList());
            }
            return result;
        }
        public Task SaveData<T>(string sql, T parameters)
        {
            using IDbConnection connection = new SqliteConnection(Cs.ToString());
            return connection.ExecuteAsync(sql, parameters);
        }
        public async Task SaveData<T>(IEnumerable<string> sql, T parameters)
        {
            using IDbConnection connection = new SqliteConnection(Cs.ToString());
            foreach (string s in sql)
            {
                await connection.ExecuteAsync(s, parameters);
            }
        }
        public void Open()
        {
            using IDbConnection connection = new SqliteConnection(Cs.ToString());
            connection.Open();
        }
    }
}
