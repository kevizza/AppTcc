using System;
using System.Collections.Generic;
using System.Text;


using SQLite;
using AppTcc.Model;
using System.Threading.Tasks;


namespace AppTcc.Helper
{
    public class SQLiteDataBaseHelper
    {
        readonly SQLiteAsyncConnection _connection;

        public SQLiteDataBaseHelper(string path)
        {
            _connection = new SQLiteAsyncConnection(path);
            _connection.CreateTableAsync<Usuario>().Wait();
        }

        public Task<int> Save(Usuario t)
        {
            return _connection.InsertAsync(t);
        }

        public Task<List<Usuario>> GetAllRows()
        {
            return _connection.Table<Usuario>().ToListAsync();
        }

        public Task<int> Delete(int id)
        {
            return _connection.Table<Usuario>().DeleteAsync(i => i.Id == id);
        }

        // Update, fará a atualização no banco de dados. //
        public Task<List<Usuario>> Update(Usuario t)
        {
            string sql = "UPDATE usuario SET " +
                         "name=?, email=?, senha=?. usuario=?," +
                         "WHERE Id=?";

            return _connection.QueryAsync<Usuario>(sql,
                t.name, t.email, t.senha, t.username, t.Id);
        }

        public Task<List<Usuario>> Search(string q)
        {
            string sql = "SELECT * FROM usuario WHERE name LIKE '%" + q + "%'";

            return _connection.QueryAsync<Usuario>(sql);
        }
    }
}
