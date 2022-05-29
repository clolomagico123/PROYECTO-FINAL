using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoProgra1
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void alirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login login = new login();
            this.Hide();
            login.Show();
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login login = new login();
            this.Hide();
            login.Show();
        }

        private void verToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVer ver = new FormVer();
            this.Hide();
            ver.Show();
        }

        private void ventaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVentas ventas = new FormVentas();
            this.Hide();
            ventas.Show();
        }

        private void historialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHistorial historial = new FormHistorial();
            this.Hide();
            historial.Show();
        }

        private void cerrarSesiónToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            login login = new login();
            this.Hide();
            login.Show();
        }

        private void agregarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAgregarProducto FormAgregarProducto = new FormAgregarProducto();
            this.Hide();
            FormAgregarProducto.Show();
        }

        private void perfilToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
