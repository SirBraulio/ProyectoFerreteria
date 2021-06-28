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
    /// Descripción breve de WebServiceCliente
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceCliente : System.Web.Services.WebService
    {

        [WebMethod(Description = "Metodo que Inserta un nuevo cliente ")]
        public bool Serviceinsertarproducto(Cliente producto)
        {
            NegocioCliente auxn = new NegocioCliente();
            return auxn.insertarCliente(producto);
        }

        [WebMethod(Description = "Metodo que busca el cliente por su id")]
        public Cliente ServicebuscaCliente(String cliente)
        {
            NegocioCliente auxn = new NegocioCliente();
            return auxn.buscaCliente(cliente);
        }


        [WebMethod(Description = "Metodo que Actualiza o Modifica un cliente por su id")]
        public void ServiceactualizarCliente(Cliente cliente)
        {
            NegocioCliente auxn = new NegocioCliente();
            auxn.actualizarCliente(cliente);
        }

    }
}
