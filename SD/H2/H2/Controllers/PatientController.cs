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
    public class PatientController : ApiController
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["HospitalDB"].ConnectionString);

        public HttpResponseMessage Get()
        {
            DataTable table = new DataTable();

            string query = "select * from dbo.Patient";

            using (con)
            using (var command = new SqlCommand(query, con))
            using (var dataAdapter = new SqlDataAdapter(command))
            {
                command.CommandType = CommandType.Text;
                dataAdapter.Fill(table);
            }

            return Request.CreateResponse(HttpStatusCode.OK, table);
        }

        public string Post(Patient patient)
        {

            string date = patient.birthdate.ToString("yyyy-MM-dd");

            try
            {
                DataTable tabel = new DataTable();

                string query = String.Format("insert into dbo.Patient(first_name, last_name, birthdate, address, gender, doctor, caregiver, medication_plan) values ('{0}', '{1}', '{2}', '{3}', '{4}', {5}, {6}, {7})",
                    patient.first_name, patient.last_name, date, patient.address, patient.gender, patient.doctor, patient.caregiver, patient.medication_plan);

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
                return "Failed to insert into Doctor Table becuase of: \n " + e.ToString();
            }
        }

        public string Put(Patient patient)
        {
            DataTable tabel = new DataTable();

            string query = String.Format("update Doctor set first_name = '{0}', last_name = '{1}', birthdate = '{2}', address = '{3}', gender = '{4}', doctor = {5}, caregiver = {6}, medication_plan = {7} where id = {8}",
                patient.first_name, patient.last_name, patient.birthdate, patient.address, patient.gender, patient.doctor, patient.caregiver, patient.medication_plan ,patient.id);


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

                return "Failed to insert into Doctor Table becuase of: \n " + e.ToString();
            }
        }
    }
}
