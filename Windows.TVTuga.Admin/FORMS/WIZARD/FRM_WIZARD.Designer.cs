namespace Windows.TVTuga.Admin.FORMS.WIZARD
{
    partial class FRM_WIZARD
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
            this.SPLITCONTAINER_WIZARD = new System.Windows.Forms.SplitContainer();
            this.BUTTON_FECHAR = new System.Windows.Forms.Button();
            this.BUTTON_ANTERIOR = new System.Windows.Forms.Button();
            this.BUTTON_SEGUINTE = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SPLITCONTAINER_WIZARD)).BeginInit();
            this.SPLITCONTAINER_WIZARD.Panel1.SuspendLayout();
            this.SPLITCONTAINER_WIZARD.SuspendLayout();
            this.SuspendLayout();
            // 
            // SPLITCONTAINER_WIZARD
            // 
            this.SPLITCONTAINER_WIZARD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SPLITCONTAINER_WIZARD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SPLITCONTAINER_WIZARD.IsSplitterFixed = true;
            this.SPLITCONTAINER_WIZARD.Location = new System.Drawing.Point(0, 0);
            this.SPLITCONTAINER_WIZARD.Name = "SPLITCONTAINER_WIZARD";
            this.SPLITCONTAINER_WIZARD.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // SPLITCONTAINER_WIZARD.Panel1
            // 
            this.SPLITCONTAINER_WIZARD.Panel1.Controls.Add(this.BUTTON_FECHAR);
            this.SPLITCONTAINER_WIZARD.Panel1.Controls.Add(this.BUTTON_ANTERIOR);
            this.SPLITCONTAINER_WIZARD.Panel1.Controls.Add(this.BUTTON_SEGUINTE);
            this.SPLITCONTAINER_WIZARD.Size = new System.Drawing.Size(334, 232);
            this.SPLITCONTAINER_WIZARD.SplitterDistance = 55;
            this.SPLITCONTAINER_WIZARD.TabIndex = 0;
            // 
            // BUTTON_FECHAR
            // 
            this.BUTTON_FECHAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BUTTON_FECHAR.Image = global::Windows.TVTuga.Admin.Properties.Resources.Delete__Custom_;
            this.BUTTON_FECHAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BUTTON_FECHAR.Location = new System.Drawing.Point(1, 1);
            this.BUTTON_FECHAR.Name = "BUTTON_FECHAR";
            this.BUTTON_FECHAR.Size = new System.Drawing.Size(64, 51);
            this.BUTTON_FECHAR.TabIndex = 17;
            this.BUTTON_FECHAR.Text = "Fechar";
            this.BUTTON_FECHAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BUTTON_FECHAR.UseVisualStyleBackColor = true;
            // 
            // BUTTON_ANTERIOR
            // 
            this.BUTTON_ANTERIOR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BUTTON_ANTERIOR.Enabled = false;
            this.BUTTON_ANTERIOR.Image = global::Windows.TVTuga.Admin.Properties.Resources.Previous__Custom_;
            this.BUTTON_ANTERIOR.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BUTTON_ANTERIOR.Location = new System.Drawing.Point(203, 1);
            this.BUTTON_ANTERIOR.Name = "BUTTON_ANTERIOR";
            this.BUTTON_ANTERIOR.Size = new System.Drawing.Size(64, 51);
            this.BUTTON_ANTERIOR.TabIndex = 16;
            this.BUTTON_ANTERIOR.Text = "Anterior";
            this.BUTTON_ANTERIOR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BUTTON_ANTERIOR.UseVisualStyleBackColor = true;
            this.BUTTON_ANTERIOR.Click += new System.EventHandler(this.BUTTON_ANTERIOR_Click);
            // 
            // BUTTON_SEGUINTE
            // 
            this.BUTTON_SEGUINTE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BUTTON_SEGUINTE.Enabled = false;
            this.BUTTON_SEGUINTE.Image = global::Windows.TVTuga.Admin.Properties.Resources.Next_icon__Custom_;
            this.BUTTON_SEGUINTE.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BUTTON_SEGUINTE.Location = new System.Drawing.Point(267, 1);
            this.BUTTON_SEGUINTE.Name = "BUTTON_SEGUINTE";
            this.BUTTON_SEGUINTE.Size = new System.Drawing.Size(64, 51);
            this.BUTTON_SEGUINTE.TabIndex = 15;
            this.BUTTON_SEGUINTE.Text = "Seguinte";
            this.BUTTON_SEGUINTE.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BUTTON_SEGUINTE.UseVisualStyleBackColor = true;
            this.BUTTON_SEGUINTE.Click += new System.EventHandler(this.BUTTON_SEGUINTE_Click);
            // 
            // FRM_WIZARD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 232);
            this.Controls.Add(this.SPLITCONTAINER_WIZARD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_WIZARD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TVTuga Admin Wizard";
            this.Load += new System.EventHandler(this.FRM_WIZARD_Load);
            this.SPLITCONTAINER_WIZARD.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SPLITCONTAINER_WIZARD)).EndInit();
            this.SPLITCONTAINER_WIZARD.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer SPLITCONTAINER_WIZARD;
        public System.Windows.Forms.Button BUTTON_SEGUINTE;
        private System.Windows.Forms.Button BUTTON_FECHAR;
        public System.Windows.Forms.Button BUTTON_ANTERIOR;
    }
}