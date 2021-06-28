using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaDTO
{
    public class DetalleDeCompra
    {
        private int idDetalleCompra;
        private int idCompra;
        private string idProducto;

        public int IdCompra { get => idCompra; set => idCompra = value; }
        public int IdDetalleCompra { get => idDetalleCompra; set => idDetalleCompra = value; }
        public string IdProducto { get => idProducto; set => idProducto = value; }
    }
}
