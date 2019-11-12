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
    public class SideEffectController : ApiController
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["HospitalDB"].ConnectionString);

        public HttpResponseMessage Get()
        {
            DataTable table = new DataTable();

            string query = "select * from dbo.side_effect";

            using (con)
            using (var command = new SqlCommand(query, con))
            using (var dataAdapter = new SqlDataAdapter(command))
            {
                command.CommandType = CommandType.Text;
                dataAdapter.Fill(table);
            }

            return Request.CreateResponse(HttpStatusCode.OK, table);
        }

        public string Post(SideEffect side_effect)
        {


            try
            {
                DataTable tabel = new DataTable();

                string query = String.Format("insert into dbo.side_effect(detail) values ('{0}')",
                    side_effect.detail);

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
                return "Failed to insert into SideEffect Table becuase of: \n " + e.ToString();
            }
        }

        public string Put(SideEffect side_effect)
        {
            DataTable tabel = new DataTable();

            string query = String.Format("update side_effect set detail = '{0}' where id = {1}",
                side_effect.detail, side_effect.id);


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

                return "Failed to insert into side_effect Table becuase of: \n " + e.ToString();
            }
        }

        public string Delete(int id)
        {
            DataTable tabel = new DataTable();

            string query = String.Format("delete from side_effect where id = {0}", id);


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

                return "Failed to insert into SideEffect Table becuase of: \n " + e.ToString();
            }
        }
    }
}
