using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.TVTuga.Admin.FORMS.DASHBOARD.PANELS.SERIES.REPORTADO;

namespace Windows.TVTuga.Admin.FORMS.DASHBOARD.PANELS.SERIES.REPORTADO
{
    public partial class PNL_GERIR_REPORTADOS : Form
    {
        public PNL_GERIR_REPORTADOS()
        {
            InitializeComponent();
        }

        private void PNL_GERIR_REPORTADOS_Load(object sender, EventArgs e)
        {
            BUTTON_REPORTADOS_LISTAGEM.PerformClick();
        }

        private void BUTTON_REPORTADOS_LISTAGEM_Click(object sender, EventArgs e)
        {
            OPEN_REPORTADOS_LISTAGEM();
        }

        public void OPEN_REPORTADOS_LISTAGEM()
        {
            if (SPLITCONTAINER_REPORTADOS.Panel2.Controls.Count == 0)
            {
                SPLITCONTAINER_REPORTADOS.Panel2.Controls.Clear();

                PNL_GERIR_REPORTADOS_LISTAGEM PNL_ReportadosListagem = new PNL_GERIR_REPORTADOS_LISTAGEM();
                PNL_ReportadosListagem.TopLevel = false;
                PNL_ReportadosListagem.AutoScroll = true;

                SPLITCONTAINER_REPORTADOS.Panel2.Controls.Add(PNL_ReportadosListagem);

                PNL_ReportadosListagem.Visible = true;
                return;
            }

            if (SPLITCONTAINER_REPORTADOS.Panel2.Controls.Count == 1 || SPLITCONTAINER_REPORTADOS.Panel2.Controls.Count > 1)
            {
                SPLITCONTAINER_REPORTADOS.Panel2.Controls.Clear();

                PNL_GERIR_REPORTADOS_LISTAGEM PNL_ReportadosListagem = new PNL_GERIR_REPORTADOS_LISTAGEM();
                PNL_ReportadosListagem.TopLevel = false;
                PNL_ReportadosListagem.AutoScroll = true;

                SPLITCONTAINER_REPORTADOS.Panel2.Controls.Add(PNL_ReportadosListagem);

                PNL_ReportadosListagem.Visible = true;
                return;
            }
        }
    }
}
