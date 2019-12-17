using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GrpcServer.Models;
using System.Data.SqlClient;
using System.Configuration;

namespace GrpcServer.Handle
{
    public class PlanHandler
    {
        string connectionString = @"Data Source=DESKTOP-EJFE3EN\SQLEXPRESS;Initial Catalog=MedicationDispenser;Integrated Security=True";

        public bool deletePlan(int id)
        {

            string query = "Delete from Medication_Plan where id = " + id;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (var command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader;

                    try 
                    {
                        connection.Open();
                        reader = command.ExecuteReader();
                        connection.Close();
                        
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        return false;
                    }
                }
            }
            return true;
        }

        public DateTime getPlanIntakeHour(int id)
        {
            string query = String.Format("Select intaketime from Medication_Plan where id = {0}", id);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (var command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader;

                    try
                    {
                        connection.Open();
                        reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            return reader.GetDateTime(0);
                        }
                    }
                    catch (Exception e)
                    {

                        Console.WriteLine(e.Message);
                    }
                }
            }
            return new DateTime();
        }

        public bool addReport(Report report)
        {
            string query = String.Format("Insert into Report (patient, medication_schedule, taken) values({0}, {1}, {2})", report.patient, report.medication_schedule, report.taken);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (var command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader;

                    try
                    {
                        connection.Open();
                        reader = command.ExecuteReader(0);
                        connection.Close();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        return false;
                    }
                }
            }
            return true;
        }

        public MedicationSchedule getMedicationSchedule(int id)
        {

            string query = "Select * from Medication_Schedule where id = " + id;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (var command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader;

                    connection.Open();
                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        MedicationSchedule medicationSchedule = new MedicationSchedule(
                            reader.GetInt32(0),
                            reader.GetString(1),
                            reader.GetInt32(2),
                            reader.GetInt32(3)
                            );
                        return medicationSchedule;
                    }
                }
            }

                return new MedicationSchedule();
        }

        public List<Medication_Plan> getMPfromPatient(int id)
        {
            string query = "Select * from Medication_Plan where patient = " + id;
            List<Medication_Plan> returnList = new List<Medication_Plan>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (var command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader;

                    connection.Open();
                    try
                    {
                        reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            Medication_Plan medication_Plan = new Medication_Plan(
                                reader.GetInt32(0),
                                reader.GetInt32(1),
                                reader.GetInt32(2),
                                reader.GetInt32(3),
                                reader.GetDateTime(4)
                                );
                            returnList.Add(medication_Plan);

                        }
                        return returnList;
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine(e.Message);
                        return returnList;
                    }
                }
            }
        }
    }
}
