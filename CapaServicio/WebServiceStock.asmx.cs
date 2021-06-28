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
    /// Descripción breve de WebServiceStock
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceStock : System.Web.Services.WebService
    {

        [WebMethod(Description = "Metodo que Inserta una compra ")]
        public Boolean ServicioinsertarCompra(DetalleCompra detalle)
        {
            NegocioStock auxn = new NegocioStock();
            return auxn.insertarCompra(detalle);
        }
        [WebMethod(Description = "Metodo que Inserta una compra detalle ")]
        public Boolean ServicioinsertarCompraDetalle(DetalleCompra detalle)
        {
            NegocioStock auxn = new NegocioStock();
            return auxn.insertarDetalleCompra(detalle);
        }
        [WebMethod(Description = "Metodo que Inserta un stock ")]
        public Boolean ServicioinsertarStock(DetalleCompra detalle)
        {
            NegocioStock auxn = new NegocioStock();
            return auxn.insertarStock(detalle);
        }
        [WebMethod(Description = "Metodo que Busca la ultima compra ")]
        public int ServicioBuscaLastCompra()
        {
            NegocioStock auxn = new NegocioStock();
            return auxn.buscaLastCompra();
        }
        [WebMethod(Description = "Metodo que Busca la ultima Detallecompra ")]
        public int ServicioBuscaLastDetalleCompra()
        {
            NegocioStock auxn = new NegocioStock();
            return auxn.buscaLastdetalle();
        }

        [WebMethod(Description = "Metodo que devuelve un stock por idDetalleCompra")]

        public Stock ServicioObtenerStockPorIdDetalle(string idDetalle)
        {
            NegocioStock auxStock = new NegocioStock();
            return auxStock.obtenerStockPorIdDetalleCompra(idDetalle);
        }

        [WebMethod(Description = "Actualizar stock")]

        public void ServicioActualizarStock(Stock stock)
        {
            NegocioStock auxStock = new NegocioStock();
            auxStock.actualizarStock(stock);
        }
    }
}
