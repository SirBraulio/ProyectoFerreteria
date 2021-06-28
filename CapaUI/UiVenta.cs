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
    public partial class UiVenta : Form
    {
        ServiceDetalleCompra.WebServiceDetalleCompraSoapClient auxDetalle = new ServiceDetalleCompra.WebServiceDetalleCompraSoapClient();
        int idCliente = -1;
        int idProducto = -1;
        public UiVenta()
        {
            InitializeComponent();
        }

        private void UiVenta_Load(object sender, EventArgs e)
        {
            this.clienteTableAdapter.Fill(this.ferreteriaDataSet.cliente);
            this.productoTableAdapter.Fill(this.ferreteriaDataSet.producto);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.clienteTableAdapter.Fill(this.ferreteriaDataSet.cliente);
            dataGridViewProductos.Visible = false;
            dataGridViewClientes.Visible = true;
            dataGridViewVentas.Visible = false;
        }

        private void buttonMostrarProducto_Click(object sender, EventArgs e)
        { 
            this.productoTableAdapter.Fill(this.ferreteriaDataSet.producto);
            dataGridViewProductos.Visible = true;
            dataGridViewClientes.Visible = false;
            dataGridViewVentas.Visible = false;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            dataGridViewProductos.Visible = false;
            dataGridViewClientes.Visible = false;
            dataGridViewVentas.Visible = true;
        }

        private void onClickedProducto(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewProductos.Rows[e.RowIndex];
                idProducto = int.Parse(row.Cells[0].Value.ToString());
                textBoxProducto.Text = row.Cells[3].Value.ToString();
                ServiceDetalleCompra.DetalleCompra detalle =  auxDetalle.ServicioBuscarDetalleCompraPorIdProducto(idProducto.ToString());
                if(detalle.IdDetalleCompra != -1)
                {

                }
                else
                {
                    //error
                }
            }
        }

        private void onClickedCliente(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewClientes.Rows[e.RowIndex];
                idCliente = int.Parse(row.Cells[0].Value.ToString());
                textBoxCliente.Text = row.Cells[2].Value.ToString();
                dataGridViewClientes.Visible = false;

            }
        }
    }
}
