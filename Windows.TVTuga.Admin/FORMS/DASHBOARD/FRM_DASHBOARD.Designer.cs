namespace Windows.TVTuga.Admin.FORMS.DASHBOARD
{
    partial class FRM_DASHBOARD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_DASHBOARD));
            this.MENUSTRIP_DASHBOARD = new System.Windows.Forms.MenuStrip();
            this.MENUSTRIP_DASHBOARD_FECHAR = new System.Windows.Forms.ToolStripMenuItem();
            this.SPLITCONTAINER_DASHBOARD = new System.Windows.Forms.SplitContainer();
            this.LABEL_MENU_PRINCIPAL = new System.Windows.Forms.Label();
            this.BUTTON_CONTAS_WEB = new System.Windows.Forms.Button();
            this.BUTTON_CONFIGURACOES = new System.Windows.Forms.Button();
            this.BUTTON_PEDIDOS = new System.Windows.Forms.Button();
            this.BUTTON_SERIES = new System.Windows.Forms.Button();
            this.BUTTON_UTILIZADORES = new System.Windows.Forms.Button();
            this.BUTTON_DASHBOARD = new System.Windows.Forms.Button();
            this.BUTTON_FERRAMENTAS = new System.Windows.Forms.Button();
            this.MENUSTRIP_DASHBOARD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SPLITCONTAINER_DASHBOARD)).BeginInit();
            this.SPLITCONTAINER_DASHBOARD.Panel1.SuspendLayout();
            this.SPLITCONTAINER_DASHBOARD.SuspendLayout();
            this.SuspendLayout();
            // 
            // MENUSTRIP_DASHBOARD
            // 
            this.MENUSTRIP_DASHBOARD.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MENUSTRIP_DASHBOARD_FECHAR});
            this.MENUSTRIP_DASHBOARD.Location = new System.Drawing.Point(0, 0);
            this.MENUSTRIP_DASHBOARD.Name = "MENUSTRIP_DASHBOARD";
            this.MENUSTRIP_DASHBOARD.Size = new System.Drawing.Size(1224, 24);
            this.MENUSTRIP_DASHBOARD.TabIndex = 0;
            this.MENUSTRIP_DASHBOARD.Text = "menuStrip1";
            // 
            // MENUSTRIP_DASHBOARD_FECHAR
            // 
            this.MENUSTRIP_DASHBOARD_FECHAR.Name = "MENUSTRIP_DASHBOARD_FECHAR";
            this.MENUSTRIP_DASHBOARD_FECHAR.Size = new System.Drawing.Size(109, 20);
            this.MENUSTRIP_DASHBOARD_FECHAR.Text = "Fechar Aplicação";
            this.MENUSTRIP_DASHBOARD_FECHAR.Click += new System.EventHandler(this.MENUSTRIP_DASHBOARD_FECHAR_Click);
            // 
            // SPLITCONTAINER_DASHBOARD
            // 
            this.SPLITCONTAINER_DASHBOARD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SPLITCONTAINER_DASHBOARD.BackColor = System.Drawing.Color.White;
            this.SPLITCONTAINER_DASHBOARD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SPLITCONTAINER_DASHBOARD.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SPLITCONTAINER_DASHBOARD.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SPLITCONTAINER_DASHBOARD.IsSplitterFixed = true;
            this.SPLITCONTAINER_DASHBOARD.Location = new System.Drawing.Point(0, 24);
            this.SPLITCONTAINER_DASHBOARD.Margin = new System.Windows.Forms.Padding(0);
            this.SPLITCONTAINER_DASHBOARD.Name = "SPLITCONTAINER_DASHBOARD";
            // 
            // SPLITCONTAINER_DASHBOARD.Panel1
            // 
            this.SPLITCONTAINER_DASHBOARD.Panel1.Controls.Add(this.BUTTON_FERRAMENTAS);
            this.SPLITCONTAINER_DASHBOARD.Panel1.Controls.Add(this.LABEL_MENU_PRINCIPAL);
            this.SPLITCONTAINER_DASHBOARD.Panel1.Controls.Add(this.BUTTON_CONTAS_WEB);
            this.SPLITCONTAINER_DASHBOARD.Panel1.Controls.Add(this.BUTTON_CONFIGURACOES);
            this.SPLITCONTAINER_DASHBOARD.Panel1.Controls.Add(this.BUTTON_PEDIDOS);
            this.SPLITCONTAINER_DASHBOARD.Panel1.Controls.Add(this.BUTTON_SERIES);
            this.SPLITCONTAINER_DASHBOARD.Panel1.Controls.Add(this.BUTTON_UTILIZADORES);
            this.SPLITCONTAINER_DASHBOARD.Panel1.Controls.Add(this.BUTTON_DASHBOARD);
            this.SPLITCONTAINER_DASHBOARD.Size = new System.Drawing.Size(1224, 623);
            this.SPLITCONTAINER_DASHBOARD.SplitterDistance = 206;
            this.SPLITCONTAINER_DASHBOARD.SplitterWidth = 1;
            this.SPLITCONTAINER_DASHBOARD.TabIndex = 1;
            // 
            // LABEL_MENU_PRINCIPAL
            // 
            this.LABEL_MENU_PRINCIPAL.AutoSize = true;
            this.LABEL_MENU_PRINCIPAL.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL_MENU_PRINCIPAL.Location = new System.Drawing.Point(5, 5);
            this.LABEL_MENU_PRINCIPAL.Name = "LABEL_MENU_PRINCIPAL";
            this.LABEL_MENU_PRINCIPAL.Size = new System.Drawing.Size(194, 35);
            this.LABEL_MENU_PRINCIPAL.TabIndex = 8;
            this.LABEL_MENU_PRINCIPAL.Text = "Menu Principal";
            // 
            // BUTTON_CONTAS_WEB
            // 
            this.BUTTON_CONTAS_WEB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BUTTON_CONTAS_WEB.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BUTTON_CONTAS_WEB.Image = global::Windows.TVTuga.Admin.Properties.Resources.book_000000_50;
            this.BUTTON_CONTAS_WEB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BUTTON_CONTAS_WEB.Location = new System.Drawing.Point(11, 132);
            this.BUTTON_CONTAS_WEB.Name = "BUTTON_CONTAS_WEB";
            this.BUTTON_CONTAS_WEB.Size = new System.Drawing.Size(185, 63);
            this.BUTTON_CONTAS_WEB.TabIndex = 5;
            this.BUTTON_CONTAS_WEB.Text = "Contas Web";
            this.BUTTON_CONTAS_WEB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BUTTON_CONTAS_WEB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BUTTON_CONTAS_WEB.UseVisualStyleBackColor = true;
            this.BUTTON_CONTAS_WEB.Click += new System.EventHandler(this.BUTTON_CONTAS_WEB_Click);
            // 
            // BUTTON_CONFIGURACOES
            // 
            this.BUTTON_CONFIGURACOES.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BUTTON_CONFIGURACOES.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BUTTON_CONFIGURACOES.Image = global::Windows.TVTuga.Admin.Properties.Resources.cogs_000000_50;
            this.BUTTON_CONFIGURACOES.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BUTTON_CONFIGURACOES.Location = new System.Drawing.Point(11, 457);
            this.BUTTON_CONFIGURACOES.Name = "BUTTON_CONFIGURACOES";
            this.BUTTON_CONFIGURACOES.Size = new System.Drawing.Size(185, 63);
            this.BUTTON_CONFIGURACOES.TabIndex = 4;
            this.BUTTON_CONFIGURACOES.Text = "Configurações";
            this.BUTTON_CONFIGURACOES.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BUTTON_CONFIGURACOES.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BUTTON_CONFIGURACOES.UseVisualStyleBackColor = true;
            this.BUTTON_CONFIGURACOES.Click += new System.EventHandler(this.BUTTON_CONFIGURACOES_Click);
            // 
            // BUTTON_PEDIDOS
            // 
            this.BUTTON_PEDIDOS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BUTTON_PEDIDOS.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BUTTON_PEDIDOS.Image = global::Windows.TVTuga.Admin.Properties.Resources.heart_000000_50;
            this.BUTTON_PEDIDOS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BUTTON_PEDIDOS.Location = new System.Drawing.Point(11, 376);
            this.BUTTON_PEDIDOS.Name = "BUTTON_PEDIDOS";
            this.BUTTON_PEDIDOS.Size = new System.Drawing.Size(185, 63);
            this.BUTTON_PEDIDOS.TabIndex = 3;
            this.BUTTON_PEDIDOS.Text = "Pedidos";
            this.BUTTON_PEDIDOS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BUTTON_PEDIDOS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BUTTON_PEDIDOS.UseVisualStyleBackColor = true;
            this.BUTTON_PEDIDOS.Click += new System.EventHandler(this.BUTTON_PEDIDOS_Click);
            // 
            // BUTTON_SERIES
            // 
            this.BUTTON_SERIES.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BUTTON_SERIES.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BUTTON_SERIES.Image = global::Windows.TVTuga.Admin.Properties.Resources.video_camera_000000_50;
            this.BUTTON_SERIES.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BUTTON_SERIES.Location = new System.Drawing.Point(11, 295);
            this.BUTTON_SERIES.Name = "BUTTON_SERIES";
            this.BUTTON_SERIES.Size = new System.Drawing.Size(185, 63);
            this.BUTTON_SERIES.TabIndex = 2;
            this.BUTTON_SERIES.Text = "Séries";
            this.BUTTON_SERIES.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BUTTON_SERIES.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BUTTON_SERIES.UseVisualStyleBackColor = true;
            this.BUTTON_SERIES.Click += new System.EventHandler(this.BUTTON_SERIES_Click);
            // 
            // BUTTON_UTILIZADORES
            // 
            this.BUTTON_UTILIZADORES.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BUTTON_UTILIZADORES.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BUTTON_UTILIZADORES.Image = global::Windows.TVTuga.Admin.Properties.Resources.users_000000_50;
            this.BUTTON_UTILIZADORES.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BUTTON_UTILIZADORES.Location = new System.Drawing.Point(11, 213);
            this.BUTTON_UTILIZADORES.Name = "BUTTON_UTILIZADORES";
            this.BUTTON_UTILIZADORES.Size = new System.Drawing.Size(185, 63);
            this.BUTTON_UTILIZADORES.TabIndex = 1;
            this.BUTTON_UTILIZADORES.Text = "Utilizadores";
            this.BUTTON_UTILIZADORES.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BUTTON_UTILIZADORES.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BUTTON_UTILIZADORES.UseVisualStyleBackColor = true;
            this.BUTTON_UTILIZADORES.Click += new System.EventHandler(this.BUTTON_UTILIZADORES_Click);
            // 
            // BUTTON_DASHBOARD
            // 
            this.BUTTON_DASHBOARD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BUTTON_DASHBOARD.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BUTTON_DASHBOARD.Image = global::Windows.TVTuga.Admin.Properties.Resources.tachometer_000000_50;
            this.BUTTON_DASHBOARD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BUTTON_DASHBOARD.Location = new System.Drawing.Point(11, 52);
            this.BUTTON_DASHBOARD.Name = "BUTTON_DASHBOARD";
            this.BUTTON_DASHBOARD.Size = new System.Drawing.Size(185, 63);
            this.BUTTON_DASHBOARD.TabIndex = 0;
            this.BUTTON_DASHBOARD.Text = "Dashboard";
            this.BUTTON_DASHBOARD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BUTTON_DASHBOARD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BUTTON_DASHBOARD.UseVisualStyleBackColor = true;
            this.BUTTON_DASHBOARD.Click += new System.EventHandler(this.BUTTON_DASHBOARD_Click);
            // 
            // BUTTON_FERRAMENTAS
            // 
            this.BUTTON_FERRAMENTAS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BUTTON_FERRAMENTAS.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BUTTON_FERRAMENTAS.Image = global::Windows.TVTuga.Admin.Properties.Resources.wrench_000000_50;
            this.BUTTON_FERRAMENTAS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BUTTON_FERRAMENTAS.Location = new System.Drawing.Point(11, 539);
            this.BUTTON_FERRAMENTAS.Name = "BUTTON_FERRAMENTAS";
            this.BUTTON_FERRAMENTAS.Size = new System.Drawing.Size(185, 63);
            this.BUTTON_FERRAMENTAS.TabIndex = 9;
            this.BUTTON_FERRAMENTAS.Text = "Ferramentas";
            this.BUTTON_FERRAMENTAS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BUTTON_FERRAMENTAS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BUTTON_FERRAMENTAS.UseVisualStyleBackColor = true;
            // 
            // FRM_DASHBOARD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 647);
            this.Controls.Add(this.SPLITCONTAINER_DASHBOARD);
            this.Controls.Add(this.MENUSTRIP_DASHBOARD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MENUSTRIP_DASHBOARD;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1240, 686);
            this.Name = "FRM_DASHBOARD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TVTuga Dashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FRM_DASHBOARD_FormClosed);
            this.Load += new System.EventHandler(this.FRM_DASHBOARD_Load);
            this.MENUSTRIP_DASHBOARD.ResumeLayout(false);
            this.MENUSTRIP_DASHBOARD.PerformLayout();
            this.SPLITCONTAINER_DASHBOARD.Panel1.ResumeLayout(false);
            this.SPLITCONTAINER_DASHBOARD.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SPLITCONTAINER_DASHBOARD)).EndInit();
            this.SPLITCONTAINER_DASHBOARD.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MENUSTRIP_DASHBOARD;
        private System.Windows.Forms.ToolStripMenuItem MENUSTRIP_DASHBOARD_FECHAR;
        private System.Windows.Forms.SplitContainer SPLITCONTAINER_DASHBOARD;
        private System.Windows.Forms.Button BUTTON_DASHBOARD;
        private System.Windows.Forms.Button BUTTON_CONFIGURACOES;
        private System.Windows.Forms.Button BUTTON_PEDIDOS;
        private System.Windows.Forms.Button BUTTON_SERIES;
        private System.Windows.Forms.Button BUTTON_UTILIZADORES;
        private System.Windows.Forms.Button BUTTON_CONTAS_WEB;
        private System.Windows.Forms.Label LABEL_MENU_PRINCIPAL;
        private System.Windows.Forms.Button BUTTON_FERRAMENTAS;
    }
}