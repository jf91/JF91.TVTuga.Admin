using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.TVTuga.Admin.FORMS.DASHBOARD.PANELS.CONTAS_WEB;

namespace Windows.TVTuga.Admin.FORMS.DASHBOARD.PANELS.CONTAS_WEB
{
    public partial class PNL_CONTAS_WEB : Form
    {
        public PNL_CONTAS_WEB()
        {
            InitializeComponent();
        }

        private void PNL_CONTAS_WEB_Load(object sender, EventArgs e)
        {
            OPEN_CONTAS_WEB();
        }

        private void BUTTON_CONTAS_WEB_Click(object sender, EventArgs e)
        {
            OPEN_CONTAS_WEB();
        }

        private void BUTTON_WEBSITES_Click(object sender, EventArgs e)
        {
            OPEN_CONTAS_WEB_WEBSITES();
        }

        public void OPEN_CONTAS_WEB()
        {
            if (SPLITCONTAINER_CONTAS_WEB.Panel2.Controls.Count == 0)
            {
                SPLITCONTAINER_CONTAS_WEB.Panel2.Controls.Clear();

                PNL_GERIR_CONTAS_WEB PNL_GerirContasWeb = new PNL_GERIR_CONTAS_WEB();
                PNL_GerirContasWeb.TopLevel = false;
                PNL_GerirContasWeb.AutoScroll = true;

                SPLITCONTAINER_CONTAS_WEB.Panel2.Controls.Add(PNL_GerirContasWeb);

                PNL_GerirContasWeb.Visible = true;
                return;
            }

            if (SPLITCONTAINER_CONTAS_WEB.Panel2.Controls.Count == 1 || SPLITCONTAINER_CONTAS_WEB.Panel2.Controls.Count > 1)
            {
                SPLITCONTAINER_CONTAS_WEB.Panel2.Controls.Clear();

                PNL_GERIR_CONTAS_WEB PNL_GerirContasWeb = new PNL_GERIR_CONTAS_WEB();
                PNL_GerirContasWeb.TopLevel = false;
                PNL_GerirContasWeb.AutoScroll = true;

                SPLITCONTAINER_CONTAS_WEB.Panel2.Controls.Add(PNL_GerirContasWeb);

                PNL_GerirContasWeb.Visible = true;
                return;
            }
        }

        public void OPEN_CONTAS_WEB_WEBSITES()
        {
            if (SPLITCONTAINER_CONTAS_WEB.Panel2.Controls.Count == 0)
            {
                SPLITCONTAINER_CONTAS_WEB.Panel2.Controls.Clear();

                PNL_GERIR_WEBSITES PNL_GerirContasWebWebsites = new PNL_GERIR_WEBSITES();
                PNL_GerirContasWebWebsites.TopLevel = false;
                PNL_GerirContasWebWebsites.AutoScroll = true;

                SPLITCONTAINER_CONTAS_WEB.Panel2.Controls.Add(PNL_GerirContasWebWebsites);

                PNL_GerirContasWebWebsites.Visible = true;
                return;
            }

            if (SPLITCONTAINER_CONTAS_WEB.Panel2.Controls.Count == 1 || SPLITCONTAINER_CONTAS_WEB.Panel2.Controls.Count > 1)
            {
                SPLITCONTAINER_CONTAS_WEB.Panel2.Controls.Clear();

                PNL_GERIR_WEBSITES PNL_GerirContasWebWebsites = new PNL_GERIR_WEBSITES();
                PNL_GerirContasWebWebsites.TopLevel = false;
                PNL_GerirContasWebWebsites.AutoScroll = true;

                SPLITCONTAINER_CONTAS_WEB.Panel2.Controls.Add(PNL_GerirContasWebWebsites);

                PNL_GerirContasWebWebsites.Visible = true;
                return;
            }
        }
    }
}
