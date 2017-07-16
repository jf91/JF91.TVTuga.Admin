namespace Windows.TVTuga.Admin.FORMS.OPCOES.PANELS.BD.CONTAS
{
    partial class PNL_OPCOES_BD_ADICIONAR
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
            this.TEXTBOX_PASSWORD = new System.Windows.Forms.TextBox();
            this.LABEL_PASSWORD = new System.Windows.Forms.Label();
            this.TEXTBOX_PORTA = new System.Windows.Forms.TextBox();
            this.LABEL_PORTA = new System.Windows.Forms.Label();
            this.COMBOBOX_PROTOCOLO = new System.Windows.Forms.ComboBox();
            this.LABEL_PROTOCOLO = new System.Windows.Forms.Label();
            this.TEXTBOX_IP = new System.Windows.Forms.TextBox();
            this.LABEL_IP = new System.Windows.Forms.Label();
            this.TEXTBOX_NOME = new System.Windows.Forms.TextBox();
            this.LABEL_NOME = new System.Windows.Forms.Label();
            this.BUTTON_CRIAR_CONTA = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TEXTBOX_PASSWORD
            // 
            this.TEXTBOX_PASSWORD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TEXTBOX_PASSWORD.Location = new System.Drawing.Point(184, 39);
            this.TEXTBOX_PASSWORD.Name = "TEXTBOX_PASSWORD";
            this.TEXTBOX_PASSWORD.Size = new System.Drawing.Size(79, 20);
            this.TEXTBOX_PASSWORD.TabIndex = 43;
            // 
            // LABEL_PASSWORD
            // 
            this.LABEL_PASSWORD.AutoSize = true;
            this.LABEL_PASSWORD.Location = new System.Drawing.Point(181, 23);
            this.LABEL_PASSWORD.Name = "LABEL_PASSWORD";
            this.LABEL_PASSWORD.Size = new System.Drawing.Size(53, 13);
            this.LABEL_PASSWORD.TabIndex = 42;
            this.LABEL_PASSWORD.Text = "Password";
            // 
            // TEXTBOX_PORTA
            // 
            this.TEXTBOX_PORTA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TEXTBOX_PORTA.Location = new System.Drawing.Point(234, 103);
            this.TEXTBOX_PORTA.Name = "TEXTBOX_PORTA";
            this.TEXTBOX_PORTA.Size = new System.Drawing.Size(40, 20);
            this.TEXTBOX_PORTA.TabIndex = 41;
            // 
            // LABEL_PORTA
            // 
            this.LABEL_PORTA.AutoSize = true;
            this.LABEL_PORTA.Location = new System.Drawing.Point(231, 87);
            this.LABEL_PORTA.Name = "LABEL_PORTA";
            this.LABEL_PORTA.Size = new System.Drawing.Size(32, 13);
            this.LABEL_PORTA.TabIndex = 40;
            this.LABEL_PORTA.Text = "Porta";
            // 
            // COMBOBOX_PROTOCOLO
            // 
            this.COMBOBOX_PROTOCOLO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.COMBOBOX_PROTOCOLO.FormattingEnabled = true;
            this.COMBOBOX_PROTOCOLO.Items.AddRange(new object[] {
            "TCP/IP",
            "Named Pipe",
            "SSH Tunnel"});
            this.COMBOBOX_PROTOCOLO.Location = new System.Drawing.Point(162, 103);
            this.COMBOBOX_PROTOCOLO.Name = "COMBOBOX_PROTOCOLO";
            this.COMBOBOX_PROTOCOLO.Size = new System.Drawing.Size(61, 21);
            this.COMBOBOX_PROTOCOLO.TabIndex = 39;
            // 
            // LABEL_PROTOCOLO
            // 
            this.LABEL_PROTOCOLO.AutoSize = true;
            this.LABEL_PROTOCOLO.Location = new System.Drawing.Point(160, 87);
            this.LABEL_PROTOCOLO.Name = "LABEL_PROTOCOLO";
            this.LABEL_PROTOCOLO.Size = new System.Drawing.Size(52, 13);
            this.LABEL_PROTOCOLO.TabIndex = 38;
            this.LABEL_PROTOCOLO.Text = "Protocolo";
            // 
            // TEXTBOX_IP
            // 
            this.TEXTBOX_IP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TEXTBOX_IP.Location = new System.Drawing.Point(54, 103);
            this.TEXTBOX_IP.Name = "TEXTBOX_IP";
            this.TEXTBOX_IP.Size = new System.Drawing.Size(95, 20);
            this.TEXTBOX_IP.TabIndex = 37;
            // 
            // LABEL_IP
            // 
            this.LABEL_IP.AutoSize = true;
            this.LABEL_IP.Location = new System.Drawing.Point(51, 87);
            this.LABEL_IP.Name = "LABEL_IP";
            this.LABEL_IP.Size = new System.Drawing.Size(83, 13);
            this.LABEL_IP.TabIndex = 36;
            this.LABEL_IP.Text = "IP ou Hostname";
            // 
            // TEXTBOX_NOME
            // 
            this.TEXTBOX_NOME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TEXTBOX_NOME.Location = new System.Drawing.Point(54, 39);
            this.TEXTBOX_NOME.Name = "TEXTBOX_NOME";
            this.TEXTBOX_NOME.Size = new System.Drawing.Size(109, 20);
            this.TEXTBOX_NOME.TabIndex = 35;
            // 
            // LABEL_NOME
            // 
            this.LABEL_NOME.AutoSize = true;
            this.LABEL_NOME.Location = new System.Drawing.Point(51, 23);
            this.LABEL_NOME.Name = "LABEL_NOME";
            this.LABEL_NOME.Size = new System.Drawing.Size(35, 13);
            this.LABEL_NOME.TabIndex = 34;
            this.LABEL_NOME.Text = "Nome";
            // 
            // BUTTON_CRIAR_CONTA
            // 
            this.BUTTON_CRIAR_CONTA.Image = global::Windows.TVTuga.Admin.Properties.Resources.Yes_check__Custom___2_;
            this.BUTTON_CRIAR_CONTA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BUTTON_CRIAR_CONTA.Location = new System.Drawing.Point(111, 157);
            this.BUTTON_CRIAR_CONTA.Name = "BUTTON_CRIAR_CONTA";
            this.BUTTON_CRIAR_CONTA.Size = new System.Drawing.Size(89, 23);
            this.BUTTON_CRIAR_CONTA.TabIndex = 44;
            this.BUTTON_CRIAR_CONTA.Text = "Criar Conta";
            this.BUTTON_CRIAR_CONTA.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BUTTON_CRIAR_CONTA.UseVisualStyleBackColor = true;
            // 
            // PNL_OPCOES_BD_ADICIONAR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(325, 233);
            this.Controls.Add(this.BUTTON_CRIAR_CONTA);
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
            this.Name = "PNL_OPCOES_BD_ADICIONAR";
            this.Text = "V";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TEXTBOX_PASSWORD;
        private System.Windows.Forms.Label LABEL_PASSWORD;
        private System.Windows.Forms.TextBox TEXTBOX_PORTA;
        private System.Windows.Forms.Label LABEL_PORTA;
        private System.Windows.Forms.ComboBox COMBOBOX_PROTOCOLO;
        private System.Windows.Forms.Label LABEL_PROTOCOLO;
        private System.Windows.Forms.TextBox TEXTBOX_IP;
        private System.Windows.Forms.Label LABEL_IP;
        private System.Windows.Forms.TextBox TEXTBOX_NOME;
        private System.Windows.Forms.Label LABEL_NOME;
        private System.Windows.Forms.Button BUTTON_CRIAR_CONTA;
    }
}
