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
    public class NegocioProveedor
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

        public Boolean insertarProovedor(Proveedor proveedor)
        {
            try
            {
                this.configurarConexion();
                this.Conec.CadenaSQL = "INSERT INTO proveedor(idProveedor ,nombreProv ,numeroProv,correoProv) VALUES ('"+ proveedor.Idproveedor +"','"+proveedor.Nombre_prov+"',"+proveedor.Numero_prov+",'"+ proveedor.CorreoProv +"')";
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

        public Proveedor buscaProv(String idproveedor)
        {
            Proveedor auxProv = new Proveedor();
            this.configurarConexion();
            this.Conec.CadenaSQL = "SELECT * FROM proveedor"
                                   + " WHERE idProveedor = '" + idproveedor + "';";
            this.Conec.EsSelect = true;
            this.Conec.conectar();
            DataTable dt = new DataTable();
            dt = this.conec.DbDataSet.Tables[0];

            if (dt.Rows.Count > 0) {
                auxProv.Idproveedor = (String)dt.Rows[0]["idProveedor"];
                auxProv.Nombre_prov = (String)dt.Rows[0]["nombreProv"];
            }
            else
            {
                auxProv.Idproveedor = String.Empty;
                auxProv.Nombre_prov = String.Empty;
            }
            return auxProv;
        }//Fin Buscar
        public Proveedor buscaConcidencia(String idproveedor)
        {
            Proveedor auxProv = new Proveedor();
            this.configurarConexion();
            this.Conec.CadenaSQL = "select idProducto, idProveedor from producto"
                                   + " WHERE idProveedor = '" + idproveedor + "';";
            this.Conec.EsSelect = true;
            this.Conec.conectar();
            DataTable dt = new DataTable();
            dt = this.Conec.DbDataSet.Tables[0];

            if (dt.Rows.Count > 0)
            {
                auxProv.Idproveedor = (String)dt.Rows[0]["idProveedor"];
                auxProv.Nombre_prov = (String)dt.Rows[0]["idProducto"];
            }
            else
            {
                auxProv.Idproveedor = String.Empty;
                auxProv.Nombre_prov = String.Empty;
            }
            return auxProv;
        } //Fin BuscaCoincidencia
        public void eliminarProv(string IDaborrar)
        {
            this.configurarConexion();
            this.Conec.CadenaSQL = " DELETE FROM proveedor " +
                                                " WHERE idProveedor = '" + IDaborrar + "';";
            this.Conec.EsSelect = false;
            this.Conec.conectar();

        } //Fin eliminar
        public void actualizarProv(Proveedor proveedor)
        {
            this.configurarConexion();
            this.Conec.CadenaSQL = "UPDATE proveedor SET nombreProv = '"
                                   + proveedor.Nombre_prov + "', numeroProv = '" + proveedor.Numero_prov + "', correoProv = '" + proveedor.CorreoProv + "' WHERE idProveedor = '" + proveedor.Idproveedor + "';";
            this.Conec.EsSelect = false;
            this.Conec.conectar();
        } //Fin Actualizar
    }
}
