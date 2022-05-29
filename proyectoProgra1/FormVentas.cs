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
    public partial class FormVentas : Form
    {

        SqlConnection sqlcon = new SqlConnection(@"Data Source=UMG-LAB\SQLEXPRESS;Initial Catalog=progra1;Integrated Security=True");
        string query;
        DataTable dtbl;
        string total; 

        private DataTable dt;

        public FormVentas()
        {
            InitializeComponent();
            total = "0.00";
            lblPrecioTotal.Text = total.Trim();
            dt = new DataTable();
            dt.Columns.Add("idProducto");
            dt.Columns.Add("Nombre");
            dt.Columns.Add("Precio");
            dt.Columns.Add("Cantidad");
            dt.Columns.Add("subtotal");

            dgvFactura.DataSource = dt;


        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {

            //verificar que no quede producto bloqueado sin facturar
            if(dt != null) { 
            for (int i = 0; i < dt.Rows.Count; i++)
            {

                //ingresar la orden
                //actualizar stock
                query = "UPDATE tbl_Inventario SET bloqueado = bloqueado - " + dt.Rows[i]["cantidad"].ToString() + " WHERE idProducto = " + dt.Rows[i]["idProducto"].ToString();
                SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
                sda = new SqlDataAdapter(query, sqlcon);
                DataTable dtbl1 = new DataTable();
                sda.Fill(dtbl1);

            }
            }
            //limpiar todo el espacio
            dgvFactura.DataSource = null;
            //limpiar buscador
            txtCodigo.ReadOnly = false;
            btnBuscar.Enabled = true;

            btnAgregar.Visible = false;
            btnCancelar.Visible = false;
            txtCantidad.Visible = false;
            txtCantidad.Text = "";
            lblCantidad.Visible = false;
            dgvInventario.DataSource = null;
            lblPrecioTotal.Text = "0.00";
            txtCliente.Text = "";
            txtNIT.Text = "";

            main main = new main();
            this.Hide();
            main.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Length > 0 && txtCodigo.Text.Trim() != "0")
            {
                query = "select idProducto, Nombre, stock - bloqueado as stock, PrecioVenta as Precio from tbl_Inventario where idProducto = " + txtCodigo.Text.Trim();

                SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);

                 dtbl = new DataTable();

                sda.Fill(dtbl);




                if (dtbl.Rows.Count > 0)
                {
                    dgvInventario.DataSource = dtbl;
                  
                    //administar nueva busqueda
                    txtCodigo.ReadOnly = true;
                    btnBuscar.Enabled = false;

                    btnAgregar.Visible = true;
                    btnCancelar.Visible = true;
                    txtCantidad.Visible = true;
                    lblCantidad.Visible = true;


                }
                else
                {

                    //administar nueva busqueda
                    txtCodigo.ReadOnly = false;
                    btnBuscar.Enabled = true;

                    btnAgregar.Visible = false;
                    btnCancelar.Visible = false;
                    txtCantidad.Visible = false;
                    lblCantidad.Visible = false;
                    dgvInventario.DataSource = null;
                    MessageBox.Show("Código de producto no encontrado.");
                }


            }
            else
            {
                //administar nueva busqueda
                txtCodigo.ReadOnly = false;
                btnBuscar.Enabled = true;

                btnAgregar.Visible = false;
                btnCancelar.Visible = false;
                txtCantidad.Visible = false;
                lblCantidad.Visible = false;
                dgvInventario.DataSource = null;

                MessageBox.Show("Error al leer el código.");

            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //administar nueva busqueda
            txtCodigo.ReadOnly = false;
            btnBuscar.Enabled = true;

            btnAgregar.Visible = false;
            btnCancelar.Visible = false;
            txtCantidad.Visible = false;
            lblCantidad.Visible = false;
            dgvInventario.DataSource = null;

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if (float.Parse(dtbl.Rows[0]["stock"].ToString()) < float.Parse(txtCantidad.Text.Trim()))
            {
                MessageBox.Show("No se cuenta con todo el producto solicitado.");


            }
            else if (txtCantidad.Text.Length > 0 && float.Parse(txtCantidad.Text.Trim()) > 0)
            {
                //agregar al detalle de la factura
                DataRow row = dt.NewRow();

                row["idProducto"] = dtbl.Rows[0]["idProducto"].ToString();
                row["Nombre"] = dtbl.Rows[0]["Nombre"].ToString();
                row["Precio"] = dtbl.Rows[0]["Precio"].ToString();
                row["Cantidad"] = txtCantidad.Text.Trim();
                row["subtotal"] = Math.Round(float.Parse(dtbl.Rows[0]["Precio"].ToString()) * float.Parse(txtCantidad.Text.Trim()), 2).ToString("#,###.#0");

                dt.Rows.Add(row);

                //total acumulado

                total =  Math.Round(float.Parse(total) + float.Parse(dtbl.Rows[0]["Precio"].ToString()) * float.Parse(txtCantidad.Text.Trim()), 2).ToString("#,###.#0");
                lblPrecioTotal.Text = total.Trim();


                //bloquear producto solicitado.
                query = "UPDATE tbl_Inventario SET bloqueado = bloqueado + " + txtCantidad.Text.Trim() + " WHERE idProducto = " + txtCodigo.Text.Trim();
                SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
                sda = new SqlDataAdapter(query, sqlcon);
                DataTable dtbl1 = new DataTable();
                sda.Fill(dtbl1);



                //limpiar buscador
                txtCodigo.ReadOnly = false;
                btnBuscar.Enabled = true;

                btnAgregar.Visible = false;
                btnCancelar.Visible = false;
                txtCantidad.Visible = false;
                txtCantidad.Text = "";
                lblCantidad.Visible = false;
                dgvInventario.DataSource = null;
            }
            else
            {
                MessageBox.Show("La cantidad ingreseda no es valida.");


            }

        }

        private void btfFacturar_Click(object sender, EventArgs e)
        {

            if (dt.Rows.Count > 0 && txtCliente.TextLength > 0)
            {
                //cuantas facturas hay

                query = "select count(*)+1 as facturas from tbl_cliente";

                SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
                sda = new SqlDataAdapter(query, sqlcon);
                DataTable dtbl1 = new DataTable();
                sda.Fill(dtbl1);

                string noFactura = dtbl1.Rows[0]["facturas"].ToString();
                //guardar datos del cliente
                query = "INSERT INTO tbl_cliente (idFactura, Cliente, NIT) VALUES ('"+ noFactura +"','"+txtCliente.Text+"','"+ txtNIT.Text+ "')";
                
                 sda = new SqlDataAdapter(query, sqlcon);
                sda = new SqlDataAdapter(query, sqlcon);
                 dtbl1 = new DataTable();
                sda.Fill(dtbl1);


                
                //pasar todos los productos agregados
                for (int i = 0; i < dt.Rows.Count; i++)
                {

                    //ingresar la orden
                    query = "INSERT INTO tbl_Orden( idFactura, idProducto,cantidad,precio) VALUES ('" + noFactura + "','" + dt.Rows[i]["idProducto"].ToString() + "','" + dt.Rows[i]["cantidad"].ToString() + "','" + dt.Rows[i]["precio"].ToString() + "')";

                    sda = new SqlDataAdapter(query, sqlcon);
                    sda = new SqlDataAdapter(query, sqlcon);
                    dtbl1 = new DataTable();
                    sda.Fill(dtbl1);

                    //actualizar stock
                    query = "UPDATE tbl_Inventario SET stock = stock - " + dt.Rows[i]["cantidad"].ToString() + ", bloqueado = bloqueado - " + dt.Rows[i]["cantidad"].ToString() + " WHERE idProducto = " + dt.Rows[i]["idProducto"].ToString();
                    sda = new SqlDataAdapter(query, sqlcon);
                    sda = new SqlDataAdapter(query, sqlcon);
                    dtbl1 = new DataTable();
                    sda.Fill(dtbl1);

                }



                MessageBox.Show("Venta Exitosa.");

                //limpiar todo el espacio
                dgvFactura.DataSource = null;
                //limpiar buscador
                txtCodigo.ReadOnly = false;
                btnBuscar.Enabled = true;
                dt = new DataTable();
                dt.Columns.Add("idProducto");
                dt.Columns.Add("Nombre");
                dt.Columns.Add("Precio");
                dt.Columns.Add("Cantidad");
                dt.Columns.Add("subtotal");
                dgvFactura.DataSource = dt;
                btnAgregar.Visible = false;
                btnCancelar.Visible = false;
                txtCantidad.Visible = false;
                txtCantidad.Text = "";
                lblCantidad.Visible = false;
                dgvInventario.DataSource = null;
                lblPrecioTotal.Text = "0.00";
                txtCliente.Text = "";
                txtNIT.Text = "";


            }
            else
            {
                MessageBox.Show("No es posible facturar, debido que faltan datos de facturación.");
            }
        }

        private void FormVentas_Load(object sender, EventArgs e)
        {

        }
    }
}
