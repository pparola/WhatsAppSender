using System.Configuration;
using CefSharp;
using CefSharp.WinForms;

namespace WhatsAppSenderC
{
    public partial class FormSendWhatsApp : Form
    {

        private ChromiumWebBrowser Browse = null;

        public FormSendWhatsApp()
        {
            InitializeComponent();

            iTiempo.Value = 10;
            iTelefono.Text = "5491157573741";
            iMensaje.Text = "Este es un mensaje enviado automaticamente";

            ActivarForm(true);

        }

        private void FormSendWhatsApp_Load(object sender, EventArgs e)
        {
            Browse = new ChromiumWebBrowser("https://web.whatsapp.com");
            
            pnlBrowser.Controls.Clear();
            pnlBrowser.Controls.Add(Browse);
            this.WindowState = FormWindowState.Maximized;
            pnlBrowser.Width = (int) (this.Width * 0.7);
        }



        private void btnEnviar_Click(object sender, EventArgs e)
        {

            ActivarForm(false);

            Browse.LoadUrlAsync("https://web.whatsapp.com/send?phone=" + 
                                    this.iTelefono.Text + 
                                    "&text=" + 
                                    this.iMensaje.Text);

            Thread.Sleep((int) iTiempo.Value * 1000);

            Browse.Focus();
            
            SendKeys.Send("{Enter}");

            Thread.Sleep(1 * 1000);

            iTelefono.Focus();

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


    }
}