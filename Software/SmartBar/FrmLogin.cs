using BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartBar
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            if(username.Length == 0 || password.Length == 0)
            {
                MessageBox.Show("Ispunite sva polja podacima!");
            }
            else
            {
                LoginService service = new LoginService();
                if(service.CheckCredentials(username, password))
                {
                    var frm2FA = new Frm2FA();
                    Hide();
                    frm2FA.ShowDialog();
                    Close();
                }
                else
                {
                    MessageBox.Show("Uneseni podaci nisu ispravni!");
                }
            }
        }
    }
}
