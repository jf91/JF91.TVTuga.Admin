using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Collections;
using System.Data;
using System.Windows.Forms;

namespace Windows.TVTuga.Admin.CLASSES.DASHBOARD.CONTAS_WEB.WEBSITES
{
    class CLS_GERIR_WEBSITES : CLS_DB_CONNECTION
    {
        // Objectos para a base de dados
        MySqlConnection LigacaoDB = new MySqlConnection(Properties.Settings.Default.ConnectionString);
        MySqlDataReader Reader;

        // Arrays para listar os dados
        public ArrayList Tipos = new ArrayList();
        public ArrayList Websites = new ArrayList();
        public ArrayList Websites_Data = new ArrayList();   

        // Variáveis Auxiliares
        private int TYPE_ID;
        private int WEBSITE_ID;

        // Default Constructor
        public CLS_GERIR_WEBSITES()
        {
        }

        /****   FUNÇÕES PARA GERIR OS TIPOS DE WEBSITES   *****/

        public ArrayList LIST_WEBSITE_TYPES()
        {
            MySqlCommand CMD_GET_WEBSITE_TYPES = new MySqlCommand("site_tvtuga_app_admin_users._SP_SELECT_WebsiteTipo", LigacaoDB);
            CMD_GET_WEBSITE_TYPES.CommandType = CommandType.StoredProcedure;

            LigacaoDB.Open();

            CMD_GET_WEBSITE_TYPES.Prepare();

            IAsyncResult Working_ListType = CMD_GET_WEBSITE_TYPES.BeginExecuteReader();

            Reader = CMD_GET_WEBSITE_TYPES.EndExecuteReader(Working_ListType);

            while (Reader.Read())
            {
                Tipos.Add(Reader["nome"].ToString());
            }

            Reader.Close();

            LigacaoDB.Close();

            return Tipos;
        }

        private void GET_TYPE_ID(string Tipo)
        {
            MySqlCommand CMD_GET_TYPE_ID = new MySqlCommand("site_tvtuga_app_admin_users._SP_SELECT_X_WebsiteTipo", LigacaoDB);
            CMD_GET_TYPE_ID.CommandType = CommandType.StoredProcedure;

            CMD_GET_TYPE_ID.Parameters.AddWithValue("_nome", Tipo);

            LigacaoDB.Open();

            CMD_GET_TYPE_ID.Prepare();

            IAsyncResult Working_GetTypeID = CMD_GET_TYPE_ID.BeginExecuteReader();

            Reader = CMD_GET_TYPE_ID.EndExecuteReader(Working_GetTypeID);

            while(Reader.Read())
            {
                //Tipo = Reader.GetString(0);

            Tipo = Reader["id"].ToString();
            }

            Reader.Close();

            TYPE_ID = Convert.ToInt32(Tipo);
        }

        public void CREATE_TYPE(string Tipo)
        {
            try
            {
                MySqlCommand CMD_CREATE_TYPE = new MySqlCommand("site_tvtuga_app_admin_users._SP_INSERT_WebsiteTipo", LigacaoDB);
                CMD_CREATE_TYPE.CommandType = CommandType.StoredProcedure;

                CMD_CREATE_TYPE.Parameters.AddWithValue("_nome", Tipo);

                LigacaoDB.Open();

                CMD_CREATE_TYPE.Prepare();

                IAsyncResult Working_CreateType = CMD_CREATE_TYPE.BeginExecuteNonQuery(null, null);

                CMD_CREATE_TYPE.EndExecuteNonQuery(Working_CreateType);
            }

            catch (Exception EX)
            {
                MessageBox.Show("Ocorreu um erro. Descrição do erro: \n\n " + EX.Message + "", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                LigacaoDB.Close();
            }
        }

        public void UPDATE_TYPE(string AUX_Tipo, string Tipo)
        {
            try
            {
                GET_TYPE_ID(AUX_Tipo);

                MySqlCommand CMD_UPDATE_TYPE = new MySqlCommand("site_tvtuga_app_admin_users._SP_UPDATE_WebsiteTipo", LigacaoDB);
                CMD_UPDATE_TYPE.CommandType = CommandType.StoredProcedure;

                CMD_UPDATE_TYPE.Parameters.AddWithValue("_id", TYPE_ID);
                CMD_UPDATE_TYPE.Parameters.AddWithValue("_nome", Tipo);

                if(LigacaoDB.State == ConnectionState.Closed)
                    LigacaoDB.Open();

                CMD_UPDATE_TYPE.Prepare();

                IAsyncResult Working_UpdateType = CMD_UPDATE_TYPE.BeginExecuteNonQuery(null, null);

                CMD_UPDATE_TYPE.EndExecuteNonQuery(Working_UpdateType);
            }

            catch (Exception EX)
            {
                MessageBox.Show("Ocorreu um erro. Descrição do erro: \n\n " + EX.Message + "", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                LigacaoDB.Close();
            }
        }

        public void DELETE_TYPE(string Tipo)
        {
            try
            {
                GET_TYPE_ID(Tipo);

                MySqlCommand CMD_DELETE_TYPE = new MySqlCommand("site_tvtuga_app_admin_users._SP_DELETE_WebsiteTipo", LigacaoDB);
                CMD_DELETE_TYPE.CommandType = CommandType.StoredProcedure;

                CMD_DELETE_TYPE.Parameters.AddWithValue("_id", TYPE_ID);

                if (LigacaoDB.State == ConnectionState.Closed)
                    LigacaoDB.Open();

                CMD_DELETE_TYPE.Prepare();

                IAsyncResult WorkingDeleteType = CMD_DELETE_TYPE.BeginExecuteNonQuery(null, null);

                CMD_DELETE_TYPE.EndExecuteNonQuery(WorkingDeleteType);
            }

            catch (Exception EX)
            {
                MessageBox.Show("Ocorreu um erro. Descrição do erro: \n\n " + EX.Message + "", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                LigacaoDB.Close();
            }
        }

        /*******************************************************/


        /****        FUNÇÕES PARA GERIR OS WEBSITES        *****/

        public ArrayList LIST_WEBSITES()
        {
            MySqlCommand CMD_GET_WEBSITES = new MySqlCommand("site_tvtuga_app_admin_users._SP_SELECT_Websites", LigacaoDB);
            CMD_GET_WEBSITES.CommandType = CommandType.StoredProcedure;

            LigacaoDB.Open();

            CMD_GET_WEBSITES.Prepare();

            IAsyncResult Working_ListWebsites = CMD_GET_WEBSITES.BeginExecuteReader();

            Reader = CMD_GET_WEBSITES.EndExecuteReader(Working_ListWebsites);

            while (Reader.Read())
            {
                Websites.Add(Reader["nome"].ToString());
            }

            Reader.Close();

            LigacaoDB.Close();

            return Websites;
        }

        private void GET_WEBSITE_ID(string Nome)
        {
            MySqlCommand CMD_GET_WEBSITE_ID = new MySqlCommand("site_tvtuga_app_admin_users._SP_SELECT_X_Websites", LigacaoDB);
            CMD_GET_WEBSITE_ID.CommandType = CommandType.StoredProcedure;

            CMD_GET_WEBSITE_ID.Parameters.AddWithValue("_nome", Nome);

            LigacaoDB.Open();

            CMD_GET_WEBSITE_ID.Prepare();

            IAsyncResult Working_GetWebsiteID = CMD_GET_WEBSITE_ID.BeginExecuteReader();

            Reader = CMD_GET_WEBSITE_ID.EndExecuteReader(Working_GetWebsiteID);

            while (Reader.Read())
            {
                Nome = Reader["id"].ToString();
            }

            Reader.Close();

            WEBSITE_ID = Convert.ToInt32(Nome);
        }

        public void FILL_WEBSITE_DATA(string Nome)
        {
            try
            {
                GET_WEBSITE_ID(Nome);

                MySqlCommand CMD_GET_WEBSITE_DATA = new MySqlCommand("site_tvtuga_app_admin_users._SP_SELECT_X_Websites_Data", LigacaoDB);
                CMD_GET_WEBSITE_DATA.CommandType = CommandType.StoredProcedure;

                CMD_GET_WEBSITE_DATA.Parameters.AddWithValue("_nome", Nome);

                if (LigacaoDB.State == ConnectionState.Closed)
                    LigacaoDB.Open();

                CMD_GET_WEBSITE_DATA.Prepare();

                IAsyncResult Working_WebsiteData = CMD_GET_WEBSITE_DATA.BeginExecuteReader();

                Reader = CMD_GET_WEBSITE_DATA.EndExecuteReader(Working_WebsiteData);

                while (Reader.Read())
                {
                    Websites_Data.Add(Reader["WebsiteNome"].ToString());
                    Websites_Data.Add(Reader["WebsiteEndereco"].ToString());
                    Websites_Data.Add(Reader["TipoNome"].ToString());
                }                
            }

            catch (Exception EX)
            {
                MessageBox.Show("Ocorreu um erro. Descrição do erro: \n\n " + EX.Message + "", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                Reader.Close();
                LigacaoDB.Close();
            }
        }        

        public void CREATE_WEBSITE(string Nome, string Endereco, string Tipo)
        {
            try
            {
                GET_TYPE_ID(Tipo);

                MySqlCommand CMD_CREATE_WEBSITE = new MySqlCommand("site_tvtuga_app_admin_users._SP_INSERT_Websites", LigacaoDB);
                CMD_CREATE_WEBSITE.CommandType = CommandType.StoredProcedure;

                CMD_CREATE_WEBSITE.Parameters.AddWithValue("_nome", Nome);
                CMD_CREATE_WEBSITE.Parameters.AddWithValue("_endereco", Endereco);
                CMD_CREATE_WEBSITE.Parameters.AddWithValue("_tipo", TYPE_ID);

                if (LigacaoDB.State == ConnectionState.Closed)
                    LigacaoDB.Open();

                CMD_CREATE_WEBSITE.Prepare();

                IAsyncResult Working_CreateWebsite = CMD_CREATE_WEBSITE.BeginExecuteNonQuery(null, null);

                CMD_CREATE_WEBSITE.EndExecuteNonQuery(Working_CreateWebsite);
            }

            catch (Exception EX)
            {
                MessageBox.Show("Ocorreu um erro. Descrição do erro: \n\n " + EX.Message + "", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                LigacaoDB.Close();
            }
        }

        public void UPDATE_WEBSITE(string AUX_Nome, string Nome, string Endereco, string Tipo)
        {

        }

        public void DELETE_WEBSITE(string Nome)
        {

        }

        /*******************************************************/
    }
}
