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
    /// Descripción breve de WebServiceProducto
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceProducto : System.Web.Services.WebService
    {

        [WebMethod(Description = "Metodo que Inserta el producto ")]
        public bool Serviceinsertarproducto(Producto producto)
        {
            NegocioProducto auxn = new NegocioProducto();            
            return auxn.insertarproducto(producto);
        }

        [WebMethod(Description = "Metodo que busca el producto por su id")]
        public Producto ServicebuscaProd(String producto)
        {
            NegocioProducto auxn = new NegocioProducto();
            return auxn.buscaProd(producto);
        }
        [WebMethod(Description = "Metodo que actualiza el producto por su id")]
        public void ServiceActualizaProducto(Producto producto)
        {
            NegocioProducto auxn = new NegocioProducto();
            auxn.actualizarProducto(producto);
        }
    }
}
