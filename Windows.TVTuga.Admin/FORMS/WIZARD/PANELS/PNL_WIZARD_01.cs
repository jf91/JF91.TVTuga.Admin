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
    public partial class PNL_WIZARD_01 : Windows.TVTuga.Admin.FORMS.OPCOES.PANELS._EXEMPLOS.PNL_OPCOES_OPCAO_EXEMPLO
    {
        FRM_WIZARD FormWizard = (FRM_WIZARD)Application.OpenForms["FRM_WIZARD"];

        public PNL_WIZARD_01()
        {
            InitializeComponent();
        }

        private void PNL_WIZARD_01_Load(object sender, EventArgs e)
        {
            if (FormWizard.ID == 0)
                TEXTBOX_ID_UTILIZADOR.Text = "";
            else
                TEXTBOX_ID_UTILIZADOR.Text = FormWizard.ID.ToString();
        }

        private void TEXTBOX_ID_UTILIZADOR_TextChanged(object sender, EventArgs e)
        {
            if (TEXTBOX_ID_UTILIZADOR.TextLength > 0)
                FormWizard.BUTTON_SEGUINTE.Enabled = true;
            else
                FormWizard.BUTTON_SEGUINTE.Enabled = false;

            FormWizard.ID = Convert.ToInt32(TEXTBOX_ID_UTILIZADOR.Text);
        }
    }
}
