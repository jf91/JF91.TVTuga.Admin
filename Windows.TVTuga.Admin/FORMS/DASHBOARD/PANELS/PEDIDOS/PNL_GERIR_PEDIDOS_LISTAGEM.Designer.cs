namespace Windows.TVTuga.Admin.FORMS.DASHBOARD.PANELS.PEDIDOS
{
    partial class PNL_GERIR_PEDIDOS_LISTAGEM
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
            this.LABEL_TITULO = new System.Windows.Forms.Label();
            this.BUTTON_PEDIDOS_RESPONDER = new System.Windows.Forms.Button();
            this.TEXTBOX_RESPOSTA = new System.Windows.Forms.TextBox();
            this.LABEL_RESPOSTA = new System.Windows.Forms.Label();
            this.DATETIMEPICKER = new System.Windows.Forms.DateTimePicker();
            this.LABEL_DATA = new System.Windows.Forms.Label();
            this.GROUPBOX_TOTAL_PEDIDOS = new System.Windows.Forms.GroupBox();
            this.LISTVIEW_TOTAL_PEDIDOS = new System.Windows.Forms.ListView();
            this.GROUPBOX_TOTAL_PEDIDOS_CONCLUIDOS = new System.Windows.Forms.GroupBox();
            this.LISTVIEW_TOTAL_PEDIDOS_CONCLUIDOS = new System.Windows.Forms.ListView();
            this.GROUPBOX_ESTADO = new System.Windows.Forms.GroupBox();
            this.RADIOBUTTON_CONCLUIDO = new System.Windows.Forms.RadioButton();
            this.RADIOBUTTON_A_SER_PROCESSADO = new System.Windows.Forms.RadioButton();
            this.RADIOBUTTON_ESPERA = new System.Windows.Forms.RadioButton();
            this.LABEL_DESCRICAO = new System.Windows.Forms.Label();
            this.TEXTBOX_DESCRICAO = new System.Windows.Forms.TextBox();
            this.TEXTBOX_USERNAME = new System.Windows.Forms.TextBox();
            this.GROUPBOX_FILTRAR = new System.Windows.Forms.GroupBox();
            this.RADIOBUTTON_FILTRAR_ESTADO = new System.Windows.Forms.RadioButton();
            this.RADIOBUTTON_FILTRAR_VOTOS = new System.Windows.Forms.RadioButton();
            this.RADIOBUTTON_FILTRAR_USERNAME = new System.Windows.Forms.RadioButton();
            this.TEXTBOX_FILTRAR = new System.Windows.Forms.TextBox();
            this.GROUPBOX_VOTOS = new System.Windows.Forms.GroupBox();
            this.LISTVIEW_VOTOS = new System.Windows.Forms.ListView();
            this.LABEL_USERNAME = new System.Windows.Forms.Label();
            this.LISTVIEW_PEDIDOS = new System.Windows.Forms.ListView();
            this.HDR_PEDIDO = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HDR_USERNAME = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.SPLITCONTAINER_PEDIDOS)).BeginInit();
            this.SPLITCONTAINER_PEDIDOS.Panel1.SuspendLayout();
            this.SPLITCONTAINER_PEDIDOS.Panel2.SuspendLayout();
            this.SPLITCONTAINER_PEDIDOS.SuspendLayout();
            this.GROUPBOX_TOTAL_PEDIDOS.SuspendLayout();
            this.GROUPBOX_TOTAL_PEDIDOS_CONCLUIDOS.SuspendLayout();
            this.GROUPBOX_ESTADO.SuspendLayout();
            this.GROUPBOX_FILTRAR.SuspendLayout();
            this.GROUPBOX_VOTOS.SuspendLayout();
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
            this.SPLITCONTAINER_PEDIDOS.Panel1.Controls.Add(this.LABEL_TITULO);
            this.SPLITCONTAINER_PEDIDOS.Panel1.Controls.Add(this.BUTTON_PEDIDOS_RESPONDER);
            // 
            // SPLITCONTAINER_PEDIDOS.Panel2
            // 
            this.SPLITCONTAINER_PEDIDOS.Panel2.Controls.Add(this.TEXTBOX_RESPOSTA);
            this.SPLITCONTAINER_PEDIDOS.Panel2.Controls.Add(this.LABEL_RESPOSTA);
            this.SPLITCONTAINER_PEDIDOS.Panel2.Controls.Add(this.DATETIMEPICKER);
            this.SPLITCONTAINER_PEDIDOS.Panel2.Controls.Add(this.LABEL_DATA);
            this.SPLITCONTAINER_PEDIDOS.Panel2.Controls.Add(this.GROUPBOX_TOTAL_PEDIDOS);
            this.SPLITCONTAINER_PEDIDOS.Panel2.Controls.Add(this.GROUPBOX_TOTAL_PEDIDOS_CONCLUIDOS);
            this.SPLITCONTAINER_PEDIDOS.Panel2.Controls.Add(this.GROUPBOX_ESTADO);
            this.SPLITCONTAINER_PEDIDOS.Panel2.Controls.Add(this.LABEL_DESCRICAO);
            this.SPLITCONTAINER_PEDIDOS.Panel2.Controls.Add(this.TEXTBOX_DESCRICAO);
            this.SPLITCONTAINER_PEDIDOS.Panel2.Controls.Add(this.TEXTBOX_USERNAME);
            this.SPLITCONTAINER_PEDIDOS.Panel2.Controls.Add(this.GROUPBOX_FILTRAR);
            this.SPLITCONTAINER_PEDIDOS.Panel2.Controls.Add(this.GROUPBOX_VOTOS);
            this.SPLITCONTAINER_PEDIDOS.Panel2.Controls.Add(this.LABEL_USERNAME);
            this.SPLITCONTAINER_PEDIDOS.Panel2.Controls.Add(this.LISTVIEW_PEDIDOS);
            this.SPLITCONTAINER_PEDIDOS.Size = new System.Drawing.Size(1010, 521);
            this.SPLITCONTAINER_PEDIDOS.SplitterDistance = 97;
            this.SPLITCONTAINER_PEDIDOS.SplitterWidth = 1;
            this.SPLITCONTAINER_PEDIDOS.TabIndex = 2;
            // 
            // LABEL_TITULO
            // 
            this.LABEL_TITULO.AutoSize = true;
            this.LABEL_TITULO.Font = new System.Drawing.Font("Trebuchet MS", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL_TITULO.Location = new System.Drawing.Point(270, 23);
            this.LABEL_TITULO.Name = "LABEL_TITULO";
            this.LABEL_TITULO.Size = new System.Drawing.Size(324, 46);
            this.LABEL_TITULO.TabIndex = 7;
            this.LABEL_TITULO.Text = "Gestão de Pedidos";
            // 
            // BUTTON_PEDIDOS_RESPONDER
            // 
            this.BUTTON_PEDIDOS_RESPONDER.Enabled = false;
            this.BUTTON_PEDIDOS_RESPONDER.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BUTTON_PEDIDOS_RESPONDER.Image = global::Windows.TVTuga.Admin.Properties.Resources.paper_plane_o_000000_50;
            this.BUTTON_PEDIDOS_RESPONDER.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BUTTON_PEDIDOS_RESPONDER.Location = new System.Drawing.Point(870, 3);
            this.BUTTON_PEDIDOS_RESPONDER.Name = "BUTTON_PEDIDOS_RESPONDER";
            this.BUTTON_PEDIDOS_RESPONDER.Size = new System.Drawing.Size(137, 86);
            this.BUTTON_PEDIDOS_RESPONDER.TabIndex = 5;
            this.BUTTON_PEDIDOS_RESPONDER.Text = "Responder";
            this.BUTTON_PEDIDOS_RESPONDER.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BUTTON_PEDIDOS_RESPONDER.UseVisualStyleBackColor = true;
            // 
            // TEXTBOX_RESPOSTA
            // 
            this.TEXTBOX_RESPOSTA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TEXTBOX_RESPOSTA.Enabled = false;
            this.TEXTBOX_RESPOSTA.Location = new System.Drawing.Point(672, 26);
            this.TEXTBOX_RESPOSTA.Multiline = true;
            this.TEXTBOX_RESPOSTA.Name = "TEXTBOX_RESPOSTA";
            this.TEXTBOX_RESPOSTA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TEXTBOX_RESPOSTA.Size = new System.Drawing.Size(184, 69);
            this.TEXTBOX_RESPOSTA.TabIndex = 56;
            // 
            // LABEL_RESPOSTA
            // 
            this.LABEL_RESPOSTA.AutoSize = true;
            this.LABEL_RESPOSTA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL_RESPOSTA.Location = new System.Drawing.Point(599, 29);
            this.LABEL_RESPOSTA.Name = "LABEL_RESPOSTA";
            this.LABEL_RESPOSTA.Size = new System.Drawing.Size(67, 16);
            this.LABEL_RESPOSTA.TabIndex = 55;
            this.LABEL_RESPOSTA.Text = "Resposta";
            // 
            // DATETIMEPICKER
            // 
            this.DATETIMEPICKER.Enabled = false;
            this.DATETIMEPICKER.Location = new System.Drawing.Point(672, 3);
            this.DATETIMEPICKER.Name = "DATETIMEPICKER";
            this.DATETIMEPICKER.Size = new System.Drawing.Size(184, 20);
            this.DATETIMEPICKER.TabIndex = 54;
            // 
            // LABEL_DATA
            // 
            this.LABEL_DATA.AutoSize = true;
            this.LABEL_DATA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL_DATA.Location = new System.Drawing.Point(629, 5);
            this.LABEL_DATA.Name = "LABEL_DATA";
            this.LABEL_DATA.Size = new System.Drawing.Size(37, 16);
            this.LABEL_DATA.TabIndex = 53;
            this.LABEL_DATA.Text = "Data";
            // 
            // GROUPBOX_TOTAL_PEDIDOS
            // 
            this.GROUPBOX_TOTAL_PEDIDOS.Controls.Add(this.LISTVIEW_TOTAL_PEDIDOS);
            this.GROUPBOX_TOTAL_PEDIDOS.Enabled = false;
            this.GROUPBOX_TOTAL_PEDIDOS.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GROUPBOX_TOTAL_PEDIDOS.Location = new System.Drawing.Point(585, 165);
            this.GROUPBOX_TOTAL_PEDIDOS.Name = "GROUPBOX_TOTAL_PEDIDOS";
            this.GROUPBOX_TOTAL_PEDIDOS.Size = new System.Drawing.Size(208, 255);
            this.GROUPBOX_TOTAL_PEDIDOS.TabIndex = 39;
            this.GROUPBOX_TOTAL_PEDIDOS.TabStop = false;
            this.GROUPBOX_TOTAL_PEDIDOS.Text = "Total de pedidos";
            // 
            // LISTVIEW_TOTAL_PEDIDOS
            // 
            this.LISTVIEW_TOTAL_PEDIDOS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LISTVIEW_TOTAL_PEDIDOS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LISTVIEW_TOTAL_PEDIDOS.Location = new System.Drawing.Point(3, 19);
            this.LISTVIEW_TOTAL_PEDIDOS.Name = "LISTVIEW_TOTAL_PEDIDOS";
            this.LISTVIEW_TOTAL_PEDIDOS.Size = new System.Drawing.Size(202, 233);
            this.LISTVIEW_TOTAL_PEDIDOS.TabIndex = 1;
            this.LISTVIEW_TOTAL_PEDIDOS.UseCompatibleStateImageBehavior = false;
            // 
            // GROUPBOX_TOTAL_PEDIDOS_CONCLUIDOS
            // 
            this.GROUPBOX_TOTAL_PEDIDOS_CONCLUIDOS.Controls.Add(this.LISTVIEW_TOTAL_PEDIDOS_CONCLUIDOS);
            this.GROUPBOX_TOTAL_PEDIDOS_CONCLUIDOS.Enabled = false;
            this.GROUPBOX_TOTAL_PEDIDOS_CONCLUIDOS.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GROUPBOX_TOTAL_PEDIDOS_CONCLUIDOS.Location = new System.Drawing.Point(799, 165);
            this.GROUPBOX_TOTAL_PEDIDOS_CONCLUIDOS.Name = "GROUPBOX_TOTAL_PEDIDOS_CONCLUIDOS";
            this.GROUPBOX_TOTAL_PEDIDOS_CONCLUIDOS.Size = new System.Drawing.Size(208, 255);
            this.GROUPBOX_TOTAL_PEDIDOS_CONCLUIDOS.TabIndex = 39;
            this.GROUPBOX_TOTAL_PEDIDOS_CONCLUIDOS.TabStop = false;
            this.GROUPBOX_TOTAL_PEDIDOS_CONCLUIDOS.Text = "Total de pedidos concluidos";
            // 
            // LISTVIEW_TOTAL_PEDIDOS_CONCLUIDOS
            // 
            this.LISTVIEW_TOTAL_PEDIDOS_CONCLUIDOS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LISTVIEW_TOTAL_PEDIDOS_CONCLUIDOS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LISTVIEW_TOTAL_PEDIDOS_CONCLUIDOS.Location = new System.Drawing.Point(3, 19);
            this.LISTVIEW_TOTAL_PEDIDOS_CONCLUIDOS.Name = "LISTVIEW_TOTAL_PEDIDOS_CONCLUIDOS";
            this.LISTVIEW_TOTAL_PEDIDOS_CONCLUIDOS.Size = new System.Drawing.Size(202, 233);
            this.LISTVIEW_TOTAL_PEDIDOS_CONCLUIDOS.TabIndex = 1;
            this.LISTVIEW_TOTAL_PEDIDOS_CONCLUIDOS.UseCompatibleStateImageBehavior = false;
            // 
            // GROUPBOX_ESTADO
            // 
            this.GROUPBOX_ESTADO.Controls.Add(this.RADIOBUTTON_CONCLUIDO);
            this.GROUPBOX_ESTADO.Controls.Add(this.RADIOBUTTON_A_SER_PROCESSADO);
            this.GROUPBOX_ESTADO.Controls.Add(this.RADIOBUTTON_ESPERA);
            this.GROUPBOX_ESTADO.Enabled = false;
            this.GROUPBOX_ESTADO.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GROUPBOX_ESTADO.Location = new System.Drawing.Point(862, 4);
            this.GROUPBOX_ESTADO.Name = "GROUPBOX_ESTADO";
            this.GROUPBOX_ESTADO.Size = new System.Drawing.Size(145, 94);
            this.GROUPBOX_ESTADO.TabIndex = 47;
            this.GROUPBOX_ESTADO.TabStop = false;
            this.GROUPBOX_ESTADO.Text = "Estado";
            // 
            // RADIOBUTTON_CONCLUIDO
            // 
            this.RADIOBUTTON_CONCLUIDO.AutoSize = true;
            this.RADIOBUTTON_CONCLUIDO.Location = new System.Drawing.Point(18, 65);
            this.RADIOBUTTON_CONCLUIDO.Name = "RADIOBUTTON_CONCLUIDO";
            this.RADIOBUTTON_CONCLUIDO.Size = new System.Drawing.Size(82, 22);
            this.RADIOBUTTON_CONCLUIDO.TabIndex = 2;
            this.RADIOBUTTON_CONCLUIDO.TabStop = true;
            this.RADIOBUTTON_CONCLUIDO.Text = "Concluído";
            this.RADIOBUTTON_CONCLUIDO.UseVisualStyleBackColor = true;
            // 
            // RADIOBUTTON_A_SER_PROCESSADO
            // 
            this.RADIOBUTTON_A_SER_PROCESSADO.AutoSize = true;
            this.RADIOBUTTON_A_SER_PROCESSADO.Location = new System.Drawing.Point(18, 42);
            this.RADIOBUTTON_A_SER_PROCESSADO.Name = "RADIOBUTTON_A_SER_PROCESSADO";
            this.RADIOBUTTON_A_SER_PROCESSADO.Size = new System.Drawing.Size(124, 22);
            this.RADIOBUTTON_A_SER_PROCESSADO.TabIndex = 1;
            this.RADIOBUTTON_A_SER_PROCESSADO.TabStop = true;
            this.RADIOBUTTON_A_SER_PROCESSADO.Text = "A Ser Processado";
            this.RADIOBUTTON_A_SER_PROCESSADO.UseVisualStyleBackColor = true;
            // 
            // RADIOBUTTON_ESPERA
            // 
            this.RADIOBUTTON_ESPERA.AutoSize = true;
            this.RADIOBUTTON_ESPERA.Location = new System.Drawing.Point(18, 19);
            this.RADIOBUTTON_ESPERA.Name = "RADIOBUTTON_ESPERA";
            this.RADIOBUTTON_ESPERA.Size = new System.Drawing.Size(87, 22);
            this.RADIOBUTTON_ESPERA.TabIndex = 0;
            this.RADIOBUTTON_ESPERA.TabStop = true;
            this.RADIOBUTTON_ESPERA.Text = "Em Espera";
            this.RADIOBUTTON_ESPERA.UseVisualStyleBackColor = true;
            // 
            // LABEL_DESCRICAO
            // 
            this.LABEL_DESCRICAO.AutoSize = true;
            this.LABEL_DESCRICAO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL_DESCRICAO.Location = new System.Drawing.Point(322, 31);
            this.LABEL_DESCRICAO.Name = "LABEL_DESCRICAO";
            this.LABEL_DESCRICAO.Size = new System.Drawing.Size(70, 16);
            this.LABEL_DESCRICAO.TabIndex = 46;
            this.LABEL_DESCRICAO.Text = "Descrição";
            // 
            // TEXTBOX_DESCRICAO
            // 
            this.TEXTBOX_DESCRICAO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TEXTBOX_DESCRICAO.Enabled = false;
            this.TEXTBOX_DESCRICAO.Location = new System.Drawing.Point(396, 29);
            this.TEXTBOX_DESCRICAO.Multiline = true;
            this.TEXTBOX_DESCRICAO.Name = "TEXTBOX_DESCRICAO";
            this.TEXTBOX_DESCRICAO.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TEXTBOX_DESCRICAO.Size = new System.Drawing.Size(183, 69);
            this.TEXTBOX_DESCRICAO.TabIndex = 45;
            // 
            // TEXTBOX_USERNAME
            // 
            this.TEXTBOX_USERNAME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TEXTBOX_USERNAME.Enabled = false;
            this.TEXTBOX_USERNAME.Location = new System.Drawing.Point(396, 3);
            this.TEXTBOX_USERNAME.Name = "TEXTBOX_USERNAME";
            this.TEXTBOX_USERNAME.Size = new System.Drawing.Size(183, 20);
            this.TEXTBOX_USERNAME.TabIndex = 41;
            // 
            // GROUPBOX_FILTRAR
            // 
            this.GROUPBOX_FILTRAR.Controls.Add(this.RADIOBUTTON_FILTRAR_ESTADO);
            this.GROUPBOX_FILTRAR.Controls.Add(this.RADIOBUTTON_FILTRAR_VOTOS);
            this.GROUPBOX_FILTRAR.Controls.Add(this.RADIOBUTTON_FILTRAR_USERNAME);
            this.GROUPBOX_FILTRAR.Controls.Add(this.TEXTBOX_FILTRAR);
            this.GROUPBOX_FILTRAR.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GROUPBOX_FILTRAR.Location = new System.Drawing.Point(3, 269);
            this.GROUPBOX_FILTRAR.Name = "GROUPBOX_FILTRAR";
            this.GROUPBOX_FILTRAR.Size = new System.Drawing.Size(313, 142);
            this.GROUPBOX_FILTRAR.TabIndex = 39;
            this.GROUPBOX_FILTRAR.TabStop = false;
            this.GROUPBOX_FILTRAR.Text = "Filtrar";
            // 
            // RADIOBUTTON_FILTRAR_ESTADO
            // 
            this.RADIOBUTTON_FILTRAR_ESTADO.AutoSize = true;
            this.RADIOBUTTON_FILTRAR_ESTADO.Location = new System.Drawing.Point(47, 48);
            this.RADIOBUTTON_FILTRAR_ESTADO.Name = "RADIOBUTTON_FILTRAR_ESTADO";
            this.RADIOBUTTON_FILTRAR_ESTADO.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RADIOBUTTON_FILTRAR_ESTADO.Size = new System.Drawing.Size(65, 22);
            this.RADIOBUTTON_FILTRAR_ESTADO.TabIndex = 47;
            this.RADIOBUTTON_FILTRAR_ESTADO.TabStop = true;
            this.RADIOBUTTON_FILTRAR_ESTADO.Text = "Estado";
            this.RADIOBUTTON_FILTRAR_ESTADO.UseVisualStyleBackColor = true;
            // 
            // RADIOBUTTON_FILTRAR_VOTOS
            // 
            this.RADIOBUTTON_FILTRAR_VOTOS.AutoSize = true;
            this.RADIOBUTTON_FILTRAR_VOTOS.Location = new System.Drawing.Point(55, 76);
            this.RADIOBUTTON_FILTRAR_VOTOS.Name = "RADIOBUTTON_FILTRAR_VOTOS";
            this.RADIOBUTTON_FILTRAR_VOTOS.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RADIOBUTTON_FILTRAR_VOTOS.Size = new System.Drawing.Size(57, 22);
            this.RADIOBUTTON_FILTRAR_VOTOS.TabIndex = 46;
            this.RADIOBUTTON_FILTRAR_VOTOS.TabStop = true;
            this.RADIOBUTTON_FILTRAR_VOTOS.Text = "Votos";
            this.RADIOBUTTON_FILTRAR_VOTOS.UseVisualStyleBackColor = true;
            // 
            // RADIOBUTTON_FILTRAR_USERNAME
            // 
            this.RADIOBUTTON_FILTRAR_USERNAME.AutoSize = true;
            this.RADIOBUTTON_FILTRAR_USERNAME.Location = new System.Drawing.Point(28, 20);
            this.RADIOBUTTON_FILTRAR_USERNAME.Name = "RADIOBUTTON_FILTRAR_USERNAME";
            this.RADIOBUTTON_FILTRAR_USERNAME.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RADIOBUTTON_FILTRAR_USERNAME.Size = new System.Drawing.Size(84, 22);
            this.RADIOBUTTON_FILTRAR_USERNAME.TabIndex = 45;
            this.RADIOBUTTON_FILTRAR_USERNAME.TabStop = true;
            this.RADIOBUTTON_FILTRAR_USERNAME.Text = "Username";
            this.RADIOBUTTON_FILTRAR_USERNAME.UseVisualStyleBackColor = true;
            // 
            // TEXTBOX_FILTRAR
            // 
            this.TEXTBOX_FILTRAR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TEXTBOX_FILTRAR.Enabled = false;
            this.TEXTBOX_FILTRAR.Location = new System.Drawing.Point(118, 19);
            this.TEXTBOX_FILTRAR.Name = "TEXTBOX_FILTRAR";
            this.TEXTBOX_FILTRAR.Size = new System.Drawing.Size(187, 23);
            this.TEXTBOX_FILTRAR.TabIndex = 44;
            // 
            // GROUPBOX_VOTOS
            // 
            this.GROUPBOX_VOTOS.Controls.Add(this.LISTVIEW_VOTOS);
            this.GROUPBOX_VOTOS.Enabled = false;
            this.GROUPBOX_VOTOS.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GROUPBOX_VOTOS.Location = new System.Drawing.Point(371, 165);
            this.GROUPBOX_VOTOS.Name = "GROUPBOX_VOTOS";
            this.GROUPBOX_VOTOS.Size = new System.Drawing.Size(208, 255);
            this.GROUPBOX_VOTOS.TabIndex = 38;
            this.GROUPBOX_VOTOS.TabStop = false;
            this.GROUPBOX_VOTOS.Text = "Votos dos utilizadores";
            // 
            // LISTVIEW_VOTOS
            // 
            this.LISTVIEW_VOTOS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LISTVIEW_VOTOS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LISTVIEW_VOTOS.Location = new System.Drawing.Point(3, 19);
            this.LISTVIEW_VOTOS.Name = "LISTVIEW_VOTOS";
            this.LISTVIEW_VOTOS.Size = new System.Drawing.Size(202, 233);
            this.LISTVIEW_VOTOS.TabIndex = 0;
            this.LISTVIEW_VOTOS.UseCompatibleStateImageBehavior = false;
            // 
            // LABEL_USERNAME
            // 
            this.LABEL_USERNAME.AutoSize = true;
            this.LABEL_USERNAME.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL_USERNAME.Location = new System.Drawing.Point(321, 4);
            this.LABEL_USERNAME.Name = "LABEL_USERNAME";
            this.LABEL_USERNAME.Size = new System.Drawing.Size(71, 16);
            this.LABEL_USERNAME.TabIndex = 1;
            this.LABEL_USERNAME.Text = "Username";
            // 
            // LISTVIEW_PEDIDOS
            // 
            this.LISTVIEW_PEDIDOS.BackColor = System.Drawing.Color.White;
            this.LISTVIEW_PEDIDOS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LISTVIEW_PEDIDOS.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.HDR_PEDIDO,
            this.HDR_USERNAME});
            this.LISTVIEW_PEDIDOS.Location = new System.Drawing.Point(-1, 1);
            this.LISTVIEW_PEDIDOS.Name = "LISTVIEW_PEDIDOS";
            this.LISTVIEW_PEDIDOS.Size = new System.Drawing.Size(317, 262);
            this.LISTVIEW_PEDIDOS.TabIndex = 0;
            this.LISTVIEW_PEDIDOS.UseCompatibleStateImageBehavior = false;
            this.LISTVIEW_PEDIDOS.View = System.Windows.Forms.View.Details;
            // 
            // HDR_PEDIDO
            // 
            this.HDR_PEDIDO.Text = "Pedido";
            this.HDR_PEDIDO.Width = 150;
            // 
            // HDR_USERNAME
            // 
            this.HDR_USERNAME.Text = "Username";
            // 
            // PNL_GERIR_PEDIDOS_LISTAGEM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1010, 521);
            this.Controls.Add(this.SPLITCONTAINER_PEDIDOS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PNL_GERIR_PEDIDOS_LISTAGEM";
            this.Text = "PNL_GERIR_PEDIDOS_LISTAGEM";
            this.Load += new System.EventHandler(this.PNL_GERIR_PEDIDOS_LISTAGEM_Load);
            this.SPLITCONTAINER_PEDIDOS.Panel1.ResumeLayout(false);
            this.SPLITCONTAINER_PEDIDOS.Panel1.PerformLayout();
            this.SPLITCONTAINER_PEDIDOS.Panel2.ResumeLayout(false);
            this.SPLITCONTAINER_PEDIDOS.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SPLITCONTAINER_PEDIDOS)).EndInit();
            this.SPLITCONTAINER_PEDIDOS.ResumeLayout(false);
            this.GROUPBOX_TOTAL_PEDIDOS.ResumeLayout(false);
            this.GROUPBOX_TOTAL_PEDIDOS_CONCLUIDOS.ResumeLayout(false);
            this.GROUPBOX_ESTADO.ResumeLayout(false);
            this.GROUPBOX_ESTADO.PerformLayout();
            this.GROUPBOX_FILTRAR.ResumeLayout(false);
            this.GROUPBOX_FILTRAR.PerformLayout();
            this.GROUPBOX_VOTOS.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer SPLITCONTAINER_PEDIDOS;
        private System.Windows.Forms.Label LABEL_TITULO;
        private System.Windows.Forms.Button BUTTON_PEDIDOS_RESPONDER;
        private System.Windows.Forms.Label LABEL_DESCRICAO;
        private System.Windows.Forms.TextBox TEXTBOX_DESCRICAO;
        private System.Windows.Forms.TextBox TEXTBOX_USERNAME;
        private System.Windows.Forms.GroupBox GROUPBOX_FILTRAR;
        private System.Windows.Forms.GroupBox GROUPBOX_VOTOS;
        private System.Windows.Forms.Label LABEL_USERNAME;
        private System.Windows.Forms.ListView LISTVIEW_PEDIDOS;
        private System.Windows.Forms.ColumnHeader HDR_PEDIDO;
        private System.Windows.Forms.GroupBox GROUPBOX_TOTAL_PEDIDOS;
        private System.Windows.Forms.ListView LISTVIEW_TOTAL_PEDIDOS;
        private System.Windows.Forms.GroupBox GROUPBOX_TOTAL_PEDIDOS_CONCLUIDOS;
        private System.Windows.Forms.ListView LISTVIEW_TOTAL_PEDIDOS_CONCLUIDOS;
        private System.Windows.Forms.GroupBox GROUPBOX_ESTADO;
        private System.Windows.Forms.RadioButton RADIOBUTTON_CONCLUIDO;
        private System.Windows.Forms.RadioButton RADIOBUTTON_A_SER_PROCESSADO;
        private System.Windows.Forms.RadioButton RADIOBUTTON_ESPERA;
        private System.Windows.Forms.ListView LISTVIEW_VOTOS;
        private System.Windows.Forms.ColumnHeader HDR_USERNAME;
        private System.Windows.Forms.TextBox TEXTBOX_RESPOSTA;
        private System.Windows.Forms.Label LABEL_RESPOSTA;
        private System.Windows.Forms.DateTimePicker DATETIMEPICKER;
        private System.Windows.Forms.Label LABEL_DATA;
        private System.Windows.Forms.RadioButton RADIOBUTTON_FILTRAR_ESTADO;
        private System.Windows.Forms.RadioButton RADIOBUTTON_FILTRAR_VOTOS;
        private System.Windows.Forms.RadioButton RADIOBUTTON_FILTRAR_USERNAME;
        private System.Windows.Forms.TextBox TEXTBOX_FILTRAR;
    }
}