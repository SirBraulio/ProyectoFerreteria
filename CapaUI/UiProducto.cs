using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaUI
{
    public partial class UiProducto : Form
    {
        public UiProducto()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            txtIDProducto.ReadOnly = false;
            if (String.IsNullOrEmpty(this.txtIDProducto.Text) || String.IsNullOrEmpty(this.txtPrecioUni.Text)
             || String.IsNullOrEmpty(this.txtIdProv.Text) || String.IsNullOrEmpty(this.txtTipoP.Text)
             || String.IsNullOrEmpty(this.txtMarca.Text))
            {
                MessageBox.Show("Los datos obligatorios no pueden estar vacios ", "Mensaje Sistema");
                return;
            }
            else {
                try
                {
                    ServiceProducto.WebServiceProductoSoapClient AuxNeg = new ServiceProducto.WebServiceProductoSoapClient();
                    ServiceProducto.Producto newProducto = new ServiceProducto.Producto();
                    newProducto.Idproducto = this.txtIDProducto.Text;
                    newProducto.Precio_unitario = Convert.ToInt32(this.txtPrecioUni.Text);
                    newProducto.Idproveedor = this.txtIdProv.Text;
                    newProducto.Tipo_producto = this.txtTipoP.Text;
                    newProducto.Caracteristica = this.txtCaracteristica.Text;
                    newProducto.Marca = this.txtMarca.Text;
                    AuxNeg.Serviceinsertarproducto(newProducto);
                    MessageBox.Show("Datos Guardados Satisfactoriamente", "Mensaje Sistema");
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Datos No Guardados " + ex.Message, "Mensaje Sistema");
                }
            }
            
        }

        private void UiProducto_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ferreteriaDataSet.producto' Puede moverla o quitarla según sea necesario.
            this.productoTableAdapter.Fill(this.ferreteriaDataSet.producto);
            // TODO: esta línea de código carga datos en la tabla 'ferreteriaDataSet.producto' Puede moverla o quitarla según sea necesario.
            this.productoTableAdapter.Fill(this.ferreteriaDataSet.producto);
            // TODO: esta línea de código carga datos en la tabla 'ferreteriaDataSet.proveedor' Puede moverla o quitarla según sea necesario.
            this.proveedorTableAdapter.Fill(this.ferreteriaDataSet.proveedor);

        }
    }
}
