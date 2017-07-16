using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows.TVTuga.Admin
{
    public partial class FRM_OPCOES : Form
    {
        public FRM_OPCOES()
        {
            InitializeComponent();
        }

        private void BUTTON_UTILIZADORES_Click(object sender, EventArgs e)
        {
            OPEN_OPCOES_UTILIZADOR();
        }

        private void BUTTON_FTP_Click(object sender, EventArgs e)
        {
            OPEN_OPCOES_FTP();
        }

        private void BUTTON_OPCOES_BD_Click(object sender, EventArgs e)
        {
            OPEN_OPCOES_BD();
        }

        public void OPEN_OPCOES_UTILIZADOR()
        {
            if (SPLICONTAINER_OPCOES.Panel2.Controls.Count == 0)
            {
                SPLICONTAINER_OPCOES.Panel2.Controls.Clear();

                FORMS.OPCOES.PANELS.PNL_OPCOES_UTILIZADOR PNL_Utilizador = new FORMS.OPCOES.PANELS.PNL_OPCOES_UTILIZADOR();
                PNL_Utilizador.TopLevel = false;
                PNL_Utilizador.AutoScroll = true;

                SPLICONTAINER_OPCOES.Panel2.Controls.Add(PNL_Utilizador);

                PNL_Utilizador.Visible = true;
                return;
            }

            if (SPLICONTAINER_OPCOES.Panel2.Controls.Count == 1 || SPLICONTAINER_OPCOES.Panel2.Controls.Count > 1)
            {
                SPLICONTAINER_OPCOES.Panel2.Controls.Clear();

                FORMS.OPCOES.PANELS.PNL_OPCOES_UTILIZADOR PNL_Utilizador = new FORMS.OPCOES.PANELS.PNL_OPCOES_UTILIZADOR();
                PNL_Utilizador.TopLevel = false;
                PNL_Utilizador.AutoScroll = true;

                SPLICONTAINER_OPCOES.Panel2.Controls.Add(PNL_Utilizador);

                PNL_Utilizador.Visible = true;
                return;
            }
        }

        public void OPEN_OPCOES_FTP()
        {
            if (SPLICONTAINER_OPCOES.Panel2.Controls.Count == 0)
            {
                SPLICONTAINER_OPCOES.Panel2.Controls.Clear();

                FORMS.OPCOES.PANELS.PNL_OPCOES_FTP PNL_Utilizador = new FORMS.OPCOES.PANELS.PNL_OPCOES_FTP();
                PNL_Utilizador.TopLevel = false;
                PNL_Utilizador.AutoScroll = true;

                SPLICONTAINER_OPCOES.Panel2.Controls.Add(PNL_Utilizador);

                PNL_Utilizador.Visible = true;
                return;
            }

            if (SPLICONTAINER_OPCOES.Panel2.Controls.Count == 1 || SPLICONTAINER_OPCOES.Panel2.Controls.Count > 1)
            {
                SPLICONTAINER_OPCOES.Panel2.Controls.Clear();

                FORMS.OPCOES.PANELS.PNL_OPCOES_FTP PNL_Utilizador = new FORMS.OPCOES.PANELS.PNL_OPCOES_FTP();
                PNL_Utilizador.TopLevel = false;
                PNL_Utilizador.AutoScroll = true;

                SPLICONTAINER_OPCOES.Panel2.Controls.Add(PNL_Utilizador);

                PNL_Utilizador.Visible = true;
                return;
            }
        }

        public void OPEN_OPCOES_BD()
        {
            if (SPLICONTAINER_OPCOES.Panel2.Controls.Count == 0)
            {
                SPLICONTAINER_OPCOES.Panel2.Controls.Clear();

                FORMS.OPCOES.PANELS.PNL_OPCOES_BD PNL_Utilizador = new FORMS.OPCOES.PANELS.PNL_OPCOES_BD();
                PNL_Utilizador.TopLevel = false;
                PNL_Utilizador.AutoScroll = true;

                SPLICONTAINER_OPCOES.Panel2.Controls.Add(PNL_Utilizador);

                PNL_Utilizador.Visible = true;
                return;
            }

            if (SPLICONTAINER_OPCOES.Panel2.Controls.Count == 1 || SPLICONTAINER_OPCOES.Panel2.Controls.Count > 1)
            {
                SPLICONTAINER_OPCOES.Panel2.Controls.Clear();

                FORMS.OPCOES.PANELS.PNL_OPCOES_BD PNL_Utilizador = new FORMS.OPCOES.PANELS.PNL_OPCOES_BD();
                PNL_Utilizador.TopLevel = false;
                PNL_Utilizador.AutoScroll = true;

                SPLICONTAINER_OPCOES.Panel2.Controls.Add(PNL_Utilizador);

                PNL_Utilizador.Visible = true;
                return;
            }
        }

        private void MENUSTRIP_OPCOES_FECHAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FRM_OPCOES_FormClosed(object sender, FormClosedEventArgs e)
        {
            FRM_INICIO FormLogin = new FRM_INICIO();
            FormLogin.Show();
        }
    }
}
