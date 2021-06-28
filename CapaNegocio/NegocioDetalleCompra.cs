using CapaConexion;
using capaDTO;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NegocioDetalleCompra
    {
        private ConexionSQL conec;

        public ConexionSQL Conec { get => conec; set => conec = value; }

        public void configurarConexion()
        {
            this.Conec = new ConexionSQL();
            this.Conec.NombreBaseDatos = "ferreteria";
            this.Conec.NombreTabla = "detalleCompra";
            this.Conec.CadenaConexion = @"Data Source=DESKTOP-1BL2V3H;Initial Catalog=ferreteria;Integrated Security=True";
        }

        public DetalleDeCompra obtenerDetalleCompraPorIdProducto (string idProducto)
        {
            this.configurarConexion();
            DetalleDeCompra detalle = new DetalleDeCompra();
            this.Conec.CadenaSQL = "SELECT * FROM detalleCompra"
                                   + " WHERE idProducto = '" + idProducto + "';";
            this.Conec.EsSelect = true;
            this.Conec.conectar();
            DataTable dt = new DataTable();
            dt = this.conec.DbDataSet.Tables[0];

            if (dt.Rows.Count > 0)
            {
                detalle.IdCompra= (int)dt.Rows[0]["idCompra"];
                detalle.IdDetalleCompra = (int)dt.Rows[0]["idDetalleCompra"];
                detalle.IdProducto = (string)dt.Rows[0]["idProducto"];
            }
            else
            {
                detalle.IdCompra = -1;
                detalle.IdDetalleCompra = -1;
                detalle.IdProducto = string.Empty;
            }
            return detalle;
        }
    }
}
