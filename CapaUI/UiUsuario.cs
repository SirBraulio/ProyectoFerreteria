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
    public partial class UiUsuario : Form
    {
        public int idUsuario = -1;
        public UiUsuario()
        {
            InitializeComponent();
        }

        

        private void UiUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ferreteriaDataSet.proveedor' Puede moverla o quitarla según sea necesario.
            this.usuarioTableAdapter.Fill(this.ferreteriaDataSet.usuario);
        }

        private void dataGridViewUsuario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                textBoxUsuario.Text = row.Cells[1].Value.ToString();
                textBoxPassword.Text = row.Cells[2].Value.ToString();
                textBoxNombre.Text = row.Cells[3].Value.ToString();
                textBoxCorreo.Text = row.Cells[4].Value.ToString();
                idUsuario = int.Parse(row.Cells[0].Value.ToString());
                buttonActualizar.Enabled = true;
                buttonEliminar.Enabled = true;
                buttonCrear.Enabled = false;
                buttonCancelar.Visible = true;
            }

        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            if(idUsuario == -1)
            {
                MessageBox.Show("Para actualizar un usuario, primero debes seleccionarlo en la lista.");
                buttonActualizar.Enabled = false;
                buttonEliminar.Enabled = false;
                buttonCancelar.Visible = false;
                buttonCrear.Enabled = true;

            }
            else
            {
                MessageBox.Show("Puede actualizar.");
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (idUsuario == -1)
            {
                MessageBox.Show("Para eliminar un usuario, primero debes seleccionarlo en la lista.");
                buttonActualizar.Enabled = false;
                buttonEliminar.Enabled = false;
                buttonCancelar.Visible = false;
                buttonCrear.Enabled = true;

            }
            else
            {
                ServiceUsuario.WebServiceUsuarioSoapClient auxUsuario = new ServiceUsuario.WebServiceUsuarioSoapClient();
                auxUsuario.ServicioEliminarUsuario(idUsuario.ToString());
                this.usuarioTableAdapter.Fill(this.ferreteriaDataSet.usuario);
                limpiarCampos();

            }
        }

        private void limpiarCampos()
        {
            buttonActualizar.Enabled = false;
            buttonEliminar.Enabled = false;
            buttonCancelar.Visible = false;
            buttonCrear.Enabled = true;
            textBoxUsuario.Text = "";
            textBoxPassword.Text = "";
            textBoxNombre.Text = "";
            textBoxCorreo.Text = "";
            idUsuario = -1;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            buttonActualizar.Enabled = false;
            buttonEliminar.Enabled = false;
            buttonCancelar.Visible = false;
            buttonCrear.Enabled = true;
            textBoxUsuario.Text = "";
            textBoxPassword.Text = "";
            textBoxNombre.Text = "";
            textBoxCorreo.Text = "";
            idUsuario = -1;
        }

        private void textBoxUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
