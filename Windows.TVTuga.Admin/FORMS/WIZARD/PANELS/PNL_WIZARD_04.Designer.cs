namespace Windows.TVTuga.Admin.FORMS.WIZARD.PANELS
{
    partial class PNL_WIZARD_04
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
            this.LABEL_AGUARDE = new System.Windows.Forms.Label();
            this.PROGRESSBAR = new System.Windows.Forms.ProgressBar();
            this.COMPLETE = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.COMPLETE)).BeginInit();
            this.SuspendLayout();
            // 
            // LABEL_AGUARDE
            // 
            this.LABEL_AGUARDE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL_AGUARDE.Location = new System.Drawing.Point(12, 9);
            this.LABEL_AGUARDE.Name = "LABEL_AGUARDE";
            this.LABEL_AGUARDE.Size = new System.Drawing.Size(308, 65);
            this.LABEL_AGUARDE.TabIndex = 5;
            this.LABEL_AGUARDE.Text = "Aguarde enquanto a sua conta é configurada. Quando estiver concluido poderá inici" +
    "ar sessão com o Username e Password definidos.";
            // 
            // PROGRESSBAR
            // 
            this.PROGRESSBAR.Location = new System.Drawing.Point(15, 77);
            this.PROGRESSBAR.Name = "PROGRESSBAR";
            this.PROGRESSBAR.Size = new System.Drawing.Size(305, 23);
            this.PROGRESSBAR.TabIndex = 6;
            // 
            // COMPLETE
            // 
            this.COMPLETE.BackgroundImage = global::Windows.TVTuga.Admin.Properties.Resources.Icon_check;
            this.COMPLETE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.COMPLETE.Location = new System.Drawing.Point(130, 106);
            this.COMPLETE.Name = "COMPLETE";
            this.COMPLETE.Size = new System.Drawing.Size(71, 64);
            this.COMPLETE.TabIndex = 7;
            this.COMPLETE.TabStop = false;
            this.COMPLETE.Visible = false;
            // 
            // PNL_WIZARD_04
            // 
            this.ClientSize = new System.Drawing.Size(332, 173);
            this.Controls.Add(this.COMPLETE);
            this.Controls.Add(this.PROGRESSBAR);
            this.Controls.Add(this.LABEL_AGUARDE);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PNL_WIZARD_04";
            ((System.ComponentModel.ISupportInitialize)(this.COMPLETE)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label LABEL_AGUARDE;
        private System.Windows.Forms.ProgressBar PROGRESSBAR;
        private System.Windows.Forms.PictureBox COMPLETE;
    }
}
