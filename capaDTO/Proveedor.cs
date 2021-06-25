using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaDTO
{
    public class Proveedor
    {
        private String idProveedor;
        private String nombreProv;
        private int numeroProv;
        private String correoProv;

        public String Idproveedor { get => idProveedor; set => idProveedor = value; }
        public String Nombre_prov { get => nombreProv; set => nombreProv = value; }
        public int Numero_prov { get => numeroProv; set => numeroProv = value; }
        public String CorreoProv { get => correoProv; set => correoProv = value; }
    }
}
