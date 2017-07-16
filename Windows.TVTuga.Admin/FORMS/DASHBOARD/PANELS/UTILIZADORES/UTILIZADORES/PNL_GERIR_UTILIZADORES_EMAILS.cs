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

namespace Windows.TVTuga.Admin.FORMS.DASHBOARD.PANELS.UTILIZADORES.UTILIZADORES
{
    public partial class PNL_GERIR_UTILIZADORES_EMAILS : Form
    {
        public PNL_GERIR_UTILIZADORES_EMAILS()
        {
            InitializeComponent();
        }

        private void PNL_GERIR_UTILIZADORES_EMAILS_Load(object sender, EventArgs e)
        {
            OPEN_ENVIAR_EMAIL();
        }

        public void OPEN_ENVIAR_EMAIL()
        {
            if (SPLITCONTAINER_GERIR_UTILIZADORES.Panel2.Controls.Count == 0)
            {
                SPLITCONTAINER_GERIR_UTILIZADORES.Panel2.Controls.Clear();

                PNL_GERIR_UTILIZADORES_EMAILS_ENVIAR PNL_GerirUtilizadoresEnviarEmail = new PNL_GERIR_UTILIZADORES_EMAILS_ENVIAR();
                PNL_GerirUtilizadoresEnviarEmail.TopLevel = false;
                PNL_GerirUtilizadoresEnviarEmail.AutoScroll = true;

                SPLITCONTAINER_GERIR_UTILIZADORES.Panel2.Controls.Add(PNL_GerirUtilizadoresEnviarEmail);

                PNL_GerirUtilizadoresEnviarEmail.Visible = true;
                return;
            }

            if (SPLITCONTAINER_GERIR_UTILIZADORES.Panel2.Controls.Count == 1 || SPLITCONTAINER_GERIR_UTILIZADORES.Panel2.Controls.Count > 1)
            {
                SPLITCONTAINER_GERIR_UTILIZADORES.Panel2.Controls.Clear();

                PNL_GERIR_UTILIZADORES_EMAILS_ENVIAR PNL_GerirUtilizadoresEnviarEmail = new PNL_GERIR_UTILIZADORES_EMAILS_ENVIAR();
                PNL_GerirUtilizadoresEnviarEmail.TopLevel = false;
                PNL_GerirUtilizadoresEnviarEmail.AutoScroll = true;

                SPLITCONTAINER_GERIR_UTILIZADORES.Panel2.Controls.Add(PNL_GerirUtilizadoresEnviarEmail);

                PNL_GerirUtilizadoresEnviarEmail.Visible = true;
                return;
            }
        }
    }
}
