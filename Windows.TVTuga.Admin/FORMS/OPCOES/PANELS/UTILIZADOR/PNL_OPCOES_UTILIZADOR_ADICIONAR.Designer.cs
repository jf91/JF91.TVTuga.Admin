namespace Windows.TVTuga.Admin.FORMS.OPCOES.PANELS.UTILIZADOR
{
    partial class PNL_OPCOES_UTILIZADOR_ADICIONAR
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
            this.BUTTON_CRIAR_CONTA = new System.Windows.Forms.Button();
            this.TEXTBOX_USERNAME = new System.Windows.Forms.TextBox();
            this.LABEL_USERNAME = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BUTTON_CRIAR_CONTA
            // 
            this.BUTTON_CRIAR_CONTA.Image = global::Windows.TVTuga.Admin.Properties.Resources.Yes_check__Custom___2_;
            this.BUTTON_CRIAR_CONTA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BUTTON_CRIAR_CONTA.Location = new System.Drawing.Point(114, 75);
            this.BUTTON_CRIAR_CONTA.Name = "BUTTON_CRIAR_CONTA";
            this.BUTTON_CRIAR_CONTA.Size = new System.Drawing.Size(89, 23);
            this.BUTTON_CRIAR_CONTA.TabIndex = 6;
            this.BUTTON_CRIAR_CONTA.Text = "Criar Conta";
            this.BUTTON_CRIAR_CONTA.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BUTTON_CRIAR_CONTA.UseVisualStyleBackColor = true;
            this.BUTTON_CRIAR_CONTA.Click += new System.EventHandler(this.BUTTON_CRIAR_CONTA_Click);
            // 
            // TEXTBOX_USERNAME
            // 
            this.TEXTBOX_USERNAME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TEXTBOX_USERNAME.Location = new System.Drawing.Point(98, 33);
            this.TEXTBOX_USERNAME.Name = "TEXTBOX_USERNAME";
            this.TEXTBOX_USERNAME.Size = new System.Drawing.Size(172, 20);
            this.TEXTBOX_USERNAME.TabIndex = 3;
            // 
            // LABEL_USERNAME
            // 
            this.LABEL_USERNAME.AutoSize = true;
            this.LABEL_USERNAME.Location = new System.Drawing.Point(28, 37);
            this.LABEL_USERNAME.Name = "LABEL_USERNAME";
            this.LABEL_USERNAME.Size = new System.Drawing.Size(55, 13);
            this.LABEL_USERNAME.TabIndex = 2;
            this.LABEL_USERNAME.Text = "Username";
            // 
            // PNL_OPCOES_UTILIZADOR_ADICIONAR
            // 
            this.ClientSize = new System.Drawing.Size(325, 233);
            this.Controls.Add(this.BUTTON_CRIAR_CONTA);
            this.Controls.Add(this.TEXTBOX_USERNAME);
            this.Controls.Add(this.LABEL_USERNAME);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PNL_OPCOES_UTILIZADOR_ADICIONAR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TEXTBOX_USERNAME;
        private System.Windows.Forms.Label LABEL_USERNAME;
        private System.Windows.Forms.Button BUTTON_CRIAR_CONTA;
    }
}
