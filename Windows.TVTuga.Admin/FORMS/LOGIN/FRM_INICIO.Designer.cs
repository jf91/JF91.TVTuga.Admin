namespace Windows.TVTuga.Admin
{
    partial class FRM_INICIO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_INICIO));
            this.MENUSTRIP_LOGIN = new System.Windows.Forms.MenuStrip();
            this.MENUSTRIP_LOGIN_FECHAR = new System.Windows.Forms.ToolStripMenuItem();
            this.MENUSTRIP_MAIN_OPCOES = new System.Windows.Forms.ToolStripMenuItem();
            this.SPLITCONTAINER_LOGIN = new System.Windows.Forms.SplitContainer();
            this.LISTVIEW_CONTAS = new System.Windows.Forms.ListView();
            this.HDR_USERNAME = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BUTTON_LOGIN = new System.Windows.Forms.Button();
            this.TEXTBOX_PASSWORD = new System.Windows.Forms.TextBox();
            this.LABEL_PASSWORD = new System.Windows.Forms.Label();
            this.TEXTBOX_USERNAME = new System.Windows.Forms.TextBox();
            this.LABEL_USERNAME = new System.Windows.Forms.Label();
            this.MENUSTRIP_LOGIN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SPLITCONTAINER_LOGIN)).BeginInit();
            this.SPLITCONTAINER_LOGIN.Panel1.SuspendLayout();
            this.SPLITCONTAINER_LOGIN.Panel2.SuspendLayout();
            this.SPLITCONTAINER_LOGIN.SuspendLayout();
            this.SuspendLayout();
            // 
            // MENUSTRIP_LOGIN
            // 
            this.MENUSTRIP_LOGIN.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MENUSTRIP_LOGIN_FECHAR,
            this.MENUSTRIP_MAIN_OPCOES});
            this.MENUSTRIP_LOGIN.Location = new System.Drawing.Point(0, 0);
            this.MENUSTRIP_LOGIN.Name = "MENUSTRIP_LOGIN";
            this.MENUSTRIP_LOGIN.Size = new System.Drawing.Size(354, 24);
            this.MENUSTRIP_LOGIN.TabIndex = 0;
            this.MENUSTRIP_LOGIN.Text = "menuStrip1";
            // 
            // MENUSTRIP_LOGIN_FECHAR
            // 
            this.MENUSTRIP_LOGIN_FECHAR.Name = "MENUSTRIP_LOGIN_FECHAR";
            this.MENUSTRIP_LOGIN_FECHAR.Size = new System.Drawing.Size(54, 20);
            this.MENUSTRIP_LOGIN_FECHAR.Text = "Fechar";
            this.MENUSTRIP_LOGIN_FECHAR.Click += new System.EventHandler(this.MENUSTRIP_LOGIN_FECHAR_Click);
            // 
            // MENUSTRIP_MAIN_OPCOES
            // 
            this.MENUSTRIP_MAIN_OPCOES.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.MENUSTRIP_MAIN_OPCOES.Name = "MENUSTRIP_MAIN_OPCOES";
            this.MENUSTRIP_MAIN_OPCOES.Size = new System.Drawing.Size(59, 20);
            this.MENUSTRIP_MAIN_OPCOES.Text = "Opções";
            this.MENUSTRIP_MAIN_OPCOES.Click += new System.EventHandler(this.MENUSTRIP_MAIN_OPCOES_Click);
            // 
            // SPLITCONTAINER_LOGIN
            // 
            this.SPLITCONTAINER_LOGIN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SPLITCONTAINER_LOGIN.Location = new System.Drawing.Point(0, 24);
            this.SPLITCONTAINER_LOGIN.Name = "SPLITCONTAINER_LOGIN";
            // 
            // SPLITCONTAINER_LOGIN.Panel1
            // 
            this.SPLITCONTAINER_LOGIN.Panel1.Controls.Add(this.LISTVIEW_CONTAS);
            // 
            // SPLITCONTAINER_LOGIN.Panel2
            // 
            this.SPLITCONTAINER_LOGIN.Panel2.Controls.Add(this.BUTTON_LOGIN);
            this.SPLITCONTAINER_LOGIN.Panel2.Controls.Add(this.TEXTBOX_PASSWORD);
            this.SPLITCONTAINER_LOGIN.Panel2.Controls.Add(this.LABEL_PASSWORD);
            this.SPLITCONTAINER_LOGIN.Panel2.Controls.Add(this.TEXTBOX_USERNAME);
            this.SPLITCONTAINER_LOGIN.Panel2.Controls.Add(this.LABEL_USERNAME);
            this.SPLITCONTAINER_LOGIN.Size = new System.Drawing.Size(354, 262);
            this.SPLITCONTAINER_LOGIN.SplitterDistance = 169;
            this.SPLITCONTAINER_LOGIN.TabIndex = 1;
            // 
            // LISTVIEW_CONTAS
            // 
            this.LISTVIEW_CONTAS.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.LISTVIEW_CONTAS.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.HDR_USERNAME});
            this.LISTVIEW_CONTAS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LISTVIEW_CONTAS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LISTVIEW_CONTAS.FullRowSelect = true;
            this.LISTVIEW_CONTAS.HideSelection = false;
            this.LISTVIEW_CONTAS.Location = new System.Drawing.Point(0, 0);
            this.LISTVIEW_CONTAS.MultiSelect = false;
            this.LISTVIEW_CONTAS.Name = "LISTVIEW_CONTAS";
            this.LISTVIEW_CONTAS.ShowGroups = false;
            this.LISTVIEW_CONTAS.Size = new System.Drawing.Size(169, 262);
            this.LISTVIEW_CONTAS.TabIndex = 0;
            this.LISTVIEW_CONTAS.UseCompatibleStateImageBehavior = false;
            this.LISTVIEW_CONTAS.View = System.Windows.Forms.View.Details;
            this.LISTVIEW_CONTAS.SelectedIndexChanged += new System.EventHandler(this.LISTVIEW_CONTAS_SelectedIndexChanged);
            // 
            // HDR_USERNAME
            // 
            this.HDR_USERNAME.Text = "Username";
            this.HDR_USERNAME.Width = 160;
            // 
            // BUTTON_LOGIN
            // 
            this.BUTTON_LOGIN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BUTTON_LOGIN.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BUTTON_LOGIN.Image = global::Windows.TVTuga.Admin.Properties.Resources.LoginIcon__Custom_;
            this.BUTTON_LOGIN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BUTTON_LOGIN.Location = new System.Drawing.Point(29, 160);
            this.BUTTON_LOGIN.Margin = new System.Windows.Forms.Padding(0);
            this.BUTTON_LOGIN.Name = "BUTTON_LOGIN";
            this.BUTTON_LOGIN.Size = new System.Drawing.Size(123, 55);
            this.BUTTON_LOGIN.TabIndex = 4;
            this.BUTTON_LOGIN.Text = "Login";
            this.BUTTON_LOGIN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BUTTON_LOGIN.UseVisualStyleBackColor = true;
            this.BUTTON_LOGIN.Click += new System.EventHandler(this.BUTTON_LOGIN_Click);
            // 
            // TEXTBOX_PASSWORD
            // 
            this.TEXTBOX_PASSWORD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TEXTBOX_PASSWORD.Location = new System.Drawing.Point(29, 110);
            this.TEXTBOX_PASSWORD.Name = "TEXTBOX_PASSWORD";
            this.TEXTBOX_PASSWORD.Size = new System.Drawing.Size(123, 20);
            this.TEXTBOX_PASSWORD.TabIndex = 3;
            this.TEXTBOX_PASSWORD.UseSystemPasswordChar = true;
            this.TEXTBOX_PASSWORD.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TEXTBOX_PASSWORD_KeyDown);
            // 
            // LABEL_PASSWORD
            // 
            this.LABEL_PASSWORD.AutoSize = true;
            this.LABEL_PASSWORD.Location = new System.Drawing.Point(28, 94);
            this.LABEL_PASSWORD.Name = "LABEL_PASSWORD";
            this.LABEL_PASSWORD.Size = new System.Drawing.Size(53, 13);
            this.LABEL_PASSWORD.TabIndex = 2;
            this.LABEL_PASSWORD.Text = "Password";
            // 
            // TEXTBOX_USERNAME
            // 
            this.TEXTBOX_USERNAME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TEXTBOX_USERNAME.Location = new System.Drawing.Point(29, 47);
            this.TEXTBOX_USERNAME.Name = "TEXTBOX_USERNAME";
            this.TEXTBOX_USERNAME.ReadOnly = true;
            this.TEXTBOX_USERNAME.Size = new System.Drawing.Size(123, 20);
            this.TEXTBOX_USERNAME.TabIndex = 1;
            // 
            // LABEL_USERNAME
            // 
            this.LABEL_USERNAME.AutoSize = true;
            this.LABEL_USERNAME.Location = new System.Drawing.Point(26, 31);
            this.LABEL_USERNAME.Name = "LABEL_USERNAME";
            this.LABEL_USERNAME.Size = new System.Drawing.Size(55, 13);
            this.LABEL_USERNAME.TabIndex = 0;
            this.LABEL_USERNAME.Text = "Username";
            // 
            // FRM_INICIO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 286);
            this.Controls.Add(this.SPLITCONTAINER_LOGIN);
            this.Controls.Add(this.MENUSTRIP_LOGIN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MENUSTRIP_LOGIN;
            this.MaximizeBox = false;
            this.Name = "FRM_INICIO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TVTuga Admin | Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FRM_INICIO_FormClosed);
            this.MENUSTRIP_LOGIN.ResumeLayout(false);
            this.MENUSTRIP_LOGIN.PerformLayout();
            this.SPLITCONTAINER_LOGIN.Panel1.ResumeLayout(false);
            this.SPLITCONTAINER_LOGIN.Panel2.ResumeLayout(false);
            this.SPLITCONTAINER_LOGIN.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SPLITCONTAINER_LOGIN)).EndInit();
            this.SPLITCONTAINER_LOGIN.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MENUSTRIP_LOGIN;
        private System.Windows.Forms.ToolStripMenuItem MENUSTRIP_LOGIN_FECHAR;
        private System.Windows.Forms.ToolStripMenuItem MENUSTRIP_MAIN_OPCOES;
        private System.Windows.Forms.SplitContainer SPLITCONTAINER_LOGIN;
        private System.Windows.Forms.ListView LISTVIEW_CONTAS;
        private System.Windows.Forms.TextBox TEXTBOX_PASSWORD;
        private System.Windows.Forms.Label LABEL_PASSWORD;
        private System.Windows.Forms.TextBox TEXTBOX_USERNAME;
        private System.Windows.Forms.Label LABEL_USERNAME;
        private System.Windows.Forms.Button BUTTON_LOGIN;
        private System.Windows.Forms.ColumnHeader HDR_USERNAME;
    }
}

