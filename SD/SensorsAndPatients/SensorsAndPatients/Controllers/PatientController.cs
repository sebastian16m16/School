using SensorsAndPatients.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SensorsAndPatients.Controllers
{
    public class PatientController : ApiController
    {
        public int count { get; set; }



        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["SensorsAndPatients"].ConnectionString);

        public HttpResponseMessage Get()
        {
            
            DataTable table = new DataTable();

            string query = "select * from dbo.Patient";

            using (con = new SqlConnection(ConfigurationManager.ConnectionStrings["SensorsAndPatients"].ConnectionString))
            {
          
                using (var command = new SqlCommand(query, con))
                using (var dataAdapter = new SqlDataAdapter(command))
                {
                    command.CommandType = CommandType.Text;
                    dataAdapter.Fill(table);
                }
            }
            count = table.Rows.Count;

            return Request.CreateResponse(HttpStatusCode.OK, table);
        }

        public string Post(Patient patient)
        {


            try
            {
                DataTable tabel = new DataTable();

                string query = String.Format("insert into dbo.Patient(start_time, end_time, activity_label) values ('{0}', '{1}', '{2}'}", patient.start_time, patient.end_time, patient.activity_label);

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
                return "Failed to insert into Patient Table becuase of: \n " + e.ToString();
            }
        }

        public string Put(Patient patient)
        {
            DataTable tabel = new DataTable();

            string query = String.Format("update Patient set start_time = '{0}', end_time = '{1}', activity_label = '{2}' where id = {3}",patient.start_time, patient.end_time, patient.activity_label, patient.id);


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

                return "Failed to insert into Patient Table becuase of: \n " + e.ToString();
            }
        }

        public string Delete(int id)
        {
            DataTable tabel = new DataTable();

            string query = String.Format("delete from Patient where id = {0}", id);


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

                return "Failed to insert into Patient Table becuase of: \n " + e.ToString();
            }
        }

        public int GetCaregiver(int id)
        {
            try
            {
                var dataSet = new DataSet();

                string query = String.Format("Select caregiver from patient where id='{0}'", id);
                using (con)
                {
                    con.Open();
                    using (var command = new SqlCommand(query, con))
                    using (SqlDataReader reader = command.ExecuteReader())
                    {

                        command.CommandType = CommandType.Text;

                        while (reader.Read())
                        {
                            int caregiver = Int32.Parse(reader[0].ToString());

                            return caregiver;
                        }

                    }
                    con.Close();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                
            }
            return -1;

        }

        public int GetCount()
        {

            DataTable table = new DataTable();

            string query = "select * from dbo.Patient";

            using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["SensorsAndPatients"].ConnectionString))
            {
                using (var command = new SqlCommand(query, con))
                {
                    using (var dataAdapter = new SqlDataAdapter(command))
                    {
                        command.CommandType = CommandType.Text;
                        dataAdapter.Fill(table);
                    }
                }
            }
            count = table.Rows.Count;

            return count;
        }
    }
}
