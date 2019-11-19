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
    public class ActivityController : ApiController
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["SensorsAndPatients"].ConnectionString);

        public HttpResponseMessage Get()
        {
            DataTable table = new DataTable();

            string query = "select * from dbo.Activity";

            using (con = new SqlConnection(ConfigurationManager.ConnectionStrings["SensorsAndPatients"].ConnectionString))
            using (var command = new SqlCommand(query, con))
            using (var dataAdapter = new SqlDataAdapter(command))
            {
                command.CommandType = CommandType.Text;
                dataAdapter.Fill(table);
            }

            return Request.CreateResponse(HttpStatusCode.OK, table);


        }

        public string Post(Activity activity)
        {


            try
            {
                DataTable tabel = new DataTable();

                string query = String.Format("insert into dbo.Activity(start_time, end_time, activity_label, patient) values ('{0}', '{1}', '{2}', {3})", activity.start_time, activity.end_time, activity.activity_label, activity.patient);

                using (con = new SqlConnection(ConfigurationManager.ConnectionStrings["SensorsAndPatients"].ConnectionString))
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
                return "Failed to insert into Activity Table becuase of: \n " + e.ToString();
            }
        }


        public string DELETE()
        {
            DataTable tabel = new DataTable();

            string query = String.Format("delete from Activity; DBCC CHECKIDENT(Activity, RESEED, 0)");


            try
            {
                using (con)
                using (var command = new SqlCommand(query, con))
                using (var dataAdapter = new SqlDataAdapter(command))
                {
                    command.CommandType = CommandType.Text;
                    dataAdapter.Fill(tabel);
                }

                return "Deleted Successfully!";
            }
            catch (Exception e)
            {

                return "Failed to delete from Activity Table becuase of: \n " + e.ToString();
            }
        }
    }
}
