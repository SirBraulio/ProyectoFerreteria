using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaDTO
{
    public class DetalleVenta
    {
        private int idDetalleVenta;
        private int idVenta;
        private int idStock;
        private int cantidad;
        private int total;

        public int IdDetalleVenta { get => idDetalleVenta; set => idDetalleVenta = value; }
        public int IdVenta { get => idVenta; set => idVenta = value; }
        public int IdStock { get => idStock; set => idStock = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public int Total { get => total; set => total = value; }
    }
}
