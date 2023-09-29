using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsuariosAccesoDatos;
using UsuariosEntidades;

namespace LogicaUsuarios
{
    public class UsuariosLogica
    {
        AccesoDatos Acc;
        public UsuariosLogica()
        {
            Acc = new AccesoDatos();
        }
        public bool Verificacion(string Usuario, string Contraseña)
        {
            bool Verificado = false;
            int Login = Acc.Login(Usuario, Contraseña);
            if (Login > 0) 
            {
                Verificado = true;
            }
            return Verificado;
        }
    }
}
