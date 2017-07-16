namespace Windows.TVTuga.Admin.FORMS.DASHBOARD.PANELS.PEDIDOS
{
    partial class PNL_GERIR_PEDIDOS
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
            this.SPLITCONTAINER_PEDIDOS = new System.Windows.Forms.SplitContainer();
            this.BUTTON_PEDIDOS = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SPLITCONTAINER_PEDIDOS)).BeginInit();
            this.SPLITCONTAINER_PEDIDOS.Panel1.SuspendLayout();
            this.SPLITCONTAINER_PEDIDOS.SuspendLayout();
            this.SuspendLayout();
            // 
            // SPLITCONTAINER_PEDIDOS
            // 
            this.SPLITCONTAINER_PEDIDOS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SPLITCONTAINER_PEDIDOS.Location = new System.Drawing.Point(0, 0);
            this.SPLITCONTAINER_PEDIDOS.Margin = new System.Windows.Forms.Padding(0);
            this.SPLITCONTAINER_PEDIDOS.Name = "SPLITCONTAINER_PEDIDOS";
            this.SPLITCONTAINER_PEDIDOS.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // SPLITCONTAINER_PEDIDOS.Panel1
            // 
            this.SPLITCONTAINER_PEDIDOS.Panel1.Controls.Add(this.BUTTON_PEDIDOS);
            this.SPLITCONTAINER_PEDIDOS.Size = new System.Drawing.Size(1009, 615);
            this.SPLITCONTAINER_PEDIDOS.SplitterDistance = 94;
            this.SPLITCONTAINER_PEDIDOS.SplitterWidth = 1;
            this.SPLITCONTAINER_PEDIDOS.TabIndex = 2;
            // 
            // BUTTON_PEDIDOS
            // 
            this.BUTTON_PEDIDOS.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BUTTON_PEDIDOS.Image = global::Windows.TVTuga.Admin.Properties.Resources.heart_000000_50;
            this.BUTTON_PEDIDOS.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BUTTON_PEDIDOS.Location = new System.Drawing.Point(4, 3);
            this.BUTTON_PEDIDOS.Name = "BUTTON_PEDIDOS";
            this.BUTTON_PEDIDOS.Size = new System.Drawing.Size(137, 86);
            this.BUTTON_PEDIDOS.TabIndex = 0;
            this.BUTTON_PEDIDOS.Text = "Pedidos";
            this.BUTTON_PEDIDOS.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BUTTON_PEDIDOS.UseVisualStyleBackColor = true;
            this.BUTTON_PEDIDOS.Click += new System.EventHandler(this.BUTTON_PEDIDOS_Click);
            // 
            // PNL_GERIR_PEDIDOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1009, 615);
            this.Controls.Add(this.SPLITCONTAINER_PEDIDOS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PNL_GERIR_PEDIDOS";
            this.Text = "PNL_GERIR_PEDIDOS";
            this.Load += new System.EventHandler(this.PNL_GERIR_PEDIDOS_Load);
            this.SPLITCONTAINER_PEDIDOS.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SPLITCONTAINER_PEDIDOS)).EndInit();
            this.SPLITCONTAINER_PEDIDOS.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer SPLITCONTAINER_PEDIDOS;
        private System.Windows.Forms.Button BUTTON_PEDIDOS;
    }
}