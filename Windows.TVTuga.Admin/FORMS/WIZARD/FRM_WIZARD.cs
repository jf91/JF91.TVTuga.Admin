using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using Windows.TVTuga.Admin.CLASSES;
using Windows.TVTuga.Admin.FORMS.WIZARD.PANELS;
using Windows.TVTuga.Admin.FORMS.WIZARD.PANELS.CLASSES;

namespace Windows.TVTuga.Admin.FORMS.WIZARD
{
    public partial class FRM_WIZARD : Form
    {
        CLS_GUARDAR_DADOS GuardarDados = new CLS_GUARDAR_DADOS();

        int Pagina = 0;

        public int ID;
        public string Nome;
        public string Username;
        public string Password;
        public string Servidor;

        public bool DefaultServer = true;

        public FRM_WIZARD()
        {
            InitializeComponent();
        }

        private void FRM_WIZARD_Load(object sender, EventArgs e)
        {
            OPEN_WIZARD_01();
        }

        private void BUTTON_SEGUINTE_Click(object sender, EventArgs e)
        {
            if(Pagina == 1)
            {
                SET_DATA();
                GET_DATA();

                OPEN_WIZARD_02();

                BUTTON_ANTERIOR.Enabled = true;

                return;
            }

            if(Pagina == 2)
            {
                SET_DATA();
                GET_DATA();

                OPEN_WIZARD_03();

                BUTTON_SEGUINTE.Text = "Concluir";

                return;
            }

            if (Pagina == 3)
            {
                SET_DATA();
                GET_DATA();

                OPEN_WIZARD_04();

                CREATE_CONFIG();

                return;
            }
        }

        private void BUTTON_ANTERIOR_Click(object sender, EventArgs e)
        {
            if (Pagina == 2)
            {
                SET_DATA();
                GET_DATA();

                OPEN_WIZARD_01();

                BUTTON_ANTERIOR.Enabled = false;

                return;
            }

            if (Pagina == 3)
            {
                SET_DATA();
                GET_DATA();

                OPEN_WIZARD_02();

                return;
            }

            if (Pagina == 4)
            {
                SET_DATA();
                GET_DATA();

                OPEN_WIZARD_03();

                return;
            }
        }
                
        public void OPEN_WIZARD_01()
        {
            if (SPLITCONTAINER_WIZARD.Panel2.Controls.Count == 0)
            {
                SPLITCONTAINER_WIZARD.Panel2.Controls.Clear();

                PNL_WIZARD_01 PNL_Wizard01 = new PNL_WIZARD_01();
                PNL_Wizard01.TopLevel = false;
                PNL_Wizard01.AutoScroll = true;

                SPLITCONTAINER_WIZARD.Panel2.Controls.Add(PNL_Wizard01);

                PNL_Wizard01.Visible = true;
                Pagina = 1;
                return;
            }

            if (SPLITCONTAINER_WIZARD.Panel2.Controls.Count == 1 || SPLITCONTAINER_WIZARD.Panel2.Controls.Count > 1)
            {
                SPLITCONTAINER_WIZARD.Panel2.Controls.Clear();

                PNL_WIZARD_01 PNL_Wizard01 = new PNL_WIZARD_01();
                PNL_Wizard01.TopLevel = false;
                PNL_Wizard01.AutoScroll = true;

                SPLITCONTAINER_WIZARD.Panel2.Controls.Add(PNL_Wizard01);

                PNL_Wizard01.Visible = true;
                Pagina = 1;
                return;
            }
        }

        public void OPEN_WIZARD_02()
        {
            if (SPLITCONTAINER_WIZARD.Panel2.Controls.Count == 0)
            {
                SPLITCONTAINER_WIZARD.Panel2.Controls.Clear();

                PNL_WIZARD_02 PNL_Wizard02 = new PNL_WIZARD_02();
                PNL_Wizard02.TopLevel = false;
                PNL_Wizard02.AutoScroll = true;

                SPLITCONTAINER_WIZARD.Panel2.Controls.Add(PNL_Wizard02);

                PNL_Wizard02.Visible = true;
                Pagina = 2;
                return;
            }

            if (SPLITCONTAINER_WIZARD.Panel2.Controls.Count == 1 || SPLITCONTAINER_WIZARD.Panel2.Controls.Count > 1)
            {
                SPLITCONTAINER_WIZARD.Panel2.Controls.Clear();

                PNL_WIZARD_02 PNL_Wizard02 = new PNL_WIZARD_02();
                PNL_Wizard02.TopLevel = false;
                PNL_Wizard02.AutoScroll = true;

                SPLITCONTAINER_WIZARD.Panel2.Controls.Add(PNL_Wizard02);

                PNL_Wizard02.Visible = true;
                Pagina = 2;
                return;
            }
        }

        public void OPEN_WIZARD_03()
        {
            if (SPLITCONTAINER_WIZARD.Panel2.Controls.Count == 0)
            {
                SPLITCONTAINER_WIZARD.Panel2.Controls.Clear();

                PNL_WIZARD_03 PNL_Wizard03 = new PNL_WIZARD_03();
                PNL_Wizard03.TopLevel = false;
                PNL_Wizard03.AutoScroll = true;

                SPLITCONTAINER_WIZARD.Panel2.Controls.Add(PNL_Wizard03);

                PNL_Wizard03.Visible = true;
                Pagina = 3;
                return;
            }

            if (SPLITCONTAINER_WIZARD.Panel2.Controls.Count == 1 || SPLITCONTAINER_WIZARD.Panel2.Controls.Count > 1)
            {
                SPLITCONTAINER_WIZARD.Panel2.Controls.Clear();

                PNL_WIZARD_03 PNL_Wizard03 = new PNL_WIZARD_03();
                PNL_Wizard03.TopLevel = false;
                PNL_Wizard03.AutoScroll = true;

                SPLITCONTAINER_WIZARD.Panel2.Controls.Add(PNL_Wizard03);

                PNL_Wizard03.Visible = true;
                Pagina = 3;
                return;
            }
        }

        public void OPEN_WIZARD_04()
        {
            if (SPLITCONTAINER_WIZARD.Panel2.Controls.Count == 0)
            {
                SPLITCONTAINER_WIZARD.Panel2.Controls.Clear();

                PNL_WIZARD_04 PNL_Wizard04 = new PNL_WIZARD_04();
                PNL_Wizard04.TopLevel = false;
                PNL_Wizard04.AutoScroll = true;

                SPLITCONTAINER_WIZARD.Panel2.Controls.Add(PNL_Wizard04);

                PNL_Wizard04.Visible = true;
                Pagina = 4;
                return;
            }

            if (SPLITCONTAINER_WIZARD.Panel2.Controls.Count == 1 || SPLITCONTAINER_WIZARD.Panel2.Controls.Count > 1)
            {
                SPLITCONTAINER_WIZARD.Panel2.Controls.Clear();

                PNL_WIZARD_04 PNL_Wizard04 = new PNL_WIZARD_04();
                PNL_Wizard04.TopLevel = false;
                PNL_Wizard04.AutoScroll = true;

                SPLITCONTAINER_WIZARD.Panel2.Controls.Add(PNL_Wizard04);

                PNL_Wizard04.Visible = true;
                Pagina = 4;
                return;
            }
        }

        public void SET_DATA()
        {
            if (Pagina == 1)
            {
                GuardarDados.SetID(ID);
                GuardarDados.GetID();
            }

            if (Pagina == 2)
            {
                GuardarDados.SetNome(Nome);
                GuardarDados.SetUsername(Username);
                GuardarDados.SetPassword(Password);
            }

            if (Pagina == 3)
            {
                if (DefaultServer == true)
                    GuardarDados.SetServidor(GuardarDados.AUX_Servidor_Default);
                else
                    GuardarDados.SetServidor(Servidor);
            }
        }

        public void GET_DATA()
        {
            if (Pagina == 1)
            {
                GuardarDados.GetID();
            }

            if (Pagina == 2)
            {
                GuardarDados.GetNome();
                GuardarDados.GetUsername();
                GuardarDados.GetPassword();
            }

            if (Pagina == 3)
            {
                GuardarDados.GetServidor();
            }
        }

        // Criar Configuração

        public void CREATE_CONFIG()
        {
            //ENCRYPT_PASSWORD();
            SAVE_LOCAL_USER();
            SAVE_DB_USER();
        }

        public void ENCRYPT_PASSWORD()
        {
            GuardarDados.ENCRYPT_PASSWORD();
        }

        public void SAVE_LOCAL_USER()
        {
            GuardarDados.WRITE_TO_REGISTRY();
        }

        public void SAVE_DB_USER()
        {
            GuardarDados.SAVE_DB_USER_CREDENTIALS();
            GuardarDados.SET_DB_PERMISSIONS();
        }
    }
}
