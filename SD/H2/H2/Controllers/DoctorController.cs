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
    public class DoctorController : ApiController
    {

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["HospitalDB"].ConnectionString);

        public HttpResponseMessage Get()
        {
            DataTable table = new DataTable();

            string query = "select * from dbo.Doctor";

            using (con)
            using (var command = new SqlCommand(query, con))
            using (var dataAdapter = new SqlDataAdapter(command))
            {
                command.CommandType = CommandType.Text;
                dataAdapter.Fill(table);
            }

            return Request.CreateResponse(HttpStatusCode.OK, table);
        }

        public string Post(Doctor doctor)
        {

            string date = doctor.birthdate.ToString("yyyy-MM-dd");

            try
            {
                DataTable tabel = new DataTable();

                string query = String.Format("insert into dbo.Doctor(first_name, last_name, birthdate, medical_record, address, gender) values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')",
                    doctor.first_name, doctor.last_name, date, doctor.medical_record, doctor.address, doctor.gender);

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
                return "Failed to insert into Doctor Table becuase of: \n "+ e.ToString();
            }
        }

        public string Put(Doctor doctor)
        {
            DataTable tabel = new DataTable();
          
            string query = String.Format("update Doctor set first_name = '{0}', last_name = '{1}', birthdate = '{2}', medical_record = '{3}', address = '{4}', gender = '{5}' where id = {6}", 
                doctor.first_name, doctor.last_name, doctor.birthdate, doctor.medical_record, doctor.address, doctor.gender, doctor.id);


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

                return "Failed to insert into Doctor Table becuase of: \n " + e.ToString();
            }
        }

        public string Delete(int id)
        {
            DataTable tabel = new DataTable();

            string query = String.Format("delete from Doctor where id = {0}", id);


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

                return "Failed to insert into Doctor Table becuase of: \n " + e.ToString();
            }
        }
    }
}
