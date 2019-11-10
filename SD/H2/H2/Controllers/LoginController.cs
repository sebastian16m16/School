using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using H2.Models;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace H2.Controllers
{
    public class LoginController : ApiController
    {

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["HospitalDB"].ConnectionString);

        public string Get(Login login)
        {
            try
            {
                var dataSet = new DataSet();

                string query = String.Format("Select password, type from login where username='{0}'", login.username);
                using (con) {
                    con.Open();
                    using (var command = new SqlCommand(query, con))
                    using (SqlDataReader reader = command.ExecuteReader())
                    {

                        command.CommandType = CommandType.Text;

                        while (reader.Read())
                        {

                            string p = reader[0].ToString();
                            string t = reader[1].ToString();

                            if (p.Equals(login.password))
                            {
                                return t;
                            }
                            else
                                throw new Exception("Wrong Password");
                        }

                    }
                    con.Close();
                }

            }
            catch (Exception e)
            {
                return String.Format("Something went wrong, try again!\n {0}", e);
            }
            return "FALSE";
        }
    }
}
