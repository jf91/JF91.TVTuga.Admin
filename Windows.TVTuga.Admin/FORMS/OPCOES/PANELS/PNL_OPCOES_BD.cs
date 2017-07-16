using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Windows.TVTuga.Admin.FORMS.OPCOES.PANELS
{
    public partial class PNL_OPCOES_BD : Windows.TVTuga.Admin.FORMS.OPCOES.PANELS.PNL_OPCOES_EXEMPLO
    {
        public PNL_OPCOES_BD()
        {
            InitializeComponent();
            OPEN_OPCOES_BD_CONTAS();
        }

        private void BUTTON_CONTAS_Click(object sender, EventArgs e)
        {
            OPEN_OPCOES_BD_CONTAS();
        }

        private void BUTTON_BD_Click(object sender, EventArgs e)
        {
            OPEN_OPCOES_BD_BDS();
        }

        private void BUTTON_TABELAS_Click(object sender, EventArgs e)
        {

        }

        private void BUTTON_OPCOES_Click(object sender, EventArgs e)
        {
            OPEN_OPCOES_BD_OPCOES();
        }

        public void OPEN_OPCOES_BD_CONTAS()
        {
            if (SPLITCONTAINER_OPCOES_BD.Panel2.Controls.Count == 0)
            {
                SPLITCONTAINER_OPCOES_BD.Panel2.Controls.Clear();

                FORMS.OPCOES.PANELS.BD.PNL_OPCOES_BD_CONTAS PNL_BDContas = new FORMS.OPCOES.PANELS.BD.PNL_OPCOES_BD_CONTAS();
                PNL_BDContas.TopLevel = false;
                PNL_BDContas.AutoScroll = true;

                SPLITCONTAINER_OPCOES_BD.Panel2.Controls.Add(PNL_BDContas);

                PNL_BDContas.Visible = true;
                return;
            }

            if (SPLITCONTAINER_OPCOES_BD.Panel2.Controls.Count == 1 || SPLITCONTAINER_OPCOES_BD.Panel2.Controls.Count > 1)
            {
                SPLITCONTAINER_OPCOES_BD.Panel2.Controls.Clear();

                FORMS.OPCOES.PANELS.BD.PNL_OPCOES_BD_CONTAS PNL_BDContas = new FORMS.OPCOES.PANELS.BD.PNL_OPCOES_BD_CONTAS();
                PNL_BDContas.TopLevel = false;
                PNL_BDContas.AutoScroll = true;

                SPLITCONTAINER_OPCOES_BD.Panel2.Controls.Add(PNL_BDContas);

                PNL_BDContas.Visible = true;
                return;
            }
        }

        public void OPEN_OPCOES_BD_ADICIONAR_CONTA()
        {
            if (SPLITCONTAINER_OPCOES_BD.Panel2.Controls.Count == 0)
            {
                SPLITCONTAINER_OPCOES_BD.Panel2.Controls.Clear();

                FORMS.OPCOES.PANELS.BD.CONTAS.PNL_OPCOES_BD_ADICIONAR PNL_BDAdicionarConta = new FORMS.OPCOES.PANELS.BD.CONTAS.PNL_OPCOES_BD_ADICIONAR();
                PNL_BDAdicionarConta.TopLevel = false;
                PNL_BDAdicionarConta.AutoScroll = true;

                SPLITCONTAINER_OPCOES_BD.Panel2.Controls.Add(PNL_BDAdicionarConta);

                PNL_BDAdicionarConta.Visible = true;
                return;
            }

            if (SPLITCONTAINER_OPCOES_BD.Panel2.Controls.Count == 1 || SPLITCONTAINER_OPCOES_BD.Panel2.Controls.Count > 1)
            {
                SPLITCONTAINER_OPCOES_BD.Panel2.Controls.Clear();

                FORMS.OPCOES.PANELS.BD.CONTAS.PNL_OPCOES_BD_ADICIONAR PNL_BDAdicionarConta = new FORMS.OPCOES.PANELS.BD.CONTAS.PNL_OPCOES_BD_ADICIONAR();
                PNL_BDAdicionarConta.TopLevel = false;
                PNL_BDAdicionarConta.AutoScroll = true;

                SPLITCONTAINER_OPCOES_BD.Panel2.Controls.Add(PNL_BDAdicionarConta);

                PNL_BDAdicionarConta.Visible = true;
                return;
            }
        }

        public void OPEN_OPCOES_BD_BDS()
        {
            if (SPLITCONTAINER_OPCOES_BD.Panel2.Controls.Count == 0)
            {
                SPLITCONTAINER_OPCOES_BD.Panel2.Controls.Clear();

                FORMS.OPCOES.PANELS.BD.BDS.PNL_OPCOES_BD_BDS PNL_BDBDS = new FORMS.OPCOES.PANELS.BD.BDS.PNL_OPCOES_BD_BDS();
                PNL_BDBDS.TopLevel = false;
                PNL_BDBDS.AutoScroll = true;

                SPLITCONTAINER_OPCOES_BD.Panel2.Controls.Add(PNL_BDBDS);

                PNL_BDBDS.Visible = true;
                return;
            }

            if (SPLITCONTAINER_OPCOES_BD.Panel2.Controls.Count == 1 || SPLITCONTAINER_OPCOES_BD.Panel2.Controls.Count > 1)
            {
                SPLITCONTAINER_OPCOES_BD.Panel2.Controls.Clear();

                FORMS.OPCOES.PANELS.BD.BDS.PNL_OPCOES_BD_BDS PNL_BDBDS = new FORMS.OPCOES.PANELS.BD.BDS.PNL_OPCOES_BD_BDS();
                PNL_BDBDS.TopLevel = false;
                PNL_BDBDS.AutoScroll = true;

                SPLITCONTAINER_OPCOES_BD.Panel2.Controls.Add(PNL_BDBDS);

                PNL_BDBDS.Visible = true;
                return;
            }
        }

        public void OPEN_OPCOES_BD_TABELAS()
        {

        }

        public void OPEN_OPCOES_BD_OPCOES()
        {
            if (SPLITCONTAINER_OPCOES_BD.Panel2.Controls.Count == 0)
            {
                SPLITCONTAINER_OPCOES_BD.Panel2.Controls.Clear();

                FORMS.OPCOES.PANELS.BD.OPCOES.PNL_OPCOES_OPCOES PNL_BDOpcoes = new FORMS.OPCOES.PANELS.BD.OPCOES.PNL_OPCOES_OPCOES();
                PNL_BDOpcoes.TopLevel = false;
                PNL_BDOpcoes.AutoScroll = true;

                SPLITCONTAINER_OPCOES_BD.Panel2.Controls.Add(PNL_BDOpcoes);

                PNL_BDOpcoes.Visible = true;
                return;
            }

            if (SPLITCONTAINER_OPCOES_BD.Panel2.Controls.Count == 1 || SPLITCONTAINER_OPCOES_BD.Panel2.Controls.Count > 1)
            {
                SPLITCONTAINER_OPCOES_BD.Panel2.Controls.Clear();

                FORMS.OPCOES.PANELS.BD.OPCOES.PNL_OPCOES_OPCOES PNL_BDOpcoes = new FORMS.OPCOES.PANELS.BD.OPCOES.PNL_OPCOES_OPCOES();
                PNL_BDOpcoes.TopLevel = false;
                PNL_BDOpcoes.AutoScroll = true;

                SPLITCONTAINER_OPCOES_BD.Panel2.Controls.Add(PNL_BDOpcoes);

                PNL_BDOpcoes.Visible = true;
                return;
            }
        }
    }
}
