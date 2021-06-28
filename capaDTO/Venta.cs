using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaDTO
{
    public class Venta
    {
        private int idVenta;
        private int idCliente;

        public int IdVenta { get => idVenta; set => idVenta = value; }
        public int IdCliente { get => idCliente; set => idCliente = value; }
    }
}
