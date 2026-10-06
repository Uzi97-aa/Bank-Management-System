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
    public partial class ctrlUserWithFilter : UserControl
    {
    public  delegate void DataBackEventHandler(object sender, clsUser user);
        public event DataBackEventHandler DataBack;

        clsUser _User;

        public ctrlUserWithFilter()
        {
            InitializeComponent();
        }

        private void ctrlUserWithFilter_Load(object sender, EventArgs e)
        {

        }

        private int CheckExistenceNumber()
        {
            int number =0;
            if (cbSelect.SelectedItem == null)
            {
                MessageBox.Show("Please select a filter option first.");
                return -1;
            }
            if (cbSelect.SelectedItem == "User ID")
            {
                if (!int.TryParse(txtFilter.FastText.Trim(), out number))
                {
                    MessageBox.Show("Please enter a valid User ID.");
                    return -1;
                }
            }

            if (cbSelect.SelectedItem == "Employee ID")
            {

                if (!int.TryParse(txtFilter.FastText.Trim(), out number))
                {
                    MessageBox.Show("Please enter a valid Employee ID.");
                    return -1;
                }
            }

            if (cbSelect.SelectedItem == "Customer ID")
            {

                if (!int.TryParse(txtFilter.FastText.Trim(), out number))
                {
                    MessageBox.Show("Please enter a valid Customer ID.");
                    return -1;
                }
            }

            return number;
        }


        private void CheckExistenceObject()
        {

            int Number = CheckExistenceNumber();

            if (cbSelect.SelectedItem == "User ID")
            {
                _User = clsUser.Find(Number);

                if (_User == null)
                {
                    MessageBox.Show("User not found.");
                    return;
                }

            }

            if (cbSelect.SelectedItem == "Employee ID")
            {

                _User = clsUser.FindByEmployeeID(Number);

                if (_User == null)
                {
                    MessageBox.Show("User not found.");
                    return;
                }
            }

            if (cbSelect.SelectedItem == "Customer ID")
            {

                _User = clsUser.FindByCustomerID(Number);

                if (_User == null)
                {
                    MessageBox.Show("User not found.");
                    return;
                }
            }

            if (cbSelect.SelectedItem == "User Name")
            {
                string userName = txtFilter.FastText.Trim();
                if (string.IsNullOrEmpty(userName))
                {
                    MessageBox.Show("Please enter a valid User Name.");
                    return;
                }

                _User = clsUser.FindByUserName(userName);

                if (_User == null)
                {
                    MessageBox.Show("User not found.");
                    return;
                }

            }



        }
        private void LoadUserData()
        {
            if (cbSelect.SelectedItem == null)
            {
                MessageBox.Show("Please select a filter option first.");
                return;
            }
            CheckExistenceObject();
            if (_User != null)
            {
                lblUserID.Text = _User.UserID.ToString();
                lblUserName.Text = _User.UserName;
                lblEmployeeID.Text = _User.EmployeeID?.ToString() ?? "N/A";
                lblCustomerID.Text = _User.CustomerID?.ToString() ?? "N/A";
                lblRole.Text = _User.Role.ToString();
                lblIsActive.Text = _User.IsActive ? "Active" : "Inactive";
            }


        }
    

        private void txtFilter_Click(object sender, EventArgs e)
        {
            if (cbSelect.SelectedItem == null)
            {
                MessageBox.Show("Please select a filter option first."); return;
            }

            if (cbSelect.SelectedItem == "User ID")
            {
                txtFilter.InputType = FastUI.FastUILibrary.Core.FastInputType.IntegerOnly; return;
            }

            if (cbSelect.SelectedItem == "User Name")
            {
                txtFilter.InputType = FastUI.FastUILibrary.Core.FastInputType.LettersOnly; return;
            }

            if (cbSelect.SelectedItem == "Employee ID")
            {
                txtFilter.InputType = FastUI.FastUILibrary.Core.FastInputType.IntegerOnly; return;
            }

            if (cbSelect.SelectedItem == "Customer ID")
            {
                txtFilter.InputType = FastUI.FastUILibrary.Core.FastInputType.IntegerOnly; return;
            }
        }

        private void lblUserName_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            string filter = txtFilter.FastText.Trim();
            if (string.IsNullOrEmpty(filter))
            {
                MessageBox.Show("Please enter a filter value.");
                return;
            }
            LoadUserData();
            DataBack?.Invoke(this, _User);
        }

        private void cbSelect_Click(object sender, EventArgs e)
        {

        }

        private void lblCustomerID_Click(object sender, EventArgs e)
        {

        }
    }
}
