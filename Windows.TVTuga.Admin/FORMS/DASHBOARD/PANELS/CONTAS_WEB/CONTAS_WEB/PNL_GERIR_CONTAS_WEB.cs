using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.TVTuga.Admin.FORMS.DASHBOARD.PANELS.CONTAS_WEB.CONTAS_WEB;


namespace Windows.TVTuga.Admin.FORMS.DASHBOARD.PANELS.CONTAS_WEB
{
    public partial class PNL_GERIR_CONTAS_WEB : Form
    {
        public PNL_GERIR_CONTAS_WEB()
        {
            InitializeComponent();
        }

        private void PNL_GERIR_CONTAS_WEB_Load(object sender, EventArgs e)
        {
            OPEN_CONTAS_WEB_LISTAGEM();
        }

        private void BUTTON_CONTAS_WEB_LISTAGEM_Click(object sender, EventArgs e)
        {
            OPEN_CONTAS_WEB_LISTAGEM();
        }

        private void BUTTON_CONTAS_WEB_ADICIONAR_Click(object sender, EventArgs e)
        {
            OPEN_CONTAS_WEB_ADICIONAR();
        }

        public void OPEN_CONTAS_WEB_LISTAGEM()
        {
            if (SPLITCONTAINER_CONTAS_WEB.Panel2.Controls.Count == 0)
            {
                SPLITCONTAINER_CONTAS_WEB.Panel2.Controls.Clear();

                PNL_GERIR_CONTAS_WEB_LISTAGEM PNL_GerirContasWebListagem = new PNL_GERIR_CONTAS_WEB_LISTAGEM();
                PNL_GerirContasWebListagem.TopLevel = false;
                PNL_GerirContasWebListagem.AutoScroll = true;

                SPLITCONTAINER_CONTAS_WEB.Panel2.Controls.Add(PNL_GerirContasWebListagem);

                PNL_GerirContasWebListagem.Visible = true;
                return;
            }

            if (SPLITCONTAINER_CONTAS_WEB.Panel2.Controls.Count == 1 || SPLITCONTAINER_CONTAS_WEB.Panel2.Controls.Count > 1)
            {
                SPLITCONTAINER_CONTAS_WEB.Panel2.Controls.Clear();

                PNL_GERIR_CONTAS_WEB_LISTAGEM PNL_GerirContasWebListagem = new PNL_GERIR_CONTAS_WEB_LISTAGEM();
                PNL_GerirContasWebListagem.TopLevel = false;
                PNL_GerirContasWebListagem.AutoScroll = true;

                SPLITCONTAINER_CONTAS_WEB.Panel2.Controls.Add(PNL_GerirContasWebListagem);

                PNL_GerirContasWebListagem.Visible = true;
                return;
            }
        }

        public void OPEN_CONTAS_WEB_ADICIONAR()
        {
            if (SPLITCONTAINER_CONTAS_WEB.Panel2.Controls.Count == 0)
            {
                SPLITCONTAINER_CONTAS_WEB.Panel2.Controls.Clear();

                PNL_GERIR_CONTAS_WEB_ADICIONAR PNL_GerirContasWebAdicionar = new PNL_GERIR_CONTAS_WEB_ADICIONAR();
                PNL_GerirContasWebAdicionar.TopLevel = false;
                PNL_GerirContasWebAdicionar.AutoScroll = true;

                SPLITCONTAINER_CONTAS_WEB.Panel2.Controls.Add(PNL_GerirContasWebAdicionar);

                PNL_GerirContasWebAdicionar.Visible = true;
                return;
            }

            if (SPLITCONTAINER_CONTAS_WEB.Panel2.Controls.Count == 1 || SPLITCONTAINER_CONTAS_WEB.Panel2.Controls.Count > 1)
            {
                SPLITCONTAINER_CONTAS_WEB.Panel2.Controls.Clear();

                PNL_GERIR_CONTAS_WEB_ADICIONAR PNL_GerirContasWebAdicionar = new PNL_GERIR_CONTAS_WEB_ADICIONAR();
                PNL_GerirContasWebAdicionar.TopLevel = false;
                PNL_GerirContasWebAdicionar.AutoScroll = true;

                SPLITCONTAINER_CONTAS_WEB.Panel2.Controls.Add(PNL_GerirContasWebAdicionar);

                PNL_GerirContasWebAdicionar.Visible = true;
                return;
            }
        }        
    }
}
