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
using SensorsAndPatients.Controllers;

namespace SensorsAndPatients.Resource
{
    public class PatientHandle
    {
        Notification notification = new Notification();
        PatientController patientController = new PatientController();
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["SensorsAndPatients"].ConnectionString);

        public string notifyCaregiver(int id)
        {
            notification.about = id;
            notification.notify = patientController.GetCaregiver(id);

            try
            {
                DataTable tabel = new DataTable();

                string query = String.Format("Insert into dbo.Notification (notify, about) values ({0}, {1})", notification.notify, notification.about);

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
                return "Failed to insert into Patient Table becuase of: \n " + e.ToString();
            }
        }
    }
}