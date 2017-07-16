namespace Windows.TVTuga.Admin.FORMS.WIZARD.PANELS
{
    partial class PNL_WIZARD_01
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
            this.LABEL_ID_UTILIZADOR = new System.Windows.Forms.Label();
            this.TEXTBOX_ID_UTILIZADOR = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LABEL_ID_UTILIZADOR
            // 
            this.LABEL_ID_UTILIZADOR.AutoSize = true;
            this.LABEL_ID_UTILIZADOR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL_ID_UTILIZADOR.Location = new System.Drawing.Point(-2, 50);
            this.LABEL_ID_UTILIZADOR.Name = "LABEL_ID_UTILIZADOR";
            this.LABEL_ID_UTILIZADOR.Size = new System.Drawing.Size(336, 15);
            this.LABEL_ID_UTILIZADOR.TabIndex = 3;
            this.LABEL_ID_UTILIZADOR.Text = "Introduza o seu ID de utilizador fornecido pelo Administrador";
            // 
            // TEXTBOX_ID_UTILIZADOR
            // 
            this.TEXTBOX_ID_UTILIZADOR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TEXTBOX_ID_UTILIZADOR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TEXTBOX_ID_UTILIZADOR.Location = new System.Drawing.Point(137, 81);
            this.TEXTBOX_ID_UTILIZADOR.Name = "TEXTBOX_ID_UTILIZADOR";
            this.TEXTBOX_ID_UTILIZADOR.Size = new System.Drawing.Size(51, 22);
            this.TEXTBOX_ID_UTILIZADOR.TabIndex = 2;
            this.TEXTBOX_ID_UTILIZADOR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TEXTBOX_ID_UTILIZADOR.TextChanged += new System.EventHandler(this.TEXTBOX_ID_UTILIZADOR_TextChanged);
            // 
            // PNL_WIZARD_01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(332, 173);
            this.Controls.Add(this.LABEL_ID_UTILIZADOR);
            this.Controls.Add(this.TEXTBOX_ID_UTILIZADOR);
            this.Name = "PNL_WIZARD_01";
            this.Load += new System.EventHandler(this.PNL_WIZARD_01_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label LABEL_ID_UTILIZADOR;
        public System.Windows.Forms.TextBox TEXTBOX_ID_UTILIZADOR;
    }
}
