using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Windows.TVTuga.Admin.FORMS.OPCOES.PANELS
{
    public partial class PNL_OPCOES_FTP : Windows.TVTuga.Admin.FORMS.OPCOES.PANELS.PNL_OPCOES_EXEMPLO
    {
        public PNL_OPCOES_FTP()
        {
            InitializeComponent();
            OPEN_OPCOES_FTP_CONTAS();
        }

        private void BUTTON_CONTAS_Click(object sender, EventArgs e)
        {
            OPEN_OPCOES_FTP_CONTAS();
        }

        private void BUTTON_ADICIONAR_Click(object sender, EventArgs e)
        {
            OPEN_OPCOES_FTP_ADICIONAR();
        }

        private void BUTTON_REMOVER_Click(object sender, EventArgs e)
        {
            OPEN_OPCOES_FTP_REMOVER();
        }

        private void BUTTON_ALTERAR_Click(object sender, EventArgs e)
        {
            OPEN_OPCOES_FTP_ALTERAR();
        }

        public void OPEN_OPCOES_FTP_CONTAS()
        {
            if (SPLITCONTAINER_OPCOES_FTP.Panel2.Controls.Count == 0)
            {
                SPLITCONTAINER_OPCOES_FTP.Panel2.Controls.Clear();

                FORMS.OPCOES.PANELS.FTP.PNL_OPCOES_FTP_CONTAS PNL_FTPContas = new FORMS.OPCOES.PANELS.FTP.PNL_OPCOES_FTP_CONTAS();
                PNL_FTPContas.TopLevel = false;
                PNL_FTPContas.AutoScroll = true;

                SPLITCONTAINER_OPCOES_FTP.Panel2.Controls.Add(PNL_FTPContas);

                PNL_FTPContas.Visible = true;
                return;
            }

            if (SPLITCONTAINER_OPCOES_FTP.Panel2.Controls.Count == 1 || SPLITCONTAINER_OPCOES_FTP.Panel2.Controls.Count > 1)
            {
                SPLITCONTAINER_OPCOES_FTP.Panel2.Controls.Clear();

                FORMS.OPCOES.PANELS.FTP.PNL_OPCOES_FTP_CONTAS PNL_FTPContas = new FORMS.OPCOES.PANELS.FTP.PNL_OPCOES_FTP_CONTAS();
                PNL_FTPContas.TopLevel = false;
                PNL_FTPContas.AutoScroll = true;

                SPLITCONTAINER_OPCOES_FTP.Panel2.Controls.Add(PNL_FTPContas);

                PNL_FTPContas.Visible = true;
                return;
            }
        }

        public void OPEN_OPCOES_FTP_ADICIONAR()
        {
            if (SPLITCONTAINER_OPCOES_FTP.Panel2.Controls.Count == 0)
            {
                SPLITCONTAINER_OPCOES_FTP.Panel2.Controls.Clear();

                FORMS.OPCOES.PANELS.FTP.PNL_OPCOES_FTP_ADICIONAR PNL_FTPAdicionar = new FORMS.OPCOES.PANELS.FTP.PNL_OPCOES_FTP_ADICIONAR();
                PNL_FTPAdicionar.TopLevel = false;
                PNL_FTPAdicionar.AutoScroll = true;

                SPLITCONTAINER_OPCOES_FTP.Panel2.Controls.Add(PNL_FTPAdicionar);

                PNL_FTPAdicionar.Visible = true;
                return;
            }

            if (SPLITCONTAINER_OPCOES_FTP.Panel2.Controls.Count == 1 || SPLITCONTAINER_OPCOES_FTP.Panel2.Controls.Count > 1)
            {
                SPLITCONTAINER_OPCOES_FTP.Panel2.Controls.Clear();

                FORMS.OPCOES.PANELS.FTP.PNL_OPCOES_FTP_ADICIONAR PNL_FTPAdicionar = new FORMS.OPCOES.PANELS.FTP.PNL_OPCOES_FTP_ADICIONAR();
                PNL_FTPAdicionar.TopLevel = false;
                PNL_FTPAdicionar.AutoScroll = true;

                SPLITCONTAINER_OPCOES_FTP.Panel2.Controls.Add(PNL_FTPAdicionar);

                PNL_FTPAdicionar.Visible = true;
                return;
            }
        }

        public void OPEN_OPCOES_FTP_REMOVER()
        {
            if (SPLITCONTAINER_OPCOES_FTP.Panel2.Controls.Count == 0)
            {
                SPLITCONTAINER_OPCOES_FTP.Panel2.Controls.Clear();

                FORMS.OPCOES.PANELS.FTP.PNL_OPCOES_FTP_REMOVER PNL_FTPRemover = new FORMS.OPCOES.PANELS.FTP.PNL_OPCOES_FTP_REMOVER();
                PNL_FTPRemover.TopLevel = false;
                PNL_FTPRemover.AutoScroll = true;

                SPLITCONTAINER_OPCOES_FTP.Panel2.Controls.Add(PNL_FTPRemover);

                PNL_FTPRemover.Visible = true;
                return;
            }

            if (SPLITCONTAINER_OPCOES_FTP.Panel2.Controls.Count == 1 || SPLITCONTAINER_OPCOES_FTP.Panel2.Controls.Count > 1)
            {
                SPLITCONTAINER_OPCOES_FTP.Panel2.Controls.Clear();

                FORMS.OPCOES.PANELS.FTP.PNL_OPCOES_FTP_REMOVER PNL_FTPRemover = new FORMS.OPCOES.PANELS.FTP.PNL_OPCOES_FTP_REMOVER();
                PNL_FTPRemover.TopLevel = false;
                PNL_FTPRemover.AutoScroll = true;

                SPLITCONTAINER_OPCOES_FTP.Panel2.Controls.Add(PNL_FTPRemover);

                PNL_FTPRemover.Visible = true;
                return;
            }
        }

        public void OPEN_OPCOES_FTP_ALTERAR()
        {
            if (SPLITCONTAINER_OPCOES_FTP.Panel2.Controls.Count == 0)
            {
                SPLITCONTAINER_OPCOES_FTP.Panel2.Controls.Clear();

                FORMS.OPCOES.PANELS.FTP.PNL_OPCOES_FTP_ALTERAR PNL_FTPAlterar = new FORMS.OPCOES.PANELS.FTP.PNL_OPCOES_FTP_ALTERAR();
                PNL_FTPAlterar.TopLevel = false;
                PNL_FTPAlterar.AutoScroll = true;

                SPLITCONTAINER_OPCOES_FTP.Panel2.Controls.Add(PNL_FTPAlterar);

                PNL_FTPAlterar.Visible = true;
                return;
            }

            if (SPLITCONTAINER_OPCOES_FTP.Panel2.Controls.Count == 1 || SPLITCONTAINER_OPCOES_FTP.Panel2.Controls.Count > 1)
            {
                SPLITCONTAINER_OPCOES_FTP.Panel2.Controls.Clear();

                FORMS.OPCOES.PANELS.FTP.PNL_OPCOES_FTP_ALTERAR PNL_FTPAlterar = new FORMS.OPCOES.PANELS.FTP.PNL_OPCOES_FTP_ALTERAR();
                PNL_FTPAlterar.TopLevel = false;
                PNL_FTPAlterar.AutoScroll = true;

                SPLITCONTAINER_OPCOES_FTP.Panel2.Controls.Add(PNL_FTPAlterar);

                PNL_FTPAlterar.Visible = true;
                return;
            }
        }
    }
}
