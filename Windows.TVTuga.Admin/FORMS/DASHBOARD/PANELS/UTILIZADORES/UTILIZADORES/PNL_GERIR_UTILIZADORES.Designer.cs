namespace Windows.TVTuga.Admin.FORMS.DASHBOARD.PANELS.UTILIZADORES.UTILIZADORES
{
    partial class PNL_GERIR_UTILIZADORES
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
            this.SPLITCONTAINER_GERIR_UTILIZADORES = new System.Windows.Forms.SplitContainer();
            this.BUTTON_ACTUALIZAR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SPLITCONTAINER_GERIR_UTILIZADORES)).BeginInit();
            this.SPLITCONTAINER_GERIR_UTILIZADORES.Panel1.SuspendLayout();
            this.SPLITCONTAINER_GERIR_UTILIZADORES.SuspendLayout();
            this.SuspendLayout();
            // 
            // SPLITCONTAINER_GERIR_UTILIZADORES
            // 
            this.SPLITCONTAINER_GERIR_UTILIZADORES.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SPLITCONTAINER_GERIR_UTILIZADORES.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SPLITCONTAINER_GERIR_UTILIZADORES.Location = new System.Drawing.Point(0, 0);
            this.SPLITCONTAINER_GERIR_UTILIZADORES.Margin = new System.Windows.Forms.Padding(0);
            this.SPLITCONTAINER_GERIR_UTILIZADORES.Name = "SPLITCONTAINER_GERIR_UTILIZADORES";
            // 
            // SPLITCONTAINER_GERIR_UTILIZADORES.Panel1
            // 
            this.SPLITCONTAINER_GERIR_UTILIZADORES.Panel1.Controls.Add(this.BUTTON_ACTUALIZAR);
            this.SPLITCONTAINER_GERIR_UTILIZADORES.Size = new System.Drawing.Size(1001, 512);
            this.SPLITCONTAINER_GERIR_UTILIZADORES.SplitterDistance = 145;
            this.SPLITCONTAINER_GERIR_UTILIZADORES.SplitterWidth = 1;
            this.SPLITCONTAINER_GERIR_UTILIZADORES.TabIndex = 2;
            // 
            // BUTTON_ACTUALIZAR
            // 
            this.BUTTON_ACTUALIZAR.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BUTTON_ACTUALIZAR.Image = global::Windows.TVTuga.Admin.Properties.Resources.refresh_000000_501;
            this.BUTTON_ACTUALIZAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BUTTON_ACTUALIZAR.Location = new System.Drawing.Point(3, 3);
            this.BUTTON_ACTUALIZAR.Name = "BUTTON_ACTUALIZAR";
            this.BUTTON_ACTUALIZAR.Size = new System.Drawing.Size(137, 86);
            this.BUTTON_ACTUALIZAR.TabIndex = 5;
            this.BUTTON_ACTUALIZAR.Text = "Actualizar";
            this.BUTTON_ACTUALIZAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BUTTON_ACTUALIZAR.UseVisualStyleBackColor = true;
            // 
            // PNL_GERIR_UTILIZADORES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1001, 512);
            this.Controls.Add(this.SPLITCONTAINER_GERIR_UTILIZADORES);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PNL_GERIR_UTILIZADORES";
            this.Text = "PNL_UTILIZADORES_LISTAGEM";
            this.Load += new System.EventHandler(this.PNL_GERIR_UTILIZADORES_Load);
            this.SPLITCONTAINER_GERIR_UTILIZADORES.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SPLITCONTAINER_GERIR_UTILIZADORES)).EndInit();
            this.SPLITCONTAINER_GERIR_UTILIZADORES.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer SPLITCONTAINER_GERIR_UTILIZADORES;
        private System.Windows.Forms.Button BUTTON_ACTUALIZAR;
    }
}