using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.TVTuga.Admin.FORMS.DASHBOARD.PANELS.DASHBOARD;
using Windows.TVTuga.Admin.FORMS.DASHBOARD.PANELS.CONTAS_WEB;
using Windows.TVTuga.Admin.FORMS.DASHBOARD.PANELS.UTILIZADORES;
using Windows.TVTuga.Admin.FORMS.DASHBOARD.PANELS.SERIES;
using Windows.TVTuga.Admin.FORMS.DASHBOARD.PANELS.PEDIDOS;

namespace Windows.TVTuga.Admin.FORMS.DASHBOARD
{
    public partial class FRM_DASHBOARD : Form
    {
        public FRM_DASHBOARD()
        {
            InitializeComponent();
        }

        private void FRM_DASHBOARD_Load(object sender, EventArgs e)
        {
            BUTTON_DASHBOARD.PerformClick();
        }

        private void FRM_DASHBOARD_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BUTTON_DASHBOARD_Click(object sender, EventArgs e)
        {
            OPEN_DASHBOARD();
        }

        private void BUTTON_CONTAS_WEB_Click(object sender, EventArgs e)
        {
            OPEN_CONTAS_WEB();
        }

        private void BUTTON_UTILIZADORES_Click(object sender, EventArgs e)
        {
            OPEN_UTILIZADORES();
        }

        private void BUTTON_SERIES_Click(object sender, EventArgs e)
        {
            OPEN_SERIES();
        }

        private void BUTTON_PEDIDOS_Click(object sender, EventArgs e)
        {
            OPEN_PEDIDOS();
        }

        private void BUTTON_CONFIGURACOES_Click(object sender, EventArgs e)
        {
            OPEN_CONFIGURACOES();
        }

        public void OPEN_DASHBOARD()
        {
            if (SPLITCONTAINER_DASHBOARD.Panel2.Controls.Count == 0)
            {
                SPLITCONTAINER_DASHBOARD.Panel2.Controls.Clear();

                PNL_DASHBOARD PNL_Dashboard = new PNL_DASHBOARD();
                PNL_Dashboard.TopLevel = false;
                PNL_Dashboard.AutoScroll = true;

                SPLITCONTAINER_DASHBOARD.Panel2.Controls.Add(PNL_Dashboard);

                PNL_Dashboard.Visible = true;
                return;
            }

            if (SPLITCONTAINER_DASHBOARD.Panel2.Controls.Count == 1 || SPLITCONTAINER_DASHBOARD.Panel2.Controls.Count > 1)
            {
                SPLITCONTAINER_DASHBOARD.Panel2.Controls.Clear();

                PNL_DASHBOARD PNL_Dashboard = new PNL_DASHBOARD();
                PNL_Dashboard.TopLevel = false;
                PNL_Dashboard.AutoScroll = true;

                SPLITCONTAINER_DASHBOARD.Panel2.Controls.Add(PNL_Dashboard);

                PNL_Dashboard.Visible = true;
                return;
            }
        }

        public void OPEN_CONTAS_WEB()
        {
            if (SPLITCONTAINER_DASHBOARD.Panel2.Controls.Count == 0)
            {
                SPLITCONTAINER_DASHBOARD.Panel2.Controls.Clear();

                PNL_CONTAS_WEB PNL_ContasWeb = new PNL_CONTAS_WEB();
                PNL_ContasWeb.TopLevel = false;
                PNL_ContasWeb.AutoScroll = true;

                SPLITCONTAINER_DASHBOARD.Panel2.Controls.Add(PNL_ContasWeb);

                PNL_ContasWeb.Visible = true;
                return;
            }

            if (SPLITCONTAINER_DASHBOARD.Panel2.Controls.Count == 1 || SPLITCONTAINER_DASHBOARD.Panel2.Controls.Count > 1)
            {
                SPLITCONTAINER_DASHBOARD.Panel2.Controls.Clear();

                PNL_CONTAS_WEB PNL_ContasWeb = new PNL_CONTAS_WEB();
                PNL_ContasWeb.TopLevel = false;
                PNL_ContasWeb.AutoScroll = true;

                SPLITCONTAINER_DASHBOARD.Panel2.Controls.Add(PNL_ContasWeb);

                PNL_ContasWeb.Visible = true;
                return;
            }
        }

        public void OPEN_UTILIZADORES()
        {
            if (SPLITCONTAINER_DASHBOARD.Panel2.Controls.Count == 0)
            {
                SPLITCONTAINER_DASHBOARD.Panel2.Controls.Clear();

                PNL_UTILIZADORES PNL_Utilizadores = new PNL_UTILIZADORES();
                PNL_Utilizadores.TopLevel = false;
                PNL_Utilizadores.AutoScroll = true;

                SPLITCONTAINER_DASHBOARD.Panel2.Controls.Add(PNL_Utilizadores);

                PNL_Utilizadores.Visible = true;
                return;
            }

            if (SPLITCONTAINER_DASHBOARD.Panel2.Controls.Count == 1 || SPLITCONTAINER_DASHBOARD.Panel2.Controls.Count > 1)
            {
                SPLITCONTAINER_DASHBOARD.Panel2.Controls.Clear();

                PNL_UTILIZADORES PNL_Utilizadores = new PNL_UTILIZADORES();
                PNL_Utilizadores.TopLevel = false;
                PNL_Utilizadores.AutoScroll = true;

                SPLITCONTAINER_DASHBOARD.Panel2.Controls.Add(PNL_Utilizadores);

                PNL_Utilizadores.Visible = true;
                return;
            }
        }

        public void OPEN_SERIES()
        {
            if (SPLITCONTAINER_DASHBOARD.Panel2.Controls.Count == 0)
            {
                SPLITCONTAINER_DASHBOARD.Panel2.Controls.Clear();

                PNL_SERIES PNL_Series = new PNL_SERIES();
                PNL_Series.TopLevel = false;
                PNL_Series.AutoScroll = true;

                SPLITCONTAINER_DASHBOARD.Panel2.Controls.Add(PNL_Series);

                PNL_Series.Visible = true;
                return;
            }

            if (SPLITCONTAINER_DASHBOARD.Panel2.Controls.Count == 1 || SPLITCONTAINER_DASHBOARD.Panel2.Controls.Count > 1)
            {
                SPLITCONTAINER_DASHBOARD.Panel2.Controls.Clear();

                PNL_SERIES PNL_Series = new PNL_SERIES();
                PNL_Series.TopLevel = false;
                PNL_Series.AutoScroll = true;

                SPLITCONTAINER_DASHBOARD.Panel2.Controls.Add(PNL_Series);

                PNL_Series.Visible = true;
                return;
            }
        }

        public void OPEN_PEDIDOS()
        {
            if (SPLITCONTAINER_DASHBOARD.Panel2.Controls.Count == 0)
            {
                SPLITCONTAINER_DASHBOARD.Panel2.Controls.Clear();

                PNL_GERIR_PEDIDOS PNL_Pedidos = new PNL_GERIR_PEDIDOS();
                PNL_Pedidos.TopLevel = false;
                PNL_Pedidos.AutoScroll = true;

                SPLITCONTAINER_DASHBOARD.Panel2.Controls.Add(PNL_Pedidos);

                PNL_Pedidos.Visible = true;
                return;
            }

            if (SPLITCONTAINER_DASHBOARD.Panel2.Controls.Count == 1 || SPLITCONTAINER_DASHBOARD.Panel2.Controls.Count > 1)
            {
                SPLITCONTAINER_DASHBOARD.Panel2.Controls.Clear();

                PNL_GERIR_PEDIDOS PNL_Pedidos = new PNL_GERIR_PEDIDOS();
                PNL_Pedidos.TopLevel = false;
                PNL_Pedidos.AutoScroll = true;

                SPLITCONTAINER_DASHBOARD.Panel2.Controls.Add(PNL_Pedidos);

                PNL_Pedidos.Visible = true;
                return;
            }
        }

        public void OPEN_CONFIGURACOES()
        {

        }

        private void MENUSTRIP_DASHBOARD_FECHAR_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
