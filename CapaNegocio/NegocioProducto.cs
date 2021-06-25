using CapaConexion;
using capaDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NegocioProducto
    {
        private ConexionSQL conec;


        public ConexionSQL Conec { get => conec; set => conec = value; }

        public void configurarConexion()
        {
            this.Conec = new ConexionSQL();
            this.Conec.NombreBaseDatos = "ferreteria";
            this.Conec.NombreTabla = "proveedor";
            this.Conec.CadenaConexion = @"Data Source=DESKTOP-USSDBAG\SQLEXPRESS01;Initial Catalog=ferreteria;Integrated Security=True";
        }

        public Boolean insertarproducto(Producto producto)
        {
            try
            {
                this.configurarConexion();
                this.Conec.CadenaSQL = "INSERT INTO producto(idProducto, precioUnitario, idProveedor, tipoProducto, caracteristica, marca))VALUES('"
                                       + producto.Idproducto + "','" + producto.Precio_unitario + "','" + producto.Idproveedor + "','" + producto.Tipo_producto + "','" + producto.Caracteristica + "','" + producto.Marca + "');";
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

        } //Fin insertar
    }
}
