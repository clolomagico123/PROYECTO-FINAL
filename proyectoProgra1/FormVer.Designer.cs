namespace proyectoProgra1
{
    partial class FormVer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVer));
            this.btnRegresar = new System.Windows.Forms.Button();
            this.dgvInventario = new System.Windows.Forms.DataGridView();
            this.INVENTARIO = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LBLpRODUCTO = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnNueva = new System.Windows.Forms.Button();
            this.lblAgregarExistencia = new System.Windows.Forms.Label();
            this.txtAgregarExistencia = new System.Windows.Forms.TextBox();
            this.btnAgregarExistencia = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(786, 13);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(122, 38);
            this.btnRegresar.TabIndex = 0;
            this.btnRegresar.Text = "MENU PRINCIPAL";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvInventario
            // 
            this.dgvInventario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInventario.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventario.Location = new System.Drawing.Point(32, 152);
            this.dgvInventario.Name = "dgvInventario";
            this.dgvInventario.ReadOnly = true;
            this.dgvInventario.Size = new System.Drawing.Size(852, 191);
            this.dgvInventario.TabIndex = 1;
            // 
            // INVENTARIO
            // 
            this.INVENTARIO.AutoSize = true;
            this.INVENTARIO.Font = new System.Drawing.Font("Palatino Linotype", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.INVENTARIO.Location = new System.Drawing.Point(346, 36);
            this.INVENTARIO.Name = "INVENTARIO";
            this.INVENTARIO.Size = new System.Drawing.Size(225, 43);
            this.INVENTARIO.TabIndex = 2;
            this.INVENTARIO.Text = "INVENTARIO";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-3, -26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // LBLpRODUCTO
            // 
            this.LBLpRODUCTO.AutoSize = true;
            this.LBLpRODUCTO.Location = new System.Drawing.Point(48, 113);
            this.LBLpRODUCTO.Name = "LBLpRODUCTO";
            this.LBLpRODUCTO.Size = new System.Drawing.Size(52, 13);
            this.LBLpRODUCTO.TabIndex = 4;
            this.LBLpRODUCTO.Text = "CODIGO:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(203, 102);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(108, 32);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btbBuscar_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(101, 109);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(96, 20);
            this.txtCodigo.TabIndex = 6;
            // 
            // btnNueva
            // 
            this.btnNueva.Location = new System.Drawing.Point(203, 102);
            this.btnNueva.Name = "btnNueva";
            this.btnNueva.Size = new System.Drawing.Size(159, 31);
            this.btnNueva.TabIndex = 7;
            this.btnNueva.Text = "Nueva busqueda";
            this.btnNueva.UseVisualStyleBackColor = true;
            this.btnNueva.Visible = false;
            this.btnNueva.Click += new System.EventHandler(this.btnNueva_Click);
            // 
            // lblAgregarExistencia
            // 
            this.lblAgregarExistencia.AutoSize = true;
            this.lblAgregarExistencia.Location = new System.Drawing.Point(597, 116);
            this.lblAgregarExistencia.Name = "lblAgregarExistencia";
            this.lblAgregarExistencia.Size = new System.Drawing.Size(94, 13);
            this.lblAgregarExistencia.TabIndex = 8;
            this.lblAgregarExistencia.Text = "Agregar existencia";
            this.lblAgregarExistencia.Visible = false;
            // 
            // txtAgregarExistencia
            // 
            this.txtAgregarExistencia.Location = new System.Drawing.Point(697, 113);
            this.txtAgregarExistencia.Name = "txtAgregarExistencia";
            this.txtAgregarExistencia.Size = new System.Drawing.Size(100, 20);
            this.txtAgregarExistencia.TabIndex = 9;
            this.txtAgregarExistencia.Visible = false;
            // 
            // btnAgregarExistencia
            // 
            this.btnAgregarExistencia.Location = new System.Drawing.Point(803, 106);
            this.btnAgregarExistencia.Name = "btnAgregarExistencia";
            this.btnAgregarExistencia.Size = new System.Drawing.Size(81, 31);
            this.btnAgregarExistencia.TabIndex = 10;
            this.btnAgregarExistencia.Text = "Agregar";
            this.btnAgregarExistencia.UseVisualStyleBackColor = true;
            this.btnAgregarExistencia.Visible = false;
            this.btnAgregarExistencia.Click += new System.EventHandler(this.btnAgregarExistencia_Click);
            // 
            // FormVer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 371);
            this.ControlBox = false;
            this.Controls.Add(this.btnAgregarExistencia);
            this.Controls.Add(this.txtAgregarExistencia);
            this.Controls.Add(this.lblAgregarExistencia);
            this.Controls.Add(this.btnNueva);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.LBLpRODUCTO);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.INVENTARIO);
            this.Controls.Add(this.dgvInventario);
            this.Controls.Add(this.btnRegresar);
            this.Name = "FormVer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VER INVENTARIO";
            this.Load += new System.EventHandler(this.FormVer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.DataGridView dgvInventario;
        private System.Windows.Forms.Label INVENTARIO;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LBLpRODUCTO;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnNueva;
        private System.Windows.Forms.Label lblAgregarExistencia;
        private System.Windows.Forms.TextBox txtAgregarExistencia;
        private System.Windows.Forms.Button btnAgregarExistencia;
    }
}