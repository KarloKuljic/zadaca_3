using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zadaca_3.Model;

namespace Zadaca_3
{
    public partial class FrmLogin : Form
    {
        string username = "Marko Marulić";
        string password = "lozinka123";
        public static Owner LoggedOwner { get; set; }
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
                if (txtUsername.Text == "")
                {
                    MessageBox.Show("Korisničko ime nije uneseno!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtPassword.Text == "")
                {
                    MessageBox.Show("Lozinka nije unesena!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    LoggedOwner = new Owner();
                    if (txtUsername.Text == LoggedOwner.Username && LoggedOwner.CheckPassword(txtPassword.Text))
                    {
                        FrmHomepage frmHomepage = new FrmHomepage();
                        Hide();
                        frmHomepage.ShowDialog();
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Krivi podaci!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }
    }

