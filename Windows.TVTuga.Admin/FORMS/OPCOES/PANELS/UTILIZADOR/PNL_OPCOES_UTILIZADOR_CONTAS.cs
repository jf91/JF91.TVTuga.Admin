using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Windows.TVTuga.Admin.FORMS.OPCOES.PANELS.UTILIZADOR.CLASSES;

namespace Windows.TVTuga.Admin.FORMS.OPCOES.PANELS.UTILIZADOR
{
    public partial class PNL_OPCOES_UTILIZADOR_CONTAS : Form
    {
        CLS_OBTER_CONTAS ObterContas = new CLS_OBTER_CONTAS();

        public string Username = "";
        public string AUX_Username = "";

        public PNL_OPCOES_UTILIZADOR_CONTAS()
        {
            InitializeComponent();
            ObterContas.OBTER_CONTAS_LOCAIS();
            FILL_ACCOUNT_LIST();
        }

        private void LISTVIEW_CONTAS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LISTVIEW_CONTAS.SelectedIndices.Count == -1 || LISTVIEW_CONTAS.SelectedIndices.Count == 0)
                return;
            else
            {
                Username = LISTVIEW_CONTAS.SelectedItems[0].Text;
                TEXTBOX_USERNAME.Text = LISTVIEW_CONTAS.SelectedItems[0].Text;

                foreach (string User in ObterContas.User)
                {
                    if(LISTVIEW_CONTAS.SelectedItems[0].Text == User.Substring(2))
                    {
                        if (User.Substring(0, 1) == "1")
                            COMBOBOX_RANKS.SelectedIndex = 0;
                        if (User.Substring(0, 1) == "2")
                            COMBOBOX_RANKS.SelectedIndex = 1;
                        if (User.Substring(0, 1) == "3")
                            COMBOBOX_RANKS.SelectedIndex = 2;
                        if (User.Substring(0, 1) == "4")
                            COMBOBOX_RANKS.SelectedIndex = 3;
                        if (User.Substring(0, 1) == "5")
                            COMBOBOX_RANKS.SelectedIndex = 4;
                    }
                }
            }
        }

        private void TEXTBOX_USERNAME_TextChanged(object sender, EventArgs e)
        {
            AUX_Username = TEXTBOX_USERNAME.Text;
        }

        public void FILL_ACCOUNT_LIST()
        {
            foreach (string User in ObterContas.User)
            {
                LISTVIEW_CONTAS.Items.Add(User.ToString().Substring(2));
            }
        }
    }
}
