using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Windows.TVTuga.Admin.FORMS.OPCOES.PANELS.UTILIZADOR;

namespace Windows.TVTuga.Admin.FORMS.OPCOES.PANELS
{
    public partial class PNL_OPCOES_UTILIZADOR : Windows.TVTuga.Admin.FORMS.OPCOES.PANELS.PNL_OPCOES_EXEMPLO
    {
        public PNL_OPCOES_UTILIZADOR()
        {
            InitializeComponent();
            OPEN_OPCOES_UTILIZADOR_CONTAS();
        }

        private void BUTTON_CONTAS_Click(object sender, EventArgs e)
        {
            OPEN_OPCOES_UTILIZADOR_CONTAS();
        }

        /***** EVENTOS *****/

        private void BUTTON_ADICIONAR_Click(object sender, EventArgs e)
        {
            INSERT_LOCAL_USER();
        }

        private void BUTTON_REMOVER_Click(object sender, EventArgs e)
        {
            DELETE_LOCAL_USER();
        }

        private void BUTTON_ALTERAR_Click(object sender, EventArgs e)
        {
            UPDATE_LOCAL_USER();
        }

        private void BUTTON_ACTUALIZAR_Click(object sender, EventArgs e)
        {
            REFRESH();
        }

        /***** FUNÇÕES GLOBAIS *****/
        
        public void OPEN_OPCOES_UTILIZADOR_CONTAS()
        {
            if (SPLITCONTAINER_OPCOES_UTILIZADOR.Panel2.Controls.Count == 0)
            {
                SPLITCONTAINER_OPCOES_UTILIZADOR.Panel2.Controls.Clear();

                FORMS.OPCOES.PANELS.UTILIZADOR.PNL_OPCOES_UTILIZADOR_CONTAS PNL_UtilizadorContas = new FORMS.OPCOES.PANELS.UTILIZADOR.PNL_OPCOES_UTILIZADOR_CONTAS();
                PNL_UtilizadorContas.TopLevel = false;
                PNL_UtilizadorContas.AutoScroll = true;

                SPLITCONTAINER_OPCOES_UTILIZADOR.Panel2.Controls.Add(PNL_UtilizadorContas);

                PNL_UtilizadorContas.Visible = true;
                return;
            }

            if (SPLITCONTAINER_OPCOES_UTILIZADOR.Panel2.Controls.Count == 1 || SPLITCONTAINER_OPCOES_UTILIZADOR.Panel2.Controls.Count > 1)
            {
                SPLITCONTAINER_OPCOES_UTILIZADOR.Panel2.Controls.Clear();

                FORMS.OPCOES.PANELS.UTILIZADOR.PNL_OPCOES_UTILIZADOR_CONTAS PNL_UtilizadorContas = new FORMS.OPCOES.PANELS.UTILIZADOR.PNL_OPCOES_UTILIZADOR_CONTAS();
                PNL_UtilizadorContas.TopLevel = false;
                PNL_UtilizadorContas.AutoScroll = true;

                SPLITCONTAINER_OPCOES_UTILIZADOR.Panel2.Controls.Add(PNL_UtilizadorContas);

                PNL_UtilizadorContas.Visible = true;
                return;
            }
        }

        public void OPEN_OPCOES_UTILIZADOR_ADICIONAR()
        {
            if (SPLITCONTAINER_OPCOES_UTILIZADOR.Panel2.Controls.Count == 0)
            {
                SPLITCONTAINER_OPCOES_UTILIZADOR.Panel2.Controls.Clear();

                FORMS.OPCOES.PANELS.UTILIZADOR.PNL_OPCOES_UTILIZADOR_ADICIONAR PNL_UtilizadorAdicionar = new FORMS.OPCOES.PANELS.UTILIZADOR.PNL_OPCOES_UTILIZADOR_ADICIONAR();
                PNL_UtilizadorAdicionar.TopLevel = false;
                PNL_UtilizadorAdicionar.AutoScroll = true;

                SPLITCONTAINER_OPCOES_UTILIZADOR.Panel2.Controls.Add(PNL_UtilizadorAdicionar);

                PNL_UtilizadorAdicionar.Visible = true;
                return;
            }

            if (SPLITCONTAINER_OPCOES_UTILIZADOR.Panel2.Controls.Count == 1 || SPLITCONTAINER_OPCOES_UTILIZADOR.Panel2.Controls.Count > 1)
            {
                SPLITCONTAINER_OPCOES_UTILIZADOR.Panel2.Controls.Clear();

                FORMS.OPCOES.PANELS.UTILIZADOR.PNL_OPCOES_UTILIZADOR_ADICIONAR PNL_UtilizadorAdicionar = new FORMS.OPCOES.PANELS.UTILIZADOR.PNL_OPCOES_UTILIZADOR_ADICIONAR();
                PNL_UtilizadorAdicionar.TopLevel = false;
                PNL_UtilizadorAdicionar.AutoScroll = true;

                SPLITCONTAINER_OPCOES_UTILIZADOR.Panel2.Controls.Add(PNL_UtilizadorAdicionar);

                PNL_UtilizadorAdicionar.Visible = true;
                return;
            }
        }

        public void OPEN_OPCOES_UTILIZADOR_REMOVER()
        {
            if (SPLITCONTAINER_OPCOES_UTILIZADOR.Panel2.Controls.Count == 0)
            {
                SPLITCONTAINER_OPCOES_UTILIZADOR.Panel2.Controls.Clear();

                FORMS.OPCOES.PANELS.UTILIZADOR.PNL_OPCOES_UTILIZADOR_REMOVER PNL_UtilizadorRemover = new FORMS.OPCOES.PANELS.UTILIZADOR.PNL_OPCOES_UTILIZADOR_REMOVER();
                PNL_UtilizadorRemover.TopLevel = false;
                PNL_UtilizadorRemover.AutoScroll = true;

                SPLITCONTAINER_OPCOES_UTILIZADOR.Panel2.Controls.Add(PNL_UtilizadorRemover);

                PNL_UtilizadorRemover.Visible = true;
                return;
            }

            if (SPLITCONTAINER_OPCOES_UTILIZADOR.Panel2.Controls.Count == 1 || SPLITCONTAINER_OPCOES_UTILIZADOR.Panel2.Controls.Count > 1)
            {
                SPLITCONTAINER_OPCOES_UTILIZADOR.Panel2.Controls.Clear();

                FORMS.OPCOES.PANELS.UTILIZADOR.PNL_OPCOES_UTILIZADOR_REMOVER PNL_UtilizadorRemover = new FORMS.OPCOES.PANELS.UTILIZADOR.PNL_OPCOES_UTILIZADOR_REMOVER();
                PNL_UtilizadorRemover.TopLevel = false;
                PNL_UtilizadorRemover.AutoScroll = true;

                SPLITCONTAINER_OPCOES_UTILIZADOR.Panel2.Controls.Add(PNL_UtilizadorRemover);

                PNL_UtilizadorRemover.Visible = true;
                return;
            }
        }

        public void OPEN_OPCOES_UTILIZADOR_ALTERAR()
        {
            if (SPLITCONTAINER_OPCOES_UTILIZADOR.Panel2.Controls.Count == 0)
            {
                SPLITCONTAINER_OPCOES_UTILIZADOR.Panel2.Controls.Clear();

                FORMS.OPCOES.PANELS.UTILIZADOR.PNL_OPCOES_UTILIZADOR_ALTERAR PNL_UtilizadorAlterar = new FORMS.OPCOES.PANELS.UTILIZADOR.PNL_OPCOES_UTILIZADOR_ALTERAR();
                PNL_UtilizadorAlterar.TopLevel = false;
                PNL_UtilizadorAlterar.AutoScroll = true;

                SPLITCONTAINER_OPCOES_UTILIZADOR.Panel2.Controls.Add(PNL_UtilizadorAlterar);

                PNL_UtilizadorAlterar.Visible = true;
                return;
            }

            if (SPLITCONTAINER_OPCOES_UTILIZADOR.Panel2.Controls.Count == 1 || SPLITCONTAINER_OPCOES_UTILIZADOR.Panel2.Controls.Count > 1)
            {
                SPLITCONTAINER_OPCOES_UTILIZADOR.Panel2.Controls.Clear();

                FORMS.OPCOES.PANELS.UTILIZADOR.PNL_OPCOES_UTILIZADOR_ALTERAR PNL_UtilizadorAlterar = new FORMS.OPCOES.PANELS.UTILIZADOR.PNL_OPCOES_UTILIZADOR_ALTERAR();
                PNL_UtilizadorAlterar.TopLevel = false;
                PNL_UtilizadorAlterar.AutoScroll = true;

                SPLITCONTAINER_OPCOES_UTILIZADOR.Panel2.Controls.Add(PNL_UtilizadorAlterar);

                PNL_UtilizadorAlterar.Visible = true;
                return;
            }
        }

        public void REFRESH()
        {
            try
            {
                PNL_OPCOES_UTILIZADOR_CONTAS FormContas = new PNL_OPCOES_UTILIZADOR_CONTAS();
                FormContas = (PNL_OPCOES_UTILIZADOR_CONTAS)Application.OpenForms["PNL_OPCOES_UTILIZADOR_CONTAS"];

                //StringBuilder FORMS = new StringBuilder();
                string FORMS = "";

                foreach (var CONTROL in SPLITCONTAINER_OPCOES_UTILIZADOR.Panel2.Controls)
                {
                    FORMS = CONTROL.GetType().ToString();

                    if (FORMS == "Windows.TVTuga.Admin.FORMS.OPCOES.PANELS.UTILIZADOR.PNL_OPCOES_UTILIZADOR_CONTAS")
                    {
                        FormContas.Username = "";
                        FormContas.AUX_Username = "";
                        FormContas.Close();
                        OPEN_OPCOES_UTILIZADOR_CONTAS();
                        return;
                    }

                    break;
                }
            }

            catch(Exception EX)
            {
                MessageBox.Show("Ocorreu um erro. Descrição do erro: \n\n " + EX.Message + "","",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        public void INSERT_LOCAL_USER()
        {
            try
            {
                PNL_OPCOES_UTILIZADOR_CONTAS FormContas = new PNL_OPCOES_UTILIZADOR_CONTAS();
                FormContas = (PNL_OPCOES_UTILIZADOR_CONTAS)Application.OpenForms["PNL_OPCOES_UTILIZADOR_CONTAS"];

                if (FormContas.AUX_Username != "")
                {
                    using (RegistryKey Chave = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\Roaming\OptionsConfig\AppUsers", true))
                    {
                        if (Chave.ValueCount > 0)
                        {
                            foreach (string User in Chave.GetValueNames())
                            {
                                if (User.Substring(2) != FormContas.AUX_Username)
                                {
                                    if (FormContas.COMBOBOX_RANKS.SelectedIndex != -1)
                                    {
                                        if (FormContas.COMBOBOX_RANKS.SelectedIndex == 0)
                                            Chave.SetValue("1|" + FormContas.AUX_Username, "");
                                        if (FormContas.COMBOBOX_RANKS.SelectedIndex == 1)
                                            Chave.SetValue("2|" + FormContas.AUX_Username, "");
                                        if (FormContas.COMBOBOX_RANKS.SelectedIndex == 2)
                                            Chave.SetValue("3|" + FormContas.AUX_Username, "");
                                        if (FormContas.COMBOBOX_RANKS.SelectedIndex == 3)
                                            Chave.SetValue("4|" + FormContas.AUX_Username, "");
                                        if (FormContas.COMBOBOX_RANKS.SelectedIndex == 4)
                                            Chave.SetValue("5|" + FormContas.AUX_Username, "");
                                    }

                                    else
                                    {
                                        MessageBox.Show("O utilizador local que está a tentar criar tem de ter um rank definido. Escolha um rank", "Definir Rank de Utilizador", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        return;
                                    }
                                }

                                else
                                {
                                    MessageBox.Show("O utilizador local que está a tentar criar já se encontra registado. Escolha outro Username", "Utilzador duplicado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                            }
                        }

                        if(Chave.ValueCount == 0)
                        {
                            if (FormContas.COMBOBOX_RANKS.SelectedIndex != -1)
                            {
                                if (FormContas.COMBOBOX_RANKS.SelectedIndex == 0)
                                    Chave.SetValue("1|" + FormContas.AUX_Username, "");
                                if (FormContas.COMBOBOX_RANKS.SelectedIndex == 1)
                                    Chave.SetValue("2|" + FormContas.AUX_Username, "");
                                if (FormContas.COMBOBOX_RANKS.SelectedIndex == 2)
                                    Chave.SetValue("3|" + FormContas.AUX_Username, "");
                                if (FormContas.COMBOBOX_RANKS.SelectedIndex == 3)
                                    Chave.SetValue("4|" + FormContas.AUX_Username, "");
                                if (FormContas.COMBOBOX_RANKS.SelectedIndex == 4)
                                    Chave.SetValue("5|" + FormContas.AUX_Username, "");
                            }

                            else
                            {
                                MessageBox.Show("O utilizador local que está a tentar criar tem de ter um rank definido. Escolha um rank", "Definir Rank de Utilizador", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                    }

                    FormContas.Username = "";
                    FormContas.AUX_Username = "";
                    FormContas.Close();

                    OPEN_OPCOES_UTILIZADOR_CONTAS();
                }

                else
                {
                    MessageBox.Show("O utilizador local que está a tentar criar não pode ter o nome em branco. Defina um nome de utilizador", "Definir Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            catch (Exception EX)
            {
                MessageBox.Show("Ocorreu um erro. Descrição do erro: \n\n " + EX.Message + "", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void DELETE_LOCAL_USER()
        {
            try
            {
                PNL_OPCOES_UTILIZADOR_CONTAS FormContas = new PNL_OPCOES_UTILIZADOR_CONTAS();
                FormContas = (PNL_OPCOES_UTILIZADOR_CONTAS)Application.OpenForms["PNL_OPCOES_UTILIZADOR_CONTAS"];

                if (FormContas.Username != "")
                {
                    DialogResult Confirmar = MessageBox.Show("Tem a certeza que deseja remover o utilizador '" + FormContas.Username + "' ? Todas as definições de FTP e Base de Dados serão removidas.", "Remover Utilizador?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (Confirmar == DialogResult.Yes)
                    {
                        using (RegistryKey Chave = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\Roaming\OptionsConfig\AppUsers", true))
                        {
                            foreach (string User in Chave.GetValueNames())
                            {
                                if (User.Substring(2) == FormContas.Username)
                                {
                                    Chave.DeleteValue(User);
                                }
                            }
                        }

                        FormContas.Username = "";
                        FormContas.AUX_Username = "";
                        FormContas.Close();

                        OPEN_OPCOES_UTILIZADOR_CONTAS();
                    }

                    else
                        return;
                }

                else
                {
                    MessageBox.Show("Tem de selecionar um utilizador para puder remove-lo", "Selecionar Utilizador", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    FormContas.Username = "";
                    FormContas.AUX_Username = "";
                    FormContas.Close();

                    OPEN_OPCOES_UTILIZADOR_CONTAS();
                }
            }

            catch (Exception EX)
            {
                MessageBox.Show("Ocorreu um erro. Descrição do erro: \n\n " + EX.Message + "", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void UPDATE_LOCAL_USER()
        {
            try
            {
                PNL_OPCOES_UTILIZADOR_CONTAS FormContas = new PNL_OPCOES_UTILIZADOR_CONTAS();
                FormContas = (PNL_OPCOES_UTILIZADOR_CONTAS)Application.OpenForms["PNL_OPCOES_UTILIZADOR_CONTAS"];

                FormContas.Refresh();

                if (FormContas.LISTVIEW_CONTAS.SelectedIndices.Count > 0)
                {
                    FormContas.Username = FormContas.LISTVIEW_CONTAS.SelectedItems[0].Text;
                    FormContas.AUX_Username = FormContas.TEXTBOX_USERNAME.Text;
                }

                if (FormContas.Username != "")
                {
                    DialogResult Confirmar = MessageBox.Show("Tem a certeza que deseja mudar o nome do utilizador '" + FormContas.Username + "' ?", "Alterar Utilizador?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (Confirmar == DialogResult.Yes)
                    {
                        using (RegistryKey Chave = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\Roaming\OptionsConfig\AppUsers", true))
                        {
                            foreach (string User in Chave.GetValueNames())
                            {
                                if (User.Substring(2) == FormContas.Username)
                                {
                                    Chave.DeleteValue(User);

                                    if (FormContas.COMBOBOX_RANKS.SelectedIndex == 0)
                                        Chave.SetValue("1|" + FormContas.AUX_Username, "");
                                    if (FormContas.COMBOBOX_RANKS.SelectedIndex == 1)
                                        Chave.SetValue("2|" + FormContas.AUX_Username, "");
                                    if (FormContas.COMBOBOX_RANKS.SelectedIndex == 2)
                                        Chave.SetValue("3|" + FormContas.AUX_Username, "");
                                    if (FormContas.COMBOBOX_RANKS.SelectedIndex == 3)
                                        Chave.SetValue("4|" + FormContas.AUX_Username, "");
                                    if (FormContas.COMBOBOX_RANKS.SelectedIndex == 4)
                                        Chave.SetValue("5|" + FormContas.AUX_Username, "");
                                }
                            }
                        }

                        FormContas.Username = "";
                        FormContas.AUX_Username = "";
                        FormContas.Close();

                        OPEN_OPCOES_UTILIZADOR_CONTAS();
                        return;
                    }

                    else
                        return;
                }

                else
                {
                    MessageBox.Show("Tem de selecionar um utilizador para puder altera-lo", "Selecionar Utilizador", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    FormContas.Username = "";
                    FormContas.AUX_Username = "";
                    FormContas.Close();

                    OPEN_OPCOES_UTILIZADOR_CONTAS();
                }
            }

            catch (Exception EX)
            {
                MessageBox.Show("Ocorreu um erro. Descrição do erro: \n\n " + EX.Message + "", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
