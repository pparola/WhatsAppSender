using CefSharp.WinForms;
using Syncfusion.XlsIO;

namespace WhatsAppSenderC
{
    public partial class FormSendWhatsApp : Form
    {

        private List<Caso> ListaCasos { get; set; } = new List<Caso>();
        private int nCaso = 0;
        private ChromiumWebBrowser? Browse = null;

        public FormSendWhatsApp()
        {
            InitializeComponent();

            iTiempo.Value = 15;
            ActivarForm(true);
            ActualizarRegistro();

        }

        private void ActualizarRegistro()
        {
            if (ListaCasos.Count == 0)
            {
                iTelefono.Text = "";
                iMensaje.Text = "";
                iContador.Text = "0/0";
            }
            else
            {
                var caso = ListaCasos[nCaso];
                iTelefono.Text = "549" + caso.Telefono;

                iMensaje.Text = "Hola " + caso.Nombre + "\n " ;
                iMensaje.Text += "Muchas Gracias! \n" ;
                iMensaje.Text += caso.Link + "\n " ; 

                iContador.Text = (nCaso + 1).ToString() + "/" + ListaCasos.Count.ToString();

            }
            Application.DoEvents();

        }


        private void FormSendWhatsApp_Load(object sender, EventArgs e)
        {
            Browse = new ChromiumWebBrowser("https://web.whatsapp.com");

            pnlBrowser.Controls.Clear();
            pnlBrowser.Controls.Add(Browse);
            this.WindowState = FormWindowState.Maximized;
            pnlBrowser.Width = (int)(this.Width * 0.85);
        }



        private void btnEnviar_Click(object sender, EventArgs e)
        {
            enviar();
        }

        private class Caso
        {
            public string Codigo { get; set; }
            public string Nombre { get; set; }
            public string Telefono { get; set; }
            public string Link { get; set; }
            public Caso()
            {
                Codigo = "";
                Nombre = "";
                Telefono = "";
                Link = "";
            }
        }



        private void enviar()
        {
            ActivarForm(false);

            lblMensaje.Text = "Cargando Mensaje...";
            Application.DoEvents();

            // Browse!.LoadUrlAsync("https://web.whatsapp.com/send?phone=" + iTelefono.Text);
            Browse!.LoadUrl("https://web.whatsapp.com/send?phone=" + iTelefono.Text);

            lblMensaje.Text = "Esperando Envio...";
            Application.DoEvents();

            Thread.Sleep(15 * 1000);

            lblMensaje.Text = "Enviado...";
            Application.DoEvents();

            Browse.Focus();
            Browse.Focus();

            SendKeys.Send(iMensaje.Text);

            SendKeys.Send("{Enter}");
            Thread.Sleep(1 * 1000);

            ActivarForm(true);

        }


        private void ActivarForm(bool estado)
        {
            this.iTelefono.Enabled = estado;
            this.iMensaje.Enabled = estado;
            this.btnEnviar.Enabled = estado;

            this.lblMensaje.Visible = !estado;

            Application.DoEvents();
        }

        private void cExcelSelect_Click(object sender, EventArgs e)
        {
            var respuesta = this.openFileExcel.ShowDialog();
            if (respuesta == DialogResult.OK)
            {
                iArchivo.Text = openFileExcel.FileName;
                int fila = 4;
                string celda;
                string codigo;
                string nombre;
                string link;
                string telefono;

                ListaCasos = new List<Caso>();

                ExcelEngine excelEngine = new ExcelEngine();

                using (var stream = File.Open(iArchivo.Text.Replace("\\", "\\\\"), FileMode.Open, FileAccess.Read))
                {
                    var workbook = excelEngine.Excel.Workbooks.Open(stream);
                    var sheet = workbook.Worksheets.FirstOrDefault();

                    if (sheet != null)
                    {
                        while (true)
                        {
                            celda = "A" + fila.ToString(); codigo = sheet.Range[celda].Value;
                            if (codigo == "")
                                break;
                            if (codigo.Contains("Cantidad"))
                                break;

                            celda = "B" + fila.ToString(); nombre = sheet.Range[celda].Value;
                            celda = "E" + fila.ToString(); link = sheet.Range[celda].Value;
                            celda = "F" + fila.ToString(); telefono = sheet.Range[celda].Value;

                            var caso = new Caso();
                            caso.Codigo = codigo;
                            caso.Nombre = nombre;
                            caso.Telefono = telefono;
                            caso.Link = link;
                            ListaCasos.Add(caso);

                            fila++;
                        }
                    }
                    nCaso = 0;
                    ActualizarRegistro();
                }
            }
        }

        private void cSiguiente_Click(object sender, EventArgs e)
        {
            nCaso++;
            if (nCaso >= ListaCasos.Count - 1) nCaso = ListaCasos.Count - 1;
            ActualizarRegistro();
        }

        private void cAnterior_Click(object sender, EventArgs e)
        {
            nCaso--;
            if (nCaso < 0) nCaso = 0;
            ActualizarRegistro();
        }

    }
}