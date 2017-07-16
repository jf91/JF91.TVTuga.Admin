using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.TVTuga.Admin.FORMS.DASHBOARD.PANELS.SERIES.CATEGORIAS;

namespace Windows.TVTuga.Admin.FORMS.DASHBOARD.PANELS.SERIES.CATEGORIAS
{
    public partial class PNL_GERIR_CATEGORIAS : Form
    {
        public PNL_GERIR_CATEGORIAS()
        {
            InitializeComponent();
        }

        private void PNL_GERIR_CATEGORIAS_Load(object sender, EventArgs e)
        {
            BUTTON_CATEGORIAS_LISTAGEM.PerformClick();
        }

        private void BUTTON_CATEGORIAS_LISTAGEM_Click(object sender, EventArgs e)
        {
            OPEN_CATEGORIAS_LISTAGEM();
        }

        public void OPEN_CATEGORIAS_LISTAGEM()
        {
            if (SPLITCONTAINER_CATEGORIAS.Panel2.Controls.Count == 0)
            {
                SPLITCONTAINER_CATEGORIAS.Panel2.Controls.Clear();

                PNL_GERIR_CATEGORIAS_LISTAGEM PNL_CategoriasListagem = new PNL_GERIR_CATEGORIAS_LISTAGEM();
                PNL_CategoriasListagem.TopLevel = false;
                PNL_CategoriasListagem.AutoScroll = true;

                SPLITCONTAINER_CATEGORIAS.Panel2.Controls.Add(PNL_CategoriasListagem);

                PNL_CategoriasListagem.Visible = true;
                return;
            }

            if (SPLITCONTAINER_CATEGORIAS.Panel2.Controls.Count == 1 || SPLITCONTAINER_CATEGORIAS.Panel2.Controls.Count > 1)
            {
                SPLITCONTAINER_CATEGORIAS.Panel2.Controls.Clear();

                PNL_GERIR_CATEGORIAS_LISTAGEM PNL_CategoriasListagem = new PNL_GERIR_CATEGORIAS_LISTAGEM();
                PNL_CategoriasListagem.TopLevel = false;
                PNL_CategoriasListagem.AutoScroll = true;

                SPLITCONTAINER_CATEGORIAS.Panel2.Controls.Add(PNL_CategoriasListagem);

                PNL_CategoriasListagem.Visible = true;
                return;
            }
        }
    }
}
