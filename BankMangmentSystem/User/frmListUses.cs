using BuisnessLogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BankMangmentSystem.User
{
    public partial class frmListUses : Form
    {

        DataTable _dtUsers = clsUser.GetAllUser();
        

        public frmListUses()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            frmAddUpdateUser frm = new frmAddUpdateUser();
            frm.ShowDialog();
        }

        private void SizeOfHeader()
        {
            dgvUserList.DataSource = _dtUsers;
            dgvUserList.Columns["UserID"].HeaderText = "User ID";
            dgvUserList.Columns["UserID"].Width = 150;
            dgvUserList.Columns["EmployeeID"].HeaderText = "Employee ID";
            dgvUserList.Columns["EmployeeID"].Width = 150;
            dgvUserList.Columns["CustomerID"].HeaderText = "Customer ID";
            dgvUserList.Columns["CustomerID"].Width = 150;
            dgvUserList.Columns["UserName"].HeaderText = "User Name";
            dgvUserList.Columns["UserName"].Width = 150;
            dgvUserList.Columns["Role"].HeaderText = "Role";
            dgvUserList.Columns["Role"].Width = 150;
            dgvUserList.Columns["FullName"].HeaderText = "Full Name";
            dgvUserList.Columns["FullName"].Width = 150;
           
        }
        private void LoadUsers()
        {
            SizeOfHeader();



        }
        private void frmListUses_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void fuiComboBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            //Map Selected Filter to real Column name 
            switch (cbSelect.SelectedItem)
            {
                case "UserID":
                    FilterColumn = "UserID";
                    break;
                case "UserName":
                    FilterColumn = "UserName";
                    break;

                case "CustomerID":
                    FilterColumn = "CustomerID";
                    break;


                case "FullName":
                    FilterColumn = "FullName";
                    break;

                case "EmployeeID":
                        FilterColumn = "EmployeeID";
                    break;
                case "Role":
                    FilterColumn = "Role";
                    break;

                default:
                    FilterColumn = "none";
                    break;

            }

            //Reset the filters in case nothing selected or filter value conains nothing.
            if (txtFilterValue.FastText.Trim() == "" || FilterColumn == "Select")
            {
                _dtUsers.DefaultView.RowFilter = "";
                lblRecord.Text = dgvUserList.Rows.Count.ToString();
                return;
            }


            if (FilterColumn != "FullName" && FilterColumn != "UserName")
                //in this case we deal with numbers not string.
                _dtUsers.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterValue.Text.Trim());
            else
                _dtUsers.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterValue.Text.Trim());

            lblRecord.Text = dgvUserList.Rows.Count.ToString();
        }

        private void txtFilterValue_Click(object sender, EventArgs e)
        {

        }

        private void txtValue_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            //Map Selected Filter to real Column name 
            switch (cbSelect.SelectedItem)
            {
                case "UserID":
                    FilterColumn = "UserID";
                    break;
                case "UserName":
                    FilterColumn = "UserName";
                    break;

                case "CustomerID":
                    FilterColumn = "CustomerID";
                    break;


                case "FullName":
                    FilterColumn = "FullName";
                    break;

                case "EmployeeID":
                    FilterColumn = "EmployeeID";
                    break;
                case "Role":
                    FilterColumn = "Role";
                    break;

                default:
                    FilterColumn = "Select";
                    break;

            }

            //Reset the filters in case nothing selected or filter value conains nothing.
            if (txtFilterValue.FastText.Trim() == "" || FilterColumn == "Select")
            {
                _dtUsers.DefaultView.RowFilter = "";
                lblRecord.Text = dgvUserList.Rows.Count.ToString();
                return;
            }


            if (FilterColumn != "FullName" && FilterColumn != "UserName")
                //in this case we deal with numbers not string.
                _dtUsers.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterValue.Text.Trim());
            else
                _dtUsers.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterValue.Text.Trim());

            lblRecord.Text = dgvUserList.Rows.Count.ToString();
        }
    }
}
