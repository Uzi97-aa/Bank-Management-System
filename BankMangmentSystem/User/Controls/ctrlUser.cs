using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BuisnessLogicLayer;
namespace BankMangmentSystem.User.Controls
{
    public partial class ctrlUser : UserControl
    {
        int _UserID;
        public delegate void UserControlEventHandler(object sender, int UserId);
        public event UserControlEventHandler UserDataBack;
        public ctrlUser(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
        }

        private void LoadData()
        {
            
            clsUser user = clsUser.Find(_UserID);
            if (user != null)
            {
                lblUserID.Text = user.UserID.ToString();
                lblUserName.Text = user.UserName;
                lblCustomerID.Text = user.CustomerID.ToString()??"N/A";
                lblEmployeeID.Text = user.EmployeeID.ToString()??"N/A";
                lblRole.Text = user.Role.ToString();
                lblIsActive.Text = user.IsActive.ToString();
                UserDataBack?.Invoke(this, user.UserID);
            }
        }

        private void ctrlUser_Load(object sender, EventArgs e)
        {


            LoadData();


        }
    }
}
