using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using MySql.Data.MySqlClient;
using Windows.TVTuga.Admin.CLASSES;
using Windows.TVTuga.Admin.FORMS.WIZARD.PANELS.CLASSES;

namespace Windows.TVTuga.Admin.FORMS.WIZARD.PANELS.CLASSES
{
    class CLS_GUARDAR_DADOS
    {
        CLS_ENCRYPT Encrypt = new CLS_ENCRYPT();
        CLS_DB_CONNECTION LigacaoDB = new CLS_DB_CONNECTION();
        CLS_CRIAR_UTILIZADOR CriarUtilizador = new CLS_CRIAR_UTILIZADOR();

        // Member Variables
        private int AUX_ID = 0;
        private string AUX_Nome = "";
        private string AUX_Username = "";
        private string AUX_Password = "";
        private string AUX_Servidor = "";
        public string AUX_Servidor_Default = "46.105.16.137";
        
        // Default Constructor
        public CLS_GUARDAR_DADOS()
        {
            AUX_ID = 0;
            AUX_Nome = "";
            AUX_Username = "";
            AUX_Password = "";
            AUX_Servidor = AUX_Servidor_Default;
        }

        // Overload Constructor
        public CLS_GUARDAR_DADOS(int ID, string Nome, string Username, string Password, string Servidor)
        {
            AUX_ID = ID;
            AUX_Nome = Nome;
            AUX_Username = Username;
            AUX_Password = Password;
            AUX_Servidor = Servidor;
        }

        // GET Functions
        public int GetID()
        {
            return AUX_ID;
        }

        public string GetNome()
        {
            return AUX_Nome;
        }

        public string GetUsername()
        {
            return AUX_Username;
        }

        public string GetPassword()
        {
            return AUX_Password;
        }

        public string GetServidor()
        {
            return AUX_Servidor;
        }

        // SET Functions
        public void SetID(int ID)
        {
            AUX_ID = ID;
        }

        public void SetNome(string Nome)
        {
            AUX_Nome = Nome;
        }

        public void SetUsername(string Username)
        {
            AUX_Username = Username;
        }

        public void SetPassword(string Password)
        {
            AUX_Password = Password;
        }

        public void SetServidor(string Servidor)
        {
            AUX_Servidor = Servidor;
        }

        // Encriptar password
        public string ENCRYPT_PASSWORD()
        {
            return Encrypt.ENCRYPT(AUX_Password);
        }

        // Desemcriptar password
        public string DECRYPT_PASSWORD()
        {
            return Encrypt.DECRYPT(ENCRYPT_PASSWORD()).ToString();
        }

        // Criar primeira configuração no regedit
        public void WRITE_TO_REGISTRY()
        {
            RegistryKey Chave = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\Roaming", true);
            Chave.CreateSubKey("OptionsConfig");
            Chave = Chave.OpenSubKey("OptionsConfig", true);
            Chave.CreateSubKey("AppUsers");
            Chave = Chave.OpenSubKey("AppUsers", true);
            //Chave.SetValue(AUX_Username, GENERATE_CONNECTION_STRING());
            Chave.Close();
        }

        // Criar primeira configuração de conexão à base de dados para armazenar no registo.
        //public string GENERATE_CONNECTION_STRING()
        //{
        //    //return LigacaoDB.CREATE_CONNECTION_STRING(AUX_Servidor, "mysql", AUX_Username, AUX_Password);
        //}

        // Criar primeira conexão à base de dados
        public void CREATE_CONNECTION()
        {
            LigacaoDB = new CLS_DB_CONNECTION(AUX_Servidor, "mysql", AUX_ID.ToString());
        }
    
        public void SAVE_DB_USER_CREDENTIALS()
        {
            CREATE_CONNECTION();
            //CriarUtilizador.UPDATE_USER(LigacaoDB.CONNECTION, AUX_ID.ToString(), AUX_Username, AUX_Password);
            //LigacaoDB.UPDATE_CONNECTION(AUX_Servidor, "mysql", AUX_Username, AUX_Password);
        }

        public void SET_DB_PERMISSIONS()
        {

        }
    }
}
