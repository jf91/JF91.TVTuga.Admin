using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Windows.TVTuga.Admin.CLASSES;
using Windows.TVTuga.Admin.FORMS.OPCOES.PANELS.BD.CONTAS;
using Windows.TVTuga.Admin.FORMS.OPCOES.PANELS;
using Windows.TVTuga.Admin.FORMS.OPCOES.PANELS.UTILIZADOR.CLASSES;
using Microsoft.Win32;
using System.Collections;

namespace Windows.TVTuga.Admin.FORMS.OPCOES.PANELS.BD
{
    public partial class PNL_OPCOES_BD_CONTAS : Form
    {
        CLS_OBTER_CONTAS ObterContas = new CLS_OBTER_CONTAS();
        CLS_DB_CONNECTION LigacaoDB;

        MySqlDataReader Reader;

        private string LocalUsername;
        private string LocalRank;

        private int UserID;
        private int DB_Protocol;
        private ArrayList UserProtocols = new ArrayList();

        public PNL_OPCOES_BD_CONTAS()
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
                if (CHECK_USER_DB_ACCOUNT() == false)
                {
                    MessageBox.Show("Esta conta local não tem nenhuma configuração de acesso à base de dados. Configure esta conta para puder criar uma configuração de utilizador", "Conta não configurada", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    foreach (Control TB in this.Controls)
                    {
                        if (TB is TextBox)
                            TB.Text = "";
                    }

                    COMBOBOX_PROTOCOLO.SelectedIndex = -1;

                    using (RegistryKey Chave = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\Roaming\OptionsConfig\AppUsers", true))
                    {
                        foreach (string User in Chave.GetValueNames())
                        {
                            if (User.Substring(2) == LISTVIEW_CONTAS.SelectedItems[0].Text)
                            {
                                LocalUsername = User.Substring(2);
                                LocalRank = User.Substring(0, 1);
                            }
                        }
                    }
                }

                else
                {
                    using (RegistryKey Chave = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\Roaming\OptionsConfig\AppUsers", true))
                    {
                        foreach (string User in Chave.GetValueNames())
                        {
                            if (User.Substring(2) == LISTVIEW_CONTAS.SelectedItems[0].Text)
                            {
                                LocalUsername = User.Substring(2);
                                LocalRank = User.Substring(0, 1);

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

                                UPDATE_CONNECTION_STRING(AUX_Hostname, AUX_Username, AUX_Password);

                                GET_USER_DB_ID(LISTVIEW_CONTAS.SelectedItems[0].Text);
                                FILL_USER_DB_ACOUNT_DETAILS(UserID.ToString(), LISTVIEW_CONTAS.SelectedItems[0].Text);

                                return;
                            }
                        }
                    }
                }
            }
        }

        private void CHECKBOX_PASSWORD_CheckedChanged(object sender, EventArgs e)
        {
            if (CHECKBOX_PASSWORD.Checked == true)
                TEXTBOX_PASSWORD.UseSystemPasswordChar = false;
            if (CHECKBOX_PASSWORD.Checked == false)
                TEXTBOX_PASSWORD.UseSystemPasswordChar = true;
        }

        private void BUTTON_CRIAR_CONTA_Click(object sender, EventArgs e)
        {
            if (CREATE_VALIDATIONS() == true)
            {
                UPDATE_LOCAL_ACCOUNT(TEXTBOX_IP.Text, TEXTBOX_USERNAME.Text, TEXTBOX_PASSWORD.Text);

                UPDATE_CONNECTION_STRING(TEXTBOX_IP.Text, TEXTBOX_USERNAME.Text, TEXTBOX_PASSWORD.Text);

                CREATE_DB_USER(LocalUsername, Convert.ToInt32(LocalRank));

                GET_USER_DB_ID(LocalUsername);

                if (COMBOBOX_PROTOCOLO.SelectedIndex == 0)
                    DB_Protocol = 1;
                if (COMBOBOX_PROTOCOLO.SelectedIndex == 1)
                    DB_Protocol = 2;
                if (COMBOBOX_PROTOCOLO.SelectedIndex == 2)
                    DB_Protocol = 3;

                CREATE_DB_USER_CONFIG(UserID, TEXTBOX_IP.Text, DB_Protocol, Convert.ToInt32(TEXTBOX_PORTA.Text));

                CREATE_DB_USER_DB_CONFIG(UserID, TEXTBOX_USERNAME.Text, TEXTBOX_PASSWORD.Text);

                MessageBox.Show("O Utilizador '" + LocalUsername + "' foi configurado com sucesso na base dados. Pode agora iniciar sessão na base de dados. Falta só configurar as definições de FTP para esta conta de forma a que possa enviar e transferir ficheiros do servidor","Conta configurada com sucesso",MessageBoxButtons.OK, MessageBoxIcon.Information);

                RESET_CONTROLS();
            }
        }

        private void BUTTON_REMOVER_CONTA_Click(object sender, EventArgs e)
        {
            DELETE_DB_USER(Convert.ToInt32(TEXTBOX_ID.Text));

            MessageBox.Show("O utilizador '" + LocalUsername + "' foi removido da base de dados com sucesso. Se pretender remove-lo por completo terá de eliminar as definições de FTP associadas a esta conta e por fim remover a conta local.","Utilizador removido com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            RESET_CONTROLS();
        }

        private void BUTTON_GRAVAR_ALTERACOES_Click(object sender, EventArgs e)
        {
            UPDATE_DB_USER(Convert.ToInt32(TEXTBOX_ID.Text), TEXTBOX_IP.Text, COMBOBOX_PROTOCOLO.SelectedIndex + 1, Convert.ToInt32(TEXTBOX_PORTA.Text), TEXTBOX_USERNAME.Text, TEXTBOX_PASSWORD.Text);

            MessageBox.Show("O utilizador '" + LocalUsername + "' foi alterado na base de dados com sucesso.", "Utilizador alterado com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            RESET_CONTROLS();
        }        

        /***** FUNCOES *****/

        public void RESET_CONTROLS()
        {
            foreach(ListViewItem LVI in LISTVIEW_CONTAS.Items)
            {
                if (LVI.Selected == true)
                    LVI.Selected = false;
            }

            foreach(Control CT in this.Controls)
            {
                if (CT is TextBox)
                    ((TextBox)CT).Text = "";
                if (CT is ComboBox)
                    ((ComboBox)CT).SelectedIndex = -1;
            }
        }

        public void FILL_ACCOUNT_LIST()
        {
            try
            {
                foreach (string User in ObterContas.User)
                {
                    LISTVIEW_CONTAS.Items.Add(User.ToString().Substring(2));
                }
            }

            catch(Exception EX)
            {
                MessageBox.Show("Ocorreu um erro. Descrição do erro: \n\n " + EX.Message + "", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool CREATE_VALIDATIONS()
        {
            if (LISTVIEW_CONTAS.SelectedIndices.Count == -1 || LISTVIEW_CONTAS.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Tem de selecionar um utilizador local para puder configura-lo", "Selecionar Utilizador", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            else
            {
                if(TEXTBOX_USERNAME.Text.Length == 0)
                {
                    MessageBox.Show("O campo 'Username' não pode estar vazio", "Campo em Branco", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if(TEXTBOX_IP.Text.Length == 0)
                {
                    MessageBox.Show("O campo 'IP ou Hostname' não pode estar vazio", "Campo em Branco", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if(COMBOBOX_PROTOCOLO.SelectedIndex == -1)
                {
                    MessageBox.Show("Tem de selecionar um protocol de conexão", "Protocolo em Falta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if(TEXTBOX_PASSWORD.Text.Length == 0)
                {
                    MessageBox.Show("O campo 'Password' não pode estar vazio", "Campo em Branco", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (TEXTBOX_PORTA.Text.Length == 0)
                {
                    MessageBox.Show("Tem de definir uma porta de conexão", "Porta em Falta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                else
                {
                    using (RegistryKey Chave = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\Roaming\OptionsConfig\AppUsers", true))
                    {
                        foreach (string User in Chave.GetValueNames())
                        {
                            if (User.Substring(2) == LISTVIEW_CONTAS.SelectedItems[0].Text)
                            {
                                if (Chave.GetValue(User) != "")
                                {
                                    MessageBox.Show("O utilizador que está a tentar criar já se encontra registado. Apenas pode alterar as configurações ou remover o utilizador", "Utilizador já existente", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    return false;
                                }
                            }
                        }
                    }
                }
                return true;
            }
        }

        // VERIFICAR CONNECTION STRING LOCAL ATRAVES DO USERNAME
        public bool CHECK_USER_DB_ACCOUNT()
        {
            using (RegistryKey Chave = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\Roaming\OptionsConfig\AppUsers", true))
            {
                foreach (string User in Chave.GetValueNames())
                {
                    if (User.Substring(2) == LISTVIEW_CONTAS.SelectedItems[0].Text)
                    {
                        if (Chave.GetValue(User).ToString() == "")
                            return false;
                    }
                }
            }

            return true;
        }

        public void FILL_USER_DB_ACOUNT_DETAILS(string UserID, string Username)
        {
            try
            {
                TEXTBOX_ID.Text = UserID;

                MySqlCommand CMD_SELECT_LOGIN_NAME = new MySqlCommand();
                CMD_SELECT_LOGIN_NAME.Connection = LigacaoDB.CONNECTION;
                CMD_SELECT_LOGIN_NAME.CommandText = "SELECT nome FROM site_tvtuga_app_admin_users.sql_users WHERE admin_id = " + Convert.ToInt32(UserID) + "";

                MySqlCommand CMD_SELECT_LOGIN_IP = new MySqlCommand();
                CMD_SELECT_LOGIN_IP.Connection = LigacaoDB.CONNECTION;
                CMD_SELECT_LOGIN_IP.CommandText = "SELECT db_host FROM site_tvtuga_app_admin_users.admin_config WHERE admin_id = " + Convert.ToInt32(UserID) + "";

                MySqlCommand CMD_SELECT_LOGIN_PROTOCOL = new MySqlCommand();
                CMD_SELECT_LOGIN_PROTOCOL.Connection = LigacaoDB.CONNECTION;
                CMD_SELECT_LOGIN_PROTOCOL.CommandText = "SELECT site_tvtuga_app_admin_users.admin_config.db_protocol FROM site_tvtuga_app_admin_users.admin_config INNER JOIN site_tvtuga_app_admin_users.sql_protocols ON site_tvtuga_app_admin_users.admin_config.db_protocol = site_tvtuga_app_admin_users.sql_protocols.id WHERE admin_id = " + Convert.ToInt32(UserID) + "";

                MySqlCommand CMD_SELECT_LOGIN_PASSWORD = new MySqlCommand();
                CMD_SELECT_LOGIN_PASSWORD.Connection = LigacaoDB.CONNECTION;
                CMD_SELECT_LOGIN_PASSWORD.CommandText = "SELECT password FROM site_tvtuga_app_admin_users.sql_users WHERE admin_id = " + Convert.ToInt32(UserID) + "";

                MySqlCommand CMD_SELECT_LOGIN_PORT = new MySqlCommand();
                CMD_SELECT_LOGIN_PORT.Connection = LigacaoDB.CONNECTION;
                CMD_SELECT_LOGIN_PORT.CommandText = "SELECT db_port FROM site_tvtuga_app_admin_users.admin_config WHERE admin_id = " + Convert.ToInt32(UserID) + "";

                LigacaoDB.OPEN_CONNECTION();

                CMD_SELECT_LOGIN_NAME.Prepare();
                CMD_SELECT_LOGIN_IP.Prepare();
                CMD_SELECT_LOGIN_PROTOCOL.Prepare();
                CMD_SELECT_LOGIN_PASSWORD.Prepare();
                CMD_SELECT_LOGIN_PORT.Prepare();


                /* QUERY: OBTER O NOME DE LOGIN DA CONNECTION STRING */
                IAsyncResult Working_GetUserLoginName = CMD_SELECT_LOGIN_NAME.BeginExecuteReader();

                Reader = CMD_SELECT_LOGIN_NAME.EndExecuteReader(Working_GetUserLoginName);

                while (Reader.Read())
                {
                    for (int VALUE = 0; VALUE < Reader.FieldCount; VALUE++)
                    {
                        TEXTBOX_USERNAME.Text = Reader.GetValue(VALUE).ToString();
                    }
                }

                Reader.Close();

                /* QUERY: OBTER O IP DE LOGIN DA CONNECTION STRING */
                IAsyncResult Working_GetUserLoginIP = CMD_SELECT_LOGIN_IP.BeginExecuteReader();

                Reader = CMD_SELECT_LOGIN_IP.EndExecuteReader(Working_GetUserLoginIP);

                while (Reader.Read())
                {
                    for (int VALUE = 0; VALUE < Reader.FieldCount; VALUE++)
                    {
                        TEXTBOX_IP.Text = Reader.GetValue(VALUE).ToString();
                    }
                }

                Reader.Close();

                /* QUERY: OBTER O PROTOCOL USADO NA CONNECTION STRING */
                IAsyncResult Working_GetUserLoginProtocol = CMD_SELECT_LOGIN_PROTOCOL.BeginExecuteReader();

                Reader = CMD_SELECT_LOGIN_PROTOCOL.EndExecuteReader(Working_GetUserLoginProtocol);

                while (Reader.Read())
                {
                    for (int VALUE = 0; VALUE < Reader.FieldCount; VALUE++)
                    {
                        string ProtocolID = Reader.GetValue(VALUE).ToString();

                        if(Convert.ToInt32(ProtocolID) == 1)
                        {
                            COMBOBOX_PROTOCOLO.SelectedIndex = Convert.ToInt32(ProtocolID) - 1;
                            break;
                        }
                        if (Convert.ToInt32(ProtocolID) == 2)
                        {
                            COMBOBOX_PROTOCOLO.SelectedIndex = Convert.ToInt32(ProtocolID) - 1;
                            break;
                        }
                        if (Convert.ToInt32(ProtocolID) == 3)
                        {
                            COMBOBOX_PROTOCOLO.SelectedIndex = Convert.ToInt32(ProtocolID) - 1;
                            break;
                        }

                        break;
                    }
                }

                Reader.Close();

                /* QUERY: OBTER A PASSWORD DA CONNECTION STRING */
                IAsyncResult Working_GetUserLoginPassword = CMD_SELECT_LOGIN_PASSWORD.BeginExecuteReader();

                Reader = CMD_SELECT_LOGIN_PASSWORD.EndExecuteReader(Working_GetUserLoginPassword);

                while (Reader.Read())
                {
                    for (int VALUE = 0; VALUE < Reader.FieldCount; VALUE++)
                    {
                        TEXTBOX_PASSWORD.Text = Reader.GetValue(VALUE).ToString();
                    }
                }

                Reader.Close();

                /* QUERY: OBTER A PORTA DA CONNECTION STRING */
                IAsyncResult Working_GetUserLoginPort = CMD_SELECT_LOGIN_PORT.BeginExecuteReader();

                Reader = CMD_SELECT_LOGIN_PORT.EndExecuteReader(Working_GetUserLoginPort);

                while (Reader.Read())
                {
                    for (int VALUE = 0; VALUE < Reader.FieldCount; VALUE++)
                    {
                        TEXTBOX_PORTA.Text = Reader.GetValue(VALUE).ToString();
                    }
                }

                Reader.Close();
            }

            catch (Exception EX)
            {
                MessageBox.Show("Ocorreu um erro de ligação. Verifique a sua configuração.\nDescrição do erro: \n\n " + EX.Message + "", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                LigacaoDB.CLOSE_CONNECTION();
            }
        }

        public void UPDATE_LOCAL_ACCOUNT(string Hostname, string Username, string Password)
        {
            using (RegistryKey Chave = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\Roaming\OptionsConfig\AppUsers", true))
            {
                foreach (string User in Chave.GetValueNames())
                {
                    if (User.Substring(2) == LISTVIEW_CONTAS.SelectedItems[0].Text)
                    {
                        Chave.DeleteValue(User);

                        Chave.SetValue(User, "SERVER=" + Hostname + ";UID=" + Username + ";PWD=" + Password + ";Use Procedure Bodies=false;");
                    }
                }
            }
        }

        public void UPDATE_CONNECTION_STRING(string Hostname, string Username, string Password)
        {
            LigacaoDB = new CLS_DB_CONNECTION(Hostname, Username, Password);
        }

        public void CREATE_DB_USER(string Username, int Rank)
        {
            try
            {
                MySqlCommand CMD_CREATE_USER = new MySqlCommand("site_tvtuga_app_admin_users._SP_INSERT_AdminUsers", LigacaoDB.CONNECTION);
                CMD_CREATE_USER.CommandType = CommandType.StoredProcedure;

                CMD_CREATE_USER.Parameters.AddWithValue("_username", Username);
                CMD_CREATE_USER.Parameters.AddWithValue("_rank", Rank);

                LigacaoDB.OPEN_CONNECTION();

                CMD_CREATE_USER.Prepare();

                IAsyncResult Working_CreateUser = CMD_CREATE_USER.BeginExecuteNonQuery(null, null);

                //while (!Working_CreateUser.IsCompleted)
                //{
                    // Accções Adicionais
                //}

                CMD_CREATE_USER.EndExecuteNonQuery(Working_CreateUser);
            }

            catch (Exception EX)
            {
                MessageBox.Show("Ocorreu um erro. Descrição do erro: \n\n " + EX.Message + "", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                LigacaoDB.CLOSE_CONNECTION();
            }
        }

        public void GET_USER_DB_ID(string Username)
        {
            try
            {

                MySqlCommand CMD_GET_USER_ID = new MySqlCommand();
                CMD_GET_USER_ID.Connection = LigacaoDB.CONNECTION;
                CMD_GET_USER_ID.CommandText = "SELECT id FROM site_tvtuga_app_admin_users.admin_users WHERE username = '" + Username + "'";

                LigacaoDB.OPEN_CONNECTION();

                CMD_GET_USER_ID.Prepare();

                IAsyncResult Working_GetUserID = CMD_GET_USER_ID.BeginExecuteReader();

                //while (!Working_GetUserID.IsCompleted)
                //{
                // Accções Adicionais
                //}

                Reader = CMD_GET_USER_ID.EndExecuteReader(Working_GetUserID);

                while (Reader.Read())
                {
                    for (int VALUE = 0; VALUE < Reader.FieldCount; VALUE++)
                    {
                        UserID = Convert.ToInt32(Reader.GetValue(VALUE));
                    }
                }

                Reader.Close();
            }

            catch (Exception EX)
            {
                MessageBox.Show("Ocorreu um erro de ligação. Verifique a sua configuração.\nDescrição do erro: \n\n " + EX.Message + "", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                if(LigacaoDB.CONNECTION.State == ConnectionState.Open)
                    LigacaoDB.CLOSE_CONNECTION();
            }
        }

        public void CREATE_DB_USER_CONFIG(int UserID, string DB_Host, int DB_Protocol, int DP_Port)
        {
            try
            {
                MySqlCommand CMD_CREATE_USER_CONFIG = new MySqlCommand("site_tvtuga_app_admin_users._SP_INSERT_AdminConfig", LigacaoDB.CONNECTION);
                CMD_CREATE_USER_CONFIG.CommandType = CommandType.StoredProcedure;

                CMD_CREATE_USER_CONFIG.Parameters.AddWithValue("_admin_id", UserID);
                CMD_CREATE_USER_CONFIG.Parameters.AddWithValue("_db_host", DB_Host);
                CMD_CREATE_USER_CONFIG.Parameters.AddWithValue("_db_protocol", DB_Protocol);
                CMD_CREATE_USER_CONFIG.Parameters.AddWithValue("_db_port", DP_Port);
                CMD_CREATE_USER_CONFIG.Parameters.AddWithValue("_ftp_host", null);
                CMD_CREATE_USER_CONFIG.Parameters.AddWithValue("_ftp_protocol", null);
                CMD_CREATE_USER_CONFIG.Parameters.AddWithValue("_ftp_port", null);
                CMD_CREATE_USER_CONFIG.Parameters.AddWithValue("_ftp_directory", null);

                LigacaoDB.OPEN_CONNECTION();

                CMD_CREATE_USER_CONFIG.Prepare();


                IAsyncResult Working_CreateUserConfig = CMD_CREATE_USER_CONFIG.BeginExecuteNonQuery(null, null);

                //while (!Working_CreateUser.IsCompleted)
                //{
                // Accções Adicionais
                //}

                CMD_CREATE_USER_CONFIG.EndExecuteNonQuery(Working_CreateUserConfig);
            }

            catch (Exception EX)
            {
                MessageBox.Show("Ocorreu um erro. Descrição do erro: \n\n " + EX.Message + "", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                LigacaoDB.CLOSE_CONNECTION();
            }
        }

        public void CREATE_DB_USER_DB_CONFIG(int UserID, string Username, string Password)
        {
            try
            {   
                MySqlCommand CMD_CREATE_USER_DB_CONFIG = new MySqlCommand("site_tvtuga_app_admin_users._SP_INSERT_SQLUsers", LigacaoDB.CONNECTION);
                CMD_CREATE_USER_DB_CONFIG.CommandType = CommandType.StoredProcedure;

                CMD_CREATE_USER_DB_CONFIG.Parameters.AddWithValue("_admin_id", UserID);
                CMD_CREATE_USER_DB_CONFIG.Parameters.AddWithValue("_username", Username);
                CMD_CREATE_USER_DB_CONFIG.Parameters.AddWithValue("_password", Password);

                LigacaoDB.OPEN_CONNECTION();

                CMD_CREATE_USER_DB_CONFIG.Prepare();


                IAsyncResult Working_CreateUserDBConfig = CMD_CREATE_USER_DB_CONFIG.BeginExecuteNonQuery(null, null);

                //while (!Working_CreateUserDBConfig.IsCompleted)
                //{
                // Accções Adicionais
                //}

                CMD_CREATE_USER_DB_CONFIG.EndExecuteNonQuery(Working_CreateUserDBConfig);
            }

            catch (Exception EX)
            {
                MessageBox.Show("Ocorreu um erro. Descrição do erro: \n\n " + EX.Message + "", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                LigacaoDB.CLOSE_CONNECTION();
            }
        }

        public void DELETE_DB_USER(int UserID)
        {
            try
            {
                // REMOVER ADMIN
                MySqlCommand CMD_DELETE_ADMIN = new MySqlCommand("site_tvtuga_app_admin_users._SP_DELETE_AdminUsers", LigacaoDB.CONNECTION);
                CMD_DELETE_ADMIN.CommandType = CommandType.StoredProcedure;
                CMD_DELETE_ADMIN.Parameters.AddWithValue("_id", UserID);                

                // REMOVER ADMIN CONFIG
                MySqlCommand CMD_DELETE_ADMIN_CONFIG = new MySqlCommand("site_tvtuga_app_admin_users._SP_DELETE_AdminConfig", LigacaoDB.CONNECTION);
                CMD_DELETE_ADMIN_CONFIG.CommandType = CommandType.StoredProcedure;
                CMD_DELETE_ADMIN_CONFIG.Parameters.AddWithValue("_id", UserID);
                

                // REMOVER ADMIN SQL
                MySqlCommand CMD_DELETE_ADMIN_SQL = new MySqlCommand("site_tvtuga_app_admin_users._SP_DELETE_SQLUsers", LigacaoDB.CONNECTION);
                CMD_DELETE_ADMIN_SQL.CommandType = CommandType.StoredProcedure;
                CMD_DELETE_ADMIN_SQL.Parameters.AddWithValue("_id", UserID);                

                LigacaoDB.OPEN_CONNECTION();

                CMD_DELETE_ADMIN.Prepare();
                CMD_DELETE_ADMIN_CONFIG.Prepare();
                CMD_DELETE_ADMIN_SQL.Prepare();

                IAsyncResult Working_DeleteAdminSQL = CMD_DELETE_ADMIN_SQL.BeginExecuteNonQuery(null, null);
                CMD_DELETE_ADMIN_SQL.EndExecuteNonQuery(Working_DeleteAdminSQL);

                IAsyncResult Working_DeleteAdminConfig = CMD_DELETE_ADMIN_CONFIG.BeginExecuteNonQuery(null, null);
                CMD_DELETE_ADMIN_CONFIG.EndExecuteNonQuery(Working_DeleteAdminConfig);

                IAsyncResult Working_DeleteAdmin = CMD_DELETE_ADMIN.BeginExecuteNonQuery(null, null);
                CMD_DELETE_ADMIN.EndExecuteNonQuery(Working_DeleteAdmin);

                using (RegistryKey Chave = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\Roaming\OptionsConfig\AppUsers", true))
                {
                    foreach (string User in Chave.GetValueNames())
                    {
                        if (User.Substring(2) == LISTVIEW_CONTAS.SelectedItems[0].Text)
                        {
                            Chave.DeleteValue(User);

                            Chave.SetValue(User, "");
                        }
                    }
                }
            }

            catch (Exception EX)
            {
                MessageBox.Show("Ocorreu um erro. Descrição do erro: \n\n " + EX.Message + "", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                LigacaoDB.CLOSE_CONNECTION();
            }
        }

        public void UPDATE_DB_USER(int UserID, string DB_Host, int DB_Protocol, int DP_Port, string Username, string Password)
        {
            try
            {
                using (RegistryKey Chave = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\Roaming\OptionsConfig\AppUsers", true))
                {
                    foreach (string User in Chave.GetValueNames())
                    {
                        if (User.Substring(2) == LISTVIEW_CONTAS.SelectedItems[0].Text)
                        {
                            Chave.DeleteValue(User);

                            Chave.SetValue(User, "SERVER=" + DB_Host + ";UID=" + Username + ";PWD=" + Password + ";Use Procedure Bodies=false;");
                        }
                    }
                }

                UPDATE_CONNECTION_STRING(DB_Host, Username, Password);

                // ALTERAR ADMIN
                MySqlCommand CMD_UPDATE_ADMIN = new MySqlCommand("site_tvtuga_app_admin_users._SP_UPDATE_AdminUsers", LigacaoDB.CONNECTION);
                CMD_UPDATE_ADMIN.CommandType = CommandType.StoredProcedure;
                CMD_UPDATE_ADMIN.Parameters.AddWithValue("_id", UserID);
                CMD_UPDATE_ADMIN.Parameters.AddWithValue("_username", LocalUsername);
                CMD_UPDATE_ADMIN.Parameters.AddWithValue("_rank", LocalRank);

                // ALTERAR ADMIN CONFIG
                MySqlCommand CMD_UPDATE_ADMIN_CONFIG = new MySqlCommand("site_tvtuga_app_admin_users._SP_UPDATE_AdminConfig", LigacaoDB.CONNECTION);
                CMD_UPDATE_ADMIN_CONFIG.CommandType = CommandType.StoredProcedure;
                CMD_UPDATE_ADMIN_CONFIG.Parameters.AddWithValue("_admin_id", UserID);
                CMD_UPDATE_ADMIN_CONFIG.Parameters.AddWithValue("_db_host", DB_Host);
                CMD_UPDATE_ADMIN_CONFIG.Parameters.AddWithValue("_db_protocol", DB_Protocol);
                CMD_UPDATE_ADMIN_CONFIG.Parameters.AddWithValue("_db_port", DP_Port);
                CMD_UPDATE_ADMIN_CONFIG.Parameters.AddWithValue("_ftp_host", null);
                CMD_UPDATE_ADMIN_CONFIG.Parameters.AddWithValue("_ftp_protocol", null);
                CMD_UPDATE_ADMIN_CONFIG.Parameters.AddWithValue("_ftp_port", null);
                CMD_UPDATE_ADMIN_CONFIG.Parameters.AddWithValue("_ftp_directory", null);

                // ALTERAR ADMIN SQL
                MySqlCommand CMD_UPDATE_ADMIN_SQL = new MySqlCommand("site_tvtuga_app_admin_users._SP_UPDATE_SQLUsers   ", LigacaoDB.CONNECTION);
                CMD_UPDATE_ADMIN_SQL.CommandType = CommandType.StoredProcedure;
                CMD_UPDATE_ADMIN_SQL.Parameters.AddWithValue("_admin_id", UserID);
                CMD_UPDATE_ADMIN_SQL.Parameters.AddWithValue("_nome", Username);
                CMD_UPDATE_ADMIN_SQL.Parameters.AddWithValue("_password", Password);

                LigacaoDB.OPEN_CONNECTION();

                CMD_UPDATE_ADMIN.Prepare();
                CMD_UPDATE_ADMIN_CONFIG.Prepare();
                CMD_UPDATE_ADMIN_SQL.Prepare();

                IAsyncResult Working_UpdateAdmin = CMD_UPDATE_ADMIN.BeginExecuteNonQuery(null, null);
                CMD_UPDATE_ADMIN.EndExecuteNonQuery(Working_UpdateAdmin);

                IAsyncResult Working_UpdateAdminConfig = CMD_UPDATE_ADMIN_CONFIG.BeginExecuteNonQuery(null, null);
                CMD_UPDATE_ADMIN_CONFIG.EndExecuteNonQuery(Working_UpdateAdminConfig);

                IAsyncResult Working_UpdateAdminSQL = CMD_UPDATE_ADMIN_SQL.BeginExecuteNonQuery(null, null);
                CMD_UPDATE_ADMIN_SQL.EndExecuteNonQuery(Working_UpdateAdminSQL);
            }

            catch (Exception EX)
            {
                MessageBox.Show("Ocorreu um erro. Descrição do erro: \n\n " + EX.Message + "", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                LigacaoDB.CLOSE_CONNECTION();
            }
        }        
    }
}
