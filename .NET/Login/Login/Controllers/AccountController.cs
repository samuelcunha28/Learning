using Login.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Login.Controllers
{
    public class AccountController : Controller
    {
        SqlConnection _connection = new SqlConnection();
        SqlCommand _command = new SqlCommand();
        SqlDataReader dr;

        // GET Account
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        void connectionString()
        {
            _connection.ConnectionString = "data source=DESKTOP-VMCE8VG; database=WEBDAO; integrated security = SSPI";

        }

        [HttpPost]
        public ActionResult Verify(Account acc)
        {
            connectionString();
            _connection.Open();
            _command.CommandText =  "select * from login where username='" + acc.Name + "' and password='" + acc.Password + "'";
            _command.Connection = _connection;
            dr = _command.ExecuteReader();

            if (dr.Read())
            {
                _connection.Close();
                return View("Create");
            }
            else
            {
                _connection.Close();
                return View("Error");
            }
        }
    }
}