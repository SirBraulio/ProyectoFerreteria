using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using CapaNegocio;
using capaDTO;

namespace CapaServicio
{
    /// <summary>
    /// Descripción breve de WebServiceVenta
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceVenta : System.Web.Services.WebService
    {

        [WebMethod(Description = "Metodo que crea una nueva venta")]
        public Boolean ServicioCrearVenta(Venta venta)
        {
            NegocioVenta auxVenta = new NegocioVenta();
            return auxVenta.insertarVenta(venta);
        }

        [WebMethod(Description = "Metodo que obtiene el id de la ultima venta")]
        public int ServicioObtenerIdUltimaVenta()
        {
            NegocioVenta auxVenta = new NegocioVenta();
            return auxVenta.buscarUltimoIdVenta();
        }


        [WebMethod(Description = "Metodo que crea un nuevo detalle de venta")]
        public Boolean ServicioCrearDetalleVenta(DetalleVenta detalle)
        {
            NegocioVenta auxVenta = new NegocioVenta();
            return auxVenta.insertarDetalleVenta(detalle);
        }
    }
}
