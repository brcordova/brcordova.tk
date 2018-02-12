namespace MF_PruebasSPEI
{
    partial class frmCargarXML
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
            this.fbdUbicacionArchivo = new System.Windows.Forms.FolderBrowserDialog();
            this.btnCargarDatos = new System.Windows.Forms.Button();
            this.lblEnviaAbono = new System.Windows.Forms.Label();
            this.dialogoBuscarArchivo = new System.Windows.Forms.OpenFileDialog();
            this.lblEnviaAbonoResultado = new System.Windows.Forms.Label();
            this.rbWSWAN = new System.Windows.Forms.RadioButton();
            this.rbWSLocal = new System.Windows.Forms.RadioButton();
            this.btnAplicarOrden = new System.Windows.Forms.Button();
            this.lblAplicaAbono = new System.Windows.Forms.Label();
            this.rbMetodo = new System.Windows.Forms.RadioButton();
            this.gbWebServices = new System.Windows.Forms.GroupBox();
            this.rbWSLAN = new System.Windows.Forms.RadioButton();
            this.lblAplicaAbonoResultado = new System.Windows.Forms.Label();
            this.sfdDescarga = new System.Windows.Forms.SaveFileDialog();
            this.lblCambiaEstado = new System.Windows.Forms.Label();
            this.btnCambioEdo = new System.Windows.Forms.Button();
            this.lblCambiaEstadoResultado = new System.Windows.Forms.Label();
            this.lblCargaBanco = new System.Windows.Forms.Label();
            this.btnCargaBanco = new System.Windows.Forms.Button();
            this.lblCargaBancoResultado = new System.Windows.Forms.Label();
            this.lblEnviaPagos = new System.Windows.Forms.Label();
            this.btnEnviaPagos = new System.Windows.Forms.Button();
            this.lblEnviaPagosResultado = new System.Windows.Forms.Label();
            this.gbWebServices.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCargarDatos
            // 
            this.btnCargarDatos.Location = new System.Drawing.Point(245, 12);
            this.btnCargarDatos.Name = "btnCargarDatos";
            this.btnCargarDatos.Size = new System.Drawing.Size(75, 23);
            this.btnCargarDatos.TabIndex = 0;
            this.btnCargarDatos.Text = "Carga XML";
            this.btnCargarDatos.UseVisualStyleBackColor = true;
            this.btnCargarDatos.Click += new System.EventHandler(this.btnCargarDatos_Click);
            // 
            // lblEnviaAbono
            // 
            this.lblEnviaAbono.AutoSize = true;
            this.lblEnviaAbono.Location = new System.Drawing.Point(143, 17);
            this.lblEnviaAbono.Name = "lblEnviaAbono";
            this.lblEnviaAbono.Size = new System.Drawing.Size(69, 13);
            this.lblEnviaAbono.TabIndex = 1;
            this.lblEnviaAbono.Text = "Envía abono";
            // 
            // lblEnviaAbonoResultado
            // 
            this.lblEnviaAbonoResultado.AutoSize = true;
            this.lblEnviaAbonoResultado.Location = new System.Drawing.Point(326, 17);
            this.lblEnviaAbonoResultado.Name = "lblEnviaAbonoResultado";
            this.lblEnviaAbonoResultado.Size = new System.Drawing.Size(99, 13);
            this.lblEnviaAbonoResultado.TabIndex = 2;
            this.lblEnviaAbonoResultado.Text = "Proceso de archivo";
            // 
            // rbWSWAN
            // 
            this.rbWSWAN.AutoSize = true;
            this.rbWSWAN.Location = new System.Drawing.Point(6, 92);
            this.rbWSWAN.Name = "rbWSWAN";
            this.rbWSWAN.Size = new System.Drawing.Size(103, 17);
            this.rbWSWAN.TabIndex = 4;
            this.rbWSWAN.TabStop = true;
            this.rbWSWAN.Tag = "4";
            this.rbWSWAN.Text = "WS Servidor Ext";
            this.rbWSWAN.UseVisualStyleBackColor = true;
            // 
            // rbWSLocal
            // 
            this.rbWSLocal.AutoSize = true;
            this.rbWSLocal.Location = new System.Drawing.Point(6, 46);
            this.rbWSLocal.Name = "rbWSLocal";
            this.rbWSLocal.Size = new System.Drawing.Size(72, 17);
            this.rbWSLocal.TabIndex = 5;
            this.rbWSLocal.TabStop = true;
            this.rbWSLocal.Tag = "2";
            this.rbWSLocal.Text = "WS Local";
            this.rbWSLocal.UseVisualStyleBackColor = true;
            // 
            // btnAplicarOrden
            // 
            this.btnAplicarOrden.Location = new System.Drawing.Point(245, 55);
            this.btnAplicarOrden.Name = "btnAplicarOrden";
            this.btnAplicarOrden.Size = new System.Drawing.Size(75, 23);
            this.btnAplicarOrden.TabIndex = 6;
            this.btnAplicarOrden.Text = "Aplicar Orden";
            this.btnAplicarOrden.UseVisualStyleBackColor = true;
            this.btnAplicarOrden.Click += new System.EventHandler(this.btnAplicarOrden_Click);
            // 
            // lblAplicaAbono
            // 
            this.lblAplicaAbono.AutoSize = true;
            this.lblAplicaAbono.Location = new System.Drawing.Point(143, 60);
            this.lblAplicaAbono.Name = "lblAplicaAbono";
            this.lblAplicaAbono.Size = new System.Drawing.Size(72, 13);
            this.lblAplicaAbono.TabIndex = 7;
            this.lblAplicaAbono.Text = "Aplicar abono";
            // 
            // rbMetodo
            // 
            this.rbMetodo.AutoSize = true;
            this.rbMetodo.Location = new System.Drawing.Point(6, 23);
            this.rbMetodo.Name = "rbMetodo";
            this.rbMetodo.Size = new System.Drawing.Size(90, 17);
            this.rbMetodo.TabIndex = 8;
            this.rbMetodo.TabStop = true;
            this.rbMetodo.Tag = "1";
            this.rbMetodo.Text = "Método Local";
            this.rbMetodo.UseVisualStyleBackColor = true;
            // 
            // gbWebServices
            // 
            this.gbWebServices.Controls.Add(this.rbWSLAN);
            this.gbWebServices.Controls.Add(this.rbMetodo);
            this.gbWebServices.Controls.Add(this.rbWSWAN);
            this.gbWebServices.Controls.Add(this.rbWSLocal);
            this.gbWebServices.Location = new System.Drawing.Point(12, 12);
            this.gbWebServices.Name = "gbWebServices";
            this.gbWebServices.Size = new System.Drawing.Size(112, 118);
            this.gbWebServices.TabIndex = 11;
            this.gbWebServices.TabStop = false;
            this.gbWebServices.Text = "Webservice";
            // 
            // rbWSLAN
            // 
            this.rbWSLAN.AutoSize = true;
            this.rbWSLAN.Location = new System.Drawing.Point(6, 69);
            this.rbWSLAN.Name = "rbWSLAN";
            this.rbWSLAN.Size = new System.Drawing.Size(100, 17);
            this.rbWSLAN.TabIndex = 9;
            this.rbWSLAN.TabStop = true;
            this.rbWSLAN.Tag = "3";
            this.rbWSLAN.Text = "WS Servidor Int";
            this.rbWSLAN.UseVisualStyleBackColor = true;
            // 
            // lblAplicaAbonoResultado
            // 
            this.lblAplicaAbonoResultado.AutoSize = true;
            this.lblAplicaAbonoResultado.Location = new System.Drawing.Point(326, 58);
            this.lblAplicaAbonoResultado.Name = "lblAplicaAbonoResultado";
            this.lblAplicaAbonoResultado.Size = new System.Drawing.Size(99, 13);
            this.lblAplicaAbonoResultado.TabIndex = 2;
            this.lblAplicaAbonoResultado.Text = "Proceso de archivo";
            // 
            // lblCambiaEstado
            // 
            this.lblCambiaEstado.AutoSize = true;
            this.lblCambiaEstado.Location = new System.Drawing.Point(143, 106);
            this.lblCambiaEstado.Name = "lblCambiaEstado";
            this.lblCambiaEstado.Size = new System.Drawing.Size(95, 13);
            this.lblCambiaEstado.TabIndex = 14;
            this.lblCambiaEstado.Text = "Cambiar de estado";
            // 
            // btnCambioEdo
            // 
            this.btnCambioEdo.Location = new System.Drawing.Point(245, 98);
            this.btnCambioEdo.Name = "btnCambioEdo";
            this.btnCambioEdo.Size = new System.Drawing.Size(75, 23);
            this.btnCambioEdo.TabIndex = 13;
            this.btnCambioEdo.Text = "Carga XML";
            this.btnCambioEdo.UseVisualStyleBackColor = true;
            this.btnCambioEdo.Click += new System.EventHandler(this.btnCambioEdo_Click);
            // 
            // lblCambiaEstadoResultado
            // 
            this.lblCambiaEstadoResultado.AutoSize = true;
            this.lblCambiaEstadoResultado.Location = new System.Drawing.Point(326, 104);
            this.lblCambiaEstadoResultado.Name = "lblCambiaEstadoResultado";
            this.lblCambiaEstadoResultado.Size = new System.Drawing.Size(99, 13);
            this.lblCambiaEstadoResultado.TabIndex = 12;
            this.lblCambiaEstadoResultado.Text = "Proceso de archivo";
            // 
            // lblCargaBanco
            // 
            this.lblCargaBanco.AutoSize = true;
            this.lblCargaBanco.Location = new System.Drawing.Point(143, 152);
            this.lblCargaBanco.Name = "lblCargaBanco";
            this.lblCargaBanco.Size = new System.Drawing.Size(73, 13);
            this.lblCargaBanco.TabIndex = 17;
            this.lblCargaBanco.Text = "Carga bancos";
            // 
            // btnCargaBanco
            // 
            this.btnCargaBanco.Location = new System.Drawing.Point(245, 141);
            this.btnCargaBanco.Name = "btnCargaBanco";
            this.btnCargaBanco.Size = new System.Drawing.Size(75, 23);
            this.btnCargaBanco.TabIndex = 16;
            this.btnCargaBanco.Text = "Carga XML";
            this.btnCargaBanco.UseVisualStyleBackColor = true;
            this.btnCargaBanco.Click += new System.EventHandler(this.btnCargaBanco_Click);
            // 
            // lblCargaBancoResultado
            // 
            this.lblCargaBancoResultado.AutoSize = true;
            this.lblCargaBancoResultado.Location = new System.Drawing.Point(326, 151);
            this.lblCargaBancoResultado.Name = "lblCargaBancoResultado";
            this.lblCargaBancoResultado.Size = new System.Drawing.Size(99, 13);
            this.lblCargaBancoResultado.TabIndex = 15;
            this.lblCargaBancoResultado.Text = "Proceso de archivo";
            // 
            // lblEnviaPagos
            // 
            this.lblEnviaPagos.AutoSize = true;
            this.lblEnviaPagos.Location = new System.Drawing.Point(143, 189);
            this.lblEnviaPagos.Name = "lblEnviaPagos";
            this.lblEnviaPagos.Size = new System.Drawing.Size(68, 13);
            this.lblEnviaPagos.TabIndex = 20;
            this.lblEnviaPagos.Text = "Envía pagos";
            // 
            // btnEnviaPagos
            // 
            this.btnEnviaPagos.Location = new System.Drawing.Point(245, 184);
            this.btnEnviaPagos.Name = "btnEnviaPagos";
            this.btnEnviaPagos.Size = new System.Drawing.Size(75, 23);
            this.btnEnviaPagos.TabIndex = 19;
            this.btnEnviaPagos.Text = "Envia pago";
            this.btnEnviaPagos.UseVisualStyleBackColor = true;
            this.btnEnviaPagos.Click += new System.EventHandler(this.btnEnviaPagos_Click);
            // 
            // lblEnviaPagosResultado
            // 
            this.lblEnviaPagosResultado.AutoSize = true;
            this.lblEnviaPagosResultado.Location = new System.Drawing.Point(326, 189);
            this.lblEnviaPagosResultado.Name = "lblEnviaPagosResultado";
            this.lblEnviaPagosResultado.Size = new System.Drawing.Size(97, 13);
            this.lblEnviaPagosResultado.TabIndex = 18;
            this.lblEnviaPagosResultado.Text = "Proceso por iniciar.";
            // 
            // frmCargarXML
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 262);
            this.Controls.Add(this.lblEnviaPagos);
            this.Controls.Add(this.btnEnviaPagos);
            this.Controls.Add(this.lblEnviaPagosResultado);
            this.Controls.Add(this.lblCargaBanco);
            this.Controls.Add(this.btnCargaBanco);
            this.Controls.Add(this.lblCargaBancoResultado);
            this.Controls.Add(this.lblCambiaEstado);
            this.Controls.Add(this.btnCambioEdo);
            this.Controls.Add(this.lblCambiaEstadoResultado);
            this.Controls.Add(this.gbWebServices);
            this.Controls.Add(this.lblAplicaAbono);
            this.Controls.Add(this.btnAplicarOrden);
            this.Controls.Add(this.lblAplicaAbonoResultado);
            this.Controls.Add(this.lblEnviaAbonoResultado);
            this.Controls.Add(this.lblEnviaAbono);
            this.Controls.Add(this.btnCargarDatos);
            this.Name = "frmCargarXML";
            this.Text = "Form1";
            this.gbWebServices.ResumeLayout(false);
            this.gbWebServices.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog fbdUbicacionArchivo;
        private System.Windows.Forms.Button btnCargarDatos;
        private System.Windows.Forms.Label lblEnviaAbono;
        private System.Windows.Forms.OpenFileDialog dialogoBuscarArchivo;
        private System.Windows.Forms.Label lblEnviaAbonoResultado;
        private System.Windows.Forms.RadioButton rbWSWAN;
        private System.Windows.Forms.RadioButton rbWSLocal;
        private System.Windows.Forms.Button btnAplicarOrden;
        private System.Windows.Forms.Label lblAplicaAbono;
        private System.Windows.Forms.RadioButton rbMetodo;
        private System.Windows.Forms.GroupBox gbWebServices;
        private System.Windows.Forms.RadioButton rbWSLAN;
        private System.Windows.Forms.SaveFileDialog sfdDescarga;
        private System.Windows.Forms.Label lblCambiaEstado;
        private System.Windows.Forms.Button btnCambioEdo;
        protected internal System.Windows.Forms.Label lblCambiaEstadoResultado;
        private System.Windows.Forms.Label lblCargaBanco;
        private System.Windows.Forms.Button btnCargaBanco;
        protected internal System.Windows.Forms.Label lblCargaBancoResultado;
        private System.Windows.Forms.Label lblAplicaAbonoResultado;
        private System.Windows.Forms.Label lblEnviaPagos;
        private System.Windows.Forms.Button btnEnviaPagos;
        protected internal System.Windows.Forms.Label lblEnviaPagosResultado;

    }
}

