namespace Windows.TVTuga.Admin.FORMS.OPCOES.PANELS.UTILIZADOR
{
    partial class PNL_OPCOES_UTILIZADOR_CONTAS
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
            this.LISTVIEW_CONTAS = new System.Windows.Forms.ListView();
            this.HDR_NOME = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TEXTBOX_USERNAME = new System.Windows.Forms.TextBox();
            this.LABEL_USERNAME = new System.Windows.Forms.Label();
            this.LABEL_RANK = new System.Windows.Forms.Label();
            this.COMBOBOX_RANKS = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // LISTVIEW_CONTAS
            // 
            this.LISTVIEW_CONTAS.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.HDR_NOME});
            this.LISTVIEW_CONTAS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LISTVIEW_CONTAS.FullRowSelect = true;
            this.LISTVIEW_CONTAS.HideSelection = false;
            this.LISTVIEW_CONTAS.Location = new System.Drawing.Point(3, 3);
            this.LISTVIEW_CONTAS.Name = "LISTVIEW_CONTAS";
            this.LISTVIEW_CONTAS.Size = new System.Drawing.Size(111, 226);
            this.LISTVIEW_CONTAS.TabIndex = 0;
            this.LISTVIEW_CONTAS.UseCompatibleStateImageBehavior = false;
            this.LISTVIEW_CONTAS.View = System.Windows.Forms.View.Details;
            this.LISTVIEW_CONTAS.SelectedIndexChanged += new System.EventHandler(this.LISTVIEW_CONTAS_SelectedIndexChanged);
            // 
            // HDR_NOME
            // 
            this.HDR_NOME.Text = "Nome";
            this.HDR_NOME.Width = 107;
            // 
            // TEXTBOX_USERNAME
            // 
            this.TEXTBOX_USERNAME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TEXTBOX_USERNAME.Location = new System.Drawing.Point(123, 25);
            this.TEXTBOX_USERNAME.Name = "TEXTBOX_USERNAME";
            this.TEXTBOX_USERNAME.Size = new System.Drawing.Size(109, 20);
            this.TEXTBOX_USERNAME.TabIndex = 6;
            this.TEXTBOX_USERNAME.TextChanged += new System.EventHandler(this.TEXTBOX_USERNAME_TextChanged);
            // 
            // LABEL_USERNAME
            // 
            this.LABEL_USERNAME.AutoSize = true;
            this.LABEL_USERNAME.Location = new System.Drawing.Point(120, 9);
            this.LABEL_USERNAME.Name = "LABEL_USERNAME";
            this.LABEL_USERNAME.Size = new System.Drawing.Size(55, 13);
            this.LABEL_USERNAME.TabIndex = 5;
            this.LABEL_USERNAME.Text = "Username";
            // 
            // LABEL_RANK
            // 
            this.LABEL_RANK.AutoSize = true;
            this.LABEL_RANK.Location = new System.Drawing.Point(235, 9);
            this.LABEL_RANK.Name = "LABEL_RANK";
            this.LABEL_RANK.Size = new System.Drawing.Size(33, 13);
            this.LABEL_RANK.TabIndex = 10;
            this.LABEL_RANK.Text = "Rank";
            // 
            // COMBOBOX_RANKS
            // 
            this.COMBOBOX_RANKS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.COMBOBOX_RANKS.FormattingEnabled = true;
            this.COMBOBOX_RANKS.Items.AddRange(new object[] {
            "Colaborador",
            "Staff",
            "Moderador",
            "Administrador",
            "Super-Administrador"});
            this.COMBOBOX_RANKS.Location = new System.Drawing.Point(238, 24);
            this.COMBOBOX_RANKS.Name = "COMBOBOX_RANKS";
            this.COMBOBOX_RANKS.Size = new System.Drawing.Size(84, 21);
            this.COMBOBOX_RANKS.TabIndex = 11;
            // 
            // PNL_OPCOES_UTILIZADOR_CONTAS
            // 
            this.ClientSize = new System.Drawing.Size(325, 233);
            this.Controls.Add(this.COMBOBOX_RANKS);
            this.Controls.Add(this.LABEL_RANK);
            this.Controls.Add(this.TEXTBOX_USERNAME);
            this.Controls.Add(this.LABEL_USERNAME);
            this.Controls.Add(this.LISTVIEW_CONTAS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PNL_OPCOES_UTILIZADOR_CONTAS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListView LISTVIEW_CONTAS;
        public System.Windows.Forms.TextBox TEXTBOX_USERNAME;
        private System.Windows.Forms.Label LABEL_USERNAME;
        private System.Windows.Forms.ColumnHeader HDR_NOME;
        private System.Windows.Forms.Label LABEL_RANK;
        public System.Windows.Forms.ComboBox COMBOBOX_RANKS;
    }
}
