using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.TVTuga.Admin.FORMS.DASHBOARD.PANELS.UTILIZADORES.UTILIZADORES;

namespace Windows.TVTuga.Admin.FORMS.DASHBOARD.PANELS.UTILIZADORES
{
    public partial class PNL_UTILIZADORES : Form
    {
        public PNL_UTILIZADORES()
        {
            InitializeComponent();
        }

        private void PNL_UTILIZADORES_Load(object sender, EventArgs e)
        {
            BUTTON_CONTAS_WEB.PerformClick();
        }

        private void BUTTON_CONTAS_WEB_Click(object sender, EventArgs e)
        {
            OPEN_GERIR_UTILIZADORES();
        }

        private void BUTTON_ENVIAR_EMAIL_Click(object sender, EventArgs e)
        {
            OPEN_ENVIAR_EMAIL();
        }

        public void OPEN_GERIR_UTILIZADORES()
        {
            if (SPLITCONTAINER_CONTAS_WEB.Panel2.Controls.Count == 0)
            {
                SPLITCONTAINER_CONTAS_WEB.Panel2.Controls.Clear();

                PNL_GERIR_UTILIZADORES PNL_GerirUtilizadores = new PNL_GERIR_UTILIZADORES();
                PNL_GerirUtilizadores.TopLevel = false;
                PNL_GerirUtilizadores.AutoScroll = true;

                SPLITCONTAINER_CONTAS_WEB.Panel2.Controls.Add(PNL_GerirUtilizadores);

                PNL_GerirUtilizadores.Visible = true;
                return;
            }

            if (SPLITCONTAINER_CONTAS_WEB.Panel2.Controls.Count == 1 || SPLITCONTAINER_CONTAS_WEB.Panel2.Controls.Count > 1)
            {
                SPLITCONTAINER_CONTAS_WEB.Panel2.Controls.Clear();

                PNL_GERIR_UTILIZADORES PNL_GerirUtilizadores = new PNL_GERIR_UTILIZADORES();
                PNL_GerirUtilizadores.TopLevel = false;
                PNL_GerirUtilizadores.AutoScroll = true;

                SPLITCONTAINER_CONTAS_WEB.Panel2.Controls.Add(PNL_GerirUtilizadores);

                PNL_GerirUtilizadores.Visible = true;
                return;
            }
        }

        public void OPEN_ENVIAR_EMAIL()
        {
            if (SPLITCONTAINER_CONTAS_WEB.Panel2.Controls.Count == 0)
            {
                SPLITCONTAINER_CONTAS_WEB.Panel2.Controls.Clear();

                PNL_GERIR_UTILIZADORES_EMAILS PNL_GerirUtilizadoresEnviarEmail = new PNL_GERIR_UTILIZADORES_EMAILS();
                PNL_GerirUtilizadoresEnviarEmail.TopLevel = false;
                PNL_GerirUtilizadoresEnviarEmail.AutoScroll = true;

                SPLITCONTAINER_CONTAS_WEB.Panel2.Controls.Add(PNL_GerirUtilizadoresEnviarEmail);

                PNL_GerirUtilizadoresEnviarEmail.Visible = true;
                return;
            }

            if (SPLITCONTAINER_CONTAS_WEB.Panel2.Controls.Count == 1 || SPLITCONTAINER_CONTAS_WEB.Panel2.Controls.Count > 1)
            {
                SPLITCONTAINER_CONTAS_WEB.Panel2.Controls.Clear();

                PNL_GERIR_UTILIZADORES_EMAILS PNL_GerirUtilizadoresEnviarEmail = new PNL_GERIR_UTILIZADORES_EMAILS();
                PNL_GerirUtilizadoresEnviarEmail.TopLevel = false;
                PNL_GerirUtilizadoresEnviarEmail.AutoScroll = true;

                SPLITCONTAINER_CONTAS_WEB.Panel2.Controls.Add(PNL_GerirUtilizadoresEnviarEmail);

                PNL_GerirUtilizadoresEnviarEmail.Visible = true;
                return;
            }
        }
    }
}
