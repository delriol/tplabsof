using MySql.Data.MySqlClient;
using Npgsql;
using TrabajoPracticoIntegrador.Dominio.Entidades;
using TrabajoPracticoIntegrador.Dominio.Repositorio;

namespace TrabajoPracticoIntegrador.Infraestructura
{
    public class VehiculoRepositorioInPostgreSQL : VehiculoRepositorio
    {
        private static string server = "localhost";
        private static string database = "postgresql_tp";
        private static string username = "postgres";
        private static string password = "1234";
        private static string connectionString = "Host=" + server + ";Username=" + username + ";Password=" + password + ";Database= " + database;

        NpgsqlConnection connection = new NpgsqlConnection(connectionString);

        List<Vehiculo> vehiculos = new List<Vehiculo>();

        public List<Vehiculo> getAll()
        {
            return findAllByInPostgreSql();
        }

        public void save(Vehiculo vehiculo)
        {
            saveInPostgreSql(vehiculo);
        }

        public void update(Vehiculo vehiculo)
        {
            updateInPostgreSql(vehiculo);
        }

        public void delete(string id)
        {
            deleteInPostgreSql(id);
        }


        private List<Vehiculo> findAllByInPostgreSql()
        {
            try
            {
                connection.Open();
                string query = "SELECT * FROM vehiculos";
                NpgsqlCommand command = new NpgsqlCommand(query, connection);

                using (NpgsqlDataReader reader = command.ExecuteReader())
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
            catch (NpgsqlException ex)
            {
                connection.Close();
                Console.WriteLine("Error de PostgreSQL: " + ex.Message);
            }
            catch (Exception ex)
            {
                connection.Close();
                Console.WriteLine("Error general: " + ex.Message);
            }
            connection.Close();
            return vehiculos;
        }

        private void saveInPostgreSql(Vehiculo vehiculo)
        {
            try
            {
                connection.Open();
                string insertQuery = "INSERT INTO vehiculos (id, marca, modelo, motor, chasis) " +
                    "VALUES (@id, @marca, @modelo, @motor, @chasis)";
                using (NpgsqlCommand command = new NpgsqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@id", vehiculo.getId().ToString());
                    command.Parameters.AddWithValue("@marca", vehiculo.getMarca());
                    command.Parameters.AddWithValue("@modelo", vehiculo.getModelo());
                    command.Parameters.AddWithValue("@motor", vehiculo.getMotor());
                    command.Parameters.AddWithValue("@chasis", vehiculo.getChasis());

                    int rowsAffected = command.ExecuteNonQuery();
                    Console.WriteLine($"{rowsAffected} fila(s) insertada(s) correctamente.");
                }
            }
            catch (NpgsqlException ex)
            {
                connection.Close();
                Console.WriteLine("Error de PostgreSQL: " + ex.Message);
            }
            catch (Exception ex)
            {
                connection.Close();
                Console.WriteLine("Error general: " + ex.Message);
            }
        }

        private void updateInPostgreSql(Vehiculo vehiculo)
        {
            try
            {
                connection.Open();
                string insertQuery = "UPDATE vehiculos " +
                    "SET marca=@marca, modelo=@modelo, motor=@motor, chasis=@chasis " +
                     "WHERE id = @id";
                using (NpgsqlCommand command = new NpgsqlCommand(insertQuery, connection))
                {        
                    command.Parameters.AddWithValue("@marca", vehiculo.getMarca());
                    command.Parameters.Add("@marca", NpgsqlTypes.NpgsqlDbType.Varchar).Value = vehiculo.getMarca();
                   //
                   command.Parameters.AddWithValue("@modelo", vehiculo.getModelo());
                    command.Parameters.AddWithValue("@motor", vehiculo.getMotor());
                    command.Parameters.AddWithValue("@chasis", vehiculo.getChasis());
                    command.Parameters.AddWithValue("@id", vehiculo.getId().ToString());

                    int rowsAffected = command.ExecuteNonQuery();
                    Console.WriteLine($"{rowsAffected} fila(s) actualizada(s) correctamente.");
                }
            }
            catch (NpgsqlException ex)
            {
                connection.Close();
                Console.WriteLine("Error de PostgreSQL: " + ex.Message);
            }
            catch (Exception ex)
            {
                connection.Close();
                Console.WriteLine("Error general: " + ex.Message);
            }
        }

        private void deleteInPostgreSql(string id)
        {
            try
            {
                connection.Open();
                string insertQuery = "DELETE FROM vehiculos  WHERE id = @id ";
                using (NpgsqlCommand command = new NpgsqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    int rowsAffected = command.ExecuteNonQuery();
                    Console.WriteLine($"{rowsAffected} fila(s) eliminada(s) correctamente.");
                }
            }
            catch (NpgsqlException ex)
            {
                connection.Close();
                Console.WriteLine("Error de PostgreSQL: " + ex.Message);
            }
            catch (Exception ex)
            {
                connection.Close();
                Console.WriteLine("Error general: " + ex.Message);
            }
        }

    }
}
