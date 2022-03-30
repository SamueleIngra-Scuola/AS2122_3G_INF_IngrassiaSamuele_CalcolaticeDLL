using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AS2122_3G_INF_IngraSamuele_CalcolatriceDLL.Library;


namespace AS2122_3G_INF_IngrassiaSamuele_CalcolaticeDLL
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnCalcola_Click(object sender, EventArgs e)
        {
            Operazioni o = new Operazioni();
        }
    }
}
