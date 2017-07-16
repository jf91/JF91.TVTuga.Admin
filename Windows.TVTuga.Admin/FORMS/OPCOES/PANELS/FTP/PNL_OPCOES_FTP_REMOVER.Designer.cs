namespace Windows.TVTuga.Admin.FORMS.OPCOES.PANELS.FTP
{
    partial class PNL_OPCOES_FTP_REMOVER
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
            this.TEXTBOX_DIRECTORIO_INICIAL = new System.Windows.Forms.TextBox();
            this.LABEL_DIRECTORIO_INICIAL = new System.Windows.Forms.Label();
            this.TEXTBOX_PORTA = new System.Windows.Forms.TextBox();
            this.LABEL_PORTA = new System.Windows.Forms.Label();
            this.COMBOBOX_PROTOCOLO = new System.Windows.Forms.ComboBox();
            this.LABEL_PROTOCOLO = new System.Windows.Forms.Label();
            this.TEXTBOX_IP = new System.Windows.Forms.TextBox();
            this.LABEL_IP = new System.Windows.Forms.Label();
            this.TEXTBOX_NOME = new System.Windows.Forms.TextBox();
            this.LABEL_NOME = new System.Windows.Forms.Label();
            this.TEXTBOX_ID = new System.Windows.Forms.TextBox();
            this.LABEL_ID = new System.Windows.Forms.Label();
            this.LISTVIEW_CONTAS = new System.Windows.Forms.ListView();
            this.BUTTON_REMOVER_CONTA = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TEXTBOX_DIRECTORIO_INICIAL
            // 
            this.TEXTBOX_DIRECTORIO_INICIAL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TEXTBOX_DIRECTORIO_INICIAL.Location = new System.Drawing.Point(158, 166);
            this.TEXTBOX_DIRECTORIO_INICIAL.Name = "TEXTBOX_DIRECTORIO_INICIAL";
            this.TEXTBOX_DIRECTORIO_INICIAL.ReadOnly = true;
            this.TEXTBOX_DIRECTORIO_INICIAL.Size = new System.Drawing.Size(162, 20);
            this.TEXTBOX_DIRECTORIO_INICIAL.TabIndex = 35;
            // 
            // LABEL_DIRECTORIO_INICIAL
            // 
            this.LABEL_DIRECTORIO_INICIAL.AutoSize = true;
            this.LABEL_DIRECTORIO_INICIAL.Location = new System.Drawing.Point(155, 150);
            this.LABEL_DIRECTORIO_INICIAL.Name = "LABEL_DIRECTORIO_INICIAL";
            this.LABEL_DIRECTORIO_INICIAL.Size = new System.Drawing.Size(82, 13);
            this.LABEL_DIRECTORIO_INICIAL.TabIndex = 34;
            this.LABEL_DIRECTORIO_INICIAL.Text = "Directório Inicial";
            // 
            // TEXTBOX_PORTA
            // 
            this.TEXTBOX_PORTA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TEXTBOX_PORTA.Location = new System.Drawing.Point(263, 118);
            this.TEXTBOX_PORTA.Name = "TEXTBOX_PORTA";
            this.TEXTBOX_PORTA.ReadOnly = true;
            this.TEXTBOX_PORTA.Size = new System.Drawing.Size(57, 20);
            this.TEXTBOX_PORTA.TabIndex = 31;
            // 
            // LABEL_PORTA
            // 
            this.LABEL_PORTA.AutoSize = true;
            this.LABEL_PORTA.Location = new System.Drawing.Point(260, 102);
            this.LABEL_PORTA.Name = "LABEL_PORTA";
            this.LABEL_PORTA.Size = new System.Drawing.Size(32, 13);
            this.LABEL_PORTA.TabIndex = 30;
            this.LABEL_PORTA.Text = "Porta";
            // 
            // COMBOBOX_PROTOCOLO
            // 
            this.COMBOBOX_PROTOCOLO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.COMBOBOX_PROTOCOLO.Enabled = false;
            this.COMBOBOX_PROTOCOLO.FormattingEnabled = true;
            this.COMBOBOX_PROTOCOLO.Items.AddRange(new object[] {
            "FTP",
            "SFTP (SSH)"});
            this.COMBOBOX_PROTOCOLO.Location = new System.Drawing.Point(259, 71);
            this.COMBOBOX_PROTOCOLO.Name = "COMBOBOX_PROTOCOLO";
            this.COMBOBOX_PROTOCOLO.Size = new System.Drawing.Size(61, 21);
            this.COMBOBOX_PROTOCOLO.TabIndex = 29;
            // 
            // LABEL_PROTOCOLO
            // 
            this.LABEL_PROTOCOLO.AutoSize = true;
            this.LABEL_PROTOCOLO.Location = new System.Drawing.Point(257, 55);
            this.LABEL_PROTOCOLO.Name = "LABEL_PROTOCOLO";
            this.LABEL_PROTOCOLO.Size = new System.Drawing.Size(52, 13);
            this.LABEL_PROTOCOLO.TabIndex = 28;
            this.LABEL_PROTOCOLO.Text = "Protocolo";
            // 
            // TEXTBOX_IP
            // 
            this.TEXTBOX_IP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TEXTBOX_IP.Location = new System.Drawing.Point(158, 118);
            this.TEXTBOX_IP.Name = "TEXTBOX_IP";
            this.TEXTBOX_IP.ReadOnly = true;
            this.TEXTBOX_IP.Size = new System.Drawing.Size(95, 20);
            this.TEXTBOX_IP.TabIndex = 27;
            // 
            // LABEL_IP
            // 
            this.LABEL_IP.AutoSize = true;
            this.LABEL_IP.Location = new System.Drawing.Point(155, 102);
            this.LABEL_IP.Name = "LABEL_IP";
            this.LABEL_IP.Size = new System.Drawing.Size(83, 13);
            this.LABEL_IP.TabIndex = 26;
            this.LABEL_IP.Text = "IP ou Hostname";
            // 
            // TEXTBOX_NOME
            // 
            this.TEXTBOX_NOME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TEXTBOX_NOME.Location = new System.Drawing.Point(158, 71);
            this.TEXTBOX_NOME.Name = "TEXTBOX_NOME";
            this.TEXTBOX_NOME.ReadOnly = true;
            this.TEXTBOX_NOME.Size = new System.Drawing.Size(95, 20);
            this.TEXTBOX_NOME.TabIndex = 25;
            // 
            // LABEL_NOME
            // 
            this.LABEL_NOME.AutoSize = true;
            this.LABEL_NOME.Location = new System.Drawing.Point(155, 55);
            this.LABEL_NOME.Name = "LABEL_NOME";
            this.LABEL_NOME.Size = new System.Drawing.Size(35, 13);
            this.LABEL_NOME.TabIndex = 24;
            this.LABEL_NOME.Text = "Nome";
            // 
            // TEXTBOX_ID
            // 
            this.TEXTBOX_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TEXTBOX_ID.Location = new System.Drawing.Point(158, 25);
            this.TEXTBOX_ID.Name = "TEXTBOX_ID";
            this.TEXTBOX_ID.ReadOnly = true;
            this.TEXTBOX_ID.Size = new System.Drawing.Size(50, 20);
            this.TEXTBOX_ID.TabIndex = 23;
            // 
            // LABEL_ID
            // 
            this.LABEL_ID.AutoSize = true;
            this.LABEL_ID.Location = new System.Drawing.Point(155, 9);
            this.LABEL_ID.Name = "LABEL_ID";
            this.LABEL_ID.Size = new System.Drawing.Size(18, 13);
            this.LABEL_ID.TabIndex = 22;
            this.LABEL_ID.Text = "ID";
            // 
            // LISTVIEW_CONTAS
            // 
            this.LISTVIEW_CONTAS.Location = new System.Drawing.Point(3, 3);
            this.LISTVIEW_CONTAS.Name = "LISTVIEW_CONTAS";
            this.LISTVIEW_CONTAS.Size = new System.Drawing.Size(146, 226);
            this.LISTVIEW_CONTAS.TabIndex = 21;
            this.LISTVIEW_CONTAS.UseCompatibleStateImageBehavior = false;
            // 
            // BUTTON_REMOVER_CONTA
            // 
            this.BUTTON_REMOVER_CONTA.Image = global::Windows.TVTuga.Admin.Properties.Resources.Delete__Custom___2_;
            this.BUTTON_REMOVER_CONTA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BUTTON_REMOVER_CONTA.Location = new System.Drawing.Point(185, 199);
            this.BUTTON_REMOVER_CONTA.Name = "BUTTON_REMOVER_CONTA";
            this.BUTTON_REMOVER_CONTA.Size = new System.Drawing.Size(107, 23);
            this.BUTTON_REMOVER_CONTA.TabIndex = 37;
            this.BUTTON_REMOVER_CONTA.Text = "Remover Conta";
            this.BUTTON_REMOVER_CONTA.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BUTTON_REMOVER_CONTA.UseVisualStyleBackColor = true;
            // 
            // PNL_OPCOES_FTP_REMOVER
            // 
            this.ClientSize = new System.Drawing.Size(325, 233);
            this.Controls.Add(this.BUTTON_REMOVER_CONTA);
            this.Controls.Add(this.TEXTBOX_DIRECTORIO_INICIAL);
            this.Controls.Add(this.LABEL_DIRECTORIO_INICIAL);
            this.Controls.Add(this.TEXTBOX_PORTA);
            this.Controls.Add(this.LABEL_PORTA);
            this.Controls.Add(this.COMBOBOX_PROTOCOLO);
            this.Controls.Add(this.LABEL_PROTOCOLO);
            this.Controls.Add(this.TEXTBOX_IP);
            this.Controls.Add(this.LABEL_IP);
            this.Controls.Add(this.TEXTBOX_NOME);
            this.Controls.Add(this.LABEL_NOME);
            this.Controls.Add(this.TEXTBOX_ID);
            this.Controls.Add(this.LABEL_ID);
            this.Controls.Add(this.LISTVIEW_CONTAS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PNL_OPCOES_FTP_REMOVER";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TEXTBOX_DIRECTORIO_INICIAL;
        private System.Windows.Forms.Label LABEL_DIRECTORIO_INICIAL;
        private System.Windows.Forms.TextBox TEXTBOX_PORTA;
        private System.Windows.Forms.Label LABEL_PORTA;
        private System.Windows.Forms.ComboBox COMBOBOX_PROTOCOLO;
        private System.Windows.Forms.Label LABEL_PROTOCOLO;
        private System.Windows.Forms.TextBox TEXTBOX_IP;
        private System.Windows.Forms.Label LABEL_IP;
        private System.Windows.Forms.TextBox TEXTBOX_NOME;
        private System.Windows.Forms.Label LABEL_NOME;
        private System.Windows.Forms.TextBox TEXTBOX_ID;
        private System.Windows.Forms.Label LABEL_ID;
        private System.Windows.Forms.ListView LISTVIEW_CONTAS;
        private System.Windows.Forms.Button BUTTON_REMOVER_CONTA;
    }
}
