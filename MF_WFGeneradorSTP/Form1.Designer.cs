namespace GeneradorSTP
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dgvDatosExportar = new System.Windows.Forms.DataGridView();
            this.dtpFechaProceso = new System.Windows.Forms.DateTimePicker();
            this.lblFechaProcesada = new System.Windows.Forms.Label();
            this.btnCargarDatos = new System.Windows.Forms.Button();
            this.lblTotalRegistros = new System.Windows.Forms.Label();
            this.btnExportar = new System.Windows.Forms.Button();
            this.fbdUbicacionArchivo = new System.Windows.Forms.FolderBrowserDialog();
            this.lblUbicacion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosExportar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDatosExportar
            // 
            this.dgvDatosExportar.AllowUserToAddRows = false;
            this.dgvDatosExportar.AllowUserToDeleteRows = false;
            this.dgvDatosExportar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDatosExportar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDatosExportar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosExportar.Location = new System.Drawing.Point(24, 65);
            this.dgvDatosExportar.MultiSelect = false;
            this.dgvDatosExportar.Name = "dgvDatosExportar";
            this.dgvDatosExportar.ReadOnly = true;
            this.dgvDatosExportar.Size = new System.Drawing.Size(914, 395);
            this.dgvDatosExportar.TabIndex = 3;
            this.dgvDatosExportar.Resize += new System.EventHandler(this.Form1_Load);
            // 
            // dtpFechaProceso
            // 
            this.dtpFechaProceso.CustomFormat = "dd/MM/aaaa";
            this.dtpFechaProceso.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpFechaProceso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaProceso.Location = new System.Drawing.Point(120, 27);
            this.dtpFechaProceso.Name = "dtpFechaProceso";
            this.dtpFechaProceso.Size = new System.Drawing.Size(125, 20);
            this.dtpFechaProceso.TabIndex = 0;
            // 
            // lblFechaProcesada
            // 
            this.lblFechaProcesada.AutoSize = true;
            this.lblFechaProcesada.Location = new System.Drawing.Point(21, 31);
            this.lblFechaProcesada.Name = "lblFechaProcesada";
            this.lblFechaProcesada.Size = new System.Drawing.Size(93, 13);
            this.lblFechaProcesada.TabIndex = 1;
            this.lblFechaProcesada.Text = "Fecha a procesar:";
            // 
            // btnCargarDatos
            // 
            this.btnCargarDatos.Location = new System.Drawing.Point(326, 23);
            this.btnCargarDatos.Name = "btnCargarDatos";
            this.btnCargarDatos.Size = new System.Drawing.Size(94, 29);
            this.btnCargarDatos.TabIndex = 2;
            this.btnCargarDatos.Text = "Consultar datos";
            this.btnCargarDatos.UseVisualStyleBackColor = true;
            this.btnCargarDatos.Click += new System.EventHandler(this.btnCargarDatos_Click);
            // 
            // lblTotalRegistros
            // 
            this.lblTotalRegistros.AutoSize = true;
            this.lblTotalRegistros.Location = new System.Drawing.Point(573, 475);
            this.lblTotalRegistros.Name = "lblTotalRegistros";
            this.lblTotalRegistros.Size = new System.Drawing.Size(35, 13);
            this.lblTotalRegistros.TabIndex = 4;
            this.lblTotalRegistros.Text = "label1";
            // 
            // btnExportar
            // 
            this.btnExportar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExportar.Enabled = false;
            this.btnExportar.Location = new System.Drawing.Point(865, 466);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(73, 30);
            this.btnExportar.TabIndex = 5;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // lblUbicacion
            // 
            this.lblUbicacion.AutoSize = true;
            this.lblUbicacion.Location = new System.Drawing.Point(443, 31);
            this.lblUbicacion.Name = "lblUbicacion";
            this.lblUbicacion.Size = new System.Drawing.Size(200, 13);
            this.lblUbicacion.TabIndex = 6;
            this.lblUbicacion.Text = "Directorio a guardar el archivo generado.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 569);
            this.Controls.Add(this.lblUbicacion);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.lblTotalRegistros);
            this.Controls.Add(this.dgvDatosExportar);
            this.Controls.Add(this.btnCargarDatos);
            this.Controls.Add(this.lblFechaProcesada);
            this.Controls.Add(this.dtpFechaProceso);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosExportar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFechaProceso;
        private System.Windows.Forms.Label lblFechaProcesada;
        private System.Windows.Forms.Button btnCargarDatos;
        private System.Windows.Forms.Label lblTotalRegistros;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.FolderBrowserDialog fbdUbicacionArchivo;
        private System.Windows.Forms.Label lblUbicacion;
        private System.Windows.Forms.DataGridView dgvDatosExportar;
    }
}

