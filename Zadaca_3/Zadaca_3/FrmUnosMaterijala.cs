using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadaca_3
{
    public partial class FrmUnosMaterijala : Form
    {
        public FrmUnosMaterijala()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmHomepage frmHomepage = new FrmHomepage();
            Hide();
            frmHomepage.ShowDialog();
            Close();
        }
    }
}
