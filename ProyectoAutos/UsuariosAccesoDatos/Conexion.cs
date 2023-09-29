using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace UsuariosAccesoDatos
{
    public class Conexion
    {
        public MySqlConnection _conex;

        public Conexion(string servidor, string usuario, string password, string database, uint puerto)
        {
            MySqlConnectionStringBuilder cadenaConexion = new MySqlConnectionStringBuilder();
            cadenaConexion.Server = servidor;
            cadenaConexion.UserID = usuario;
            cadenaConexion.Password = password;
            cadenaConexion.Database = database;
            cadenaConexion.Port = puerto;

            _conex = new MySqlConnection(cadenaConexion.ToString());
        }
        public void EjecutarConsulta(string consulta)
        {
            try
            {
                _conex.Open();
                using (MySqlCommand comando = new MySqlCommand(consulta, _conex))
                {
                    comando.ExecuteNonQuery();
                    Console.WriteLine("Consulta ejecutada correctamente");
                }
                _conex.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al ejecutar la consulta: ", ex.Message);
            }
        }
        //DataTable funciona con una tabla, DataSet varias tablas señalando su posición
        public DataTable ObtenerDatos(string consulta)
        {
            DataTable tabla = new DataTable();
            try
            {
                _conex.Open();
                using (MySqlCommand comando = new MySqlCommand(consulta, _conex))
                {
                    using (MySqlDataAdapter adaptador = new MySqlDataAdapter(comando))
                    {
                        adaptador.Fill(tabla);
                        Console.WriteLine("Consulta ejecutada correctamente");
                    }
                }
                _conex.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al ejecutar la consulta: ", ex.Message);
            }
            return tabla;
        }
    }

}
