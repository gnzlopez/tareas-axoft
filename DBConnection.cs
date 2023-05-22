using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
using System.Collections;

namespace axoftTareas
{
    public class DBConnection
    {
        private string _connectionString = "";

        public string ConnectionString
        { 
            get 
            { 
                return _connectionString; 
            } 
            set 
            { 
                _connectionString = value;
            } 
        }

        public bool ConnectOK()
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                try
                {
                    conn.Open();
                    conn.Close();
                    return true;
                }
                catch (Exception ex)
                {
                    throw new Exception("Ocurrio un error: " + ex.Message);
                }
            }
        }

        public List<Task> Get(string query)
        {
            List<Task> tasks = new List<Task>();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Task task = new Task()
                        {
                            Id = reader.GetInt32(0),
                            Name = reader["Name"].ToString(),
                            State = (State)reader.GetInt32(2),
                            Date = reader.IsDBNull(3) ? (DateTime?)null : (DateTime?)reader.GetDateTime(3)
                        };
                    
                        tasks.Add(task);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("Ocurrio un error: " + ex.Message);
                }
            }

            return tasks;
        }

        public void Set(string query)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);

                try
                {
                    conn.Open();

                    cmd.ExecuteNonQuery();

                    conn.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("Ocurrio un error: " + ex.Message);
                }
            }
        }

    }
}
