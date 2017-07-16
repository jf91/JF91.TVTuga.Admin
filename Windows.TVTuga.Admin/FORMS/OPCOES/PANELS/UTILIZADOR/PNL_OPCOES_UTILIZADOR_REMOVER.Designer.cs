namespace Windows.TVTuga.Admin.FORMS.OPCOES.PANELS.UTILIZADOR
{
    partial class PNL_OPCOES_UTILIZADOR_REMOVER
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
            this.TEXTBOX_USERNAME = new System.Windows.Forms.TextBox();
            this.LABEL_USERNAME = new System.Windows.Forms.Label();
            this.TEXTBOX_NOME = new System.Windows.Forms.TextBox();
            this.LABEL_NOME = new System.Windows.Forms.Label();
            this.TEXTBOX_ID = new System.Windows.Forms.TextBox();
            this.LABEL_ID = new System.Windows.Forms.Label();
            this.LISTVIEW_CONTAS = new System.Windows.Forms.ListView();
            this.BUTTON_REMOVER_CONTA = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TEXTBOX_USERNAME
            // 
            this.TEXTBOX_USERNAME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TEXTBOX_USERNAME.Location = new System.Drawing.Point(158, 140);
            this.TEXTBOX_USERNAME.Name = "TEXTBOX_USERNAME";
            this.TEXTBOX_USERNAME.ReadOnly = true;
            this.TEXTBOX_USERNAME.Size = new System.Drawing.Size(155, 20);
            this.TEXTBOX_USERNAME.TabIndex = 13;
            // 
            // LABEL_USERNAME
            // 
            this.LABEL_USERNAME.AutoSize = true;
            this.LABEL_USERNAME.Location = new System.Drawing.Point(155, 124);
            this.LABEL_USERNAME.Name = "LABEL_USERNAME";
            this.LABEL_USERNAME.Size = new System.Drawing.Size(55, 13);
            this.LABEL_USERNAME.TabIndex = 12;
            this.LABEL_USERNAME.Text = "Username";
            // 
            // TEXTBOX_NOME
            // 
            this.TEXTBOX_NOME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TEXTBOX_NOME.Location = new System.Drawing.Point(158, 81);
            this.TEXTBOX_NOME.Name = "TEXTBOX_NOME";
            this.TEXTBOX_NOME.ReadOnly = true;
            this.TEXTBOX_NOME.Size = new System.Drawing.Size(155, 20);
            this.TEXTBOX_NOME.TabIndex = 11;
            // 
            // LABEL_NOME
            // 
            this.LABEL_NOME.AutoSize = true;
            this.LABEL_NOME.Location = new System.Drawing.Point(155, 65);
            this.LABEL_NOME.Name = "LABEL_NOME";
            this.LABEL_NOME.Size = new System.Drawing.Size(35, 13);
            this.LABEL_NOME.TabIndex = 10;
            this.LABEL_NOME.Text = "Nome";
            // 
            // TEXTBOX_ID
            // 
            this.TEXTBOX_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TEXTBOX_ID.Location = new System.Drawing.Point(158, 25);
            this.TEXTBOX_ID.Name = "TEXTBOX_ID";
            this.TEXTBOX_ID.ReadOnly = true;
            this.TEXTBOX_ID.Size = new System.Drawing.Size(50, 20);
            this.TEXTBOX_ID.TabIndex = 9;
            // 
            // LABEL_ID
            // 
            this.LABEL_ID.AutoSize = true;
            this.LABEL_ID.Location = new System.Drawing.Point(155, 9);
            this.LABEL_ID.Name = "LABEL_ID";
            this.LABEL_ID.Size = new System.Drawing.Size(18, 13);
            this.LABEL_ID.TabIndex = 8;
            this.LABEL_ID.Text = "ID";
            // 
            // LISTVIEW_CONTAS
            // 
            this.LISTVIEW_CONTAS.Location = new System.Drawing.Point(3, 3);
            this.LISTVIEW_CONTAS.Name = "LISTVIEW_CONTAS";
            this.LISTVIEW_CONTAS.Size = new System.Drawing.Size(146, 226);
            this.LISTVIEW_CONTAS.TabIndex = 7;
            this.LISTVIEW_CONTAS.UseCompatibleStateImageBehavior = false;
            // 
            // BUTTON_REMOVER_CONTA
            // 
            this.BUTTON_REMOVER_CONTA.Image = global::Windows.TVTuga.Admin.Properties.Resources.Delete__Custom___2_;
            this.BUTTON_REMOVER_CONTA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BUTTON_REMOVER_CONTA.Location = new System.Drawing.Point(182, 180);
            this.BUTTON_REMOVER_CONTA.Name = "BUTTON_REMOVER_CONTA";
            this.BUTTON_REMOVER_CONTA.Size = new System.Drawing.Size(107, 23);
            this.BUTTON_REMOVER_CONTA.TabIndex = 14;
            this.BUTTON_REMOVER_CONTA.Text = "Remover Conta";
            this.BUTTON_REMOVER_CONTA.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BUTTON_REMOVER_CONTA.UseVisualStyleBackColor = true;
            // 
            // PNL_OPCOES_UTILIZADOR_REMOVER
            // 
            this.ClientSize = new System.Drawing.Size(325, 233);
            this.Controls.Add(this.BUTTON_REMOVER_CONTA);
            this.Controls.Add(this.TEXTBOX_USERNAME);
            this.Controls.Add(this.LABEL_USERNAME);
            this.Controls.Add(this.TEXTBOX_NOME);
            this.Controls.Add(this.LABEL_NOME);
            this.Controls.Add(this.TEXTBOX_ID);
            this.Controls.Add(this.LABEL_ID);
            this.Controls.Add(this.LISTVIEW_CONTAS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PNL_OPCOES_UTILIZADOR_REMOVER";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TEXTBOX_USERNAME;
        private System.Windows.Forms.Label LABEL_USERNAME;
        private System.Windows.Forms.TextBox TEXTBOX_NOME;
        private System.Windows.Forms.Label LABEL_NOME;
        private System.Windows.Forms.TextBox TEXTBOX_ID;
        private System.Windows.Forms.Label LABEL_ID;
        private System.Windows.Forms.ListView LISTVIEW_CONTAS;
        private System.Windows.Forms.Button BUTTON_REMOVER_CONTA;
    }
}
