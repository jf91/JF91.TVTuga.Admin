namespace Windows.TVTuga.Admin.FORMS.WIZARD.PANELS
{
    partial class PNL_WIZARD_02
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
            this.TEXTBOX_USERNAME = new System.Windows.Forms.TextBox();
            this.LABEL_USERNAME = new System.Windows.Forms.Label();
            this.TEXTBOX_NOME = new System.Windows.Forms.TextBox();
            this.LABEL_NOME = new System.Windows.Forms.Label();
            this.LABEL_ID_COMPLETAR_INFORMACAO = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TEXTBOX_PASSWORD
            // 
            this.TEXTBOX_PASSWORD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TEXTBOX_PASSWORD.Location = new System.Drawing.Point(103, 122);
            this.TEXTBOX_PASSWORD.Name = "TEXTBOX_PASSWORD";
            this.TEXTBOX_PASSWORD.Size = new System.Drawing.Size(172, 20);
            this.TEXTBOX_PASSWORD.TabIndex = 11;
            this.TEXTBOX_PASSWORD.TextChanged += new System.EventHandler(this.TEXTBOX_PASSWORD_TextChanged);
            // 
            // LABEL_PASSWORD
            // 
            this.LABEL_PASSWORD.AutoSize = true;
            this.LABEL_PASSWORD.Location = new System.Drawing.Point(35, 126);
            this.LABEL_PASSWORD.Name = "LABEL_PASSWORD";
            this.LABEL_PASSWORD.Size = new System.Drawing.Size(53, 13);
            this.LABEL_PASSWORD.TabIndex = 10;
            this.LABEL_PASSWORD.Text = "Password";
            // 
            // TEXTBOX_USERNAME
            // 
            this.TEXTBOX_USERNAME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TEXTBOX_USERNAME.Location = new System.Drawing.Point(103, 80);
            this.TEXTBOX_USERNAME.Name = "TEXTBOX_USERNAME";
            this.TEXTBOX_USERNAME.Size = new System.Drawing.Size(172, 20);
            this.TEXTBOX_USERNAME.TabIndex = 9;
            this.TEXTBOX_USERNAME.TextChanged += new System.EventHandler(this.TEXTBOX_USERNAME_TextChanged);
            // 
            // LABEL_USERNAME
            // 
            this.LABEL_USERNAME.AutoSize = true;
            this.LABEL_USERNAME.Location = new System.Drawing.Point(33, 84);
            this.LABEL_USERNAME.Name = "LABEL_USERNAME";
            this.LABEL_USERNAME.Size = new System.Drawing.Size(55, 13);
            this.LABEL_USERNAME.TabIndex = 8;
            this.LABEL_USERNAME.Text = "Username";
            // 
            // TEXTBOX_NOME
            // 
            this.TEXTBOX_NOME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TEXTBOX_NOME.Location = new System.Drawing.Point(103, 41);
            this.TEXTBOX_NOME.Name = "TEXTBOX_NOME";
            this.TEXTBOX_NOME.Size = new System.Drawing.Size(172, 20);
            this.TEXTBOX_NOME.TabIndex = 7;
            this.TEXTBOX_NOME.TextChanged += new System.EventHandler(this.TEXTBOX_NOME_TextChanged);
            // 
            // LABEL_NOME
            // 
            this.LABEL_NOME.AutoSize = true;
            this.LABEL_NOME.Location = new System.Drawing.Point(53, 45);
            this.LABEL_NOME.Name = "LABEL_NOME";
            this.LABEL_NOME.Size = new System.Drawing.Size(35, 13);
            this.LABEL_NOME.TabIndex = 6;
            this.LABEL_NOME.Text = "Nome";
            // 
            // LABEL_ID_COMPLETAR_INFORMACAO
            // 
            this.LABEL_ID_COMPLETAR_INFORMACAO.AutoSize = true;
            this.LABEL_ID_COMPLETAR_INFORMACAO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL_ID_COMPLETAR_INFORMACAO.Location = new System.Drawing.Point(81, 9);
            this.LABEL_ID_COMPLETAR_INFORMACAO.Name = "LABEL_ID_COMPLETAR_INFORMACAO";
            this.LABEL_ID_COMPLETAR_INFORMACAO.Size = new System.Drawing.Size(158, 15);
            this.LABEL_ID_COMPLETAR_INFORMACAO.TabIndex = 12;
            this.LABEL_ID_COMPLETAR_INFORMACAO.Text = "Complete a sua informação";
            // 
            // PNL_WIZARD_02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(332, 173);
            this.Controls.Add(this.LABEL_ID_COMPLETAR_INFORMACAO);
            this.Controls.Add(this.TEXTBOX_PASSWORD);
            this.Controls.Add(this.LABEL_PASSWORD);
            this.Controls.Add(this.TEXTBOX_USERNAME);
            this.Controls.Add(this.LABEL_USERNAME);
            this.Controls.Add(this.TEXTBOX_NOME);
            this.Controls.Add(this.LABEL_NOME);
            this.Name = "PNL_WIZARD_02";
            this.Load += new System.EventHandler(this.PNL_WIZARD_02_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TEXTBOX_PASSWORD;
        private System.Windows.Forms.Label LABEL_PASSWORD;
        private System.Windows.Forms.TextBox TEXTBOX_USERNAME;
        private System.Windows.Forms.Label LABEL_USERNAME;
        private System.Windows.Forms.TextBox TEXTBOX_NOME;
        private System.Windows.Forms.Label LABEL_NOME;
        private System.Windows.Forms.Label LABEL_ID_COMPLETAR_INFORMACAO;
    }
}
