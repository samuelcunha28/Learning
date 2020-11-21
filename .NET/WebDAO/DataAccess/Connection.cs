using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using WebDAO.Interfaces;

namespace WebDAO.DataAccess
{
    public class Connection : IConnection, IDisposable
    {
        private SqlConnection _connection;

        public Connection()
        {
            _connection = new SqlConnection("Data Source=DESKTOP-VMCE8VG; Initial Catalog=WEBDAO; Integrated Security=SSPI");
        }

        public void Close()
        {
            if (_connection.State == System.Data.ConnectionState.Open)
            {
                _connection.Close();
            }
        }

        public void Dispose()
        {
            this.Close();
            GC.SuppressFinalize(this); // garbage collector
        }

        public SqlConnection Fetch()
        {
            return this.Open();
        }

        public SqlConnection Open()
        {
            if (_connection.State == System.Data.ConnectionState.Open)
            {
                _connection.Open();
            }
            return _connection;
        }
    }
}
