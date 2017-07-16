using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.TVTuga.Admin.CLASSES;
using Windows.TVTuga.Admin.FORMS.DASHBOARD;

namespace Windows.TVTuga.Admin
{
    public partial class FRM_INICIO : Form
    {
        CLS_DB_CONNECTION LigacaoDB;

        private string PWD;

        public FRM_INICIO()
        {
            InitializeComponent();
            if (FILL_ACCOUNT_LIST() == false)
            {
                //LAUNCH_WIZARD();
                //this.Visible = false;
                MessageBox.Show("Não tem nenhuma conta configurada para acesso à base de dados. Por favor crie uma nas opções para prosseguir", "Sem contas de acesso", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }

        private void MENUSTRIP_MAIN_OPCOES_Click(object sender, EventArgs e)
        {
            this.Hide();
            FRM_OPCOES FRM_Opcoes = new FRM_OPCOES();
            FRM_Opcoes.ShowDialog();
        }

        public bool CHECK_ACCOUNT_LIST()
        {
            if (LISTVIEW_CONTAS.Items.Count == 0)
                return false;
            else
                return true;
        }

        public bool FILL_ACCOUNT_LIST()
        {
            RegistryKey Chave = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\Roaming\OptionsConfig\AppUsers", true);

            if (Chave != null)
            {
                foreach (string User in Chave.GetValueNames())
                {
                    LISTVIEW_CONTAS.Items.Add(User.Substring(2));                    
                }

                if (LISTVIEW_CONTAS.Items.Count == 0)
                    return false;

                return true;
            }

            else
                return false;
        }

        public void LAUNCH_WIZARD()
        {
            //FORMS.WIZARD.FRM_WIZARD Wizard = new FORMS.WIZARD.FRM_WIZARD();
                      
            //Wizard.ShowDialog();       
        }

        private void LISTVIEW_CONTAS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LISTVIEW_CONTAS.SelectedIndices.Count == -1 || LISTVIEW_CONTAS.SelectedIndices.Count == 0)
                return;
            else
            {
                TEXTBOX_USERNAME.Text = LISTVIEW_CONTAS.SelectedItems[0].Text;

                SELECT_CONNECTION_STRING();
            }
        }

        private void MENUSTRIP_LOGIN_FECHAR_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FRM_INICIO_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void SELECT_CONNECTION_STRING()
        {
            try
            {
                using (RegistryKey Chave = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\Roaming\OptionsConfig\AppUsers", true))
                {
                    foreach (string User in Chave.GetValueNames())
                    {
                        if (User.Substring(2) == LISTVIEW_CONTAS.SelectedItems[0].Text)
                        {
                            string AUX_Hostname = "";
                            string AUX_Username = "";
                            string AUX_Password = "";

                            string VALUE = Chave.GetValue(User).ToString();
                            string AUX_VALUE = VALUE.Remove(VALUE.IndexOf(";Use"));

                            AUX_Hostname = AUX_VALUE.Substring(7);
                            AUX_Hostname = AUX_Hostname.Remove(AUX_Hostname.IndexOf(";"));

                            AUX_Username = AUX_VALUE.Remove(AUX_VALUE.IndexOf(";PWD"));
                            AUX_Username = AUX_Username.Substring(AUX_Username.IndexOf(";"));
                            AUX_Username = AUX_Username.Substring(5);

                            AUX_Password = AUX_VALUE.Substring(AUX_VALUE.IndexOf(";"));
                            AUX_Password = AUX_Password.Substring(1);
                            AUX_Password = AUX_Password.Substring(AUX_Password.IndexOf(";"));
                            AUX_Password = AUX_Password.Substring(5);

                            PWD = AUX_Password;

                            UPDATE_CONNECTION_STRING(AUX_Hostname, AUX_Username, AUX_Password);
                        }
                    }
                }
            }

            catch (Exception EX)
            {
                MessageBox.Show("Ocorreu um erro. Descrição do erro: \n\n " + EX.Message + "", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UPDATE_CONNECTION_STRING(string Hostname, string Username, string Password)
        {
            LigacaoDB = new CLS_DB_CONNECTION(Hostname, Username, Password);
        }

        private bool USER_SELECTED()
        {
            if (TEXTBOX_USERNAME.Text.Length == 0)
            {
                MessageBox.Show("Selecione um utilizador para iniciar sessão.", "Nenhum utilizador selecionado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            else
                return true;
        }

        private bool PWD_TYPED()
        {
            if (TEXTBOX_PASSWORD.Text.Length == 0)
            {
                MessageBox.Show("Introduza a sua password!", "Password Vazia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            else
                return true;
        }

        private bool PWD_MATCH()
        {
            if (TEXTBOX_PASSWORD.Text == PWD)
                return true;
            else
            {
                MessageBox.Show("Password Errada. Tente novamente.", "Password Errada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void BUTTON_LOGIN_Click(object sender, EventArgs e)
        {
            try
            {
                if (USER_SELECTED() == true)
                {
                    if (PWD_TYPED() == true)
                    {
                        if (PWD_MATCH() == true)
                        {
                            FRM_DASHBOARD PNL_Dashboard = new FRM_DASHBOARD();

                            this.Hide();

                            PNL_Dashboard.Show();
                        }
                    }
                }
            }

            catch (Exception EX)
            {
                MessageBox.Show("Ocorreu um erro. Descrição do erro: \n\n " + EX.Message + "", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TEXTBOX_PASSWORD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                BUTTON_LOGIN.PerformClick();
        }
    }
}
