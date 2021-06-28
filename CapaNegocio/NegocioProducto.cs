using CapaConexion;
using capaDTO;
using System;
using System.Collections.Generic;
using System.Data;
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
            this.Conec.CadenaConexion = @"Data Source=DESKTOP-1BL2V3H;Initial Catalog=ferreteria;Integrated Security=True";
        }

        public Boolean insertarproducto(Producto producto)
        {
            try
            {
                this.configurarConexion();
                this.Conec.CadenaSQL = "INSERT INTO producto(idProducto, precioUnitario, idProveedor, tipoProducto, caracteristica, marca) VALUES ('"+ producto.Idproducto + "'," + producto.Precio_unitario + ",'" + producto.Idproveedor + "','" + producto.Tipo_producto + "','" + producto.Caracteristica + "','" + producto.Marca + "');";
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
        public Producto buscaProd(String idProducto)
        {
            Producto auxProv = new Producto();
            this.configurarConexion();
            this.Conec.CadenaSQL = "SELECT * FROM producto"
                                   + " WHERE idProducto = '" + idProducto + "';";
            this.Conec.EsSelect = true;
            this.Conec.conectar();
            DataTable dt = new DataTable();
            dt = this.Conec.DbDataSet.Tables[0];

            if (dt.Rows.Count > 0)
            {
                auxProv.Idproducto = (String)dt.Rows[0]["idproducto"];
                auxProv.Tipo_producto = (String)dt.Rows[0]["tipoProducto"];
            }
            else
            {
                auxProv.Idproducto = String.Empty;
                auxProv.Tipo_producto = String.Empty;
            }
            return auxProv;
        } //Fin Busca
        public void actualizarProducto(Producto producto)
        {
            this.configurarConexion();
            this.Conec.CadenaSQL = "UPDATE producto SET idProducto = '"
                                   + producto.Idproducto +
                                   "', precioUnitario = '" + producto.Precio_unitario +
                                   "', tipoProducto = '" + producto.Tipo_producto +
                                   "', caracteristica = '" + producto.Caracteristica +
                                   "', marca = '" + producto.Marca +

                                   "' WHERE idproducto = '" + producto.Idproducto + "';";
            this.Conec.EsSelect = false;
            this.Conec.conectar();
        } //Fin Actualizar  

    }
}
