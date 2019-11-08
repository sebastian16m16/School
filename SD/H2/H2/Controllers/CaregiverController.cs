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
    public class CaregiverController : ApiController
    {

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["HospitalDB"].ConnectionString);

        public HttpResponseMessage Get()
        {
            DataTable table = new DataTable();

            string query = "select * from Caregiver";

            using (con)
            using (var command = new SqlCommand(query, con))
            using (var dataAdapter = new SqlDataAdapter(command))
            {
                command.CommandType = CommandType.Text;
                dataAdapter.Fill(table);
            }

            return Request.CreateResponse(HttpStatusCode.OK, table);
        }

        public string Post(Caregiver caregiver)
        {
            

            
            try
            {
                DataTable tabel = new DataTable();

                string query = "insert into Caregiver(first_name, last_name, birthdate, gender, address) values ('" + caregiver.first_name + "', '" + caregiver.last_name +
                    "', '" + caregiver.birthdate + "', '" + caregiver.gender + "', '" + caregiver.address + "');";

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

                return "Failed to insert into Caregiver Table becuase of: \n " + e.ToString();
            }

        }

        public string Put(Caregiver caregiver)
        {
            DataTable tabel = new DataTable();

            string query = String.Format("update Caregiver set first_name = '{0}', last_name = '{1}', birthdate = '{2}', gender = '{3}', address = '{4}', where id = {5}",
                caregiver.first_name, caregiver.last_name, caregiver.birthdate, caregiver.gender, caregiver.address, caregiver.id);


            try
            {
                using (con)
                using (var command = new SqlCommand(query, con))
                using (var dataAdapter = new SqlDataAdapter(command))
                {
                    command.CommandType = CommandType.Text;
                    dataAdapter.Fill(tabel);
                }

                return "Updated Successfully!";
            }
            catch (Exception e)
            {

                return "Failed to insert into Caregiver Table becuase of: \n " + e.ToString();
            }
        }

        public string Delete(int id)
        {
            DataTable tabel = new DataTable();

            string query = String.Format("delete from caregiver where id = {0}", id);

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

                return "Failed to insert into Caregiver Table becuase of: \n " + e.ToString();
            }
        }


    }
}
