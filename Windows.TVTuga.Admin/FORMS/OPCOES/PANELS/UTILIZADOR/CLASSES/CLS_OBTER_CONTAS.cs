using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Microsoft.Win32;
using System.Collections;

namespace Windows.TVTuga.Admin.FORMS.OPCOES.PANELS.UTILIZADOR.CLASSES
{
    class CLS_OBTER_CONTAS
    {
        // MEMBER VARIABLES
        private int AUX_ID;
        private string AUX_Nome;
        private string AUX_RankNome;
        private int AUX_RankID;
        private string AUX_Username;
        private string AUX_Password;

        public ArrayList User = new ArrayList();

        // DEFAULT CONSTRUCTOR
        public CLS_OBTER_CONTAS()
        {
            AUX_ID = 0;
            AUX_Nome = "";
            AUX_RankNome = "";
            AUX_RankID = 0;
            AUX_Username = "";
            AUX_Password = "";
        }

        // OVERLOAD CONSTRUCTOR
        public CLS_OBTER_CONTAS(int ID, string Nome, string RankNome, int RankID, string Username, string Password)
        {
            AUX_ID = ID;
            AUX_Nome = Nome;
            AUX_RankNome = RankNome;
            AUX_RankID = RankID;
            AUX_Username = Username;
            AUX_Password = Password;
        }

        // OBTER CONTAS LOCAIS
        public ArrayList OBTER_CONTAS_LOCAIS()
        {            
            RegistryKey Chave = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\Roaming\OptionsConfig\AppUsers", true);

            if (Chave != null)
            {
                foreach (string AUX_User in Chave.GetValueNames())
                {
                    User.Add(AUX_User);
                }
            }

            return User;
        }
    }
}
