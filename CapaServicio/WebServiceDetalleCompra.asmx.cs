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
    /// Descripción breve de WebServiceDetalleCompra
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceDetalleCompra : System.Web.Services.WebService
    {

        [WebMethod(Description = "Metodo que obtiene un detalle de compra por idProducto ")]
        public DetalleDeCompra ServicioBuscarDetalleCompraPorIdProducto(string idProducto)
        {
            NegocioDetalleCompra auxDetalle = new NegocioDetalleCompra();
            return auxDetalle.obtenerDetalleCompraPorIdProducto(idProducto);
        }
    }
}
