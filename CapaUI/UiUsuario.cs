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
        ServiceUsuario.WebServiceUsuarioSoapClient auxUsuario = new ServiceUsuario.WebServiceUsuarioSoapClient();

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
            if (idUsuario == -1)
            {
                MessageBox.Show("Para actualizar un usuario, primero debes seleccionarlo en la lista.");
                buttonActualizar.Enabled = false;
                buttonEliminar.Enabled = false;
                buttonCancelar.Visible = false;
                buttonCrear.Enabled = true;

            }
            else
            {
                try
                {
                    if (check_isValid(textBoxUsuario.Text, "El usuario debe tener un tamaño minimo de 5 caracteres.", 4) == false) return;

                    if (check_isValid(textBoxNombre.Text, "El nombre debe tener un tamaño minimo de 5 caracteres", 4) == false) return;

                    if (check_isValid(textBoxCorreo.Text, "El correo debe tener un tamaño minimo de 5 caracteres", 4) == false) return;

                    if (check_isValid(textBoxPassword.Text, "La contraseña debe tener un tamaño minimo de 6 caracteres", 5) == false) return;

                    ServiceUsuario.Usuario user = new ServiceUsuario.Usuario();

                    user.User = textBoxUsuario.Text;
                    user.Nombre = textBoxNombre.Text;
                    user.Correo = textBoxCorreo.Text;
                    user.Contraseña = textBoxPassword.Text;
                    user.IdUsuario = idUsuario;

                    auxUsuario.ServicioActualizarUsuario(user);
                    this.usuarioTableAdapter.Fill(this.ferreteriaDataSet.usuario);
                    MessageBox.Show("Datos Guardados", "Mensaje Sistema");
                    limpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Datos No Guardados " + ex.Message, "Mensaje Sistema");
                }
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


        private void buttonCrear_Click(object sender, EventArgs e)
        {
            try
            {

                if (check_isValid(textBoxUsuario.Text, "El usuario debe tener un tamaño minimo de 5 caracteres.", 4) == false) return;

                if (check_isValid(textBoxNombre.Text, "El nombre debe tener un tamaño minimo de 5 caracteres", 4) == false) return;

                if (check_isValid(textBoxCorreo.Text, "El correo debe tener un tamaño minimo de 5 caracteres", 4) == false) return;

                if (check_isValid(textBoxPassword.Text, "La contraseña debe tener un tamaño minimo de 6 caracteres", 5) == false) return;

                ServiceUsuario.Usuario new_user = new ServiceUsuario.Usuario();
                
                new_user.User = textBoxUsuario.Text;
                new_user.Nombre = textBoxNombre.Text;
                new_user.Correo = textBoxCorreo.Text;
                new_user.Contraseña = textBoxPassword.Text;

                auxUsuario.ServicioInsertarUsuario(new_user);

                this.usuarioTableAdapter.Fill(this.ferreteriaDataSet.usuario);
                MessageBox.Show("Datos Guardados", "Mensaje Sistema");
                limpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Datos No Guardados " + ex.Message, "Mensaje Sistema");
            }
        }

        private bool check_isValid(string param, string mensaje, int tamañoDeseado)
        {
            if (param.Trim().Length < tamañoDeseado)
            {
                MessageBox.Show(mensaje);
                return false;
            }
            else return true;
        }


    }
}
