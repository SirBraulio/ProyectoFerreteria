using CapaConexion;
using capaDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NegocioUsuario
    {
        private ConexionSQL conec;

        public ConexionSQL Conec { get => conec; set => conec = value; }

        public void configurarConexion()
        {
            this.Conec = new ConexionSQL();
            this.Conec.NombreBaseDatos = "ferreteria";
            this.Conec.NombreTabla = "usuario";
            this.Conec.CadenaConexion = @"Data Source=DESKTOP-1BL2V3H;Initial Catalog=ferreteria;Integrated Security=True";
        }

        public Boolean insertarUsuario(Usuario usuario)
        {
            try
            {
                this.configurarConexion();
                this.Conec.CadenaSQL = "INSERT INTO usuario (usuario ,contraseña ,nombre ,correo) VALUES ('" + usuario.User + "','" + usuario.Contraseña + "','" + usuario.Nombre + "','" + usuario.Correo + "')";
                this.Conec.EsSelect = false;
                this.Conec.conectar();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Datos no guardados " + ex.Message, "Mensaje Sistema");

                return false;
            }
        }

        public Usuario buscarUsuario(String idUsuario)
        {
            Usuario auxUsuario = new Usuario();
            this.configurarConexion();
            this.Conec.CadenaSQL = "SELECT * FROM usuario"
                                   + " WHERE idUsuario = '" + idUsuario + "';";
            this.Conec.EsSelect = true;
            this.Conec.conectar();
            DataTable dt = new DataTable();
            dt = this.conec.DbDataSet.Tables[0];

            if (dt.Rows.Count > 0)
            {
                auxUsuario.IdUsuario = (int)dt.Rows[0]["idUsuario"];
                auxUsuario.Nombre = (String)dt.Rows[0]["nombre"];
            }
            else
            {
                auxUsuario.IdUsuario = -1;
                auxUsuario.Nombre = String.Empty;
            }
            return auxUsuario;
        }//Fin Buscar

        public void eliminarUsuario(string IDaborrar)
        {
            this.configurarConexion();
            this.Conec.CadenaSQL = " DELETE FROM usuario " +
                                                " WHERE idUsuario = '" + IDaborrar + "';";
            this.Conec.EsSelect = false;
            this.Conec.conectar();

        } //Fin eliminar

        public void actualizarUsuario(Usuario usuario)
        {
            this.configurarConexion();
            this.Conec.CadenaSQL = "UPDATE usuario SET usuario = '"
                                   + usuario.User + "', contraseña = '" + usuario.Contraseña + "', nombre = '" + usuario.Nombre + "', correo = '" + usuario.Correo + "' WHERE idUsuario = '" + usuario.IdUsuario + "';";
            this.Conec.EsSelect = false;
            this.Conec.conectar();
        } // Fin Actualizar

        public bool logearUsuario(String correo, String password)
        {
            this.configurarConexion();
            this.Conec.CadenaSQL = "SELECT * FROM usuario"
                                   + " WHERE correo = '" + correo + "' AND contraseña =  '" + password + "';";
            this.Conec.EsSelect = true;
            this.Conec.conectar();
            DataTable dt = new DataTable();
            dt = this.conec.DbDataSet.Tables[0];

            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
