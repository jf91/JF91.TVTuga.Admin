using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Windows.TVTuga.Admin.FORMS.OPCOES.PANELS.UTILIZADOR
{
    public partial class PNL_OPCOES_UTILIZADOR_ADICIONAR : Form
    {
        public PNL_OPCOES_UTILIZADOR_ADICIONAR()
        {
            InitializeComponent();
        }

        private void BUTTON_CRIAR_CONTA_Click(object sender, EventArgs e)
        {
            RegistryKey Chave = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\Roaming", true);
            Chave.CreateSubKey("OptionsConfig");
            Chave = Chave.OpenSubKey("OptionsConfig", true);
            Chave.CreateSubKey("AppUsers");
            Chave = Chave.OpenSubKey("AppUsers", true);
            foreach (string User in Chave.GetValueNames())
            {
                if (User.ToString() == TEXTBOX_USERNAME.Text)
                {
                    MessageBox.Show("O utilizador local que está a tentar criar já se encontra registado. Escolha outro Username", "Utilzador duplicado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            Chave.SetValue(TEXTBOX_USERNAME.Text, "");
            Chave.Close();

            TEXTBOX_USERNAME.Text = "";

            MessageBox.Show("Utilizador local criado com sucesso. Defina agora as definições de FTP e Base de Dados","Utilizador local criado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
