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
    public partial class PNL_GERIR_WEBSITES_LISTAGEM : Form
    {
        CLS_GERIR_WEBSITES GerirWebsites = new CLS_GERIR_WEBSITES();

        public PNL_GERIR_WEBSITES_LISTAGEM()
        {
            InitializeComponent();
            GerirWebsites.LIST_WEBSITES();
            GerirWebsites.LIST_WEBSITE_TYPES();            
        }

        private void PNL_GERIR_WEBSITES_LISTAGEM_Load(object sender, EventArgs e)
        {
            FILL_WEBSITES();
            FILL_WEBSITE_TYPES();
        }

        private void LISTVIEW_WEBSITES_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LISTVIEW_WEBSITES.SelectedIndices.Count == -1 || LISTVIEW_WEBSITES.SelectedIndices.Count == 0)
                return;
            else
            {
                FILL_WEBSITE_DATA();
            }
        }

        private void FILL_WEBSITE_TYPES()
        {
            foreach (string Tipo in GerirWebsites.Tipos)
            {
                COMBOBOX_TIPO.Items.Add(Tipo);
            }
        }    
        
        private void FILL_WEBSITES()
        {
            foreach (string Website in GerirWebsites.Websites)
            {
                LISTVIEW_WEBSITES.Items.Add(Website);
            }
        }

        private void FILL_WEBSITE_DATA()
        {
            GerirWebsites.FILL_WEBSITE_DATA(LISTVIEW_WEBSITES.SelectedItems[0].Text);

            TEXTBOX_NOME.Text = GerirWebsites.Websites_Data[0].ToString();
            TEXTBOX_ENDERECO.Text = GerirWebsites.Websites_Data[1].ToString();
            COMBOBOX_TIPO.SelectedIndex = COMBOBOX_TIPO.FindString(GerirWebsites.Websites_Data[2].ToString());
        }
    }
}
