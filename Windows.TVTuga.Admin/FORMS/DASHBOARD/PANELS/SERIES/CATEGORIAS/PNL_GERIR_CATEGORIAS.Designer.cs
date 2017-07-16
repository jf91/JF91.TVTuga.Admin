namespace Windows.TVTuga.Admin.FORMS.DASHBOARD.PANELS.SERIES.CATEGORIAS
{
    partial class PNL_GERIR_CATEGORIAS
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
            this.SPLITCONTAINER_CATEGORIAS = new System.Windows.Forms.SplitContainer();
            this.BUTTON_CATEGORIAS_LISTAGEM = new System.Windows.Forms.Button();
            this.BUTTON_ACTUALIZAR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SPLITCONTAINER_CATEGORIAS)).BeginInit();
            this.SPLITCONTAINER_CATEGORIAS.Panel1.SuspendLayout();
            this.SPLITCONTAINER_CATEGORIAS.SuspendLayout();
            this.SuspendLayout();
            // 
            // SPLITCONTAINER_CATEGORIAS
            // 
            this.SPLITCONTAINER_CATEGORIAS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SPLITCONTAINER_CATEGORIAS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SPLITCONTAINER_CATEGORIAS.Location = new System.Drawing.Point(0, 0);
            this.SPLITCONTAINER_CATEGORIAS.Margin = new System.Windows.Forms.Padding(0);
            this.SPLITCONTAINER_CATEGORIAS.Name = "SPLITCONTAINER_CATEGORIAS";
            // 
            // SPLITCONTAINER_CATEGORIAS.Panel1
            // 
            this.SPLITCONTAINER_CATEGORIAS.Panel1.Controls.Add(this.BUTTON_CATEGORIAS_LISTAGEM);
            this.SPLITCONTAINER_CATEGORIAS.Panel1.Controls.Add(this.BUTTON_ACTUALIZAR);
            this.SPLITCONTAINER_CATEGORIAS.Size = new System.Drawing.Size(1001, 512);
            this.SPLITCONTAINER_CATEGORIAS.SplitterDistance = 145;
            this.SPLITCONTAINER_CATEGORIAS.SplitterWidth = 1;
            this.SPLITCONTAINER_CATEGORIAS.TabIndex = 4;
            // 
            // BUTTON_CATEGORIAS_LISTAGEM
            // 
            this.BUTTON_CATEGORIAS_LISTAGEM.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BUTTON_CATEGORIAS_LISTAGEM.Image = global::Windows.TVTuga.Admin.Properties.Resources.bars_000000_50;
            this.BUTTON_CATEGORIAS_LISTAGEM.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BUTTON_CATEGORIAS_LISTAGEM.Location = new System.Drawing.Point(3, 3);
            this.BUTTON_CATEGORIAS_LISTAGEM.Name = "BUTTON_CATEGORIAS_LISTAGEM";
            this.BUTTON_CATEGORIAS_LISTAGEM.Size = new System.Drawing.Size(137, 86);
            this.BUTTON_CATEGORIAS_LISTAGEM.TabIndex = 6;
            this.BUTTON_CATEGORIAS_LISTAGEM.Text = "Lista";
            this.BUTTON_CATEGORIAS_LISTAGEM.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BUTTON_CATEGORIAS_LISTAGEM.UseVisualStyleBackColor = true;
            this.BUTTON_CATEGORIAS_LISTAGEM.Click += new System.EventHandler(this.BUTTON_CATEGORIAS_LISTAGEM_Click);
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
            // PNL_GERIR_CATEGORIAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1001, 512);
            this.Controls.Add(this.SPLITCONTAINER_CATEGORIAS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PNL_GERIR_CATEGORIAS";
            this.Text = "PNL_GERIR_CATEGORIAS";
            this.Load += new System.EventHandler(this.PNL_GERIR_CATEGORIAS_Load);
            this.SPLITCONTAINER_CATEGORIAS.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SPLITCONTAINER_CATEGORIAS)).EndInit();
            this.SPLITCONTAINER_CATEGORIAS.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer SPLITCONTAINER_CATEGORIAS;
        private System.Windows.Forms.Button BUTTON_CATEGORIAS_LISTAGEM;
        private System.Windows.Forms.Button BUTTON_ACTUALIZAR;
    }
}