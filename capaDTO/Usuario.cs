using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaDTO
{
    public class Usuario
    {
        private int idUsuario;
        private String usuario;
        private String contraseña;
        private String nombre;
        private String correo;

        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string User { get => usuario; set => usuario = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Correo { get => correo; set => correo = value; }
    }
}
