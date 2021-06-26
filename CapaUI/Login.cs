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
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Admin" && txtContra.Text == "123")
            {
                this.Hide();
                UImenu pProv = new UImenu();
                pProv.ShowDialog();
            }
            else {
                MessageBox.Show("El usuario y contraseña no coinciden. reintenlo o comuniquese con el administrador para mas info ", "Mensaje Sistema");
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
