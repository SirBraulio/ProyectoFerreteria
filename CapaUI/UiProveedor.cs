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
    public partial class UiProveedor : Form
    {
        public UiProveedor()
        {
            InitializeComponent();
        }

        private void UiProveedor_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ferreteriaDataSet.proveedor' Puede moverla o quitarla según sea necesario.
            this.proveedorTableAdapter.Fill(this.ferreteriaDataSet.proveedor);

        }

        private void irAMantenedorDeProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void limpiar() {
            txtIdProv.Text = "";
            txtNameProv.Text = "";
            txtNumberProv.Text = "";
            txtCorreo.Text = "";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(this.txtIdProv.Text) || String.IsNullOrEmpty(this.txtNameProv.Text) || String.IsNullOrEmpty(this.txtNumberProv.Text) || String.IsNullOrEmpty(this.txtCorreo.Text))
                {
                    MessageBox.Show("No se pueden dejar datos en blanco ", "Mensaje Sistema");
                    return;
                }
                else if (txtIdProv.Text.Length >= 7)
                {
                    MessageBox.Show("El id debe tener como maximo 6 caracteres", "Mensaje Sistema");
                    return;
                }
                else if (txtNameProv.Text.Length >= 50)
                {
                    MessageBox.Show("La cantidad de caracteres de Nombre excede el maximo ", "Mensaje Sistema");
                    return;
                }
                else {
                    ServiceProveedor.WebServiceProveedorSoapClient Aux_newProv = new ServiceProveedor.WebServiceProveedorSoapClient();
                    ServiceProveedor.Proveedor new_prov = new ServiceProveedor.Proveedor();
                    new_prov.Idproveedor = this.txtIdProv.Text;
                    new_prov.Nombre_prov = this.txtNameProv.Text;
                    new_prov.Numero_prov = Convert.ToInt32(this.txtNumberProv.Text);
                    new_prov.CorreoProv = this.txtCorreo.Text;
                    limpiar();
                    Aux_newProv.ServicioinsertarProveedor(new_prov);
                    this.proveedorTableAdapter.Fill(this.ferreteriaDataSet.proveedor);
                    MessageBox.Show("Datos Guardados ", "Mensaje Sistema");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Datos No Guardados " + ex.Message, "Mensaje Sistema");
            }
           

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(this.txtIdProv.Text))
                {
                    MessageBox.Show("Por Favor seleccione o ingrese un ID EXISTENTE ", "Mensaje Sistema");
                    return;
                }
                else
                {
                    ServiceProveedor.WebServiceProveedorSoapClient Aux_negProv = new ServiceProveedor.WebServiceProveedorSoapClient();

                    if (String.IsNullOrEmpty(Aux_negProv.ServiciobuscaProv(this.txtIdProv.Text).Idproveedor))
                    {
                        MessageBox.Show("Proveedor NO existe ", "Mensaje Sistema");
                        return;
                    }
                    else if (!String.IsNullOrEmpty(Aux_negProv.ServiciobuscaConcidencia(this.txtIdProv.Text).Idproveedor))
                    {
                        MessageBox.Show("El Proveedor tiene uno o varios productos a su nombre, por lo tanto no se puede eliminar ", "Mensaje Sistema");
                        return;
                    }
                    else
                    {
                        MessageBox.Show("No se podra eliminar un proveedor si tiene un producto de este en bodega. ", "Mensaje Sistema");
                        var confirmacion = MessageBox.Show("¿Está seguro que desea eliminar PARA SIEMPRE el registro seleccionado ?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                        if (confirmacion == DialogResult.Yes)
                        {
                            string iddeleted = this.txtIdProv.Text;
                            Aux_negProv.ServicioeliminarProv(iddeleted);
                            MessageBox.Show("Datos Eliminados Satisfactoriamente ", "Mensaje Sistema");
                            limpiar();
                            this.proveedorTableAdapter.Fill(this.ferreteriaDataSet.proveedor);
                        }
                        else
                        {
                            MessageBox.Show("Se a arrepentido justo a tiempo ", "Mensaje Sistema");
                            return;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Datos No Guardados " + ex.Message, "Mensaje Sistema");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(this.txtIdProv.Text) || String.IsNullOrEmpty(this.txtNameProv.Text) || String.IsNullOrEmpty(this.txtNumberProv.Text))
                {
                    MessageBox.Show("No se pueden dejar datos en blanco ", "Mensaje Sistema");
                    return;
                }
                else
                {
                    ServiceProveedor.WebServiceProveedorSoapClient Aux_negProv = new ServiceProveedor.WebServiceProveedorSoapClient();
                    
                    if (String.IsNullOrEmpty(Aux_negProv.ServiciobuscaProv(this.txtIdProv.Text).Idproveedor))
                    {
                        MessageBox.Show("El ID del Proveedor NO existe ", "Mensaje Sistema");
                        return;
                    }
                    else if (txtIdProv.Text.Length >= 7)
                    {
                        MessageBox.Show("El id debe tener como maximo 6 caracteres", "Mensaje Sistema");
                        return;
                    }
                    else if (txtNameProv.Text.Length >= 50)
                    {
                        MessageBox.Show("La cantidad de caracteres de Nombre excede el maximo ", "Mensaje Sistema");
                        return;
                    }
                    else
                    {
                        ServiceProveedor.Proveedor new_proc = new ServiceProveedor.Proveedor();

                        new_proc.Idproveedor = this.txtIdProv.Text;
                        new_proc.Nombre_prov = this.txtNameProv.Text;
                        new_proc.Numero_prov = Convert.ToInt32(this.txtNumberProv.Text);
                        new_proc.CorreoProv = this.txtCorreo.Text;

                        Aux_negProv.ServcioactualizarProv(new_proc);
                        MessageBox.Show("Datos Guardados ", "Mensaje Sistema");
                        limpiar();
                        this.proveedorTableAdapter.Fill(this.ferreteriaDataSet.proveedor);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Datos No Guardados " + ex.Message, "Mensaje Sistema");
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {

                if (e.ColumnIndex == 0)
                {
                    int j = 4;
                    for (int i = 0; i < j; i++)
                    {
                        Console.WriteLine(" el i " + i);
                        String Nombre = this.dataGridView1[i, e.RowIndex].Value.ToString();
                        Console.WriteLine(" es " + Nombre);
                        if (i == 0) { txtIdProv.Text = Nombre; txtIdProv.ReadOnly = true; }
                        else if (i == 1) { txtNameProv.Text = Nombre; }
                        else if (i == 2) { txtNumberProv.Text = Nombre; }
                        else if (i == 3) { txtCorreo.Text = Nombre; }

                    }   
                    
                }
                else if (e.ColumnIndex == 1)
                {
                    String Nombre = this.dataGridView1[e.ColumnIndex, e.RowIndex].Value.ToString();
                    Console.WriteLine(" " + Nombre);
                    txtNameProv.Text = Nombre;
                    txtIdProv.ReadOnly = true;
                }
            }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            if (btnList.Text == "Mostrar Lista")
            {
                btnList.Text = "Ocultar Lista";
            }
            else if (btnList.Text == "Ocultar Lista") { txtIdProv.ReadOnly = false; this.proveedorTableAdapter.Fill(this.ferreteriaDataSet.proveedor); btnList.Text = "Mostrar Lista"; dataGridView1.Visible = false; }
            else { }
        }

        private void irAMenuPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            UImenu pventana = new UImenu();
            pventana.ShowDialog();
        }
    }
}
