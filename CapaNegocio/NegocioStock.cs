using CapaConexion;
using capaDTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NegocioStock
    {
        private ConexionSQL conec;


        public ConexionSQL Conec { get => conec; set => conec = value; }
        string cadena = @"Data Source=DESKTOP-1BL2V3H;Initial Catalog=ferreteria;Integrated Security=True";
        public void configurarConexion()
        {
            this.Conec = new ConexionSQL();
            this.Conec.NombreBaseDatos = "ferreteria";
            this.Conec.NombreTabla = "proveedor";
            this.Conec.CadenaConexion = @"Data Source=DESKTOP-1BL2V3H;Initial Catalog=ferreteria;Integrated Security=True";
        }

        public Boolean insertarCompra(DetalleCompra detalle)
        {
            try
            {
                this.configurarConexion();
                this.Conec.CadenaSQL = "INSERT INTO compra(idProveedor ) VALUES ('" + detalle.Idproveedor + "')";
                this.Conec.EsSelect = false;
                this.Conec.conectar();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Datos no guardados " + ex.Message, "Mensaje Sistema");

                return false; ;
            }
        }//Fin insertar
        public int buscaLastCompra()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = cadena;
            conn.Open();
            SqlCommand da = new SqlCommand("select max(idCompra) as idcompra from compra;",conn);
            SqlDataReader ds = da.ExecuteReader();
            if (ds.Read())
            {
                return (int)ds["idCompra"];
            }
            else
            {
                return 0;
            }
            
        } //Fin Busca
        public Boolean insertarDetalleCompra(DetalleCompra detalle)
        {
            try
            {
                this.configurarConexion();

                this.Conec.CadenaSQL = "INSERT INTO detalleCompra(idCompra, idProducto ) VALUES (" + detalle.IdCompra + ", '" + detalle.IdProducto + "')";
                this.Conec.EsSelect = false;
                this.Conec.conectar();

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Datos no guardados " + ex.Message, "Mensaje Sistema");

                return false; ;
            }
        }//Fin insertar

        public int buscaLastdetalle()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = cadena;
            conn.Open();
            SqlCommand da = new SqlCommand("select max(idDetalleCompra) as iddetcompra from detalleCompra;", conn);
            SqlDataReader ds = da.ExecuteReader();
            if (ds.Read())
            {
                return (int)ds["iddetcompra"];
            }
            else
            {
                return 0;
            }

        } //Fin Busca

        public Boolean insertarStock(DetalleCompra detalle)
        {
            try
            {
                this.configurarConexion();

                this.Conec.CadenaSQL = "INSERT INTO stock(idDetalleCompra, cantidad ) VALUES (" + detalle.IdDetalleCompra + "," + detalle.Cantidad + ")";
                this.Conec.EsSelect = false;
                this.Conec.conectar();

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Datos no guardados " + ex.Message, "Mensaje Sistema");

                return false; ;
            }
        }//Fin insertar

        public Stock obtenerStockPorIdDetalleCompra(string idDetalle)
        {
            Stock auxStock = new Stock();
            this.configurarConexion();
            this.Conec.CadenaSQL = "SELECT * FROM stock"
                                   + " WHERE idDetalleCompra = '" + idDetalle + "';";
            this.Conec.EsSelect = true;
            this.Conec.conectar();
            DataTable dt = new DataTable();
            dt = this.conec.DbDataSet.Tables[0];

            if (dt.Rows.Count > 0)
            {
                auxStock.IdStock = (int)dt.Rows[0]["idStock"];
                auxStock.IdDetalleCompra = (int)dt.Rows[0]["idDetalleCompra"];
                auxStock.Cantidad = (int)dt.Rows[0]["cantidad"];
            }
            else
            {
                auxStock.IdStock = -1;
                auxStock.IdDetalleCompra = -1;
                auxStock.Cantidad = -1;
            }

            return auxStock;
        }

        public void actualizarStock(Stock stock)
        {
            this.configurarConexion();
            this.Conec.CadenaSQL = "UPDATE stock SET cantidad = '"
                                   + stock.Cantidad +  "' WHERE idStock = '" + stock.IdStock + "';";
            this.Conec.EsSelect = false;
            this.Conec.conectar();
        }
    }
}
