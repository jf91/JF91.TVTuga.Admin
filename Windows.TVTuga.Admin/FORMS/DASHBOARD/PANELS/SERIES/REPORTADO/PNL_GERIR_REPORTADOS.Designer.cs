namespace Windows.TVTuga.Admin.FORMS.DASHBOARD.PANELS.SERIES.REPORTADO
{
    partial class PNL_GERIR_REPORTADOS
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
            this.SPLITCONTAINER_REPORTADOS = new System.Windows.Forms.SplitContainer();
            this.BUTTON_REPORTADOS_LISTAGEM = new System.Windows.Forms.Button();
            this.BUTTON_ACTUALIZAR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SPLITCONTAINER_REPORTADOS)).BeginInit();
            this.SPLITCONTAINER_REPORTADOS.Panel1.SuspendLayout();
            this.SPLITCONTAINER_REPORTADOS.SuspendLayout();
            this.SuspendLayout();
            // 
            // SPLITCONTAINER_REPORTADOS
            // 
            this.SPLITCONTAINER_REPORTADOS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SPLITCONTAINER_REPORTADOS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SPLITCONTAINER_REPORTADOS.Location = new System.Drawing.Point(0, 0);
            this.SPLITCONTAINER_REPORTADOS.Margin = new System.Windows.Forms.Padding(0);
            this.SPLITCONTAINER_REPORTADOS.Name = "SPLITCONTAINER_REPORTADOS";
            // 
            // SPLITCONTAINER_REPORTADOS.Panel1
            // 
            this.SPLITCONTAINER_REPORTADOS.Panel1.Controls.Add(this.BUTTON_REPORTADOS_LISTAGEM);
            this.SPLITCONTAINER_REPORTADOS.Panel1.Controls.Add(this.BUTTON_ACTUALIZAR);
            this.SPLITCONTAINER_REPORTADOS.Size = new System.Drawing.Size(1001, 512);
            this.SPLITCONTAINER_REPORTADOS.SplitterDistance = 145;
            this.SPLITCONTAINER_REPORTADOS.SplitterWidth = 1;
            this.SPLITCONTAINER_REPORTADOS.TabIndex = 4;
            // 
            // BUTTON_REPORTADOS_LISTAGEM
            // 
            this.BUTTON_REPORTADOS_LISTAGEM.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BUTTON_REPORTADOS_LISTAGEM.Image = global::Windows.TVTuga.Admin.Properties.Resources.bars_000000_50;
            this.BUTTON_REPORTADOS_LISTAGEM.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BUTTON_REPORTADOS_LISTAGEM.Location = new System.Drawing.Point(3, 3);
            this.BUTTON_REPORTADOS_LISTAGEM.Name = "BUTTON_REPORTADOS_LISTAGEM";
            this.BUTTON_REPORTADOS_LISTAGEM.Size = new System.Drawing.Size(137, 86);
            this.BUTTON_REPORTADOS_LISTAGEM.TabIndex = 6;
            this.BUTTON_REPORTADOS_LISTAGEM.Text = "Lista";
            this.BUTTON_REPORTADOS_LISTAGEM.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BUTTON_REPORTADOS_LISTAGEM.UseVisualStyleBackColor = true;
            this.BUTTON_REPORTADOS_LISTAGEM.Click += new System.EventHandler(this.BUTTON_REPORTADOS_LISTAGEM_Click);
            // 
            // BUTTON_ACTUALIZAR
            // 
            this.BUTTON_ACTUALIZAR.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BUTTON_ACTUALIZAR.Image = global::Windows.TVTuga.Admin.Properties.Resources.refresh_000000_501;
            this.BUTTON_ACTUALIZAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BUTTON_ACTUALIZAR.Location = new System.Drawing.Point(3, 421);
            this.BUTTON_ACTUALIZAR.Name = "BUTTON_ACTUALIZAR";
            this.BUTTON_ACTUALIZAR.Size = new System.Drawing.Size(137, 86);
            this.BUTTON_ACTUALIZAR.TabIndex = 5;
            this.BUTTON_ACTUALIZAR.Text = "Actualizar";
            this.BUTTON_ACTUALIZAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BUTTON_ACTUALIZAR.UseVisualStyleBackColor = true;
            // 
            // PNL_GERIR_REPORTADOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1001, 512);
            this.Controls.Add(this.SPLITCONTAINER_REPORTADOS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PNL_GERIR_REPORTADOS";
            this.Text = "PNL_GERIR_REPORTADOS";
            this.Load += new System.EventHandler(this.PNL_GERIR_REPORTADOS_Load);
            this.SPLITCONTAINER_REPORTADOS.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SPLITCONTAINER_REPORTADOS)).EndInit();
            this.SPLITCONTAINER_REPORTADOS.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer SPLITCONTAINER_REPORTADOS;
        private System.Windows.Forms.Button BUTTON_REPORTADOS_LISTAGEM;
        private System.Windows.Forms.Button BUTTON_ACTUALIZAR;
    }
}