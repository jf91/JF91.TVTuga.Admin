using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.TVTuga.Admin.FORMS.DASHBOARD.PANELS.SERIES.CATEGORIAS;
using Windows.TVTuga.Admin.FORMS.DASHBOARD.PANELS.SERIES.EPISODIOS;
using Windows.TVTuga.Admin.FORMS.DASHBOARD.PANELS.SERIES.REPORTADO;
using Windows.TVTuga.Admin.FORMS.DASHBOARD.PANELS.SERIES.SERIES;

namespace Windows.TVTuga.Admin.FORMS.DASHBOARD.PANELS.SERIES
{
    public partial class PNL_SERIES : Form
    {
        public PNL_SERIES()
        {
            InitializeComponent();
        }

        private void PNL_SERIES_Load(object sender, EventArgs e)
        {
            BUTTON_SERIES.PerformClick();
        }

        private void BUTTON_SERIES_Click(object sender, EventArgs e)
        {
            OPEN_SERIES();
        }

        private void BUTTON_EPISODIOS_Click(object sender, EventArgs e)
        {
            OPEN_EPISODIOS();
        }

        private void BUTTON_CATEGORIAS_Click(object sender, EventArgs e)
        {
            OPEN_CATEGORIAS();
        }

        private void BUTTON_REPORTADO_Click(object sender, EventArgs e)
        {
            OPEN_REPORTADOS();
        }

        public void OPEN_SERIES()
        {
            if (SPLITCONTAINER_SERIES.Panel2.Controls.Count == 0)
            {
                SPLITCONTAINER_SERIES.Panel2.Controls.Clear();

                PNL_GERIR_SERIES PNL_Series = new PNL_GERIR_SERIES();
                PNL_Series.TopLevel = false;
                PNL_Series.AutoScroll = true;

                SPLITCONTAINER_SERIES.Panel2.Controls.Add(PNL_Series);

                PNL_Series.Visible = true;
                return;
            }

            if (SPLITCONTAINER_SERIES.Panel2.Controls.Count == 1 || SPLITCONTAINER_SERIES.Panel2.Controls.Count > 1)
            {
                SPLITCONTAINER_SERIES.Panel2.Controls.Clear();

                PNL_GERIR_SERIES PNL_Series = new PNL_GERIR_SERIES();
                PNL_Series.TopLevel = false;
                PNL_Series.AutoScroll = true;

                SPLITCONTAINER_SERIES.Panel2.Controls.Add(PNL_Series);

                PNL_Series.Visible = true;
                return;
            }
        }

        public void OPEN_EPISODIOS()
        {
            if (SPLITCONTAINER_SERIES.Panel2.Controls.Count == 0)
            {
                SPLITCONTAINER_SERIES.Panel2.Controls.Clear();

                PNL_GERIR_EPISODIOS PNL_Episodios = new PNL_GERIR_EPISODIOS();
                PNL_Episodios.TopLevel = false;
                PNL_Episodios.AutoScroll = true;

                SPLITCONTAINER_SERIES.Panel2.Controls.Add(PNL_Episodios);

                PNL_Episodios.Visible = true;
                return;
            }

            if (SPLITCONTAINER_SERIES.Panel2.Controls.Count == 1 || SPLITCONTAINER_SERIES.Panel2.Controls.Count > 1)
            {
                SPLITCONTAINER_SERIES.Panel2.Controls.Clear();

                PNL_GERIR_EPISODIOS PNL_Episodios = new PNL_GERIR_EPISODIOS();
                PNL_Episodios.TopLevel = false;
                PNL_Episodios.AutoScroll = true;

                SPLITCONTAINER_SERIES.Panel2.Controls.Add(PNL_Episodios);

                PNL_Episodios.Visible = true;
                return;
            }
        }

        public void OPEN_CATEGORIAS()
        {
            if (SPLITCONTAINER_SERIES.Panel2.Controls.Count == 0)
            {
                SPLITCONTAINER_SERIES.Panel2.Controls.Clear();

                PNL_GERIR_CATEGORIAS PNL_Categorias = new PNL_GERIR_CATEGORIAS();
                PNL_Categorias.TopLevel = false;
                PNL_Categorias.AutoScroll = true;

                SPLITCONTAINER_SERIES.Panel2.Controls.Add(PNL_Categorias);

                PNL_Categorias.Visible = true;
                return;
            }

            if (SPLITCONTAINER_SERIES.Panel2.Controls.Count == 1 || SPLITCONTAINER_SERIES.Panel2.Controls.Count > 1)
            {
                SPLITCONTAINER_SERIES.Panel2.Controls.Clear();

                PNL_GERIR_CATEGORIAS PNL_Categorias = new PNL_GERIR_CATEGORIAS();
                PNL_Categorias.TopLevel = false;
                PNL_Categorias.AutoScroll = true;

                SPLITCONTAINER_SERIES.Panel2.Controls.Add(PNL_Categorias);

                PNL_Categorias.Visible = true;
                return;
            }
        }

        public void OPEN_REPORTADOS()
        {
            if (SPLITCONTAINER_SERIES.Panel2.Controls.Count == 0)
            {
                SPLITCONTAINER_SERIES.Panel2.Controls.Clear();

                PNL_GERIR_REPORTADOS PNL_Reportados = new PNL_GERIR_REPORTADOS();
                PNL_Reportados.TopLevel = false;
                PNL_Reportados.AutoScroll = true;

                SPLITCONTAINER_SERIES.Panel2.Controls.Add(PNL_Reportados);

                PNL_Reportados.Visible = true;
                return;
            }

            if (SPLITCONTAINER_SERIES.Panel2.Controls.Count == 1 || SPLITCONTAINER_SERIES.Panel2.Controls.Count > 1)
            {
                SPLITCONTAINER_SERIES.Panel2.Controls.Clear();

                PNL_GERIR_REPORTADOS PNL_Reportados = new PNL_GERIR_REPORTADOS();
                PNL_Reportados.TopLevel = false;
                PNL_Reportados.AutoScroll = true;

                SPLITCONTAINER_SERIES.Panel2.Controls.Add(PNL_Reportados);

                PNL_Reportados.Visible = true;
                return;
            }
        }        
    }
}
