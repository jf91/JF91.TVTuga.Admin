using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Windows.TVTuga.Admin.CLASSES;
using System.Data;

namespace Windows.TVTuga.Admin.FORMS.WIZARD.PANELS.CLASSES
{
    class CLS_CRIAR_UTILIZADOR
    {
        private CLS_DB_FUNCTIONS FuncoesDB = new CLS_DB_FUNCTIONS();

        // Default Constructor
        public CLS_CRIAR_UTILIZADOR()
        { }

        public void UPDATE_USER(MySqlConnection LigacaoDB, string ID, string Username, string Password)
        {
            //MySqlCommand CMD_UPDATE_USER = new MySqlCommand("SP_UPDATE_UTILIZADOR", LigacaoDB);
            //CMD_UPDATE_USER.CommandType = CommandType.StoredProcedure;

            //CMD_UPDATE_USER.Parameters.AddWithValue("_username", ID);
            //CMD_UPDATE_USER.Parameters.AddWithValue("_newname", Username);
            //CMD_UPDATE_USER.Parameters.AddWithValue("_password", Password);

            MySqlCommand CMD_UPDATE_USER = new MySqlCommand();
            CMD_UPDATE_USER.Connection = LigacaoDB;
            CMD_UPDATE_USER.CommandText = "RENAME USER '" + ID + "'@'%' TO '" + Username + "'@'%';";
            
            MySqlCommand CMD_UPDATE_PASS = new MySqlCommand();
            CMD_UPDATE_PASS.Connection = LigacaoDB;
            CMD_UPDATE_PASS.CommandText = "SET PASSWORD FOR '" + Username + "'@'%' = PASSWORD('" + Password + "');";
            
            LigacaoDB.Open();

            CMD_UPDATE_USER.Prepare();

            try
            {
                IAsyncResult Working_UpdateUser = CMD_UPDATE_USER.BeginExecuteNonQuery(null, null);

                while (!Working_UpdateUser.IsCompleted)
                {
                    // Accções Adicionais
                }

                CMD_UPDATE_USER.EndExecuteNonQuery(Working_UpdateUser);

                FuncoesDB.FLUSH_PRIVILEGES(LigacaoDB);

                IAsyncResult Working_UpdatePass = CMD_UPDATE_PASS.BeginExecuteNonQuery(null, null);

                while (!Working_UpdatePass.IsCompleted)
                {
                    // Accções Adicionais
                }

                CMD_UPDATE_PASS.EndExecuteNonQuery(Working_UpdatePass);

                FuncoesDB.FLUSH_PRIVILEGES(LigacaoDB);
            }

            catch
            {
                throw;
            }
            finally
            {
                LigacaoDB.Close();
            }
        }

        public void SET_PERMISSIONS(MySqlConnection LigacaoDB, string Username)
        {
            MySqlCommand CMD_SET_PERMISSIONS = new MySqlCommand();
            CMD_SET_PERMISSIONS.Connection = LigacaoDB;
            CMD_SET_PERMISSIONS.CommandText = "";
        }
    }
}
