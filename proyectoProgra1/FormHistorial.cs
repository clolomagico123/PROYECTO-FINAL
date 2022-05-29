using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoProgra1
{
    public partial class FormHistorial : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=UMG-LAB\SQLEXPRESS;Initial Catalog=progra1;Integrated Security=True");

        public FormHistorial()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {

            main main = new main();
            this.Hide();
            main.Show();
        }

        private void FormHistorial_Load(object sender, EventArgs e)
        {
            string query = "select idFactura as 'No. Factura', cliente, NIT, Fecha from tbl_cliente order by Fecha Desc";

            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);

            DataTable dtbl = new DataTable();

            sda.Fill(dtbl);

            dgvHistorial.DataSource = dtbl;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            if(txtBuscar.TextLength > 0) { 
            string query = "select orden.idProducto,Nombre,orden.precio, orden.cantidad, orden.precio * orden.cantidad as 'subtotal'from tbl_Orden orden " +
                "INNER JOIN tbl_Inventario inv ON orden.idProducto = inv.idProducto where idFactura = " + txtBuscar.Text;
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);

            dgvDetalle.DataSource = dtbl;

            query = "select  sum(precio * cantidad) as 'subtotal' from tbl_Orden  where idFactura = " + txtBuscar.Text;
            sda = new SqlDataAdapter(query, sqlcon);
            dtbl = new DataTable();
            sda.Fill(dtbl);

            lblPrecioTotal.Text = Math.Round(float.Parse(dtbl.Rows[0]["subtotal"].ToString()), 2).ToString("#,###.#0");

            //administar nueva busqueda
            txtBuscar.ReadOnly = true;
            btnBuscar.Enabled = false;
            btnNueva.Visible = true;
            }
            else
            {
                MessageBox.Show("Debe colocar un número de factura.");
            }

        }

        private void btnNueva_Click(object sender, EventArgs e)
        {
            // administrar nueva busqeuda
            btnBuscar.Enabled = true;
            btnNueva.Visible = false;
            txtBuscar.ReadOnly = false;
            txtBuscar.Text = "";
            dgvDetalle.DataSource = null;
        }
    }
}
