namespace Windows.TVTuga.Admin.FORMS.OPCOES.PANELS.BD
{
    partial class PNL_OPCOES_BD_CONTAS
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
            this.TEXTBOX_USERNAME = new System.Windows.Forms.TextBox();
            this.LABEL_USERNAME = new System.Windows.Forms.Label();
            this.TEXTBOX_ID = new System.Windows.Forms.TextBox();
            this.LABEL_ID = new System.Windows.Forms.Label();
            this.LISTVIEW_CONTAS = new System.Windows.Forms.ListView();
            this.HDR_NOME = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CHECKBOX_PASSWORD = new System.Windows.Forms.CheckBox();
            this.BUTTON_CRIAR_CONTA = new System.Windows.Forms.Button();
            this.BUTTON_REMOVER_CONTA = new System.Windows.Forms.Button();
            this.BUTTON_GRAVAR_ALTERACOES = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TEXTBOX_PASSWORD
            // 
            this.TEXTBOX_PASSWORD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TEXTBOX_PASSWORD.Location = new System.Drawing.Point(158, 118);
            this.TEXTBOX_PASSWORD.Name = "TEXTBOX_PASSWORD";
            this.TEXTBOX_PASSWORD.Size = new System.Drawing.Size(79, 20);
            this.TEXTBOX_PASSWORD.TabIndex = 33;
            this.TEXTBOX_PASSWORD.UseSystemPasswordChar = true;
            // 
            // LABEL_PASSWORD
            // 
            this.LABEL_PASSWORD.AutoSize = true;
            this.LABEL_PASSWORD.Location = new System.Drawing.Point(155, 102);
            this.LABEL_PASSWORD.Name = "LABEL_PASSWORD";
            this.LABEL_PASSWORD.Size = new System.Drawing.Size(53, 13);
            this.LABEL_PASSWORD.TabIndex = 32;
            this.LABEL_PASSWORD.Text = "Password";
            // 
            // TEXTBOX_PORTA
            // 
            this.TEXTBOX_PORTA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TEXTBOX_PORTA.Location = new System.Drawing.Point(280, 118);
            this.TEXTBOX_PORTA.Name = "TEXTBOX_PORTA";
            this.TEXTBOX_PORTA.Size = new System.Drawing.Size(40, 20);
            this.TEXTBOX_PORTA.TabIndex = 31;
            // 
            // LABEL_PORTA
            // 
            this.LABEL_PORTA.AutoSize = true;
            this.LABEL_PORTA.Location = new System.Drawing.Point(277, 102);
            this.LABEL_PORTA.Name = "LABEL_PORTA";
            this.LABEL_PORTA.Size = new System.Drawing.Size(32, 13);
            this.LABEL_PORTA.TabIndex = 30;
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
            this.TEXTBOX_IP.Location = new System.Drawing.Point(158, 71);
            this.TEXTBOX_IP.Name = "TEXTBOX_IP";
            this.TEXTBOX_IP.Size = new System.Drawing.Size(95, 20);
            this.TEXTBOX_IP.TabIndex = 27;
            // 
            // LABEL_IP
            // 
            this.LABEL_IP.AutoSize = true;
            this.LABEL_IP.Location = new System.Drawing.Point(155, 55);
            this.LABEL_IP.Name = "LABEL_IP";
            this.LABEL_IP.Size = new System.Drawing.Size(83, 13);
            this.LABEL_IP.TabIndex = 26;
            this.LABEL_IP.Text = "IP ou Hostname";
            // 
            // TEXTBOX_USERNAME
            // 
            this.TEXTBOX_USERNAME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TEXTBOX_USERNAME.Location = new System.Drawing.Point(211, 25);
            this.TEXTBOX_USERNAME.Name = "TEXTBOX_USERNAME";
            this.TEXTBOX_USERNAME.Size = new System.Drawing.Size(109, 20);
            this.TEXTBOX_USERNAME.TabIndex = 25;
            // 
            // LABEL_USERNAME
            // 
            this.LABEL_USERNAME.AutoSize = true;
            this.LABEL_USERNAME.Location = new System.Drawing.Point(208, 9);
            this.LABEL_USERNAME.Name = "LABEL_USERNAME";
            this.LABEL_USERNAME.Size = new System.Drawing.Size(55, 13);
            this.LABEL_USERNAME.TabIndex = 24;
            this.LABEL_USERNAME.Text = "Username";
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
            this.LISTVIEW_CONTAS.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.HDR_NOME});
            this.LISTVIEW_CONTAS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LISTVIEW_CONTAS.FullRowSelect = true;
            this.LISTVIEW_CONTAS.Location = new System.Drawing.Point(3, 3);
            this.LISTVIEW_CONTAS.MultiSelect = false;
            this.LISTVIEW_CONTAS.Name = "LISTVIEW_CONTAS";
            this.LISTVIEW_CONTAS.Size = new System.Drawing.Size(146, 226);
            this.LISTVIEW_CONTAS.TabIndex = 21;
            this.LISTVIEW_CONTAS.UseCompatibleStateImageBehavior = false;
            this.LISTVIEW_CONTAS.View = System.Windows.Forms.View.Details;
            this.LISTVIEW_CONTAS.SelectedIndexChanged += new System.EventHandler(this.LISTVIEW_CONTAS_SelectedIndexChanged);
            // 
            // HDR_NOME
            // 
            this.HDR_NOME.Text = "Nome";
            this.HDR_NOME.Width = 140;
            // 
            // CHECKBOX_PASSWORD
            // 
            this.CHECKBOX_PASSWORD.AutoSize = true;
            this.CHECKBOX_PASSWORD.Image = global::Windows.TVTuga.Admin.Properties.Resources.eye_watch__Custom___2_;
            this.CHECKBOX_PASSWORD.Location = new System.Drawing.Point(239, 119);
            this.CHECKBOX_PASSWORD.Name = "CHECKBOX_PASSWORD";
            this.CHECKBOX_PASSWORD.Size = new System.Drawing.Size(35, 20);
            this.CHECKBOX_PASSWORD.TabIndex = 34;
            this.CHECKBOX_PASSWORD.UseVisualStyleBackColor = true;
            this.CHECKBOX_PASSWORD.CheckedChanged += new System.EventHandler(this.CHECKBOX_PASSWORD_CheckedChanged);
            // 
            // BUTTON_CRIAR_CONTA
            // 
            this.BUTTON_CRIAR_CONTA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BUTTON_CRIAR_CONTA.Image = global::Windows.TVTuga.Admin.Properties.Resources.Add__Custom___5_;
            this.BUTTON_CRIAR_CONTA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BUTTON_CRIAR_CONTA.Location = new System.Drawing.Point(158, 148);
            this.BUTTON_CRIAR_CONTA.Name = "BUTTON_CRIAR_CONTA";
            this.BUTTON_CRIAR_CONTA.Size = new System.Drawing.Size(89, 23);
            this.BUTTON_CRIAR_CONTA.TabIndex = 35;
            this.BUTTON_CRIAR_CONTA.Text = "Criar Conta";
            this.BUTTON_CRIAR_CONTA.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BUTTON_CRIAR_CONTA.UseVisualStyleBackColor = true;
            this.BUTTON_CRIAR_CONTA.Click += new System.EventHandler(this.BUTTON_CRIAR_CONTA_Click);
            // 
            // BUTTON_REMOVER_CONTA
            // 
            this.BUTTON_REMOVER_CONTA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BUTTON_REMOVER_CONTA.Image = global::Windows.TVTuga.Admin.Properties.Resources.Delete__Custom___2_;
            this.BUTTON_REMOVER_CONTA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BUTTON_REMOVER_CONTA.Location = new System.Drawing.Point(158, 177);
            this.BUTTON_REMOVER_CONTA.Name = "BUTTON_REMOVER_CONTA";
            this.BUTTON_REMOVER_CONTA.Size = new System.Drawing.Size(107, 23);
            this.BUTTON_REMOVER_CONTA.TabIndex = 38;
            this.BUTTON_REMOVER_CONTA.Text = "Remover Conta";
            this.BUTTON_REMOVER_CONTA.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BUTTON_REMOVER_CONTA.UseVisualStyleBackColor = true;
            this.BUTTON_REMOVER_CONTA.Click += new System.EventHandler(this.BUTTON_REMOVER_CONTA_Click);
            // 
            // BUTTON_GRAVAR_ALTERACOES
            // 
            this.BUTTON_GRAVAR_ALTERACOES.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BUTTON_GRAVAR_ALTERACOES.Image = global::Windows.TVTuga.Admin.Properties.Resources.document_save__Custom_;
            this.BUTTON_GRAVAR_ALTERACOES.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BUTTON_GRAVAR_ALTERACOES.Location = new System.Drawing.Point(158, 206);
            this.BUTTON_GRAVAR_ALTERACOES.Name = "BUTTON_GRAVAR_ALTERACOES";
            this.BUTTON_GRAVAR_ALTERACOES.Size = new System.Drawing.Size(124, 23);
            this.BUTTON_GRAVAR_ALTERACOES.TabIndex = 54;
            this.BUTTON_GRAVAR_ALTERACOES.Text = "Gravar Alterações";
            this.BUTTON_GRAVAR_ALTERACOES.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BUTTON_GRAVAR_ALTERACOES.UseVisualStyleBackColor = true;
            this.BUTTON_GRAVAR_ALTERACOES.Click += new System.EventHandler(this.BUTTON_GRAVAR_ALTERACOES_Click);
            // 
            // PNL_OPCOES_BD_CONTAS
            // 
            this.ClientSize = new System.Drawing.Size(325, 233);
            this.Controls.Add(this.BUTTON_GRAVAR_ALTERACOES);
            this.Controls.Add(this.BUTTON_REMOVER_CONTA);
            this.Controls.Add(this.BUTTON_CRIAR_CONTA);
            this.Controls.Add(this.CHECKBOX_PASSWORD);
            this.Controls.Add(this.TEXTBOX_PASSWORD);
            this.Controls.Add(this.LABEL_PASSWORD);
            this.Controls.Add(this.TEXTBOX_PORTA);
            this.Controls.Add(this.LABEL_PORTA);
            this.Controls.Add(this.COMBOBOX_PROTOCOLO);
            this.Controls.Add(this.LABEL_PROTOCOLO);
            this.Controls.Add(this.TEXTBOX_IP);
            this.Controls.Add(this.LABEL_IP);
            this.Controls.Add(this.TEXTBOX_USERNAME);
            this.Controls.Add(this.LABEL_USERNAME);
            this.Controls.Add(this.TEXTBOX_ID);
            this.Controls.Add(this.LABEL_ID);
            this.Controls.Add(this.LISTVIEW_CONTAS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PNL_OPCOES_BD_CONTAS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox CHECKBOX_PASSWORD;
        private System.Windows.Forms.TextBox TEXTBOX_PASSWORD;
        private System.Windows.Forms.Label LABEL_PASSWORD;
        private System.Windows.Forms.TextBox TEXTBOX_PORTA;
        private System.Windows.Forms.Label LABEL_PORTA;
        private System.Windows.Forms.ComboBox COMBOBOX_PROTOCOLO;
        private System.Windows.Forms.Label LABEL_PROTOCOLO;
        private System.Windows.Forms.TextBox TEXTBOX_IP;
        private System.Windows.Forms.Label LABEL_IP;
        private System.Windows.Forms.TextBox TEXTBOX_USERNAME;
        private System.Windows.Forms.Label LABEL_USERNAME;
        private System.Windows.Forms.TextBox TEXTBOX_ID;
        private System.Windows.Forms.Label LABEL_ID;
        private System.Windows.Forms.ListView LISTVIEW_CONTAS;
        private System.Windows.Forms.Button BUTTON_CRIAR_CONTA;
        private System.Windows.Forms.Button BUTTON_REMOVER_CONTA;
        private System.Windows.Forms.Button BUTTON_GRAVAR_ALTERACOES;
        private System.Windows.Forms.ColumnHeader HDR_NOME;
    }
}
