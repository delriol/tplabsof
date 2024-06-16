using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPracticoIntegrador.Infraestructura
{
    public class MySql
    {
        private static string server = "localhost";
        private static string database = "trabajopractico";
        private static string username = "root";
        private static string password = "1234";

        private static string connectionString = "server=" + server + ";database=" + database + ";user=" + username + ";password=" + password + ";";

        MySqlConnection connection = new MySqlConnection(connectionString);
            
        public MySql()
        {
            try
            {
                Console.WriteLine("Intentando conectar...");
                connection.Open();
                Console.WriteLine("Conexión exitosa a la base de datos.");

                string query = "SELECT * FROM vehiculo";
                MySqlCommand cmd = new MySqlCommand(query, connection);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine("id: " + reader["id"].ToString());
                        Console.WriteLine("Marca: " + reader["marca"].ToString());
                        Console.WriteLine("Modelo: " + reader["modelo"].ToString());
                        Console.WriteLine("Motor: " + reader["motor"].ToString());
                        Console.WriteLine(": " + reader["chasis"].ToString());
                    }
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error de MySQL: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error general: " + ex.Message);
            }
        }     

    }
}
