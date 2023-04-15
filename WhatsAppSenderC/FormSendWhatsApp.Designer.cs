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
            pnlBrowser = new Panel();
            btnEnviar = new Button();
            iMensaje = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            iTiempo = new NumericUpDown();
            lblMensaje = new Label();
            openFileExcel = new OpenFileDialog();
            cExcelSelect = new Button();
            iTelefono = new TextBox();
            iArchivo = new TextBox();
            label4 = new Label();
            cSiguiente = new Button();
            cAnterior = new Button();
            iContador = new TextBox();
            ((System.ComponentModel.ISupportInitialize)iTiempo).BeginInit();
            SuspendLayout();
            // 
            // pnlBrowser
            // 
            pnlBrowser.Dock = DockStyle.Right;
            pnlBrowser.Location = new Point(195, 0);
            pnlBrowser.Name = "pnlBrowser";
            pnlBrowser.Size = new Size(605, 506);
            pnlBrowser.TabIndex = 0;
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(12, 394);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(177, 38);
            btnEnviar.TabIndex = 2;
            btnEnviar.Text = "Enviar Un Mensaje";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // iMensaje
            // 
            iMensaje.Location = new Point(12, 256);
            iMensaje.Multiline = true;
            iMensaje.Name = "iMensaje";
            iMensaje.Size = new Size(177, 84);
            iMensaje.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 194);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 4;
            label1.Text = "Telefono:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 238);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 5;
            label2.Text = "Mensaje:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 9);
            label3.Name = "label3";
            label3.Size = new Size(103, 15);
            label3.TabIndex = 6;
            label3.Text = "Tiempo de Espera:";
            // 
            // iTiempo
            // 
            iTiempo.Location = new Point(139, 7);
            iTiempo.Name = "iTiempo";
            iTiempo.Size = new Size(50, 23);
            iTiempo.TabIndex = 7;
            iTiempo.TabStop = false;
            // 
            // lblMensaje
            // 
            lblMensaje.BackColor = Color.GreenYellow;
            lblMensaje.BorderStyle = BorderStyle.FixedSingle;
            lblMensaje.Location = new Point(12, 435);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(177, 23);
            lblMensaje.TabIndex = 8;
            lblMensaje.Text = "Procesando...";
            lblMensaje.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // openFileExcel
            // 
            openFileExcel.AddExtension = false;
            openFileExcel.Filter = "Excel files (*.xlsx)|*.xlsx";
            openFileExcel.Title = "Seleccione Archivo Excel";
            // 
            // cExcelSelect
            // 
            cExcelSelect.Location = new Point(12, 108);
            cExcelSelect.Name = "cExcelSelect";
            cExcelSelect.Size = new Size(177, 23);
            cExcelSelect.TabIndex = 9;
            cExcelSelect.Text = "Seleccione Archivo Excel";
            cExcelSelect.UseVisualStyleBackColor = true;
            cExcelSelect.Click += cExcelSelect_Click;
            // 
            // iTelefono
            // 
            iTelefono.Location = new Point(12, 212);
            iTelefono.Name = "iTelefono";
            iTelefono.Size = new Size(177, 23);
            iTelefono.TabIndex = 0;
            // 
            // iArchivo
            // 
            iArchivo.Location = new Point(12, 79);
            iArchivo.Name = "iArchivo";
            iArchivo.Size = new Size(177, 23);
            iArchivo.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 61);
            label4.Name = "label4";
            label4.Size = new Size(81, 15);
            label4.TabIndex = 11;
            label4.Text = "Archivo Excel:";
            // 
            // cSiguiente
            // 
            cSiguiente.Location = new Point(121, 137);
            cSiguiente.Name = "cSiguiente";
            cSiguiente.Size = new Size(68, 24);
            cSiguiente.TabIndex = 12;
            cSiguiente.Text = "Siguiente";
            cSiguiente.UseVisualStyleBackColor = true;
            cSiguiente.Click += cSiguiente_Click;
            // 
            // cAnterior
            // 
            cAnterior.Location = new Point(12, 137);
            cAnterior.Name = "cAnterior";
            cAnterior.Size = new Size(68, 24);
            cAnterior.TabIndex = 13;
            cAnterior.Text = "Anterior";
            cAnterior.UseVisualStyleBackColor = true;
            cAnterior.Click += cAnterior_Click;
            // 
            // iContador
            // 
            iContador.Location = new Point(79, 138);
            iContador.Name = "iContador";
            iContador.Size = new Size(43, 23);
            iContador.TabIndex = 14;
            iContador.Text = "0/0";
            iContador.TextAlign = HorizontalAlignment.Center;
            // 
            // FormSendWhatsApp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 506);
            Controls.Add(iContador);
            Controls.Add(cAnterior);
            Controls.Add(cSiguiente);
            Controls.Add(label4);
            Controls.Add(iArchivo);
            Controls.Add(cExcelSelect);
            Controls.Add(lblMensaje);
            Controls.Add(iTiempo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(iMensaje);
            Controls.Add(iTelefono);
            Controls.Add(btnEnviar);
            Controls.Add(pnlBrowser);
            Name = "FormSendWhatsApp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Envio de WhatsApp Escritorio";
            Load += FormSendWhatsApp_Load;
            ((System.ComponentModel.ISupportInitialize)iTiempo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlBrowser;
        private Button btnEnviar;
        private TextBox iMensaje;
        private Label label1;
        private Label label2;
        private Label label3;
        private NumericUpDown iTiempo;
        private Label lblMensaje;
        private OpenFileDialog openFileExcel;
        private Button cExcelSelect;
        private TextBox iTelefono;
        private TextBox iArchivo;
        private Label label4;
        private Button cSiguiente;
        private Button cAnterior;
        private TextBox iContador;
    }
}