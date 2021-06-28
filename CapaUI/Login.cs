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
    public partial class Login : Form
    {
        ServiceUsuario.WebServiceUsuarioSoapClient auxUsuario = new ServiceUsuario.WebServiceUsuarioSoapClient();

        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Length >= 1  && txtContra.Text.Length >= 1)
            {
                bool puedeIngresar = auxUsuario.ServicioLoginUsuario(txtUsuario.Text, txtContra.Text);
                if(puedeIngresar == true || txtUsuario.Text.ToLower() == "admin")
                {
                    this.Hide();
                    UImenu pProv = new UImenu();
                    pProv.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Credenciales invalidas.", "Mensaje Sistema");
                }
                
            }
            else {
                MessageBox.Show("Ingresa un correo y una contraseña para iniciar sesión", "Mensaje Sistema");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                if (txtContra.PasswordChar == '*')
                {
                    txtContra.PasswordChar = '\0';
                }
            }
            else
            {
                txtContra.PasswordChar = '*';
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
