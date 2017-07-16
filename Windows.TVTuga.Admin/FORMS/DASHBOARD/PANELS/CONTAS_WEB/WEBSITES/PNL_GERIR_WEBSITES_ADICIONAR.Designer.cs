namespace Windows.TVTuga.Admin.FORMS.DASHBOARD.PANELS.CONTAS_WEB.WEBSITES
{
    partial class PNL_GERIR_WEBSITES_ADICIONAR
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
            this.SPLITCONTAINER_WEBSITES = new System.Windows.Forms.SplitContainer();
            this.BUTTON_WEBSITES_CRIAR = new System.Windows.Forms.Button();
            this.LABEL_TITULO = new System.Windows.Forms.Label();
            this.GROUPBOX_CONTAS_ASSOCIADAS = new System.Windows.Forms.GroupBox();
            this.LISTVIEW_CONTAS_ASSOCIADAS = new System.Windows.Forms.ListView();
            this.GROUPBOX_SERIES_EPS = new System.Windows.Forms.GroupBox();
            this.TREEVIEW_SERIES_EPS = new System.Windows.Forms.TreeView();
            this.LABEL_TIPO = new System.Windows.Forms.Label();
            this.COMBOBOX_TIPO = new System.Windows.Forms.ComboBox();
            this.TEXTBOX_ENDERECO = new System.Windows.Forms.TextBox();
            this.LABEL_ENDERECO = new System.Windows.Forms.Label();
            this.TEXTBOX_NOME = new System.Windows.Forms.TextBox();
            this.LABEL_NOME = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SPLITCONTAINER_WEBSITES)).BeginInit();
            this.SPLITCONTAINER_WEBSITES.Panel1.SuspendLayout();
            this.SPLITCONTAINER_WEBSITES.Panel2.SuspendLayout();
            this.SPLITCONTAINER_WEBSITES.SuspendLayout();
            this.GROUPBOX_CONTAS_ASSOCIADAS.SuspendLayout();
            this.GROUPBOX_SERIES_EPS.SuspendLayout();
            this.SuspendLayout();
            // 
            // SPLITCONTAINER_WEBSITES
            // 
            this.SPLITCONTAINER_WEBSITES.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SPLITCONTAINER_WEBSITES.Location = new System.Drawing.Point(0, 0);
            this.SPLITCONTAINER_WEBSITES.Margin = new System.Windows.Forms.Padding(0);
            this.SPLITCONTAINER_WEBSITES.Name = "SPLITCONTAINER_WEBSITES";
            this.SPLITCONTAINER_WEBSITES.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // SPLITCONTAINER_WEBSITES.Panel1
            // 
            this.SPLITCONTAINER_WEBSITES.Panel1.Controls.Add(this.BUTTON_WEBSITES_CRIAR);
            this.SPLITCONTAINER_WEBSITES.Panel1.Controls.Add(this.LABEL_TITULO);
            // 
            // SPLITCONTAINER_WEBSITES.Panel2
            // 
            this.SPLITCONTAINER_WEBSITES.Panel2.Controls.Add(this.GROUPBOX_CONTAS_ASSOCIADAS);
            this.SPLITCONTAINER_WEBSITES.Panel2.Controls.Add(this.GROUPBOX_SERIES_EPS);
            this.SPLITCONTAINER_WEBSITES.Panel2.Controls.Add(this.LABEL_TIPO);
            this.SPLITCONTAINER_WEBSITES.Panel2.Controls.Add(this.COMBOBOX_TIPO);
            this.SPLITCONTAINER_WEBSITES.Panel2.Controls.Add(this.TEXTBOX_ENDERECO);
            this.SPLITCONTAINER_WEBSITES.Panel2.Controls.Add(this.LABEL_ENDERECO);
            this.SPLITCONTAINER_WEBSITES.Panel2.Controls.Add(this.TEXTBOX_NOME);
            this.SPLITCONTAINER_WEBSITES.Panel2.Controls.Add(this.LABEL_NOME);
            this.SPLITCONTAINER_WEBSITES.Size = new System.Drawing.Size(853, 510);
            this.SPLITCONTAINER_WEBSITES.SplitterDistance = 95;
            this.SPLITCONTAINER_WEBSITES.SplitterWidth = 1;
            this.SPLITCONTAINER_WEBSITES.TabIndex = 2;
            // 
            // BUTTON_WEBSITES_CRIAR
            // 
            this.BUTTON_WEBSITES_CRIAR.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BUTTON_WEBSITES_CRIAR.Image = global::Windows.TVTuga.Admin.Properties.Resources.check_circle_o_000000_50;
            this.BUTTON_WEBSITES_CRIAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BUTTON_WEBSITES_CRIAR.Location = new System.Drawing.Point(713, 3);
            this.BUTTON_WEBSITES_CRIAR.Name = "BUTTON_WEBSITES_CRIAR";
            this.BUTTON_WEBSITES_CRIAR.Size = new System.Drawing.Size(137, 86);
            this.BUTTON_WEBSITES_CRIAR.TabIndex = 8;
            this.BUTTON_WEBSITES_CRIAR.Text = "Confirmar";
            this.BUTTON_WEBSITES_CRIAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BUTTON_WEBSITES_CRIAR.UseVisualStyleBackColor = true;
            this.BUTTON_WEBSITES_CRIAR.Click += new System.EventHandler(this.BUTTON_WEBSITES_CRIAR_Click);
            // 
            // LABEL_TITULO
            // 
            this.LABEL_TITULO.AutoSize = true;
            this.LABEL_TITULO.Font = new System.Drawing.Font("Trebuchet MS", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL_TITULO.Location = new System.Drawing.Point(194, 23);
            this.LABEL_TITULO.Name = "LABEL_TITULO";
            this.LABEL_TITULO.Size = new System.Drawing.Size(319, 46);
            this.LABEL_TITULO.TabIndex = 7;
            this.LABEL_TITULO.Text = "Adicionar Website";
            // 
            // GROUPBOX_CONTAS_ASSOCIADAS
            // 
            this.GROUPBOX_CONTAS_ASSOCIADAS.Controls.Add(this.LISTVIEW_CONTAS_ASSOCIADAS);
            this.GROUPBOX_CONTAS_ASSOCIADAS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GROUPBOX_CONTAS_ASSOCIADAS.Location = new System.Drawing.Point(393, 24);
            this.GROUPBOX_CONTAS_ASSOCIADAS.Name = "GROUPBOX_CONTAS_ASSOCIADAS";
            this.GROUPBOX_CONTAS_ASSOCIADAS.Size = new System.Drawing.Size(221, 387);
            this.GROUPBOX_CONTAS_ASSOCIADAS.TabIndex = 42;
            this.GROUPBOX_CONTAS_ASSOCIADAS.TabStop = false;
            this.GROUPBOX_CONTAS_ASSOCIADAS.Text = "Contas associadas";
            // 
            // LISTVIEW_CONTAS_ASSOCIADAS
            // 
            this.LISTVIEW_CONTAS_ASSOCIADAS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LISTVIEW_CONTAS_ASSOCIADAS.CheckBoxes = true;
            this.LISTVIEW_CONTAS_ASSOCIADAS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LISTVIEW_CONTAS_ASSOCIADAS.Location = new System.Drawing.Point(3, 18);
            this.LISTVIEW_CONTAS_ASSOCIADAS.Name = "LISTVIEW_CONTAS_ASSOCIADAS";
            this.LISTVIEW_CONTAS_ASSOCIADAS.Size = new System.Drawing.Size(215, 366);
            this.LISTVIEW_CONTAS_ASSOCIADAS.TabIndex = 0;
            this.LISTVIEW_CONTAS_ASSOCIADAS.UseCompatibleStateImageBehavior = false;
            // 
            // GROUPBOX_SERIES_EPS
            // 
            this.GROUPBOX_SERIES_EPS.Controls.Add(this.TREEVIEW_SERIES_EPS);
            this.GROUPBOX_SERIES_EPS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GROUPBOX_SERIES_EPS.Location = new System.Drawing.Point(620, 24);
            this.GROUPBOX_SERIES_EPS.Name = "GROUPBOX_SERIES_EPS";
            this.GROUPBOX_SERIES_EPS.Size = new System.Drawing.Size(221, 387);
            this.GROUPBOX_SERIES_EPS.TabIndex = 41;
            this.GROUPBOX_SERIES_EPS.TabStop = false;
            this.GROUPBOX_SERIES_EPS.Text = "Séries e Episódios neste website";
            // 
            // TREEVIEW_SERIES_EPS
            // 
            this.TREEVIEW_SERIES_EPS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TREEVIEW_SERIES_EPS.CheckBoxes = true;
            this.TREEVIEW_SERIES_EPS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TREEVIEW_SERIES_EPS.Location = new System.Drawing.Point(3, 18);
            this.TREEVIEW_SERIES_EPS.Name = "TREEVIEW_SERIES_EPS";
            this.TREEVIEW_SERIES_EPS.Size = new System.Drawing.Size(215, 366);
            this.TREEVIEW_SERIES_EPS.TabIndex = 1;
            // 
            // LABEL_TIPO
            // 
            this.LABEL_TIPO.AutoSize = true;
            this.LABEL_TIPO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL_TIPO.Location = new System.Drawing.Point(79, 85);
            this.LABEL_TIPO.Name = "LABEL_TIPO";
            this.LABEL_TIPO.Size = new System.Drawing.Size(36, 16);
            this.LABEL_TIPO.TabIndex = 38;
            this.LABEL_TIPO.Text = "Tipo";
            // 
            // COMBOBOX_TIPO
            // 
            this.COMBOBOX_TIPO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.COMBOBOX_TIPO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COMBOBOX_TIPO.FormattingEnabled = true;
            this.COMBOBOX_TIPO.Location = new System.Drawing.Point(121, 84);
            this.COMBOBOX_TIPO.Name = "COMBOBOX_TIPO";
            this.COMBOBOX_TIPO.Size = new System.Drawing.Size(241, 24);
            this.COMBOBOX_TIPO.TabIndex = 37;
            // 
            // TEXTBOX_ENDERECO
            // 
            this.TEXTBOX_ENDERECO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TEXTBOX_ENDERECO.Location = new System.Drawing.Point(121, 58);
            this.TEXTBOX_ENDERECO.Name = "TEXTBOX_ENDERECO";
            this.TEXTBOX_ENDERECO.Size = new System.Drawing.Size(241, 20);
            this.TEXTBOX_ENDERECO.TabIndex = 4;
            // 
            // LABEL_ENDERECO
            // 
            this.LABEL_ENDERECO.AutoSize = true;
            this.LABEL_ENDERECO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL_ENDERECO.Location = new System.Drawing.Point(48, 60);
            this.LABEL_ENDERECO.Name = "LABEL_ENDERECO";
            this.LABEL_ENDERECO.Size = new System.Drawing.Size(67, 16);
            this.LABEL_ENDERECO.TabIndex = 3;
            this.LABEL_ENDERECO.Text = "Endereço";
            // 
            // TEXTBOX_NOME
            // 
            this.TEXTBOX_NOME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TEXTBOX_NOME.Location = new System.Drawing.Point(121, 32);
            this.TEXTBOX_NOME.Name = "TEXTBOX_NOME";
            this.TEXTBOX_NOME.Size = new System.Drawing.Size(241, 20);
            this.TEXTBOX_NOME.TabIndex = 2;
            // 
            // LABEL_NOME
            // 
            this.LABEL_NOME.AutoSize = true;
            this.LABEL_NOME.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL_NOME.Location = new System.Drawing.Point(70, 34);
            this.LABEL_NOME.Name = "LABEL_NOME";
            this.LABEL_NOME.Size = new System.Drawing.Size(45, 16);
            this.LABEL_NOME.TabIndex = 1;
            this.LABEL_NOME.Text = "Nome";
            // 
            // PNL_GERIR_WEBSITES_ADICIONAR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(853, 510);
            this.Controls.Add(this.SPLITCONTAINER_WEBSITES);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PNL_GERIR_WEBSITES_ADICIONAR";
            this.Text = "PNL_GERIR_WEBSITES_ADICIONAR";
            this.Load += new System.EventHandler(this.PNL_GERIR_WEBSITES_ADICIONAR_Load);
            this.SPLITCONTAINER_WEBSITES.Panel1.ResumeLayout(false);
            this.SPLITCONTAINER_WEBSITES.Panel1.PerformLayout();
            this.SPLITCONTAINER_WEBSITES.Panel2.ResumeLayout(false);
            this.SPLITCONTAINER_WEBSITES.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SPLITCONTAINER_WEBSITES)).EndInit();
            this.SPLITCONTAINER_WEBSITES.ResumeLayout(false);
            this.GROUPBOX_CONTAS_ASSOCIADAS.ResumeLayout(false);
            this.GROUPBOX_SERIES_EPS.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer SPLITCONTAINER_WEBSITES;
        private System.Windows.Forms.Label LABEL_TITULO;
        private System.Windows.Forms.Label LABEL_TIPO;
        private System.Windows.Forms.ComboBox COMBOBOX_TIPO;
        private System.Windows.Forms.TextBox TEXTBOX_ENDERECO;
        private System.Windows.Forms.Label LABEL_ENDERECO;
        private System.Windows.Forms.TextBox TEXTBOX_NOME;
        private System.Windows.Forms.Label LABEL_NOME;
        private System.Windows.Forms.Button BUTTON_WEBSITES_CRIAR;
        private System.Windows.Forms.GroupBox GROUPBOX_CONTAS_ASSOCIADAS;
        private System.Windows.Forms.GroupBox GROUPBOX_SERIES_EPS;
        private System.Windows.Forms.TreeView TREEVIEW_SERIES_EPS;
        private System.Windows.Forms.ListView LISTVIEW_CONTAS_ASSOCIADAS;
    }
}