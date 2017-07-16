namespace Windows.TVTuga.Admin.FORMS.DASHBOARD.PANELS.SERIES.SERIES
{
    partial class PNL_GERIR_SERIES
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
            this.SPLITCONTAINER_SERIES = new System.Windows.Forms.SplitContainer();
            this.BUTTON_SERIES_ADICIONAR = new System.Windows.Forms.Button();
            this.BUTTON_SERIES_LISTAGEM = new System.Windows.Forms.Button();
            this.BUTTON_ACTUALIZAR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SPLITCONTAINER_SERIES)).BeginInit();
            this.SPLITCONTAINER_SERIES.Panel1.SuspendLayout();
            this.SPLITCONTAINER_SERIES.SuspendLayout();
            this.SuspendLayout();
            // 
            // SPLITCONTAINER_SERIES
            // 
            this.SPLITCONTAINER_SERIES.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SPLITCONTAINER_SERIES.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SPLITCONTAINER_SERIES.Location = new System.Drawing.Point(0, 0);
            this.SPLITCONTAINER_SERIES.Margin = new System.Windows.Forms.Padding(0);
            this.SPLITCONTAINER_SERIES.Name = "SPLITCONTAINER_SERIES";
            // 
            // SPLITCONTAINER_SERIES.Panel1
            // 
            this.SPLITCONTAINER_SERIES.Panel1.Controls.Add(this.BUTTON_SERIES_ADICIONAR);
            this.SPLITCONTAINER_SERIES.Panel1.Controls.Add(this.BUTTON_SERIES_LISTAGEM);
            this.SPLITCONTAINER_SERIES.Panel1.Controls.Add(this.BUTTON_ACTUALIZAR);
            this.SPLITCONTAINER_SERIES.Size = new System.Drawing.Size(1001, 512);
            this.SPLITCONTAINER_SERIES.SplitterDistance = 145;
            this.SPLITCONTAINER_SERIES.SplitterWidth = 1;
            this.SPLITCONTAINER_SERIES.TabIndex = 3;
            // 
            // BUTTON_SERIES_ADICIONAR
            // 
            this.BUTTON_SERIES_ADICIONAR.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BUTTON_SERIES_ADICIONAR.Image = global::Windows.TVTuga.Admin.Properties.Resources.plus_square_o_000000_50;
            this.BUTTON_SERIES_ADICIONAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BUTTON_SERIES_ADICIONAR.Location = new System.Drawing.Point(3, 95);
            this.BUTTON_SERIES_ADICIONAR.Name = "BUTTON_SERIES_ADICIONAR";
            this.BUTTON_SERIES_ADICIONAR.Size = new System.Drawing.Size(137, 86);
            this.BUTTON_SERIES_ADICIONAR.TabIndex = 7;
            this.BUTTON_SERIES_ADICIONAR.Text = "Adicionar";
            this.BUTTON_SERIES_ADICIONAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BUTTON_SERIES_ADICIONAR.UseVisualStyleBackColor = true;
            this.BUTTON_SERIES_ADICIONAR.Click += new System.EventHandler(this.BUTTON_SERIES_ADICIONAR_Click);
            // 
            // BUTTON_SERIES_LISTAGEM
            // 
            this.BUTTON_SERIES_LISTAGEM.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BUTTON_SERIES_LISTAGEM.Image = global::Windows.TVTuga.Admin.Properties.Resources.bars_000000_50;
            this.BUTTON_SERIES_LISTAGEM.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BUTTON_SERIES_LISTAGEM.Location = new System.Drawing.Point(3, 3);
            this.BUTTON_SERIES_LISTAGEM.Name = "BUTTON_SERIES_LISTAGEM";
            this.BUTTON_SERIES_LISTAGEM.Size = new System.Drawing.Size(137, 86);
            this.BUTTON_SERIES_LISTAGEM.TabIndex = 6;
            this.BUTTON_SERIES_LISTAGEM.Text = "Lista";
            this.BUTTON_SERIES_LISTAGEM.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BUTTON_SERIES_LISTAGEM.UseVisualStyleBackColor = true;
            this.BUTTON_SERIES_LISTAGEM.Click += new System.EventHandler(this.BUTTON_SERIES_LISTAGEM_Click);
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
            // PNL_GERIR_SERIES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1001, 512);
            this.Controls.Add(this.SPLITCONTAINER_SERIES);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PNL_GERIR_SERIES";
            this.Text = "PNL_GERIR_SERIES";
            this.Load += new System.EventHandler(this.PNL_GERIR_SERIES_Load);
            this.SPLITCONTAINER_SERIES.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SPLITCONTAINER_SERIES)).EndInit();
            this.SPLITCONTAINER_SERIES.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer SPLITCONTAINER_SERIES;
        private System.Windows.Forms.Button BUTTON_ACTUALIZAR;
        private System.Windows.Forms.Button BUTTON_SERIES_ADICIONAR;
        private System.Windows.Forms.Button BUTTON_SERIES_LISTAGEM;
    }
}