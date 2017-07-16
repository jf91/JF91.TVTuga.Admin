using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.TVTuga.Admin.FORMS.DASHBOARD.PANELS.PEDIDOS;

namespace Windows.TVTuga.Admin.FORMS.DASHBOARD.PANELS.PEDIDOS
{
    public partial class PNL_GERIR_PEDIDOS : Form
    {
        public PNL_GERIR_PEDIDOS()
        {
            InitializeComponent();
        }

        private void PNL_GERIR_PEDIDOS_Load(object sender, EventArgs e)
        {
            BUTTON_PEDIDOS.PerformClick();
        }

        private void BUTTON_PEDIDOS_Click(object sender, EventArgs e)
        {
            if (SPLITCONTAINER_PEDIDOS.Panel2.Controls.Count == 0)
            {
                SPLITCONTAINER_PEDIDOS.Panel2.Controls.Clear();

                PNL_GERIR_PEDIDOS_LISTAGEM PNL_Pedidos = new PNL_GERIR_PEDIDOS_LISTAGEM();
                PNL_Pedidos.TopLevel = false;
                PNL_Pedidos.AutoScroll = true;

                SPLITCONTAINER_PEDIDOS.Panel2.Controls.Add(PNL_Pedidos);

                PNL_Pedidos.Visible = true;
                return;
            }

            if (SPLITCONTAINER_PEDIDOS.Panel2.Controls.Count == 1 || SPLITCONTAINER_PEDIDOS.Panel2.Controls.Count > 1)
            {
                SPLITCONTAINER_PEDIDOS.Panel2.Controls.Clear();

                PNL_GERIR_PEDIDOS_LISTAGEM PNL_Pedidos = new PNL_GERIR_PEDIDOS_LISTAGEM();
                PNL_Pedidos.TopLevel = false;
                PNL_Pedidos.AutoScroll = true;

                SPLITCONTAINER_PEDIDOS.Panel2.Controls.Add(PNL_Pedidos);

                PNL_Pedidos.Visible = true;
                return;
            }
        }
    }
}
