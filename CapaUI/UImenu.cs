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
    public partial class UImenu : Form
    {
        public UImenu()
        {
            InitializeComponent();
        }

        private void UImenu_Load(object sender, EventArgs e)
        {

        }

        private void salirAltF4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void irAMantenedorDeProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            UiProveedor pProducto = new UiProveedor();
            pProducto.ShowDialog();
        }

        private void irAMantenedorDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            UiProducto pProducto = new UiProducto();
            pProducto.ShowDialog();
        }

        private void irAAdministracionDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            UiUsuario pUsuario = new UiUsuario();
            pUsuario.ShowDialog();
        }
    }
}
