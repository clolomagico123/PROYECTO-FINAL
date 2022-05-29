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
    public partial class FormAgregarProducto : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=UMG-LAB\SQLEXPRESS;Initial Catalog=progra1;Integrated Security=True");

        public FormAgregarProducto()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            main main = new main();
            this.Hide();
            main.Show();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            string query = "INSERT INTO tbl_Inventario(idProducto,Nombre,precioCosto, precioVenta, stock, bloqueado) VALUES('"+txtCod.Text+ "','" + txtNombre.Text + "','" + txtPrecioCosto.Text + "','" + txtPrecioVenta.Text + "','" + txtStock.Text + "','0')";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);

            DataTable dtbl = new DataTable();

            sda.Fill(dtbl);

            MessageBox.Show("Producto agregado Satisfactoriamente.");
            txtCod.Text = "";
            txtNombre.Text = "";
            txtPrecioCosto.Text = "";
            txtPrecioVenta.Text = "";
            txtStock.Text = "";
        }
    }
}
