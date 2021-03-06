﻿using System;
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
        string connectionString = ConfigurationManager.ConnectionStrings["MedicationDispenser"].ConnectionString;

        public void deletePlan(int id)
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
                    }
                }
            }
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

        public void addReport(Report report)
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
                    }
                }
            }
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
    }
}
