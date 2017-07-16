using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Windows.TVTuga.Admin.CLASSES
{
    class CLS_DB_FUNCTIONS
    {
        public CLS_DB_FUNCTIONS()
        { }

        public void FLUSH_PRIVILEGES(MySqlConnection LigacaoDB)
        {
            MySqlCommand CMD_FLUSH = new MySqlCommand();

            string QRY_FLUSH_PRIVILEGES = "FLUSH PRIVILEGES;";

            CMD_FLUSH.Connection = LigacaoDB;
            CMD_FLUSH.CommandText = QRY_FLUSH_PRIVILEGES;

            try
            {
                IAsyncResult Working = CMD_FLUSH.BeginExecuteNonQuery(null, null);

                while (!Working.IsCompleted)
                {
                    // Accções Adicionais
                }

                CMD_FLUSH.EndExecuteNonQuery(Working);
            }

            catch
            {
                throw;
            }
        }
    }
}
