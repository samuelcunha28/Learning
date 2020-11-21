using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace WebDAO.Interfaces
{
    public interface IConnection
    {   
        // open DB connection
        SqlConnection Open();

        // fetch the open connetion
        SqlConnection Fetch();

        // close DB connection
        void Close();
    }
}
