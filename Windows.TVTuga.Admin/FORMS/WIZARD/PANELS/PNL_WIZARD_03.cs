using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Windows.TVTuga.Admin.FORMS.WIZARD;
using Windows.TVTuga.Admin.FORMS.WIZARD.PANELS.CLASSES;

namespace Windows.TVTuga.Admin.FORMS.WIZARD.PANELS
{
    public partial class PNL_WIZARD_03 : Windows.TVTuga.Admin.FORMS.OPCOES.PANELS._EXEMPLOS.PNL_OPCOES_OPCAO_EXEMPLO
    {
        FRM_WIZARD FormWizard = (FRM_WIZARD)Application.OpenForms["FRM_WIZARD"];

        public PNL_WIZARD_03()
        {
            InitializeComponent();
        }

        private void PNL_WIZARD_03_Load(object sender, EventArgs e)
        {
            if (FormWizard.DefaultServer == true)
            {
                CHECKBOX_SIM.Checked = true;
                LABEL_NOVO_ENDERECO.Visible = false;
                TEXTBOX_NOVO_ENDERECO.Visible = false;
                TEXTBOX_NOVO_ENDERECO.Text = "";
            }

            else
            {
                CHECKBOX_SIM.Checked = false;
                TEXTBOX_NOVO_ENDERECO.Text = FormWizard.Servidor;
            }
        }

        private void CHECKBOX_SIM_CheckedChanged(object sender, EventArgs e)
        {
            if (CHECKBOX_SIM.Checked == true)
            {
                FormWizard.BUTTON_SEGUINTE.Enabled = true;
                FormWizard.DefaultServer = true;
                LABEL_NOVO_ENDERECO.Visible = false;
                TEXTBOX_NOVO_ENDERECO.Visible = false;                
                return;
            }
            else
            {
                FormWizard.BUTTON_SEGUINTE.Enabled = false;
                FormWizard.DefaultServer = false;
                LABEL_NOVO_ENDERECO.Visible = true;
                TEXTBOX_NOVO_ENDERECO.Visible = true;                
                return;
            }
        }

        private void TEXTBOX_NOVO_ENDERECO_TextChanged(object sender, EventArgs e)
        {
            if (TEXTBOX_NOVO_ENDERECO.TextLength > 0)
                FormWizard.BUTTON_SEGUINTE.Enabled = true;
            else
                FormWizard.BUTTON_SEGUINTE.Enabled = false;

            FormWizard.Servidor = TEXTBOX_NOVO_ENDERECO.Text;
        }
    }
}