namespace proyectoProgra1
{
    partial class FormVentas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVentas));
            this.btnRegresar = new System.Windows.Forms.Button();
            this.VENTA = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.LBLpRODUCTO = new System.Windows.Forms.Label();
            this.dgvInventario = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.dgvFactura = new System.Windows.Forms.DataGridView();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblNIT = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblPrecioTotal = new System.Windows.Forms.Label();
            this.btfFacturar = new System.Windows.Forms.Button();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtNIT = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.Crimson;
            this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegresar.Location = new System.Drawing.Point(685, 12);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(102, 62);
            this.btnRegresar.TabIndex = 1;
            this.btnRegresar.Text = "Cancelar venta";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // VENTA
            // 
            this.VENTA.AutoSize = true;
            this.VENTA.Font = new System.Drawing.Font("Palatino Linotype", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VENTA.Location = new System.Drawing.Point(327, 43);
            this.VENTA.Name = "VENTA";
            this.VENTA.Size = new System.Drawing.Size(144, 43);
            this.VENTA.TabIndex = 3;
            this.VENTA.Text = "VENTAS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-7, -31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(64, 97);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(96, 20);
            this.txtCodigo.TabIndex = 9;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(166, 90);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(108, 32);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // LBLpRODUCTO
            // 
            this.LBLpRODUCTO.AutoSize = true;
            this.LBLpRODUCTO.Location = new System.Drawing.Point(11, 101);
            this.LBLpRODUCTO.Name = "LBLpRODUCTO";
            this.LBLpRODUCTO.Size = new System.Drawing.Size(52, 13);
            this.LBLpRODUCTO.TabIndex = 7;
            this.LBLpRODUCTO.Text = "CODIGO:";
            // 
            // dgvInventario
            // 
            this.dgvInventario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInventario.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventario.Location = new System.Drawing.Point(12, 128);
            this.dgvInventario.Name = "dgvInventario";
            this.dgvInventario.ReadOnly = true;
            this.dgvInventario.Size = new System.Drawing.Size(795, 67);
            this.dgvInventario.TabIndex = 10;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Green;
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregar.Location = new System.Drawing.Point(227, 204);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(101, 31);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Visible = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.DarkRed;
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelar.Location = new System.Drawing.Point(334, 204);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(101, 31);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(18, 214);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(49, 13);
            this.lblCantidad.TabIndex = 13;
            this.lblCantidad.Text = "Cantidad";
            this.lblCantidad.Visible = false;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(69, 210);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(152, 20);
            this.txtCantidad.TabIndex = 14;
            this.txtCantidad.Visible = false;
            // 
            // dgvFactura
            // 
            this.dgvFactura.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFactura.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFactura.Location = new System.Drawing.Point(14, 297);
            this.dgvFactura.Name = "dgvFactura";
            this.dgvFactura.ReadOnly = true;
            this.dgvFactura.Size = new System.Drawing.Size(795, 157);
            this.dgvFactura.TabIndex = 15;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(18, 269);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(82, 13);
            this.lblCliente.TabIndex = 16;
            this.lblCliente.Text = "Nombre Cliente:";
            // 
            // lblNIT
            // 
            this.lblNIT.AutoSize = true;
            this.lblNIT.Location = new System.Drawing.Point(518, 269);
            this.lblNIT.Name = "lblNIT";
            this.lblNIT.Size = new System.Drawing.Size(28, 13);
            this.lblNIT.TabIndex = 17;
            this.lblNIT.Text = "NIT:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(390, 472);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(45, 21);
            this.lblTotal.TabIndex = 18;
            this.lblTotal.Text = "total";
            // 
            // lblPrecioTotal
            // 
            this.lblPrecioTotal.AutoSize = true;
            this.lblPrecioTotal.Font = new System.Drawing.Font("Palatino Linotype", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioTotal.Location = new System.Drawing.Point(379, 493);
            this.lblPrecioTotal.Name = "lblPrecioTotal";
            this.lblPrecioTotal.Size = new System.Drawing.Size(75, 43);
            this.lblPrecioTotal.TabIndex = 19;
            this.lblPrecioTotal.Text = "0.00";
            this.lblPrecioTotal.Click += new System.EventHandler(this.label4_Click);
            // 
            // btfFacturar
            // 
            this.btfFacturar.BackColor = System.Drawing.Color.Green;
            this.btfFacturar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btfFacturar.Location = new System.Drawing.Point(511, 480);
            this.btfFacturar.Name = "btfFacturar";
            this.btfFacturar.Size = new System.Drawing.Size(133, 56);
            this.btfFacturar.TabIndex = 20;
            this.btfFacturar.Text = "FACTURAR";
            this.btfFacturar.UseVisualStyleBackColor = false;
            this.btfFacturar.Click += new System.EventHandler(this.btfFacturar_Click);
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(103, 267);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(390, 20);
            this.txtCliente.TabIndex = 21;
            // 
            // txtNIT
            // 
            this.txtNIT.Location = new System.Drawing.Point(550, 267);
            this.txtNIT.Name = "txtNIT";
            this.txtNIT.Size = new System.Drawing.Size(256, 20);
            this.txtNIT.TabIndex = 22;
            // 
            // FormVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 556);
            this.ControlBox = false;
            this.Controls.Add(this.txtNIT);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.btfFacturar);
            this.Controls.Add(this.lblPrecioTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblNIT);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.dgvFactura);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvInventario);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.LBLpRODUCTO);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.VENTA);
            this.Controls.Add(this.btnRegresar);
            this.Name = "FormVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VENTAS";
            this.Load += new System.EventHandler(this.FormVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Label VENTA;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label LBLpRODUCTO;
        private System.Windows.Forms.DataGridView dgvInventario;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.DataGridView dgvFactura;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblNIT;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblPrecioTotal;
        private System.Windows.Forms.Button btfFacturar;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.TextBox txtNIT;
    }
}