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
        ServiceDetCompra.WebServiceDetalleCompraSoapClient auxDetalle = new ServiceDetCompra.WebServiceDetalleCompraSoapClient();
        ServiceStock.WebServiceStockSoapClient auxStock = new ServiceStock.WebServiceStockSoapClient();
        ServiceVenta.WebServiceVentaSoapClient auxVenta = new ServiceVenta.WebServiceVentaSoapClient();

        int valorProducto = 0;
        int idCliente = -1;
        string idProducto = "";
        int cantidad = 0;
        int cantStock = -1;
        int total = 0;
        int idStock = -1;

        public UiVenta()
        {
            InitializeComponent();
        }

        private void UiVenta_Load(object sender, EventArgs e)
        {
            this.clienteTableAdapter.Fill(this.ferreteriaDataSet.cliente);
            this.productoTableAdapter.Fill(this.ferreteriaDataSet.producto);
            this.detalleVentaTableAdapter.Fill(this.ferreteriaDataSet.detalleVenta);
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
                idProducto = row.Cells[0].Value.ToString();
                valorProducto = int.Parse(row.Cells[1].Value.ToString());
                textBoxProducto.Text = row.Cells[3].Value.ToString();
                try
                {
                    ServiceDetCompra.DetalleDeCompra detalle = auxDetalle.ServicioBuscarDetalleCompraPorIdProducto(idProducto.ToString());
                    if (detalle.IdDetalleCompra != -1)
                    {
                        ServiceStock.Stock stock = auxStock.ServicioObtenerStockPorIdDetalle(detalle.IdDetalleCompra.ToString());
                        if (stock.Cantidad >= 0)
                        {
                            idStock = stock.IdStock;
                            cantStock = stock.Cantidad;
                            buttonRestarCantidad.Enabled = true;
                            buttonSumarCantidad.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("No se puede comprar este producto debido a que no hay stock", "Mensaje Sistema");
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se encontro el stock en nuestro sistema", "Mensaje Sistema");
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Ocurrío un error fatal" + ex.Message, "Mensaje Sistema");
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

        private void buttonSumarCantidad_Click(object sender, EventArgs e)
        {
            if(cantidad < cantStock)
            {
                cantidad += 1;
                handleChangeTotal();
            }
        }

        private void buttonRestarCantidad_Click(object sender, EventArgs e)
        {
            if(cantidad > 1)
            {
                cantidad -= 1;
                handleChangeTotal();
            }
        }

        private void handleChangeTotal()
        {
            labelValorCantidad.Text = cantidad.ToString();
            total = cantidad * valorProducto;
            textBoxTotal.Text = total.ToString();
        }

        private void buttonRegistrarVentaOnClick(object sender, EventArgs e)
        {
            if(idCliente == -1)
            {
                MessageBox.Show("Debes seleccionar un cliente para poder registrar una venta");
                return;
            }
            if(idStock == -1)
            {
                MessageBox.Show("Debes seleccionar un producto para poder registrar una venta");
                return;
            }
            if(cantidad <= 0)
            {
                MessageBox.Show("Debes seleccionar una cantidad mayor a 0 para registrar una venta");
                return;
            }

            try
            {
                ServiceVenta.Venta venta = new ServiceVenta.Venta();

                venta.IdCliente = idCliente;

                Boolean fueCreada = auxVenta.ServicioCrearVenta(venta);

                if (fueCreada == true)
                {
                    int idVenta = auxVenta.ServicioObtenerIdUltimaVenta();

                    ServiceVenta.DetalleVenta detalle = new ServiceVenta.DetalleVenta();

                    detalle.IdVenta = idVenta;
                    detalle.IdStock = idStock;
                    detalle.Cantidad = cantidad;
                    detalle.Total = total;

                    Boolean fueCreadoElDetalle = auxVenta.ServicioCrearDetalleVenta(detalle);

                    if(fueCreadoElDetalle == true)
                    {
                        ServiceStock.Stock stockActualizar = new ServiceStock.Stock();
                        stockActualizar.IdStock = idStock;
                        stockActualizar.Cantidad = cantStock - cantidad;
                        auxStock.ServicioActualizarStock(stockActualizar);
                        MessageBox.Show("Venta creada satisfactoriamente" , "Mensaje del sistema");
                        dataGridViewProductos.Visible = false;
                        dataGridViewClientes.Visible = false;
                        dataGridViewVentas.Visible = true;
                        limpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show("Ocurrío un error al registrar la venta", "Mensaje del sistema");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrío un error " + ex.Message, "Mensaje del sistema");
            }
        }

        private void limpiarCampos()
        {
            valorProducto = 0;
            idCliente = -1;
            idProducto = "";
            cantidad = -1;
            cantStock = -1;
            total = 0;
            idStock = -1;
            this.textBoxCliente.Text = "";
            this.textBoxProducto.Text = "";
            this.textBoxTotal.Text = "";
            this.labelValorCantidad.Text = "";
            this.clienteTableAdapter.Fill(this.ferreteriaDataSet.cliente);
            this.productoTableAdapter.Fill(this.ferreteriaDataSet.producto);
            this.detalleVentaTableAdapter.Fill(this.ferreteriaDataSet.detalleVenta);
        }

        private void irAMantenedorDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            UiProducto pantalla = new UiProducto();
            pantalla.Show();
        }

        private void irAMantenedorDeProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            UiProveedor pantalla = new UiProveedor();
            pantalla.Show();
        }

        private void irAAdministracionDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            UiUsuario pantalla = new UiUsuario();
            pantalla.Show();
        }

        private void irAAdminnistracionDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            UiCliente pantalla = new UiCliente();
            pantalla.Show();
        }


        private void irAMenúPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            UImenu pantalla = new UImenu();
            pantalla.Show();
        }

        private void salirAltF4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
