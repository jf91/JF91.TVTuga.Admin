﻿namespace Windows.TVTuga.Admin.FORMS.DASHBOARD.PANELS.CONTAS_WEB
{
    partial class PNL_CONTAS_WEB
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
            this.SPLITCONTAINER_CONTAS_WEB = new System.Windows.Forms.SplitContainer();
            this.BUTTON_WEBSITES = new System.Windows.Forms.Button();
            this.BUTTON_CONTAS_WEB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SPLITCONTAINER_CONTAS_WEB)).BeginInit();
            this.SPLITCONTAINER_CONTAS_WEB.Panel1.SuspendLayout();
            this.SPLITCONTAINER_CONTAS_WEB.SuspendLayout();
            this.SuspendLayout();
            // 
            // SPLITCONTAINER_CONTAS_WEB
            // 
            this.SPLITCONTAINER_CONTAS_WEB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SPLITCONTAINER_CONTAS_WEB.Location = new System.Drawing.Point(0, 0);
            this.SPLITCONTAINER_CONTAS_WEB.Margin = new System.Windows.Forms.Padding(0);
            this.SPLITCONTAINER_CONTAS_WEB.Name = "SPLITCONTAINER_CONTAS_WEB";
            this.SPLITCONTAINER_CONTAS_WEB.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // SPLITCONTAINER_CONTAS_WEB.Panel1
            // 
            this.SPLITCONTAINER_CONTAS_WEB.Panel1.Controls.Add(this.BUTTON_WEBSITES);
            this.SPLITCONTAINER_CONTAS_WEB.Panel1.Controls.Add(this.BUTTON_CONTAS_WEB);
            this.SPLITCONTAINER_CONTAS_WEB.Size = new System.Drawing.Size(1009, 615);
            this.SPLITCONTAINER_CONTAS_WEB.SplitterDistance = 94;
            this.SPLITCONTAINER_CONTAS_WEB.SplitterWidth = 1;
            this.SPLITCONTAINER_CONTAS_WEB.TabIndex = 0;
            // 
            // BUTTON_WEBSITES
            // 
            this.BUTTON_WEBSITES.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BUTTON_WEBSITES.Image = global::Windows.TVTuga.Admin.Properties.Resources.globe_000000_50;
            this.BUTTON_WEBSITES.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BUTTON_WEBSITES.Location = new System.Drawing.Point(147, 3);
            this.BUTTON_WEBSITES.Name = "BUTTON_WEBSITES";
            this.BUTTON_WEBSITES.Size = new System.Drawing.Size(137, 86);
            this.BUTTON_WEBSITES.TabIndex = 1;
            this.BUTTON_WEBSITES.Text = "Websites";
            this.BUTTON_WEBSITES.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BUTTON_WEBSITES.UseVisualStyleBackColor = true;
            this.BUTTON_WEBSITES.Click += new System.EventHandler(this.BUTTON_WEBSITES_Click);
            // 
            // BUTTON_CONTAS_WEB
            // 
            this.BUTTON_CONTAS_WEB.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BUTTON_CONTAS_WEB.Image = global::Windows.TVTuga.Admin.Properties.Resources.book_000000_50;
            this.BUTTON_CONTAS_WEB.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BUTTON_CONTAS_WEB.Location = new System.Drawing.Point(4, 3);
            this.BUTTON_CONTAS_WEB.Name = "BUTTON_CONTAS_WEB";
            this.BUTTON_CONTAS_WEB.Size = new System.Drawing.Size(137, 86);
            this.BUTTON_CONTAS_WEB.TabIndex = 0;
            this.BUTTON_CONTAS_WEB.Text = "Contas WEB";
            this.BUTTON_CONTAS_WEB.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BUTTON_CONTAS_WEB.UseVisualStyleBackColor = true;
            this.BUTTON_CONTAS_WEB.Click += new System.EventHandler(this.BUTTON_CONTAS_WEB_Click);
            // 
            // PNL_CONTAS_WEB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1009, 615);
            this.Controls.Add(this.SPLITCONTAINER_CONTAS_WEB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PNL_CONTAS_WEB";
            this.Text = "PNL_CONTAS_WEB";
            this.Load += new System.EventHandler(this.PNL_CONTAS_WEB_Load);
            this.SPLITCONTAINER_CONTAS_WEB.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SPLITCONTAINER_CONTAS_WEB)).EndInit();
            this.SPLITCONTAINER_CONTAS_WEB.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer SPLITCONTAINER_CONTAS_WEB;
        private System.Windows.Forms.Button BUTTON_WEBSITES;
        private System.Windows.Forms.Button BUTTON_CONTAS_WEB;
    }
}