using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsuariosAccesoDatos;
using UsuariosEntidades;
using System.Data;
using MySql.Data.MySqlClient;

namespace UsuariosAccesoDatos
{
    
    public class AccesoDatos
    {
        Conexion Con;

        public AccesoDatos()
        {
            Con = new Conexion("localhost", "root", "", "Users", 3306);
        }
        public int Login(string Usuario, String Contraseña)
        {
            Con._conex.Open();
            string Consulta = string.Format("select count(*) from Usuarios where nusuario = '{0}' and pass = '{1}'", Usuario, Contraseña);
            MySqlCommand Com = new MySqlCommand(Consulta, Con._conex);
            int Sesion = Convert.ToInt32(Com.ExecuteScalar());
            Con._conex.Close();
            return Sesion;
        }
    }
}
