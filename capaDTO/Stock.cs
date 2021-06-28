using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaDTO
{
    public class Stock
    {
        private int idStock;
        private int idDetalleCompra;
        private int cantidad;

        public int IdStock { get => idStock; set => idStock = value; }
        public int IdDetalleCompra { get => idDetalleCompra; set => idDetalleCompra = value; }

        public int Cantidad { get => cantidad; set => cantidad = value; }
    }
}
