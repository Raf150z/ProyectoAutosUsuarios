using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsuariosEntidades
{
    public class Usuarios
    {
        private int _idusuario;
        private string _nusuario;
        private string _pass;


        public int IdUsuario { get => _idusuario; set => _idusuario = value; }
        public string Nusuario { get => _nusuario;set => _nusuario = value; }
        public string Pass { get => _pass; set => _pass = value; }

    }
}
