using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaDTO
{
    public class DetalleCompra
    {
        private int idCompra;
        private String idProveedor;
        private int idDetalleCompra;       
        private String idProducto;
        private int idStock;
        private int cantidad;

        public int IdCompra { get => idCompra; set => idCompra = value; }
        public String Idproveedor { get => idProveedor; set => idProveedor = value; }
        public int IdDetalleCompra { get => idDetalleCompra; set => idDetalleCompra = value; }       
        public String IdProducto { get => idProducto; set => idProducto = value; }
        public int IdStock { get => idStock; set => idStock = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }

    }
}
