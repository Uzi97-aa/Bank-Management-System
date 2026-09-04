using BankMangmentSystem.Global_Classes;
using BuisnessLogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net;
namespace BankMangmentSystem
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
         //   clsUser user = clsUser.FindByUserNameAndPassword(txtUserName.FastText.Trim(),clsUser.ComputeHash(txtPassword.FastText.Trim()));
            clsUser User=clsUser.FindByUserName(txtUserName.FastText.Trim());
            
            // This automatically generates a salt and includes it in the hash string
            string hashedPassword =clsUser.ComputeHash(txtPassword.FastText.Trim().ToString());
            if (User != null&&hashedPassword.Equals(User.PasswordHash))
            {

                if (chkRememberMe.Checked)
                {
                    //store username and password
                    clsGlobal.RememberUsernameAndPassword(txtUserName.FastText.Trim(), txtPassword.FastText.Trim());


                }
                else
                {
                    //store empty username and password
                    clsGlobal.RememberUsernameAndPassword("", "");



                }

                //incase the user is not active
                if (!User.IsActive)
                {

                    txtUserName.Focus();
                    MessageBox.Show("Your accound is not Active, Contact Admin.", "In Active Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                clsGlobal.CurrentUser = User;
                this.Hide();
                frmBankList frm = new frmBankList(this);
                frm.ShowDialog();


            }
            else
            {
                txtUserName.Focus();
                MessageBox.Show("Invalid Username/Password.", "Wrong Credintials", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            string UserName = "", Password = "";



            if (clsGlobal.GetStoredCredential(ref UserName, ref Password))
            {
                if (string.IsNullOrEmpty(UserName)  && string.IsNullOrEmpty(Password))
                {
                    chkRememberMe.Checked = false;
                    return;
                }


                txtUserName.FastText = UserName;

                txtPassword.FastText = Password;
                chkRememberMe.Checked = true;
            }

            else
            {
                chkRememberMe.Checked = false;

            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
