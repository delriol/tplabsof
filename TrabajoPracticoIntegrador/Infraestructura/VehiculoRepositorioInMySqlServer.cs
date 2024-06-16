using MySql.Data.MySqlClient;
using TrabajoPracticoIntegrador.Dominio.Entidades;
using TrabajoPracticoIntegrador.Dominio.Repositorio;

namespace TrabajoPracticoIntegrador.Infraestructura
{
    public class VehiculoRepositorioInMySqlServer : VehiculoRepositorio
    {
        private static string server = "localhost";
        private static string database = "trabajopractico";
        private static string username = "root";
        private static string password = "1234";

        private static string connectionString = "server=" + server + ";database=" + database + ";user=" + username + ";password=" + password + ";";

        MySqlConnection connection = new MySqlConnection(connectionString);

        List<Vehiculo> vehiculos = new List<Vehiculo>();

        public List<Vehiculo> getAll()
        {
            return findAllByInMySql();
        }

        public void save(Vehiculo vehiculo)
        {
            this.vehiculos.Add(vehiculo);
        }


       public List<Vehiculo> findAllByInMySql()
        {
            try
            {
                connection.Open();
                string query = "SELECT * FROM vehiculos";
                MySqlCommand cmd = new MySqlCommand(query, connection);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Vehiculo vehiculo = new Vehiculo(
                            Guid.Parse(reader["id"].ToString()), 
                            reader["marca"].ToString(),
                            reader["modelo"].ToString(),
                            reader["motor"].ToString(),
                            reader["chasis"].ToString()
                            );
                        vehiculos.Add(vehiculo);
                    }
                }
               
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error de MySQL: " + ex.Message);
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error general: " + ex.Message);
                connection.Close();
            }

            connection.Close();

            return vehiculos;
        }


        void VehiculoRepositorio.update(Vehiculo vehiculo)
        {
            //throw new NotImplementedException();
        }

        void VehiculoRepositorio.delete(string id)
        {
           // throw new NotImplementedException();
        }

    }
}
