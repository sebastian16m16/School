using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SensorsAndPatients.Models;
using SensorsAndPatients.Resource;

namespace SensorsAndPatients.Controllers
{
    public class NotificationController : ApiController
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["SensorsAndPatients"].ConnectionString);

        public HttpResponseMessage Get()
        {
            DataTable table = new DataTable();

            string query = "select * from dbo.Notification";

            using (con)
            using (var command = new SqlCommand(query, con))
            using (var dataAdapter = new SqlDataAdapter(command))
            {
                command.CommandType = CommandType.Text;
                dataAdapter.Fill(table);
            }

            return Request.CreateResponse(HttpStatusCode.OK, table);


        }

        public string Post(Notification notification)
        {


            try
            {
                DataTable tabel = new DataTable();

                string query = String.Format("insert into dbo.Notification(notify, about) values ({0}, {1}}", notification.notify, notification.about);

                using (con)
                using (var command = new SqlCommand(query, con))
                using (var dataAdapter = new SqlDataAdapter(command))
                {
                    command.CommandType = CommandType.Text;
                    dataAdapter.Fill(tabel);
                }

                return "Added Successfully!";
            }
            catch (Exception e)
            {
                return "Failed to insert into Notification Table becuase of: \n " + e.ToString();
            }
        }
    }
}
