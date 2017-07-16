using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Windows.TVTuga.Admin.FORMS.WIZARD.PANELS
{
    public partial class PNL_WIZARD_02 : Windows.TVTuga.Admin.FORMS.OPCOES.PANELS._EXEMPLOS.PNL_OPCOES_OPCAO_EXEMPLO
    {
        FRM_WIZARD FormWizard = (FRM_WIZARD)Application.OpenForms["FRM_WIZARD"];

        public PNL_WIZARD_02()
        {
            InitializeComponent();

            FormWizard.BUTTON_SEGUINTE.Enabled = false;
        }

        private void PNL_WIZARD_02_Load(object sender, EventArgs e)
        {
            if (FormWizard.Nome == null)
                TEXTBOX_NOME.Text = "";
            else
                TEXTBOX_NOME.Text = FormWizard.Nome;

            if (FormWizard.Username == null)
                TEXTBOX_USERNAME.Text = "";
            else
                TEXTBOX_USERNAME.Text = FormWizard.Username;

            if (FormWizard.Password == null)
                TEXTBOX_PASSWORD.Text = "";
            else
                TEXTBOX_PASSWORD.Text = FormWizard.Password;
        }

        private void TEXTBOX_NOME_TextChanged(object sender, EventArgs e)
        {
            if (TEXTBOX_NOME.TextLength > 0 && TEXTBOX_USERNAME.TextLength > 0 && TEXTBOX_PASSWORD.TextLength > 0)
                FormWizard.BUTTON_SEGUINTE.Enabled = true;
            else
                FormWizard.BUTTON_SEGUINTE.Enabled = false;

            FormWizard.Nome = TEXTBOX_NOME.Text;
        }

        private void TEXTBOX_USERNAME_TextChanged(object sender, EventArgs e)
        {
            if (TEXTBOX_NOME.TextLength > 0 && TEXTBOX_USERNAME.TextLength > 0 && TEXTBOX_PASSWORD.TextLength > 0)
                FormWizard.BUTTON_SEGUINTE.Enabled = true;
            else
                FormWizard.BUTTON_SEGUINTE.Enabled = false;

            FormWizard.Username = TEXTBOX_USERNAME.Text;
        }

        private void TEXTBOX_PASSWORD_TextChanged(object sender, EventArgs e)
        {
            if (TEXTBOX_NOME.TextLength > 0 && TEXTBOX_USERNAME.TextLength > 0 && TEXTBOX_PASSWORD.TextLength > 0)
                FormWizard.BUTTON_SEGUINTE.Enabled = true;
            else
                FormWizard.BUTTON_SEGUINTE.Enabled = false;

            FormWizard.Password = TEXTBOX_PASSWORD.Text;
        }
    }
}
