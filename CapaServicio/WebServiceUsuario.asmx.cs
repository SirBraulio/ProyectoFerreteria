using capaDTO;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace CapaServicio
{
    /// <summary>
    /// Descripción breve de WebServiceUsuario
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceUsuario : System.Web.Services.WebService
    {
        [WebMethod(Description = "Metodo que Inserta un nuevo usuario ")]
        public Boolean ServicioInsertarUsuario(Usuario usuario)
        {
            NegocioUsuario auxn = new NegocioUsuario();
            return auxn.insertarUsuario(usuario);
        }
        [WebMethod(Description = "Metodo que busca un usuario por su id ")]
        public Usuario ServicioBuscarUsuario(String idUsuario)
        {
            NegocioUsuario auxn = new NegocioUsuario();
            return auxn.buscarUsuario(idUsuario);
        }

        [WebMethod(Description = "Metodo que elimina a un usuario por su id ")]
        public void ServicioEliminarUsuario(string IDaborrar)
        {
            NegocioUsuario auxn = new NegocioUsuario();
            auxn.eliminarUsuario(IDaborrar);
        }

        [WebMethod(Description = "Metodo que actualiza o modifica a un usuario por su id ")]
        public void ServicioActualizarUsuario(Usuario usuario)
        {
            NegocioUsuario auxn = new NegocioUsuario();
            auxn.actualizarUsuario(usuario);
        }
    }
}
