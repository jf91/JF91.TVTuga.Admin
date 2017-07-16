namespace Windows.TVTuga.Admin.FORMS.DASHBOARD.PANELS.CONTAS_WEB.WEBSITES
{
    partial class PNL_GERIR_WEBSITES_ADICIONAR_TIPO
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
            this.LABEL_TITULO = new System.Windows.Forms.Label();
            this.GROUPBOX_TIPOS_WEBSITES = new System.Windows.Forms.GroupBox();
            this.LISTVIEW_TIPOS_WEBSITES = new System.Windows.Forms.ListView();
            this.TEXTBOX_NOME = new System.Windows.Forms.TextBox();
            this.LABEL_NOME = new System.Windows.Forms.Label();
            this.HDR_NOME = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BUTTON_REMOVER = new System.Windows.Forms.Button();
            this.BUTTON_CONFIRMAR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SPLITCONTAINER_WEBSITES)).BeginInit();
            this.SPLITCONTAINER_WEBSITES.Panel1.SuspendLayout();
            this.SPLITCONTAINER_WEBSITES.Panel2.SuspendLayout();
            this.SPLITCONTAINER_WEBSITES.SuspendLayout();
            this.GROUPBOX_TIPOS_WEBSITES.SuspendLayout();
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
            this.SPLITCONTAINER_WEBSITES.Panel1.Controls.Add(this.BUTTON_REMOVER);
            this.SPLITCONTAINER_WEBSITES.Panel1.Controls.Add(this.BUTTON_CONFIRMAR);
            this.SPLITCONTAINER_WEBSITES.Panel1.Controls.Add(this.LABEL_TITULO);
            // 
            // SPLITCONTAINER_WEBSITES.Panel2
            // 
            this.SPLITCONTAINER_WEBSITES.Panel2.Controls.Add(this.GROUPBOX_TIPOS_WEBSITES);
            this.SPLITCONTAINER_WEBSITES.Panel2.Controls.Add(this.TEXTBOX_NOME);
            this.SPLITCONTAINER_WEBSITES.Panel2.Controls.Add(this.LABEL_NOME);
            this.SPLITCONTAINER_WEBSITES.Size = new System.Drawing.Size(853, 510);
            this.SPLITCONTAINER_WEBSITES.SplitterDistance = 95;
            this.SPLITCONTAINER_WEBSITES.SplitterWidth = 1;
            this.SPLITCONTAINER_WEBSITES.TabIndex = 3;
            // 
            // LABEL_TITULO
            // 
            this.LABEL_TITULO.AutoSize = true;
            this.LABEL_TITULO.Font = new System.Drawing.Font("Trebuchet MS", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL_TITULO.Location = new System.Drawing.Point(60, 23);
            this.LABEL_TITULO.Name = "LABEL_TITULO";
            this.LABEL_TITULO.Size = new System.Drawing.Size(407, 46);
            this.LABEL_TITULO.TabIndex = 7;
            this.LABEL_TITULO.Text = "Gerir tipos de Websites";
            // 
            // GROUPBOX_TIPOS_WEBSITES
            // 
            this.GROUPBOX_TIPOS_WEBSITES.Controls.Add(this.LISTVIEW_TIPOS_WEBSITES);
            this.GROUPBOX_TIPOS_WEBSITES.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GROUPBOX_TIPOS_WEBSITES.Location = new System.Drawing.Point(129, 15);
            this.GROUPBOX_TIPOS_WEBSITES.Name = "GROUPBOX_TIPOS_WEBSITES";
            this.GROUPBOX_TIPOS_WEBSITES.Size = new System.Drawing.Size(221, 387);
            this.GROUPBOX_TIPOS_WEBSITES.TabIndex = 42;
            this.GROUPBOX_TIPOS_WEBSITES.TabStop = false;
            this.GROUPBOX_TIPOS_WEBSITES.Text = "Tipos de Website";
            // 
            // LISTVIEW_TIPOS_WEBSITES
            // 
            this.LISTVIEW_TIPOS_WEBSITES.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LISTVIEW_TIPOS_WEBSITES.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.HDR_NOME});
            this.LISTVIEW_TIPOS_WEBSITES.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LISTVIEW_TIPOS_WEBSITES.HideSelection = false;
            this.LISTVIEW_TIPOS_WEBSITES.Location = new System.Drawing.Point(3, 18);
            this.LISTVIEW_TIPOS_WEBSITES.Name = "LISTVIEW_TIPOS_WEBSITES";
            this.LISTVIEW_TIPOS_WEBSITES.Size = new System.Drawing.Size(215, 366);
            this.LISTVIEW_TIPOS_WEBSITES.TabIndex = 0;
            this.LISTVIEW_TIPOS_WEBSITES.UseCompatibleStateImageBehavior = false;
            this.LISTVIEW_TIPOS_WEBSITES.View = System.Windows.Forms.View.List;
            this.LISTVIEW_TIPOS_WEBSITES.SelectedIndexChanged += new System.EventHandler(this.LISTVIEW_TIPOS_WEBSITES_SelectedIndexChanged);
            // 
            // TEXTBOX_NOME
            // 
            this.TEXTBOX_NOME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TEXTBOX_NOME.Location = new System.Drawing.Point(418, 31);
            this.TEXTBOX_NOME.Name = "TEXTBOX_NOME";
            this.TEXTBOX_NOME.Size = new System.Drawing.Size(241, 20);
            this.TEXTBOX_NOME.TabIndex = 2;
            // 
            // LABEL_NOME
            // 
            this.LABEL_NOME.AutoSize = true;
            this.LABEL_NOME.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL_NOME.Location = new System.Drawing.Point(367, 33);
            this.LABEL_NOME.Name = "LABEL_NOME";
            this.LABEL_NOME.Size = new System.Drawing.Size(45, 16);
            this.LABEL_NOME.TabIndex = 1;
            this.LABEL_NOME.Text = "Nome";
            // 
            // HDR_NOME
            // 
            this.HDR_NOME.Text = "Nome";
            this.HDR_NOME.Width = 200;
            // 
            // BUTTON_REMOVER
            // 
            this.BUTTON_REMOVER.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BUTTON_REMOVER.Image = global::Windows.TVTuga.Admin.Properties.Resources.trash_o_000000_50;
            this.BUTTON_REMOVER.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BUTTON_REMOVER.Location = new System.Drawing.Point(713, 3);
            this.BUTTON_REMOVER.Name = "BUTTON_REMOVER";
            this.BUTTON_REMOVER.Size = new System.Drawing.Size(137, 86);
            this.BUTTON_REMOVER.TabIndex = 9;
            this.BUTTON_REMOVER.Text = "Remover";
            this.BUTTON_REMOVER.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BUTTON_REMOVER.UseVisualStyleBackColor = true;
            this.BUTTON_REMOVER.Click += new System.EventHandler(this.BUTTON_REMOVER_Click);
            // 
            // BUTTON_CONFIRMAR
            // 
            this.BUTTON_CONFIRMAR.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BUTTON_CONFIRMAR.Image = global::Windows.TVTuga.Admin.Properties.Resources.check_circle_o_000000_50;
            this.BUTTON_CONFIRMAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BUTTON_CONFIRMAR.Location = new System.Drawing.Point(570, 3);
            this.BUTTON_CONFIRMAR.Name = "BUTTON_CONFIRMAR";
            this.BUTTON_CONFIRMAR.Size = new System.Drawing.Size(137, 86);
            this.BUTTON_CONFIRMAR.TabIndex = 8;
            this.BUTTON_CONFIRMAR.Text = "Confirmar";
            this.BUTTON_CONFIRMAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BUTTON_CONFIRMAR.UseVisualStyleBackColor = true;
            this.BUTTON_CONFIRMAR.Click += new System.EventHandler(this.BUTTON_CONFIRMAR_Click);
            // 
            // PNL_GERIR_WEBSITES_ADICIONAR_TIPO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(853, 510);
            this.Controls.Add(this.SPLITCONTAINER_WEBSITES);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PNL_GERIR_WEBSITES_ADICIONAR_TIPO";
            this.Text = "PNL_GERIR_WEBSITES_ADICIONAR_TIPO";
            this.Load += new System.EventHandler(this.PNL_GERIR_WEBSITES_ADICIONAR_TIPO_Load);
            this.SPLITCONTAINER_WEBSITES.Panel1.ResumeLayout(false);
            this.SPLITCONTAINER_WEBSITES.Panel1.PerformLayout();
            this.SPLITCONTAINER_WEBSITES.Panel2.ResumeLayout(false);
            this.SPLITCONTAINER_WEBSITES.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SPLITCONTAINER_WEBSITES)).EndInit();
            this.SPLITCONTAINER_WEBSITES.ResumeLayout(false);
            this.GROUPBOX_TIPOS_WEBSITES.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer SPLITCONTAINER_WEBSITES;
        private System.Windows.Forms.Button BUTTON_CONFIRMAR;
        private System.Windows.Forms.Label LABEL_TITULO;
        private System.Windows.Forms.GroupBox GROUPBOX_TIPOS_WEBSITES;
        private System.Windows.Forms.ListView LISTVIEW_TIPOS_WEBSITES;
        private System.Windows.Forms.TextBox TEXTBOX_NOME;
        private System.Windows.Forms.Label LABEL_NOME;
        private System.Windows.Forms.ColumnHeader HDR_NOME;
        private System.Windows.Forms.Button BUTTON_REMOVER;
    }
}