namespace WhatsAppSenderC
{
    partial class FormSendWhatsApp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlBrowser = new System.Windows.Forms.Panel();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.iTelefono = new System.Windows.Forms.TextBox();
            this.iMensaje = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.iTiempo = new System.Windows.Forms.NumericUpDown();
            this.lblMensaje = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iTiempo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBrowser
            // 
            this.pnlBrowser.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlBrowser.Location = new System.Drawing.Point(196, 0);
            this.pnlBrowser.Name = "pnlBrowser";
            this.pnlBrowser.Size = new System.Drawing.Size(604, 450);
            this.pnlBrowser.TabIndex = 0;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(12, 375);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(177, 38);
            this.btnEnviar.TabIndex = 2;
            this.btnEnviar.Text = "Enviar Un Mensaje";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // iTelefono
            // 
            this.iTelefono.Location = new System.Drawing.Point(12, 212);
            this.iTelefono.Name = "iTelefono";
            this.iTelefono.Size = new System.Drawing.Size(177, 23);
            this.iTelefono.TabIndex = 0;
            // 
            // iMensaje
            // 
            this.iMensaje.Location = new System.Drawing.Point(12, 256);
            this.iMensaje.Multiline = true;
            this.iMensaje.Name = "iMensaje";
            this.iMensaje.Size = new System.Drawing.Size(177, 113);
            this.iMensaje.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Telefono:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mensaje:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tiempo de Espera:";
            // 
            // iTiempo
            // 
            this.iTiempo.Location = new System.Drawing.Point(139, 7);
            this.iTiempo.Name = "iTiempo";
            this.iTiempo.Size = new System.Drawing.Size(50, 23);
            this.iTiempo.TabIndex = 7;
            this.iTiempo.TabStop = false;
            // 
            // lblMensaje
            // 
            this.lblMensaje.BackColor = System.Drawing.Color.GreenYellow;
            this.lblMensaje.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMensaje.Location = new System.Drawing.Point(12, 426);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(177, 23);
            this.lblMensaje.TabIndex = 8;
            this.lblMensaje.Text = "Procesando...";
            this.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormSendWhatsApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.iTiempo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iMensaje);
            this.Controls.Add(this.iTelefono);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.pnlBrowser);
            this.Name = "FormSendWhatsApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Envio de WhatsApp Escritorio";
            this.Load += new System.EventHandler(this.FormSendWhatsApp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iTiempo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel pnlBrowser;
        private Button btnEnviar;
        private TextBox iTelefono;
        private TextBox iMensaje;
        private Label label1;
        private Label label2;
        private Label label3;
        private NumericUpDown iTiempo;
        private Label lblMensaje;
    }
}