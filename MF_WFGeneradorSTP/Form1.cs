using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;
using System.Diagnostics;
using MF_SrvSTP;

namespace GeneradorSTP
{
    public partial class Form1 : Form
    {
        string verificacion = "0";
        string[] LineasIgnorar = ("0,2,3,16").Split(','); //Para generar Archivo TXT
        string[] LineasOcultar = ("Tipo_Pago,Tipo_Cuenta_Beneficiario,Concepto_Pago,Institucion_Operante,Empresa").Split(','); //Para mostrar en el GRID
        string[] ColumnasTamaño = ("Institucion_Contraparte,Referencia_Numerica").Split(','); //Para modificar tamañao de columnas en especifico
        private static string conStr = ConfigurationManager.ConnectionStrings["SIIFMF01"].ConnectionString;
        #region Formulario
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtpFechaProceso.Format = DateTimePickerFormat.Short;
            //dtpFechaProceso.Enabled = false; //Descomentar para que no se pueda modificar el campo de fecha JORGE
            lblUbicacion.Visible = false;
            lblTotalRegistros.Visible = false;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            dgvDatosExportar.Width = (this.Size.Width) - 50;
            dgvDatosExportar.Height = (this.Size.Height) - 220;
            btnExportar.Location = new Point(this.Size.Width - 100, this.Size.Height - 150);
            lblTotalRegistros.Visible = true;
            lblTotalRegistros.Location = new Point(this.Size.Width - 250, this.Size.Height - 140);
        }

        #endregion

        #region Eventos
        private void btnCargarDatos_Click(object sender, EventArgs e)
        {
            lblTotalRegistros.Visible = true;
            //dgvDatosExportar.AutoGenerateColumns = true;


            string fechaInicio = this.dtpFechaProceso.Value.Month + "/" +
                this.dtpFechaProceso.Value.Day + "/" +
                this.dtpFechaProceso.Value.Year;
            string fechaSegunda = fechaInicio;
            string FechaServidor = this.dtpFechaProceso.Value.Day + "/" + this.dtpFechaProceso.Value.Month + "/" + this.dtpFechaProceso.Value.Year;

            try
            {
                using (SqlConnection conn = new SqlConnection(conStr))
                {
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();

                    VerifiacionCierreTesoreria(FechaServidor, conStr);
                    //VerificarHora(); //Descomentar para que que muestre verificacion de la hora JORGE
                    #region Si ya se realizo el cierre de tesoreria
                    if (verificacion != "0")
                    {

                        dgvDatosExportar.DataSource = null;
                        lblTotalRegistros.Text = "Total de registros: 0";
                        MessageBox.Show("El cierre de tesorería ya se realizó, no se puede realizar la operación", "Sistema de Tesorería", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        conn.Close();
                        return;
                    }
                    #endregion


                    #region Cargamos los datos pagos a realizar.
                    DataTable dt = new DataTable();
                    SqlCommand comm = new SqlCommand("[dbo].[sp_C_ObtienePagos]", conn);
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.Parameters.Add("@fechaInicio", SqlDbType.NVarChar);
                    comm.Parameters["@fechaInicio"].Value = fechaInicio;
                    comm.Parameters.Add("@fechaSegunda", SqlDbType.NVarChar);
                    comm.Parameters["@fechaSegunda"].Value = fechaSegunda;
                    SqlDataAdapter sda = new SqlDataAdapter(comm);
                    sda.Fill(dt);
                    #endregion

                    // Aqui se hace una lectura de los registros para verificar 
                    VerificaCuentaAutorizada(dt);

                    int total = dt.Rows.Count;
                    dgvDatosExportar.DataSource = dt; //cmd.ExecuteNonQuery();

                    dgvDatosExportar.AutoGenerateColumns = false;
                    dgvDatosExportar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                    for (int i = 0; i < LineasOcultar.Length; i++)
                    {
                        dgvDatosExportar.Columns["" + LineasOcultar[i] + ""].Visible = false;
                    }

                    for (int j = 0; j < ColumnasTamaño.Length; j++)
                    {
                        dgvDatosExportar.Columns["" + ColumnasTamaño[j] + ""].Width = 75;
                    }

                    lblTotalRegistros.Text = "Total de registros: " + total.ToString();
                    if (total > 0) btnExportar.Enabled = true;
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de sistema!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            lblUbicacion.Visible = true;
            if (fbdUbicacionArchivo.ShowDialog() == DialogResult.OK)
            {
                lblUbicacion.Text = fbdUbicacionArchivo.SelectedPath;

                string linea = "";
                string encabezado = "INSTITUCION_CONTRAPARTE" + "\t" + "CLAVE_RASTREO" + "\t" + "NOMBRE_BENEFICIARIO" + "\t" +
                    "RFC_CURP_BENEFICIARIO" + "\t" + "TIPO_PAGO" + "\t" + "TIPO_CUENTA_BENEFICIARIO" + "\t" + "MONTO" + "\t" +
                    "CUENTA_BENEFICIARIO" + "\t" + "CONCEPTO_PAGO" + "\t" + "REFERENCIA_NUMERICA" + "\t" + "EMAIL_BENEFICIARIO" + "\t" +
                    "INSTITUCION_OPERANTE" + "\t" + "EMPRESA";

                string nombreArchivo = "MF_Pagos_" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".txt";
                string archivo = lblUbicacion.Text + "\\" + nombreArchivo;

                //TextWriter writer = new StreamWriter(@"C:\Users\brostos\Documents\BROC\Proyectos\SPEI\Layout\GeneradorSTP.txt");
                TextWriter writer = new StreamWriter(archivo);
                writer.Write(encabezado);
                writer.WriteLine("");

                for (int rows = 0; rows < dgvDatosExportar.Rows.Count; rows++)
                {
                    for (int cols = 0; cols < dgvDatosExportar.Columns.Count; cols++)
                    {

                        var Resultado = from lineas in LineasIgnorar
                                        where Convert.ToInt32(lineas) == cols
                                        select lineas;

                        if (Resultado.Count() == 0)
                        {
                            linea = linea + dgvDatosExportar.Rows[rows].Cells[cols].Value.ToString() + "\t";
                            //writer.Write("\t" + linea + dgvDatosExportar.Rows[rows].Cells[cols].Value.ToString() + "\t" + "|");
                        }

                    }
                    linea = linea.Substring(0, linea.Length - 1);
                    writer.Write(linea);
                    // Agrego la línea al archivo de texto.
                    linea = "";
                    writer.WriteLine("");
                }

                writer.Close();
                Process.Start(lblUbicacion.Text);
            }
        }

        #endregion

        #region Métodos y funciones

        private void VerifiacionCierreTesoreria(string Fecha, string conexion)
        {
            using (SqlConnection conn1 = new SqlConnection(conexion))
            {
                conn1.Open();

                SqlCommand cmd = new SqlCommand("SET DATEFORMAT 'dmy' if exists (select * from  Control_Cierre where Control_Cierre_Fecha = '" + Fecha + "')  select Control_Cierre_Diario from  Control_Cierre where Control_Cierre_Fecha = '" + Fecha + "' else select 0", conn1);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    verificacion = string.Format("{0}", dr[0]);
                }

                dr.Close();
                conn1.Close();
            }
        }

        private void VerificarHora()
        {
            DateTime HoraActual = Convert.ToDateTime(DateTime.Now.Hour + ":" + DateTime.Now.Minute);
            DateTime HoraFondo = Convert.ToDateTime(ConfigurationManager.AppSettings["HoraFondos"]);

            if (HoraActual >= HoraFondo)
            {
                MessageBox.Show("La hora de cierre de Fondos fue sobre pasada", "Cierre de Fondos", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void VerificaCuentaAutorizada(DataTable dtRegistros)
        {
            string strContrato_Id = string.Empty;
            string strCLABE = String.Empty;
            string strResultado = String.Empty;

            if (dtRegistros.Rows.Count > 0)
            {
                foreach (DataRow registro in dtRegistros.Rows)
                {

                    strContrato_Id = registro["Referencia_Numerica"].ToString().Trim();
                    strCLABE = registro["Cuenta_Beneficiario"].ToString().Trim();
                    // Verifico que la CLABE sea válida
                    if (strCLABE != "SIN/CLABE" || strCLABE.Length != 18)
                    {
                        // Tiene CLABE
                        // Aqui verifico si ya esta verificada la cuenta.
                        using (SqlConnection cnn = new SqlConnection(conStr))
                        {
                            string strSql = "SIIFMF01.dbo.sp_C_VerificaCLABE";
                            SqlCommand cmd = new SqlCommand(strSql, cnn);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@strContrato_Id", strContrato_Id);
                            cmd.Parameters.AddWithValue("@strCuentaCLABE", strCLABE);

                            cmd.Parameters.Add("@strResultado", SqlDbType.VarChar, 1).Direction = ParameterDirection.Output;
                            if (cnn.State == ConnectionState.Closed)
                                cnn.Open();

                            cmd.ExecuteNonQuery();
                            strResultado = cmd.Parameters["@strResultado"].Value.ToString();


                            MF_STPServicios srvs = new MF_STPServicios();
                            ordenPagoWS data = new ordenPagoWS();

                            // Resultados posibles:

                            // 1 - Existe y ya fue verificado


                            switch (strResultado)
                            {
                                case "0":  // 0 - Existe pero no se ha verificado
                                    #region Orden de Pago
                                    data.empresa = "MAS_FONDOS";
                                    data.claveRastreo = registro["Clave_Rastreo"].ToString().Trim();
                                    data.conceptoPago = registro["Concepto_Pago"].ToString().Trim();
                                    data.cuentaBeneficiario = registro["Cuenta_Beneficiario"].ToString().Trim();
                                    data.cuentaOrdenante = "";
                                    data.referenciaNumerica = Convert.ToInt32(registro["Referencia_Numerica"].ToString().Trim());
                                    data.referenciaNumericaSpecified = true;
                                    data.monto = 0.01M;
                                    data.montoSpecified = true;
                                    data.tipoCuentaBeneficiario = 40;
                                    data.tipoCuentaBeneficiarioSpecified = true;
                                    data.tipoPago = 1;
                                    data.tipoPagoSpecified = true;
                                    data.institucionContraparte = 846;
                                    data.institucionContraparteSpecified = true;
                                    data.nombreBeneficiario = registro["Nombre_Beneficiario"].ToString().Trim();
                                    data.institucionOperante = 90646;
                                    data.institucionOperanteSpecified = true;
                                    data.iva = 0.0;
                                    data.ivaSpecified = false;
                                    #endregion

                                    srvs.RegistrarOrdenPago(data);
                                    break;
                                case "1": // 1 - Existe y ya fue verificado
                                    // Sin proceso
                                    break;
                                case "3": // 3 - No existe.
                                    // Dar de alta y envío de verificación.

                                    break;
                                default:
                                    break;
                            }


                            if (strResultado == "1")
                            {
                                // Existe y esta validada la cuenta

                            }
                            else // No se tiene registro 
                            {

                                // Se envía la solicitud de verificación de cuenta.
                                // Envío un depósito




                                // Se envía el correo.
                            }
                        } // Conexión

                    }
                    else // No tiene cuenta CLABE
                    {
                        // Se borra de la tabla para no agregarlo al Layout
                        dtRegistros.Rows.Remove(registro);
                        dtRegistros.AcceptChanges();
                    }

                    // Verificar tabla de registros

                }
            }
        }


        private void GeneraDepositoVerificacion()
        {


            #region Orden de Pago
            ordenPagoWS data = new ordenPagoWS();
            data.empresa = "MAS_FONDOS";
            data.claveRastreo = "MSFCH0OEE80003";
            data.conceptoPago = "Pruebas de Más Fondos";
            data.cuentaBeneficiario = "846180000400000001";
            data.cuentaOrdenante = "";
            data.referenciaNumerica = 2;
            data.referenciaNumericaSpecified = true;
            data.monto = 460000.82M;
            data.montoSpecified = true;
            data.tipoCuentaBeneficiario = 40;
            data.tipoCuentaBeneficiarioSpecified = true;
            data.tipoPago = 1;
            data.tipoPagoSpecified = true;
            data.institucionContraparte = 846;
            data.institucionContraparteSpecified = true;
            data.nombreBeneficiario = "Juan Delgado";
            data.institucionOperante = 90646;
            data.institucionOperanteSpecified = true;
            data.iva = 16;
            data.ivaSpecified = true;
            #endregion

        }

        #endregion

    }
}
