using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.TVTuga.Admin.FORMS.DASHBOARD.PANELS.CONTAS_WEB.WEBSITES;

namespace Windows.TVTuga.Admin.FORMS.DASHBOARD.PANELS.CONTAS_WEB
{
    public partial class PNL_GERIR_WEBSITES : Form
    {
        public PNL_GERIR_WEBSITES()
        {
            InitializeComponent();
        }

        private void PNL_GERIR_WEBSITES_Load(object sender, EventArgs e)
        {
            BUTTON_WEBSITES_LISTAGEM.PerformClick();
        }

        private void BUTTON_CONTAS_WEB_WEBSITES_LISTAGEM_Click(object sender, EventArgs e)
        {
            OPEN_WEBSITES_LISTAGEM();
        }

        private void BUTTON_CONTAS_WEB_BUTTON_CONTAS_WEB_WEBSITES_ADICIONAR_Click(object sender, EventArgs e)
        {
            OPEN_WEBSITES_ADICIONAR();
        }     
        
        public void OPEN_WEBSITES_LISTAGEM()
        {
            if (SPLITCONTAINER_WEBSITES.Panel2.Controls.Count == 0)
            {
                SPLITCONTAINER_WEBSITES.Panel2.Controls.Clear();

                PNL_GERIR_WEBSITES_LISTAGEM PNL_GerirContasWebListagem = new PNL_GERIR_WEBSITES_LISTAGEM();
                PNL_GerirContasWebListagem.TopLevel = false;
                PNL_GerirContasWebListagem.AutoScroll = true;

                SPLITCONTAINER_WEBSITES.Panel2.Controls.Add(PNL_GerirContasWebListagem);

                PNL_GerirContasWebListagem.Visible = true;
                return;
            }

            if (SPLITCONTAINER_WEBSITES.Panel2.Controls.Count == 1 || SPLITCONTAINER_WEBSITES.Panel2.Controls.Count > 1)
            {
                SPLITCONTAINER_WEBSITES.Panel2.Controls.Clear();

                PNL_GERIR_WEBSITES_LISTAGEM PNL_GerirContasWebListagem = new PNL_GERIR_WEBSITES_LISTAGEM();
                PNL_GerirContasWebListagem.TopLevel = false;
                PNL_GerirContasWebListagem.AutoScroll = true;

                SPLITCONTAINER_WEBSITES.Panel2.Controls.Add(PNL_GerirContasWebListagem);

                PNL_GerirContasWebListagem.Visible = true;
                return;
            }
        }

        public void OPEN_WEBSITES_ADICIONAR()
        {
            if (SPLITCONTAINER_WEBSITES.Panel2.Controls.Count == 0)
            {
                SPLITCONTAINER_WEBSITES.Panel2.Controls.Clear();

                PNL_GERIR_WEBSITES_ADICIONAR PNL_GerirContasWebAdicionar = new PNL_GERIR_WEBSITES_ADICIONAR();
                PNL_GerirContasWebAdicionar.TopLevel = false;
                PNL_GerirContasWebAdicionar.AutoScroll = true;

                SPLITCONTAINER_WEBSITES.Panel2.Controls.Add(PNL_GerirContasWebAdicionar);

                PNL_GerirContasWebAdicionar.Visible = true;
                return;
            }

            if (SPLITCONTAINER_WEBSITES.Panel2.Controls.Count == 1 || SPLITCONTAINER_WEBSITES.Panel2.Controls.Count > 1)
            {
                SPLITCONTAINER_WEBSITES.Panel2.Controls.Clear();

                PNL_GERIR_WEBSITES_ADICIONAR PNL_GerirContasWebAdicionar = new PNL_GERIR_WEBSITES_ADICIONAR();
                PNL_GerirContasWebAdicionar.TopLevel = false;
                PNL_GerirContasWebAdicionar.AutoScroll = true;

                SPLITCONTAINER_WEBSITES.Panel2.Controls.Add(PNL_GerirContasWebAdicionar);

                PNL_GerirContasWebAdicionar.Visible = true;
                return;
            }
        }

        private void BUTTON_ADICIONAR_TIPO_Click(object sender, EventArgs e)
        {
            if (SPLITCONTAINER_WEBSITES.Panel2.Controls.Count == 0)
            {
                SPLITCONTAINER_WEBSITES.Panel2.Controls.Clear();

                PNL_GERIR_WEBSITES_ADICIONAR_TIPO PNL_GerirContasWebAdicionarTipo = new PNL_GERIR_WEBSITES_ADICIONAR_TIPO();
                PNL_GerirContasWebAdicionarTipo.TopLevel = false;
                PNL_GerirContasWebAdicionarTipo.AutoScroll = true;

                SPLITCONTAINER_WEBSITES.Panel2.Controls.Add(PNL_GerirContasWebAdicionarTipo);

                PNL_GerirContasWebAdicionarTipo.Visible = true;
                return;
            }

            if (SPLITCONTAINER_WEBSITES.Panel2.Controls.Count == 1 || SPLITCONTAINER_WEBSITES.Panel2.Controls.Count > 1)
            {
                SPLITCONTAINER_WEBSITES.Panel2.Controls.Clear();

                PNL_GERIR_WEBSITES_ADICIONAR_TIPO PNL_GerirContasWebAdicionarTipo = new PNL_GERIR_WEBSITES_ADICIONAR_TIPO();
                PNL_GerirContasWebAdicionarTipo.TopLevel = false;
                PNL_GerirContasWebAdicionarTipo.AutoScroll = true;

                SPLITCONTAINER_WEBSITES.Panel2.Controls.Add(PNL_GerirContasWebAdicionarTipo);

                PNL_GerirContasWebAdicionarTipo.Visible = true;
                return;
            }
        }
    }
}
