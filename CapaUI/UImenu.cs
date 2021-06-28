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

        private void irAMantenedorDeProductosToolStripMenuItem_Click_1(object sender, EventArgs e)
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


        private void irAAdminnistracionDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
        this.Hide();
        UiCliente pCliente = new UiCliente();
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
        
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
        Application.Exit();
        }

        private void irAAdministracionDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            UiUsuario pUsuario = new UiUsuario();
            pUsuario.ShowDialog();
        }

        private void irANuevaVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            UiVenta pVenta = new UiVenta();
            pVenta.ShowDialog();
        }
    }
}
