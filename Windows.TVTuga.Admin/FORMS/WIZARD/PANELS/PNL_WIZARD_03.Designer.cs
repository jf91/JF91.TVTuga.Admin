namespace Windows.TVTuga.Admin.FORMS.WIZARD.PANELS
{
    partial class PNL_WIZARD_03
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
            this.LABEL_SERVER = new System.Windows.Forms.Label();
            this.CHECKBOX_SIM = new System.Windows.Forms.CheckBox();
            this.TEXTBOX_NOVO_ENDERECO = new System.Windows.Forms.TextBox();
            this.LABEL_NOVO_ENDERECO = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LABEL_SERVER
            // 
            this.LABEL_SERVER.AutoSize = true;
            this.LABEL_SERVER.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL_SERVER.Location = new System.Drawing.Point(30, 26);
            this.LABEL_SERVER.Name = "LABEL_SERVER";
            this.LABEL_SERVER.Size = new System.Drawing.Size(216, 15);
            this.LABEL_SERVER.TabIndex = 4;
            this.LABEL_SERVER.Text = "Pretende usar o servidor pré-definido?";
            // 
            // CHECKBOX_SIM
            // 
            this.CHECKBOX_SIM.AutoSize = true;
            this.CHECKBOX_SIM.Checked = true;
            this.CHECKBOX_SIM.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CHECKBOX_SIM.Location = new System.Drawing.Point(253, 26);
            this.CHECKBOX_SIM.Name = "CHECKBOX_SIM";
            this.CHECKBOX_SIM.Size = new System.Drawing.Size(43, 17);
            this.CHECKBOX_SIM.TabIndex = 5;
            this.CHECKBOX_SIM.Text = "Sim";
            this.CHECKBOX_SIM.UseVisualStyleBackColor = true;
            this.CHECKBOX_SIM.CheckedChanged += new System.EventHandler(this.CHECKBOX_SIM_CheckedChanged);
            // 
            // TEXTBOX_NOVO_ENDERECO
            // 
            this.TEXTBOX_NOVO_ENDERECO.Location = new System.Drawing.Point(127, 48);
            this.TEXTBOX_NOVO_ENDERECO.Name = "TEXTBOX_NOVO_ENDERECO";
            this.TEXTBOX_NOVO_ENDERECO.Size = new System.Drawing.Size(119, 20);
            this.TEXTBOX_NOVO_ENDERECO.TabIndex = 6;
            this.TEXTBOX_NOVO_ENDERECO.Visible = false;
            this.TEXTBOX_NOVO_ENDERECO.TextChanged += new System.EventHandler(this.TEXTBOX_NOVO_ENDERECO_TextChanged);
            // 
            // LABEL_NOVO_ENDERECO
            // 
            this.LABEL_NOVO_ENDERECO.AutoSize = true;
            this.LABEL_NOVO_ENDERECO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL_NOVO_ENDERECO.Location = new System.Drawing.Point(30, 49);
            this.LABEL_NOVO_ENDERECO.Name = "LABEL_NOVO_ENDERECO";
            this.LABEL_NOVO_ENDERECO.Size = new System.Drawing.Size(91, 15);
            this.LABEL_NOVO_ENDERECO.TabIndex = 7;
            this.LABEL_NOVO_ENDERECO.Text = "Novo Endereço";
            this.LABEL_NOVO_ENDERECO.Visible = false;
            // 
            // PNL_WIZARD_03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(332, 173);
            this.Controls.Add(this.LABEL_NOVO_ENDERECO);
            this.Controls.Add(this.TEXTBOX_NOVO_ENDERECO);
            this.Controls.Add(this.CHECKBOX_SIM);
            this.Controls.Add(this.LABEL_SERVER);
            this.Name = "PNL_WIZARD_03";
            this.Load += new System.EventHandler(this.PNL_WIZARD_03_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label LABEL_SERVER;
        private System.Windows.Forms.CheckBox CHECKBOX_SIM;
        private System.Windows.Forms.TextBox TEXTBOX_NOVO_ENDERECO;
        public System.Windows.Forms.Label LABEL_NOVO_ENDERECO;
    }
}
