//Jayden Wigley
//Login Application
//12-7-21
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IDKMaybe
{
    public partial class LoginSignUp : Form
    {
        LoginModel user = new LoginModel();
        public LoginSignUp()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            user.UserName = SignUpUsername.Text;
            user.Password = SignUpPassword.Text;
            if(user.UserName == "" || user.Password == "" || user.Password.Contains(" ") || user.UserName.Contains(" ")) { MessageBox.Show("Can't Have A Null Username or Password"); }
            else if(user.UserName.Length < 7 && user.Password.Length < 7)
            { MessageBox.Show("Username and Password must be at least 7 character long"); }
            else {SignUpAccess.SaveUser(user);}
            SignUpUsername.Text = "";
            SignUpPassword.Text = "";
        }
       

        private void btnLogin_Click(object sender, EventArgs e)
        {
            List<LoginModel> Logins = SignUpAccess.LoadUser();
            foreach (var account in Logins)
            {
                if (account.UserName == LoginUsername.Text)
                {
                    if (account.Password == LoginPassword.Text)
                    {
                        MessageBox.Show("Login Successful");
                        ScraperForm frm1 = new ScraperForm();
                        this.Hide();
                        frm1.Show();
                        break;
                    }
                    else if (Logins.IndexOf(account) == Logins.Count - 1)
                    {
                        MessageBox.Show("Login Failed");
                    }
                }
                else if (Logins.IndexOf(account) == Logins.Count - 1)
                {
                    MessageBox.Show("Login Failed");
                }
            }
            LoginUsername.Text = "";
            LoginPassword.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            List<LoginModel> Logins = SignUpAccess.LoadUser();
            foreach (var account in Logins)
            {
                if (account.UserName == SignUpUsername.Text)
                {
                    if (account.Password == SignUpPassword.Text)
                    {
                        SignUpAccess.DeleteUser(account);
                        break;
                    }
                }
            }
            SignUpUsername.Text = "";
            SignUpPassword.Text = "";
        }
    }
}
