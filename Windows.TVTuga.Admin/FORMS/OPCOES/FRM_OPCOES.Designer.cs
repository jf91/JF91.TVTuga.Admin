namespace Windows.TVTuga.Admin
{
    partial class FRM_OPCOES
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_OPCOES));
            this.MENUSTRIP_OPCOES = new System.Windows.Forms.MenuStrip();
            this.MENUSTRIP_OPCOES_FECHAR = new System.Windows.Forms.ToolStripMenuItem();
            this.SPLICONTAINER_OPCOES = new System.Windows.Forms.SplitContainer();
            this.BUTTON_OPCOES_BD = new System.Windows.Forms.Button();
            this.BUTTON_FTP = new System.Windows.Forms.Button();
            this.BUTTON_UTILIZADORES = new System.Windows.Forms.Button();
            this.MENUSTRIP_OPCOES.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SPLICONTAINER_OPCOES)).BeginInit();
            this.SPLICONTAINER_OPCOES.Panel1.SuspendLayout();
            this.SPLICONTAINER_OPCOES.SuspendLayout();
            this.SuspendLayout();
            // 
            // MENUSTRIP_OPCOES
            // 
            this.MENUSTRIP_OPCOES.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MENUSTRIP_OPCOES_FECHAR});
            this.MENUSTRIP_OPCOES.Location = new System.Drawing.Point(0, 0);
            this.MENUSTRIP_OPCOES.Name = "MENUSTRIP_OPCOES";
            this.MENUSTRIP_OPCOES.Size = new System.Drawing.Size(432, 24);
            this.MENUSTRIP_OPCOES.TabIndex = 0;
            this.MENUSTRIP_OPCOES.Text = "menuStrip1";
            // 
            // MENUSTRIP_OPCOES_FECHAR
            // 
            this.MENUSTRIP_OPCOES_FECHAR.Name = "MENUSTRIP_OPCOES_FECHAR";
            this.MENUSTRIP_OPCOES_FECHAR.Size = new System.Drawing.Size(54, 20);
            this.MENUSTRIP_OPCOES_FECHAR.Text = "Fechar";
            this.MENUSTRIP_OPCOES_FECHAR.Click += new System.EventHandler(this.MENUSTRIP_OPCOES_FECHAR_Click);
            // 
            // SPLICONTAINER_OPCOES
            // 
            this.SPLICONTAINER_OPCOES.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SPLICONTAINER_OPCOES.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SPLICONTAINER_OPCOES.IsSplitterFixed = true;
            this.SPLICONTAINER_OPCOES.Location = new System.Drawing.Point(0, 24);
            this.SPLICONTAINER_OPCOES.Name = "SPLICONTAINER_OPCOES";
            // 
            // SPLICONTAINER_OPCOES.Panel1
            // 
            this.SPLICONTAINER_OPCOES.Panel1.Controls.Add(this.BUTTON_OPCOES_BD);
            this.SPLICONTAINER_OPCOES.Panel1.Controls.Add(this.BUTTON_FTP);
            this.SPLICONTAINER_OPCOES.Panel1.Controls.Add(this.BUTTON_UTILIZADORES);
            this.SPLICONTAINER_OPCOES.Size = new System.Drawing.Size(432, 297);
            this.SPLICONTAINER_OPCOES.SplitterDistance = 98;
            this.SPLICONTAINER_OPCOES.TabIndex = 1;
            // 
            // BUTTON_OPCOES_BD
            // 
            this.BUTTON_OPCOES_BD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BUTTON_OPCOES_BD.Image = global::Windows.TVTuga.Admin.Properties.Resources.database__Custom_;
            this.BUTTON_OPCOES_BD.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BUTTON_OPCOES_BD.Location = new System.Drawing.Point(1, 67);
            this.BUTTON_OPCOES_BD.Name = "BUTTON_OPCOES_BD";
            this.BUTTON_OPCOES_BD.Size = new System.Drawing.Size(92, 55);
            this.BUTTON_OPCOES_BD.TabIndex = 5;
            this.BUTTON_OPCOES_BD.Text = "BD";
            this.BUTTON_OPCOES_BD.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BUTTON_OPCOES_BD.UseVisualStyleBackColor = true;
            this.BUTTON_OPCOES_BD.Click += new System.EventHandler(this.BUTTON_OPCOES_BD_Click);
            // 
            // BUTTON_FTP
            // 
            this.BUTTON_FTP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BUTTON_FTP.Image = global::Windows.TVTuga.Admin.Properties.Resources._120px_Human_folder_remote_ftp_svg__Custom_;
            this.BUTTON_FTP.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BUTTON_FTP.Location = new System.Drawing.Point(1, 129);
            this.BUTTON_FTP.Name = "BUTTON_FTP";
            this.BUTTON_FTP.Size = new System.Drawing.Size(92, 55);
            this.BUTTON_FTP.TabIndex = 4;
            this.BUTTON_FTP.Text = "FTP";
            this.BUTTON_FTP.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BUTTON_FTP.UseVisualStyleBackColor = true;
            this.BUTTON_FTP.Click += new System.EventHandler(this.BUTTON_FTP_Click);
            // 
            // BUTTON_UTILIZADORES
            // 
            this.BUTTON_UTILIZADORES.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BUTTON_UTILIZADORES.Image = global::Windows.TVTuga.Admin.Properties.Resources.user1__Custom_;
            this.BUTTON_UTILIZADORES.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BUTTON_UTILIZADORES.Location = new System.Drawing.Point(1, 6);
            this.BUTTON_UTILIZADORES.Name = "BUTTON_UTILIZADORES";
            this.BUTTON_UTILIZADORES.Size = new System.Drawing.Size(92, 55);
            this.BUTTON_UTILIZADORES.TabIndex = 3;
            this.BUTTON_UTILIZADORES.Text = "Utilizadores";
            this.BUTTON_UTILIZADORES.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BUTTON_UTILIZADORES.UseVisualStyleBackColor = true;
            this.BUTTON_UTILIZADORES.Click += new System.EventHandler(this.BUTTON_UTILIZADORES_Click);
            // 
            // FRM_OPCOES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 321);
            this.Controls.Add(this.SPLICONTAINER_OPCOES);
            this.Controls.Add(this.MENUSTRIP_OPCOES);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MENUSTRIP_OPCOES;
            this.MaximizeBox = false;
            this.Name = "FRM_OPCOES";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TVTuga Admin | Opções";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FRM_OPCOES_FormClosed);
            this.MENUSTRIP_OPCOES.ResumeLayout(false);
            this.MENUSTRIP_OPCOES.PerformLayout();
            this.SPLICONTAINER_OPCOES.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SPLICONTAINER_OPCOES)).EndInit();
            this.SPLICONTAINER_OPCOES.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MENUSTRIP_OPCOES;
        private System.Windows.Forms.ToolStripMenuItem MENUSTRIP_OPCOES_FECHAR;
        private System.Windows.Forms.SplitContainer SPLICONTAINER_OPCOES;
        private System.Windows.Forms.Button BUTTON_UTILIZADORES;
        private System.Windows.Forms.Button BUTTON_FTP;
        private System.Windows.Forms.Button BUTTON_OPCOES_BD;
    }
}