using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.TVTuga.Admin.CLASSES.DASHBOARD.CONTAS_WEB.WEBSITES;

namespace Windows.TVTuga.Admin.FORMS.DASHBOARD.PANELS.CONTAS_WEB.WEBSITES
{
    public partial class PNL_GERIR_WEBSITES_ADICIONAR : Form
    {
        CLS_GERIR_WEBSITES GerirWebsites = new CLS_GERIR_WEBSITES();

        public PNL_GERIR_WEBSITES_ADICIONAR()
        {
            InitializeComponent();
            GerirWebsites.LIST_WEBSITE_TYPES();
        }

        private void PNL_GERIR_WEBSITES_ADICIONAR_Load(object sender, EventArgs e)
        {
            FILL_WEBSITE_TYPES();
        }

        private void BUTTON_WEBSITES_CRIAR_Click(object sender, EventArgs e)
        {
            if(VALIDATIONS() == true)
            {
                GerirWebsites.CREATE_WEBSITE(TEXTBOX_NOME.Text, TEXTBOX_ENDERECO.Text, COMBOBOX_TIPO.Text);

                MessageBox.Show("Website inserido com sucesso", "Website Inserido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FILL_WEBSITE_TYPES()
        {
            foreach (string Tipo in GerirWebsites.Tipos)
            {
                COMBOBOX_TIPO.Items.Add(Tipo);
            }
        }      
        
        private bool VALIDATIONS()
        {
            if(TEXTBOX_NOME.Text.Length <= 0)
            {
                MessageBox.Show("Tem de definir um nome para o novo website", "Nome em branco", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            if(TEXTBOX_ENDERECO.Text.Length <= 0)
            {
                MessageBox.Show("Tem de definir um endereco para o novo website", "Endereco em branco", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            if (COMBOBOX_TIPO.SelectedIndex == -1)
            {
                MessageBox.Show("Tem de definir um tipo para o novo website", "Tipo de website em branco", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            else
                return true;
        }        
    }
}
