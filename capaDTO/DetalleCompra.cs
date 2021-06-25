using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaDTO
{
    public class DetalleCompra
    {
        private int idDetalleCompra;
        private int idCompra;
        private String idProducto;

        public int IdDetalleCompra { get => idDetalleCompra; set => idDetalleCompra = value; }
        public int IdCompra { get => idCompra; set => idCompra = value; }
        public String IdProducto { get => idProducto; set => idProducto = value; }
    }
}
