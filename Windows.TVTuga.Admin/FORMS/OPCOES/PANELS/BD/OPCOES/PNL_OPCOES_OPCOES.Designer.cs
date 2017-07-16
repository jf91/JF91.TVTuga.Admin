namespace Windows.TVTuga.Admin.FORMS.OPCOES.PANELS.BD.OPCOES
{
    partial class PNL_OPCOES_OPCOES
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BUTTON_GRAVAR_ALTERACOES = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Connection String";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(298, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(15, 114);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(298, 20);
            this.textBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Connection String [Stored Procedures]";
            // 
            // BUTTON_GRAVAR_ALTERACOES
            // 
            this.BUTTON_GRAVAR_ALTERACOES.Image = global::Windows.TVTuga.Admin.Properties.Resources.document_save__Custom_;
            this.BUTTON_GRAVAR_ALTERACOES.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BUTTON_GRAVAR_ALTERACOES.Location = new System.Drawing.Point(97, 164);
            this.BUTTON_GRAVAR_ALTERACOES.Name = "BUTTON_GRAVAR_ALTERACOES";
            this.BUTTON_GRAVAR_ALTERACOES.Size = new System.Drawing.Size(124, 23);
            this.BUTTON_GRAVAR_ALTERACOES.TabIndex = 54;
            this.BUTTON_GRAVAR_ALTERACOES.Text = "Gravar Alterações";
            this.BUTTON_GRAVAR_ALTERACOES.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BUTTON_GRAVAR_ALTERACOES.UseVisualStyleBackColor = true;
            // 
            // PNL_OPCOES_OPCOES
            // 
            this.ClientSize = new System.Drawing.Size(325, 233);
            this.Controls.Add(this.BUTTON_GRAVAR_ALTERACOES);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PNL_OPCOES_OPCOES";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BUTTON_GRAVAR_ALTERACOES;
    }
}
