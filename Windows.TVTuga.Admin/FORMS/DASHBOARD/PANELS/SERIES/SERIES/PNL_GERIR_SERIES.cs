using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.TVTuga.Admin.FORMS.DASHBOARD.PANELS.SERIES.SERIES;

namespace Windows.TVTuga.Admin.FORMS.DASHBOARD.PANELS.SERIES.SERIES
{
    public partial class PNL_GERIR_SERIES : Form
    {
        public PNL_GERIR_SERIES()
        {
            InitializeComponent();
        }

        private void PNL_GERIR_SERIES_Load(object sender, EventArgs e)
        {
            BUTTON_SERIES_LISTAGEM.PerformClick();
        }

        private void BUTTON_SERIES_LISTAGEM_Click(object sender, EventArgs e)
        {
            OPEN_SERIES_LISTAGEM();
        }

        private void BUTTON_SERIES_ADICIONAR_Click(object sender, EventArgs e)
        {
            OPEN_SERIES_ADICIONAR();
        }

        public void OPEN_SERIES_LISTAGEM()
        {
            if (SPLITCONTAINER_SERIES.Panel2.Controls.Count == 0)
            {
                SPLITCONTAINER_SERIES.Panel2.Controls.Clear();

                PNL_GERIR_SERIES_LISTAGEM PNL_SeriesListagem = new PNL_GERIR_SERIES_LISTAGEM();
                PNL_SeriesListagem.TopLevel = false;
                PNL_SeriesListagem.AutoScroll = true;

                SPLITCONTAINER_SERIES.Panel2.Controls.Add(PNL_SeriesListagem);

                PNL_SeriesListagem.Visible = true;
                return;
            }

            if (SPLITCONTAINER_SERIES.Panel2.Controls.Count == 1 || SPLITCONTAINER_SERIES.Panel2.Controls.Count > 1)
            {
                SPLITCONTAINER_SERIES.Panel2.Controls.Clear();

                PNL_GERIR_SERIES_LISTAGEM PNL_SeriesListagem = new PNL_GERIR_SERIES_LISTAGEM();
                PNL_SeriesListagem.TopLevel = false;
                PNL_SeriesListagem.AutoScroll = true;

                SPLITCONTAINER_SERIES.Panel2.Controls.Add(PNL_SeriesListagem);

                PNL_SeriesListagem.Visible = true;
                return;
            }
        }

        public void OPEN_SERIES_ADICIONAR()
        {
            if (SPLITCONTAINER_SERIES.Panel2.Controls.Count == 0)
            {
                SPLITCONTAINER_SERIES.Panel2.Controls.Clear();

                PNL_GERIR_SERIES_ADICIONAR PNL_SeriesAdicionar = new PNL_GERIR_SERIES_ADICIONAR();
                PNL_SeriesAdicionar.TopLevel = false;
                PNL_SeriesAdicionar.AutoScroll = true;

                SPLITCONTAINER_SERIES.Panel2.Controls.Add(PNL_SeriesAdicionar);

                PNL_SeriesAdicionar.Visible = true;
                return;
            }

            if (SPLITCONTAINER_SERIES.Panel2.Controls.Count == 1 || SPLITCONTAINER_SERIES.Panel2.Controls.Count > 1)
            {
                SPLITCONTAINER_SERIES.Panel2.Controls.Clear();

                PNL_GERIR_SERIES_ADICIONAR PNL_SeriesAdicionar = new PNL_GERIR_SERIES_ADICIONAR();
                PNL_SeriesAdicionar.TopLevel = false;
                PNL_SeriesAdicionar.AutoScroll = true;

                SPLITCONTAINER_SERIES.Panel2.Controls.Add(PNL_SeriesAdicionar);

                PNL_SeriesAdicionar.Visible = true;
                return;
            }
        }
    }
}
