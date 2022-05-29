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
    public partial class FormVer : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=UMG-LAB\SQLEXPRESS;Initial Catalog=progra1;Integrated Security=True");
        string query;
        int stockActual;

        public FormVer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // administrar nueva busqeuda
            btnBuscar.Enabled = true;
            btnNueva.Visible = false;
            txtCodigo.ReadOnly = false;

            //administrar agregar stock
            txtAgregarExistencia.Visible = false;
            lblAgregarExistencia.Visible = false;
            btnAgregarExistencia.Visible = false;


            main main = new main();
            this.Hide();
            main.Show();
        }

        private void FormVer_Load(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=UMG-LAB\SQLEXPRESS;Initial Catalog=progra1;Integrated Security=True");
            string query = "SELECT idProducto,Nombre,precioCosto,precioVenta,stock FROM tbl_Inventario";

            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);

            DataTable dtbl = new DataTable();

            sda.Fill(dtbl);

            dgvInventario.DataSource = dtbl;
        }

        private void btbBuscar_Click(object sender, EventArgs e)
        {
            stockActual = 0;

            if (txtCodigo.Text.Length > 0 && txtCodigo.Text.Trim() != "0")
            {
                query = "SELECT idProducto,Nombre,precioCosto,precioVenta,stock FROM tbl_Inventario where idProducto = " + txtCodigo.Text.Trim();

                SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);

                DataTable dtbl = new DataTable();

                sda.Fill(dtbl);




                if (dtbl.Rows.Count > 0)
                {
                    dgvInventario.DataSource = dtbl;

                    stockActual = int.Parse(dtbl.Rows[0]["stock"].ToString());

                    //administar nueva busqueda
                    txtCodigo.ReadOnly = true;
                    btnBuscar.Enabled = false;
                    btnNueva.Visible = true;


                    //administrar agregar stock
                    txtAgregarExistencia.Visible = true;
                    lblAgregarExistencia.Visible = true;
                    btnAgregarExistencia.Visible = true;

                }
                else
                {
                  
                    query = "SELECT idProducto,Nombre,precioCosto,precioVenta,stock FROM tbl_Inventario";
                     sda = new SqlDataAdapter(query, sqlcon);

                     dtbl = new DataTable();

                    sda.Fill(dtbl);

                    dgvInventario.DataSource = dtbl;
                    MessageBox.Show("Código de producto no encontrado.");
                }


            }
            else
            {
                query = "SELECT idProducto,Nombre,precioCosto,precioVenta,stock FROM tbl_Inventario";

                SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);

                DataTable dtbl = new DataTable();

                sda.Fill(dtbl);

                dgvInventario.DataSource = dtbl;
            }

   
        }

        private void btnNueva_Click(object sender, EventArgs e)
        {
            stockActual = 0;
            // administrar nueva busqeuda
            btnBuscar.Enabled = true;
            btnNueva.Visible = false;
            txtCodigo.ReadOnly = false;

            //administrar agregar stock
            txtAgregarExistencia.Visible = false;
            lblAgregarExistencia.Visible = false;
            btnAgregarExistencia.Visible = false;

        }

        private void btnAgregarExistencia_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Length > 0 && txtCodigo.Text.Trim() != "0")
            {

                stockActual = stockActual + int.Parse(txtAgregarExistencia.Text);


                query = "UPDATE tbl_Inventario SET stock = "+ stockActual.ToString() +" WHERE idProducto = " + txtCodigo.Text.Trim();

                SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);

                sda = new SqlDataAdapter(query, sqlcon);

                DataTable dtbl = new DataTable();

                sda.Fill(dtbl);

                query = "select idProducto,Nombre,precioCosto,precioVenta,stock FROM tbl_Inventario where idProducto = " + txtCodigo.Text.Trim();

                sda = new SqlDataAdapter(query, sqlcon);

                dtbl = new DataTable();

                sda.Fill(dtbl);

                txtAgregarExistencia.Text = "";

                dgvInventario.DataSource = dtbl;
            }
            else {

            }

            }
    }
}
