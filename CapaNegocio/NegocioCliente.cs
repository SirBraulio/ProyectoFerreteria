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
    public class NegocioCliente
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

        public Boolean insertarCliente(Cliente cliente)
        {
            try
            {
                this.configurarConexion();
                this.Conec.CadenaSQL = "INSERT INTO cliente (rutCliente,nombre,numeroCelular,cantCompras) VALUES('"
                                       + cliente.Rutcliente + "','" + cliente.Nombre + "'," + cliente.Numero_celular + "," + cliente.Cant_compras + ");";
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

        public Cliente buscaCliente(String cliente)
        {
            Cliente auxProv = new Cliente();
            this.configurarConexion();
            this.Conec.CadenaSQL = "SELECT * FROM cliente"
                                   + " WHERE rutCliente = '" + cliente + "';";
            this.Conec.EsSelect = true;
            this.Conec.conectar();
            DataTable dt = new DataTable();
            dt = this.Conec.DbDataSet.Tables[0];

            if (dt.Rows.Count > 0)
            {
                auxProv.Rutcliente = (String)dt.Rows[0]["rutCliente"];
                auxProv.Nombre = (String)dt.Rows[0]["nombre"];
            }
            else
            {
                auxProv.Rutcliente = String.Empty;
                auxProv.Nombre = String.Empty;
            }
            return auxProv;
        } //Fin Busca//fin buscar

        public void actualizarCliente(Cliente cliente)
        {
            this.configurarConexion();
            this.Conec.CadenaSQL = "UPDATE cliente SET rutCliente = '"
                                   + cliente.Rutcliente +
                                   "', nombre = '" + cliente.Nombre +
                                   "', numeroCelular = '" + cliente.Numero_celular +

                                   "' WHERE idCliente = '" + cliente.Idcliente + "';";
            this.Conec.EsSelect = false;
            this.Conec.conectar();
        } //Fin Actualizar

    }
}
