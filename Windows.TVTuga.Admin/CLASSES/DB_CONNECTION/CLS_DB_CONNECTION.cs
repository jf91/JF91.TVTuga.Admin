using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Windows.TVTuga.Admin.CLASSES
{
    class CLS_DB_CONNECTION
    {
        // Member Variables
        public MySqlConnection CONNECTION = new MySqlConnection();
        public string ConnectionString;

        // Default Constructor
        public CLS_DB_CONNECTION()
        {
            CONNECTION.ConnectionString = ConnectionString;
        }

        // Overloaded Constructor
        public CLS_DB_CONNECTION(string Hostname, string Username, string Password)
        {
            try
            {
                ConnectionString = "SERVER=" + Hostname + ";" + "UID=" + Username + ";" + "PWD=" + Password + ";Use Procedure Bodies=false;";

                CONNECTION.ConnectionString = ConnectionString;

                Properties.Settings.Default.ConnectionString = ConnectionString;
                Properties.Settings.Default.Save();
            }            

            catch (Exception EX)
            {
                MessageBox.Show("Ocorreu um erro. Descrição do erro: \n\n " + EX.Message + "", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Abrir Ligação
        public void OPEN_CONNECTION()
        {
            try
            {
                CONNECTION.Open();
            }

            catch (Exception EX)
            {
                MessageBox.Show("Ocorreu um erro na abertura da ligação à base de dados. Configure as suas credenciais correctamente.\n\n--> Descrição do erro: \n\n " + EX.Message + "", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Fechar Ligação
        public void CLOSE_CONNECTION()
        {
            try
            {
                CONNECTION.Close();
            }

            catch (Exception EX)
            {
                MessageBox.Show("Ocorreu um erro ao fechar a ligação à base de dados.\n\n--> Descrição do erro: \n\n " + EX.Message + "", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
