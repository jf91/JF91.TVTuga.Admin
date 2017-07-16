using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Windows.TVTuga.Admin.FORMS.OPCOES.PANELS.UTILIZADOR.CLASSES;

namespace Windows.TVTuga.Admin.FORMS.OPCOES.PANELS.FTP
{
    public partial class PNL_OPCOES_FTP_CONTAS : Form
    {
        CLS_OBTER_CONTAS ObterContas = new CLS_OBTER_CONTAS();

        public PNL_OPCOES_FTP_CONTAS()
        {
            InitializeComponent();
        }
    }
}
