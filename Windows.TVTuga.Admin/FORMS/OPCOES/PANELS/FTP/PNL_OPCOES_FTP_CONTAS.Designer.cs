namespace Windows.TVTuga.Admin.FORMS.OPCOES.PANELS.FTP
{
    partial class PNL_OPCOES_FTP_CONTAS
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
            this.TEXTBOX_NOME = new System.Windows.Forms.TextBox();
            this.LABEL_NOME = new System.Windows.Forms.Label();
            this.LISTVIEW_CONTAS = new System.Windows.Forms.ListView();
            this.HDR_NOME = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TEXTBOX_IP = new System.Windows.Forms.TextBox();
            this.LABEL_IP = new System.Windows.Forms.Label();
            this.LABEL_PROTOCOLO = new System.Windows.Forms.Label();
            this.COMBOBOX_PROTOCOLO = new System.Windows.Forms.ComboBox();
            this.TEXTBOX_PORTA = new System.Windows.Forms.TextBox();
            this.LABEL_PORTA = new System.Windows.Forms.Label();
            this.TEXTBOX_PASSWORD = new System.Windows.Forms.TextBox();
            this.LABEL_PASSWORD = new System.Windows.Forms.Label();
            this.TEXTBOX_DIRECTORIO_INICIAL = new System.Windows.Forms.TextBox();
            this.LABEL_DIRECTORIO_INICIAL = new System.Windows.Forms.Label();
            this.CHECKBOX_PASSWORD = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // TEXTBOX_NOME
            // 
            this.TEXTBOX_NOME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TEXTBOX_NOME.Location = new System.Drawing.Point(158, 25);
            this.TEXTBOX_NOME.Name = "TEXTBOX_NOME";
            this.TEXTBOX_NOME.Size = new System.Drawing.Size(162, 20);
            this.TEXTBOX_NOME.TabIndex = 9;
            // 
            // LABEL_NOME
            // 
            this.LABEL_NOME.AutoSize = true;
            this.LABEL_NOME.Location = new System.Drawing.Point(155, 9);
            this.LABEL_NOME.Name = "LABEL_NOME";
            this.LABEL_NOME.Size = new System.Drawing.Size(35, 13);
            this.LABEL_NOME.TabIndex = 8;
            this.LABEL_NOME.Text = "Nome";
            // 
            // LISTVIEW_CONTAS
            // 
            this.LISTVIEW_CONTAS.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.HDR_NOME});
            this.LISTVIEW_CONTAS.Location = new System.Drawing.Point(3, 3);
            this.LISTVIEW_CONTAS.Name = "LISTVIEW_CONTAS";
            this.LISTVIEW_CONTAS.Size = new System.Drawing.Size(146, 226);
            this.LISTVIEW_CONTAS.TabIndex = 5;
            this.LISTVIEW_CONTAS.UseCompatibleStateImageBehavior = false;
            this.LISTVIEW_CONTAS.View = System.Windows.Forms.View.Details;
            // 
            // HDR_NOME
            // 
            this.HDR_NOME.Text = "Nome";
            this.HDR_NOME.Width = 140;
            // 
            // TEXTBOX_IP
            // 
            this.TEXTBOX_IP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TEXTBOX_IP.Location = new System.Drawing.Point(158, 71);
            this.TEXTBOX_IP.Name = "TEXTBOX_IP";
            this.TEXTBOX_IP.Size = new System.Drawing.Size(95, 20);
            this.TEXTBOX_IP.TabIndex = 11;
            // 
            // LABEL_IP
            // 
            this.LABEL_IP.AutoSize = true;
            this.LABEL_IP.Location = new System.Drawing.Point(155, 55);
            this.LABEL_IP.Name = "LABEL_IP";
            this.LABEL_IP.Size = new System.Drawing.Size(83, 13);
            this.LABEL_IP.TabIndex = 10;
            this.LABEL_IP.Text = "IP ou Hostname";
            // 
            // LABEL_PROTOCOLO
            // 
            this.LABEL_PROTOCOLO.AutoSize = true;
            this.LABEL_PROTOCOLO.Location = new System.Drawing.Point(257, 55);
            this.LABEL_PROTOCOLO.Name = "LABEL_PROTOCOLO";
            this.LABEL_PROTOCOLO.Size = new System.Drawing.Size(52, 13);
            this.LABEL_PROTOCOLO.TabIndex = 12;
            this.LABEL_PROTOCOLO.Text = "Protocolo";
            // 
            // COMBOBOX_PROTOCOLO
            // 
            this.COMBOBOX_PROTOCOLO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.COMBOBOX_PROTOCOLO.FormattingEnabled = true;
            this.COMBOBOX_PROTOCOLO.Items.AddRange(new object[] {
            "FTP",
            "SFTP (SSH)"});
            this.COMBOBOX_PROTOCOLO.Location = new System.Drawing.Point(259, 71);
            this.COMBOBOX_PROTOCOLO.Name = "COMBOBOX_PROTOCOLO";
            this.COMBOBOX_PROTOCOLO.Size = new System.Drawing.Size(61, 21);
            this.COMBOBOX_PROTOCOLO.TabIndex = 13;
            // 
            // TEXTBOX_PORTA
            // 
            this.TEXTBOX_PORTA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TEXTBOX_PORTA.Location = new System.Drawing.Point(280, 118);
            this.TEXTBOX_PORTA.Name = "TEXTBOX_PORTA";
            this.TEXTBOX_PORTA.Size = new System.Drawing.Size(40, 20);
            this.TEXTBOX_PORTA.TabIndex = 15;
            // 
            // LABEL_PORTA
            // 
            this.LABEL_PORTA.AutoSize = true;
            this.LABEL_PORTA.Location = new System.Drawing.Point(277, 102);
            this.LABEL_PORTA.Name = "LABEL_PORTA";
            this.LABEL_PORTA.Size = new System.Drawing.Size(32, 13);
            this.LABEL_PORTA.TabIndex = 14;
            this.LABEL_PORTA.Text = "Porta";
            // 
            // TEXTBOX_PASSWORD
            // 
            this.TEXTBOX_PASSWORD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TEXTBOX_PASSWORD.Location = new System.Drawing.Point(158, 118);
            this.TEXTBOX_PASSWORD.Name = "TEXTBOX_PASSWORD";
            this.TEXTBOX_PASSWORD.Size = new System.Drawing.Size(79, 20);
            this.TEXTBOX_PASSWORD.TabIndex = 17;
            // 
            // LABEL_PASSWORD
            // 
            this.LABEL_PASSWORD.AutoSize = true;
            this.LABEL_PASSWORD.Location = new System.Drawing.Point(155, 102);
            this.LABEL_PASSWORD.Name = "LABEL_PASSWORD";
            this.LABEL_PASSWORD.Size = new System.Drawing.Size(53, 13);
            this.LABEL_PASSWORD.TabIndex = 16;
            this.LABEL_PASSWORD.Text = "Password";
            // 
            // TEXTBOX_DIRECTORIO_INICIAL
            // 
            this.TEXTBOX_DIRECTORIO_INICIAL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TEXTBOX_DIRECTORIO_INICIAL.Location = new System.Drawing.Point(158, 166);
            this.TEXTBOX_DIRECTORIO_INICIAL.Name = "TEXTBOX_DIRECTORIO_INICIAL";
            this.TEXTBOX_DIRECTORIO_INICIAL.Size = new System.Drawing.Size(162, 20);
            this.TEXTBOX_DIRECTORIO_INICIAL.TabIndex = 19;
            // 
            // LABEL_DIRECTORIO_INICIAL
            // 
            this.LABEL_DIRECTORIO_INICIAL.AutoSize = true;
            this.LABEL_DIRECTORIO_INICIAL.Location = new System.Drawing.Point(155, 150);
            this.LABEL_DIRECTORIO_INICIAL.Name = "LABEL_DIRECTORIO_INICIAL";
            this.LABEL_DIRECTORIO_INICIAL.Size = new System.Drawing.Size(82, 13);
            this.LABEL_DIRECTORIO_INICIAL.TabIndex = 18;
            this.LABEL_DIRECTORIO_INICIAL.Text = "Directório Inicial";
            // 
            // CHECKBOX_PASSWORD
            // 
            this.CHECKBOX_PASSWORD.AutoSize = true;
            this.CHECKBOX_PASSWORD.Image = global::Windows.TVTuga.Admin.Properties.Resources.eye_watch__Custom___2_;
            this.CHECKBOX_PASSWORD.Location = new System.Drawing.Point(239, 119);
            this.CHECKBOX_PASSWORD.Name = "CHECKBOX_PASSWORD";
            this.CHECKBOX_PASSWORD.Size = new System.Drawing.Size(35, 20);
            this.CHECKBOX_PASSWORD.TabIndex = 20;
            this.CHECKBOX_PASSWORD.UseVisualStyleBackColor = true;
            // 
            // PNL_OPCOES_FTP_CONTAS
            // 
            this.ClientSize = new System.Drawing.Size(325, 233);
            this.Controls.Add(this.CHECKBOX_PASSWORD);
            this.Controls.Add(this.TEXTBOX_DIRECTORIO_INICIAL);
            this.Controls.Add(this.LABEL_DIRECTORIO_INICIAL);
            this.Controls.Add(this.TEXTBOX_PASSWORD);
            this.Controls.Add(this.LABEL_PASSWORD);
            this.Controls.Add(this.TEXTBOX_PORTA);
            this.Controls.Add(this.LABEL_PORTA);
            this.Controls.Add(this.COMBOBOX_PROTOCOLO);
            this.Controls.Add(this.LABEL_PROTOCOLO);
            this.Controls.Add(this.TEXTBOX_IP);
            this.Controls.Add(this.LABEL_IP);
            this.Controls.Add(this.TEXTBOX_NOME);
            this.Controls.Add(this.LABEL_NOME);
            this.Controls.Add(this.LISTVIEW_CONTAS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PNL_OPCOES_FTP_CONTAS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TEXTBOX_NOME;
        private System.Windows.Forms.Label LABEL_NOME;
        private System.Windows.Forms.ListView LISTVIEW_CONTAS;
        private System.Windows.Forms.TextBox TEXTBOX_IP;
        private System.Windows.Forms.Label LABEL_IP;
        private System.Windows.Forms.Label LABEL_PROTOCOLO;
        private System.Windows.Forms.ComboBox COMBOBOX_PROTOCOLO;
        private System.Windows.Forms.TextBox TEXTBOX_PORTA;
        private System.Windows.Forms.Label LABEL_PORTA;
        private System.Windows.Forms.TextBox TEXTBOX_PASSWORD;
        private System.Windows.Forms.Label LABEL_PASSWORD;
        private System.Windows.Forms.TextBox TEXTBOX_DIRECTORIO_INICIAL;
        private System.Windows.Forms.Label LABEL_DIRECTORIO_INICIAL;
        private System.Windows.Forms.CheckBox CHECKBOX_PASSWORD;
        private System.Windows.Forms.ColumnHeader HDR_NOME;
    }
}
