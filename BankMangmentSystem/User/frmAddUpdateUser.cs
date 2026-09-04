using BankMangmentSystem.Properties;
using BuisnessLogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BuisnessLogicLayer.clsCustomer;
using static SharedClass.clsShared;
namespace BankMangmentSystem.User
{
    public partial class frmAddUpdateUser : Form
    {

        public delegate void UserDataBack(object sender, int UserID);
        public event UserDataBack DataBack;

        public clsUser User;
        public UserDTO UDTO;
        private int _UserID;
        public enum enMode { Add=1, Update=2}

        private enMode _Mode;
        public frmAddUpdateUser()
        {
            InitializeComponent();
            _UserID = -1;
            _Mode= enMode.Add;
        }

        public frmAddUpdateUser(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
            _Mode = enMode.Update;
        }

        private void ResetForm()
        {
            lblUser.Text = "ADD New";
            txtCustomerID.FastText = "";
            txtEmployeeID.FastText = "";
            txtUserName.FastText = "";
            txtPassword.FastText = "";
        }

        private void AddUser()
        {
            if (cbRole.SelectedIndex<0)
            {
                MessageBox.Show("Please select a valid Role.");
                return;
            }
            // validate Customer ID
            int CustomerId;
            if (!int.TryParse(txtCustomerID.FastText.Trim(), out CustomerId))
            {
                MessageBox.Show("Please enter a valid numeric User ID.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            UDTO =new UserDTO(_UserID,
                CustomerId, null,
                txtUserName.FastText,txtPassword.RealText.Trim().ToString(), (byte)(cbRole.SelectedIndex + 1),false,true,DateTime.Now,new byte[0]);

            //UDTO.CustomerID =int.Parse(txtCustomerID.Text.ToString());
            //UDTO.UserName = txtUserName.Text;
            //UDTO.PasswordHash =txtPassword.Text;
            //UDTO.Role=(byte) (cbRole.SelectedIndex+1);

            User = new clsUser(UDTO);

            if (User == null)
            {
                MessageBox.Show("User object is null. Cannot add User.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }

            if (User.Save())
            {
                if (User.UserID == -1)
                {
                    MessageBox.Show("Failed to save User. User ID is invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show("User is Added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataBack?.Invoke(this, UDTO.UserID);
                lblUser.Visible = true;
                lblUser.Text = $"User ID: {User.UserID}";
            }
            else
            {
                MessageBox.Show("User object is null. Cannot add User.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private void ADDEmployeeOrAdmin()
        {
            if (cbRole.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a valid Role.");
                return;
            }
            UDTO = new UserDTO(_UserID,
                  null, int.Parse(txtEmployeeID.FastText.ToString()),
                  txtUserName.FastText, txtPassword.RealText.Trim().ToString(), (byte)(cbRole.SelectedIndex + 1), false,true, DateTime.Now, new byte[0]);

            User = new clsUser(UDTO);

            if (User == null)
            {
                MessageBox.Show("User object is null. Cannot add User.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }

            if (User.Save())
            {
                if (User.UserID == -1)
                {
                    MessageBox.Show("Failed to save User. User ID is invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show("User is Added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataBack?.Invoke(this, User.UserID);
                lblUser.Visible = true;
                lblUser.Text = $"User ID: {User.UserID}";
            }
            else
            {
                MessageBox.Show("User object is null. Cannot add User.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }



        }
        private void LoadUserData()
        {

            User = clsUser.Find(_UserID);
            if (User == null)
            {
                MessageBox.Show("User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }

            if (User.Role==clsUser.enRole.Customer)
            {
                txtCustomerID.FastText = User.CustomerID.ToString();
                txtPassword.FastText = User.PasswordHash;
                txtUserName.FastText = User.UserName;
                txtEmployeeID.Enabled = false;
                txtCustomerID.Visible = false;

                cbRole.TabIndex=(int)User.Role;
            }
            if (User.Role == clsUser.enRole.Employee|| User.Role == clsUser.enRole.Admin)
            {
                txtEmployeeID.FastText = User.EmployeeID.ToString();
                txtPassword.FastText = User.PasswordHash;
                txtUserName.FastText = User.UserName;
                txtCustomerID.Visible = false;
                txtEmployeeID.Enabled = false;

                cbRole.TabIndex = (int)User.Role;
            }

            
           
            



        }

        private void UpdateUser()
        {
            User = clsUser.Find(_UserID);
            if (User == null)
            {
                MessageBox.Show("User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }


            txtUserName.Text = User.UserName;
            txtPassword.Text = User.PasswordHash;

            txtEmployeeID.Enabled = false;
            txtCustomerID.Enabled = false;
            txtPassword.Enabled = false;
            txtUserName.Enabled = false;
            cbRole.Enabled = false;



            if (User == null)
            {
                MessageBox.Show("User object is null. Cannot add User.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }

            if (User.Save())
            {
                if (User.UserID == -1)
                {
                    MessageBox.Show("Failed to save User. User ID is invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show("User is Updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataBack?.Invoke(this, User.UserID);
                lblUser.Visible = true;
                lblUser.Text = $"User ID: {User.UserID}";
            }
            else
            {
                MessageBox.Show("User object is null. Cannot Update User.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }


        private void frmAddUser_Load(object sender, EventArgs e)
        {
            ResetForm();
            if (_Mode==enMode.Update)
            {
               
                LoadUserData();
            }
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
           

           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            chbAddUser.ImageIndex = 0;
            if (chbAddUser.Checked)
            {
                chbAddUser.Image = Resources.check_mark__2_;
            }

        }

        private void fuiButton1_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(txtPassword.Text)||string.IsNullOrEmpty(txtUserName.Text))
            //{
            //    MessageBox.Show("Some Filed are Required","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}


            if (_Mode == enMode.Add)
            {


                if (cbRole.SelectedItem == "Employee" || cbRole.SelectedItem == "Admin")
                {
                    ADDEmployeeOrAdmin();
                }

                if (cbRole.SelectedItem == "Customer")
                {
                    AddUser();
                }


            }

            else
            {
                UpdateUser();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
      
        }

        private void lblUser_Click(object sender, EventArgs e)
        {

        }
    }
}
