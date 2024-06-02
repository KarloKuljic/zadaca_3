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
    public partial class FrmHomepage : Form
    {
        public FrmHomepage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            Hide();
            frmLogin.ShowDialog();
            Close();
        }

        private void btnAddmaterial_Click(object sender, EventArgs e)
        {
            FrmUnosMaterijala frmUnosMaterijala = new FrmUnosMaterijala();
            Hide();
            frmUnosMaterijala.ShowDialog();
            Close();
        }

        private void FrmHomepage_Load(object sender, EventArgs e)
        {

        }
    }
}
