using CapaConexion;
using capaDTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NegocioVenta
    {
        private ConexionSQL conec;

        public ConexionSQL Conec { get => conec; set => conec = value; }

        string cadena = @"Data Source=DESKTOP-1BL2V3H;Initial Catalog=ferreteria;Integrated Security=True";

        public void configurarConexion()
        {
            this.Conec = new ConexionSQL();
            this.Conec.NombreBaseDatos = "ferreteria";
            this.Conec.NombreTabla = "venta";
            this.Conec.CadenaConexion = @"Data Source=DESKTOP-1BL2V3H;Initial Catalog=ferreteria;Integrated Security=True";
        }

        public Boolean insertarVenta(Venta venta)
        {
            try
            {
                this.configurarConexion();
                this.Conec.CadenaSQL = "INSERT INTO venta(idCliente) VALUES ('" + venta.IdCliente + "');";
                this.Conec.EsSelect = false;
                this.Conec.conectar();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Datos No Guardados " + ex.Message, "Mensaje Sistema");
                Console.WriteLine("");
                return false;
            }

        }

        public int buscarUltimoIdVenta()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = cadena;
            conn.Open();
            SqlCommand da = new SqlCommand("select max(idVenta) as idVenta from venta;", conn);
            SqlDataReader ds = da.ExecuteReader();
            if (ds.Read())
            {
                return (int)ds["idVenta"];
            }
            else
            {
                return 0;
            }

        }

        public Boolean insertarDetalleVenta(DetalleVenta detalle)
        {
            try
            {
                this.configurarConexion();
                this.Conec.CadenaSQL = "INSERT INTO detalleVenta(idVenta ,idStock ,cantidad,total) VALUES ('" + detalle.IdVenta + "','" + detalle.IdStock + "'," + detalle.Cantidad + ",'" + detalle.Total + "')";
                this.Conec.EsSelect = false;
                this.Conec.conectar();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

    }
}
