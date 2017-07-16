using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.TVTuga.Admin.FORMS.DASHBOARD.PANELS.UTILIZADORES.UTILIZADORES;

namespace Windows.TVTuga.Admin.FORMS.DASHBOARD.PANELS.UTILIZADORES.UTILIZADORES
{
    public partial class PNL_GERIR_UTILIZADORES : Form
    {
        public PNL_GERIR_UTILIZADORES()
        {
            InitializeComponent();
        }

        private void PNL_GERIR_UTILIZADORES_Load(object sender, EventArgs e)
        {
            OPEN_UTILIZADORES_LISTAGEM();
        }

        public void OPEN_UTILIZADORES_LISTAGEM()
        {
            if (SPLITCONTAINER_GERIR_UTILIZADORES.Panel2.Controls.Count == 0)
            {
                SPLITCONTAINER_GERIR_UTILIZADORES.Panel2.Controls.Clear();

                PNL_GERIR_UTILIZADORES_LISTAGEM PNL_GerirUtilizadoresListagem = new PNL_GERIR_UTILIZADORES_LISTAGEM();
                PNL_GerirUtilizadoresListagem.TopLevel = false;
                PNL_GerirUtilizadoresListagem.AutoScroll = true;

                SPLITCONTAINER_GERIR_UTILIZADORES.Panel2.Controls.Add(PNL_GerirUtilizadoresListagem);

                PNL_GerirUtilizadoresListagem.Visible = true;
                return;
            }

            if (SPLITCONTAINER_GERIR_UTILIZADORES.Panel2.Controls.Count == 1 || SPLITCONTAINER_GERIR_UTILIZADORES.Panel2.Controls.Count > 1)
            {
                SPLITCONTAINER_GERIR_UTILIZADORES.Panel2.Controls.Clear();

                PNL_GERIR_UTILIZADORES_LISTAGEM PNL_GerirUtilizadoresListagem = new PNL_GERIR_UTILIZADORES_LISTAGEM();
                PNL_GerirUtilizadoresListagem.TopLevel = false;
                PNL_GerirUtilizadoresListagem.AutoScroll = true;

                SPLITCONTAINER_GERIR_UTILIZADORES.Panel2.Controls.Add(PNL_GerirUtilizadoresListagem);

                PNL_GerirUtilizadoresListagem.Visible = true;
                return;
            }
        }
    }
}
