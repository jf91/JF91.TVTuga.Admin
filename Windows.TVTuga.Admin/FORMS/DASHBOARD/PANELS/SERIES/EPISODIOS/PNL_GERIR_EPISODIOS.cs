using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.TVTuga.Admin.FORMS.DASHBOARD.PANELS.SERIES.EPISODIOS;

namespace Windows.TVTuga.Admin.FORMS.DASHBOARD.PANELS.SERIES.EPISODIOS
{
    public partial class PNL_GERIR_EPISODIOS : Form
    {
        public PNL_GERIR_EPISODIOS()
        {
            InitializeComponent();
        }

        private void PNL_GERIR_EPISODIOS_Load(object sender, EventArgs e)
        {
            BUTTON_EPISODIOS_LISTAGEM.PerformClick();
        }

        private void BUTTON_EPISODIOS_LISTAGEM_Click(object sender, EventArgs e)
        {
            OPEN_EPISODIOS_LISTAGEM();
        }

        private void BUTTON_EPISODIOS_ADICIONAR_Click(object sender, EventArgs e)
        {
            OPEN_EPISODIOS_ADICIONAR();
        }

        public void OPEN_EPISODIOS_LISTAGEM()
        {
            if (SPLITCONTAINER_EPISODIOS.Panel2.Controls.Count == 0)
            {
                SPLITCONTAINER_EPISODIOS.Panel2.Controls.Clear();

                PNL_GERIR_EPISODIOS_LISTAGEM PNL_EpisodiosListagem = new PNL_GERIR_EPISODIOS_LISTAGEM();
                PNL_EpisodiosListagem.TopLevel = false;
                PNL_EpisodiosListagem.AutoScroll = true;

                SPLITCONTAINER_EPISODIOS.Panel2.Controls.Add(PNL_EpisodiosListagem);

                PNL_EpisodiosListagem.Visible = true;
                return;
            }

            if (SPLITCONTAINER_EPISODIOS.Panel2.Controls.Count == 1 || SPLITCONTAINER_EPISODIOS.Panel2.Controls.Count > 1)
            {
                SPLITCONTAINER_EPISODIOS.Panel2.Controls.Clear();

                PNL_GERIR_EPISODIOS_LISTAGEM PNL_EpisodiosListagem = new PNL_GERIR_EPISODIOS_LISTAGEM();
                PNL_EpisodiosListagem.TopLevel = false;
                PNL_EpisodiosListagem.AutoScroll = true;

                SPLITCONTAINER_EPISODIOS.Panel2.Controls.Add(PNL_EpisodiosListagem);

                PNL_EpisodiosListagem.Visible = true;
                return;
            }
        }

        public void OPEN_EPISODIOS_ADICIONAR()
        {
            if (SPLITCONTAINER_EPISODIOS.Panel2.Controls.Count == 0)
            {
                SPLITCONTAINER_EPISODIOS.Panel2.Controls.Clear();

                PNL_GERIR_EPISODIOS_ADICIONAR PNL_EpisodiosAdicionar = new PNL_GERIR_EPISODIOS_ADICIONAR();
                PNL_EpisodiosAdicionar.TopLevel = false;
                PNL_EpisodiosAdicionar.AutoScroll = true;

                SPLITCONTAINER_EPISODIOS.Panel2.Controls.Add(PNL_EpisodiosAdicionar);

                PNL_EpisodiosAdicionar.Visible = true;
                return;
            }

            if (SPLITCONTAINER_EPISODIOS.Panel2.Controls.Count == 1 || SPLITCONTAINER_EPISODIOS.Panel2.Controls.Count > 1)
            {
                SPLITCONTAINER_EPISODIOS.Panel2.Controls.Clear();

                PNL_GERIR_EPISODIOS_ADICIONAR PNL_EpisodiosAdicionar = new PNL_GERIR_EPISODIOS_ADICIONAR();
                PNL_EpisodiosAdicionar.TopLevel = false;
                PNL_EpisodiosAdicionar.AutoScroll = true;

                SPLITCONTAINER_EPISODIOS.Panel2.Controls.Add(PNL_EpisodiosAdicionar);

                PNL_EpisodiosAdicionar.Visible = true;
                return;
            }
        }
    }
}
