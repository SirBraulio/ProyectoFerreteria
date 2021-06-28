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
                var confirmacion = MessageBox.Show("La cantidad de productos en esta venta no sera modificable, ¿Desea Proseguir?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (confirmacion == DialogResult.Yes)
                {
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


                        if (!String.IsNullOrEmpty(AuxNeg.ServicebuscaProd(this.txtIDProducto.Text).Idproducto))
                        {

                            MessageBox.Show("Datos No Guardados " + "Ya hay un producto registrado con esa id ", "Mensaje Sistema");

                        }
                        else
                        {
                            AuxNeg.Serviceinsertarproducto(newProducto);
                            MessageBox.Show("Datos Guardados Satisfactoriamente", "Mensaje Sistema");
                            this.productoTableAdapter.Fill(this.ferreteriaDataSet.producto);

                            //Testeo brigido
                            ServiceStock.WebServiceStockSoapClient newDetalle = new ServiceStock.WebServiceStockSoapClient();
                            ServiceStock.DetalleCompra auxCompra = new ServiceStock.DetalleCompra();
                            int j = 4;
                            auxCompra.Idproveedor = newProducto.Idproveedor;
                            auxCompra.IdProducto = newProducto.Idproducto;
                            for (int i = 0; i < j; i++)
                            {
                                if (i == 0)
                                {
                                    newDetalle.ServicioinsertarCompra(auxCompra);
                                    auxCompra.IdCompra = newDetalle.ServicioBuscaLastCompra();
                                }
                                else if (i == 1)
                                {
                                    newDetalle.ServicioinsertarCompraDetalle(auxCompra);
                                    auxCompra.IdDetalleCompra = newDetalle.ServicioBuscaLastDetalleCompra();
                                }
                                else if (i == 2)
                                {
                                    auxCompra.Cantidad = Convert.ToInt32(txtCantidad.Text);
                                    newDetalle.ServicioinsertarStock(auxCompra);
                                }
                                else if (i == 3)
                                {
                                    Console.WriteLine("Si funciono?, dime que si por amor de dios");
                                    limpiar();
                                }

                            }

                        }

                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Datos No Guardados " + ex.Message, "Mensaje Sistema");
                    }
                }
                else
                {
                    MessageBox.Show("Se a arrepentido justo a tiempo ", "Mensaje Sistema");
                    return;
                }
               
            }
            
        }

        private void UiProducto_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ferreteriaDataSet.producto' Puede moverla o quitarla según sea necesario.
            this.productoTableAdapter.Fill(this.ferreteriaDataSet.producto);
          
            // TODO: esta línea de código carga datos en la tabla 'ferreteriaDataSet.proveedor' Puede moverla o quitarla según sea necesario.
            this.proveedorTableAdapter.Fill(this.ferreteriaDataSet.proveedor);

        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {

                if (e.ColumnIndex == 0)
                {
                    int j = 4;
                    for (int i = 0; i < j; i++)
                    {
                        String Nombre = this.dataGridView2[i, e.RowIndex].Value.ToString();
                        if (i == 0) { txtIdProv.Text = Nombre; txtIdProv.ReadOnly = true; }
                        
                    }
                }
                else if (e.ColumnIndex == 1)
                {
                    String Nombre = this.dataGridView2[e.ColumnIndex, e.RowIndex].Value.ToString();
                
                    txtIdProv.ReadOnly = true;
                }
            }
        }

        private void btnMostrarL_Click(object sender, EventArgs e)
        {
            
            if (dataGridView2.Visible == false)
            {
                btnMostrarL.Text = "Ocultar Lista";
               
                dataGridView2.Visible = true;
               
            }
            else if (dataGridView2.Visible == true)
            {
                btnMostrarL.Text = "Mostrar Lista";
                dataGridView2.Visible = false;
              
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {

                if (e.ColumnIndex == 0)
                {
                    int j = 6;
                    for (int i = 0; i < j; i++)
                    {
                        Console.WriteLine(" el i " + i);
                        String Nombre = this.dataGridView1[i, e.RowIndex].Value.ToString();
                        Console.WriteLine(" es " + Nombre);
                        if (i == 0) { txtIDProducto.Text = Nombre; txtIdProv.ReadOnly = true; txtIDProducto.ReadOnly = true; }
                        else if (i == 1) { txtPrecioUni.Text = Nombre; }
                        else if (i == 2) { txtIdProv.Text = Nombre; }
                        else if (i == 3) { txtTipoP.Text = Nombre; }
                        else if (i == 4) { txtCaracteristica.Text = Nombre; }
                        else if (i == 5) { txtMarca.Text = Nombre; }

                    }

                }
                else if (e.ColumnIndex == 1)
                {
                   
                }
            }
        }
        public void limpiar()
        {
            this.txtIDProducto.Text = String.Empty;
            this.txtPrecioUni.Text = String.Empty;
            this.txtCantidad.Text = String.Empty;
            this.txtIdProv.Text = String.Empty;
            this.txtTipoP.Text = String.Empty;
            this.txtCaracteristica.Text = String.Empty;
            this.txtMarca.Text = String.Empty;
            this.txtIDProducto.Focus();
            txtIdProv.ReadOnly = false;
            txtIDProducto.ReadOnly = false;
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void brnModificar_Click(object sender, EventArgs e)
        {
            var confirmacion = MessageBox.Show("No se podra modificar la cantidad del producto ", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            
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

                AuxNeg.ServiceActualizaProducto(newProducto);
                MessageBox.Show("Datos Actualizados Satisfactoriamente", "Mensaje Sistema");
                this.productoTableAdapter.Fill(this.ferreteriaDataSet.producto);
                limpiar();
            }
            catch (Exception ex )
            {
                MessageBox.Show("Datos No Guardados " + ex.Message, "Mensaje Sistema");
                return;
            }
        }

        private void irAMantenedorDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            UiProducto pCliente = new UiProducto();
            pCliente.Show();
        }

        private void irAMantenedorDeProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            UiProveedor pCliente = new UiProveedor();
            pCliente.Show();
        }

        private void irAAdministracionDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            UiUsuario pCliente = new UiUsuario();
            pCliente.Show();
        }

        private void irAAdminnistracionDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            UiCliente pCliente = new UiCliente();
            pCliente.Show();
        }

        private void irANuevaVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            UiVenta pCliente = new UiVenta();
            pCliente.Show();
        }

        private void irAMenuPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            UImenu pCliente = new UImenu();
            pCliente.Show();
        }

        private void salirAltF4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
