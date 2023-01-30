using System.Data;
using System.Data.SqlClient;

namespace Entidades
{

    public static class ManejadorSql
    {

        public static List<Auto> ObtenerAutos()
        {
            try
            {
                List<Auto> lista = new();

                SqlConnection sqlConnection = new SqlConnection(@"Server=.;Database=parcialDB;Trusted_Connection=True;"); ;
                SqlCommand sqlCommand;

                sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandText = $"SELECT * FROM Tabla_Autos";
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandType = CommandType.Text;


                if (sqlConnection is not null && sqlConnection.State != ConnectionState.Open)
                {
                    sqlConnection.Open();
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        string patente = reader["Patente"].ToString();
                        int presionInflado = Convert.ToInt32(reader["PresionInflado"]);

                        Auto auto = new(presionInflado, patente);
                        lista.Add(auto);
                    }

                }
                else
                {
                    throw new Exception("No se pudo establecer conexion");
                }

                if (sqlConnection != null && sqlConnection.State == ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static bool InsertarVehiculo(Vehiculo vehiculo)
        {
            try
            {
                bool sePudo = false;
                SqlConnection sqlConnection = new SqlConnection(@"Server=.;Database=parcialDB;Trusted_Connection=True;"); ;
                SqlCommand sqlCommand;

                sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandText = $"INSERT INTO Tabla_Autos (Patente,PresionMaxima,PresionInflado) VALUES ('{vehiculo.Patente}',{vehiculo.PresionMaxima},{vehiculo.PresionInflado})";
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandType = CommandType.Text;

                if (sqlConnection is not null && sqlConnection.State != ConnectionState.Open)
                {
                    sqlConnection.Open();

                    int rows = sqlCommand.ExecuteNonQuery();
                    sePudo = true;
                    if (rows <= 0)
                    {
                        throw new Exception("Error al insertar datos a la base");
                    }
                }
                else
                {
                    throw new Exception("No se pudo establecer conexion");
                }

                if (sqlConnection != null && sqlConnection.State == ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
                return sePudo;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
