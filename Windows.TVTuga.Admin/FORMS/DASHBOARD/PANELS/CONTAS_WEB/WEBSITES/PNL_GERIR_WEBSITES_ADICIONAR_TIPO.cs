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
    public partial class PNL_GERIR_WEBSITES_ADICIONAR_TIPO : Form
    {
        CLS_GERIR_WEBSITES GerirWebsites = new CLS_GERIR_WEBSITES();

        private string AUX_Tipo;

        public PNL_GERIR_WEBSITES_ADICIONAR_TIPO()
        {
            InitializeComponent();
            GerirWebsites.LIST_WEBSITE_TYPES();
        }

        private void PNL_GERIR_WEBSITES_ADICIONAR_TIPO_Load(object sender, EventArgs e)
        {
            FILL_WEBSITE_TYPES();
        }

        private void LISTVIEW_TIPOS_WEBSITES_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LISTVIEW_TIPOS_WEBSITES.SelectedIndices.Count == -1 || LISTVIEW_TIPOS_WEBSITES.SelectedIndices.Count == 0)
                return;
            else
            {
                TEXTBOX_NOME.Text = LISTVIEW_TIPOS_WEBSITES.SelectedItems[0].Text;
                AUX_Tipo = LISTVIEW_TIPOS_WEBSITES.SelectedItems[0].Text;
            }
        }

        private void BUTTON_CONFIRMAR_Click(object sender, EventArgs e)
        {
            if (CHECK_TYPE(TEXTBOX_NOME.Text) == false)
            {
                DialogResult DR = MessageBox.Show("O tipo de website que está a tentar criar já se encontra registado. Pretende altera-lo? \n\n Se clicar 'Sim' a alteração será efectuada. \n Se clicar 'Não' irá ser criado um novo tipo. \n Clique em cancelar para voltar.", "Alterar Tipo de Website?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (DR == DialogResult.Yes)
                {
                    UPDATE_WEBSITE_TYPE(TEXTBOX_NOME.Text);

                    RESET_WEBSITE_TYPES();

                    MessageBox.Show("O tipo de website foi alterado com sucesso", "Tipo de website alterdo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (DR == DialogResult.No)
                {
                    CREATE_WEBSITE_TYPE(TEXTBOX_NOME.Text);

                    RESET_WEBSITE_TYPES();

                    MessageBox.Show("O tipo de website foi criado com sucesso", "Tipo de website inserido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                if (DR == DialogResult.Cancel)
                    return;
                else
                    return;
            }

            else
            {
                if(VALIDATIONS() == false)
                {
                    MessageBox.Show("Tem de escrever o nome para o tipo de website que está a tentar criar.", "Nome em branco", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    return;
                }

                else
                {
                    CREATE_WEBSITE_TYPE(TEXTBOX_NOME.Text);

                    RESET_WEBSITE_TYPES();

                    MessageBox.Show("O tipo de website foi criado com sucesso", "Tipo de website inserido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void BUTTON_REMOVER_Click(object sender, EventArgs e)
        {
            DialogResult DR = MessageBox.Show("Tem a certeza que pretende remover o tipo de website '" + TEXTBOX_NOME.Text + "'? Todas as associações dos websites existente serão removidas.", "Remover Tipo de Website?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (DR == DialogResult.Yes)
            {
                DELETE_WEBSITE_TYPE(TEXTBOX_NOME.Text);

                RESET_WEBSITE_TYPES();

                MessageBox.Show("O tipo de website foi removido com sucesso", "Tipo de website removido", MessageBoxButtons.OK, MessageBoxIcon.Information);                
            }

            else
                return;
        }

        private void FILL_WEBSITE_TYPES()
        {
            foreach(string Tipo in GerirWebsites.Tipos)
            {
                LISTVIEW_TIPOS_WEBSITES.Items.Add(Tipo);
            }
        }   

        private void RESET_WEBSITE_TYPES()
        {
            LISTVIEW_TIPOS_WEBSITES.Items.Clear();

            GerirWebsites.Tipos.Clear();

            GerirWebsites.LIST_WEBSITE_TYPES();

            foreach (string Tipo in GerirWebsites.Tipos)
            {
                LISTVIEW_TIPOS_WEBSITES.Items.Add(Tipo);
            }
        }
        
        private bool CHECK_TYPE(string Tipo)
        {
            //foreach(ListViewItem LVI in LISTVIEW_TIPOS_WEBSITES.Items)
            //{
            //    if (LVI.Text == Tipo)
            //        return false;
            //}

            //return true;

            if (LISTVIEW_TIPOS_WEBSITES.SelectedIndices.Count == -1 || LISTVIEW_TIPOS_WEBSITES.SelectedIndices.Count == 0)
                return true;

            else
            {
                if (AUX_Tipo == LISTVIEW_TIPOS_WEBSITES.SelectedItems[0].Text)
                    return false;
                else
                    return true;
            }
        }

        private bool VALIDATIONS()
        {
            if (TEXTBOX_NOME.Text.Length <= 0)
                return false;
            else
                return true;
        }

        private void CREATE_WEBSITE_TYPE(string Tipo)
        {
            GerirWebsites.CREATE_TYPE(Tipo);
        }

        private void UPDATE_WEBSITE_TYPE(string Tipo)
        {
            GerirWebsites.UPDATE_TYPE(AUX_Tipo, Tipo);
        }

        private void DELETE_WEBSITE_TYPE(string Tipo)
        {
            GerirWebsites.DELETE_TYPE(Tipo);
        }
    }
}
