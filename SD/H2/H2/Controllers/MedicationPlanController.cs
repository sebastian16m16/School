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
    public class MedicationPlanController : ApiController
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["HospitalDB"].ConnectionString);

        public HttpResponseMessage Get()
        {
            DataTable table = new DataTable();

            string query = "select * from dbo.Medication_Plan";

            using (con)
            using (var command = new SqlCommand(query, con))
            using (var dataAdapter = new SqlDataAdapter(command))
            {
                command.CommandType = CommandType.Text;
                dataAdapter.Fill(table);
            }

            return Request.CreateResponse(HttpStatusCode.OK, table);
        }

        public string Post(MedicationPlan medicationPlan)
        {


            try
            {
                DataTable tabel = new DataTable();

                string query = String.Format("insert into dbo.Medication_Plan(name, medication, assigned_by) values ('{0}', {1}, {2})",
                    medicationPlan.name, medicationPlan.medication, medicationPlan.assigned_by);

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
                return "Failed to insert into MedicationPlan Table becuase of: \n " + e.ToString();
            }
        }

        public string Put(MedicationPlan medicationPlan)
        {
            DataTable tabel = new DataTable();

            string query = String.Format("update Medication_Plan set name = '{0}', medication = {1}, assigned_by = {2} where id = {3}",
               medicationPlan.name, medicationPlan.medication, medicationPlan.assigned_by, medicationPlan.id);


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

                return "Failed to insert into Medication_Plan Table becuase of: \n " + e.ToString();
            }
        }

        public string Delete(int id)
        {
            DataTable tabel = new DataTable();

            string query = String.Format("delete from Medication_Plan where id = {0}", id);


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

                return "Failed to insert into MedicationPlan Table becuase of: \n " + e.ToString();
            }
        }
    }
}
