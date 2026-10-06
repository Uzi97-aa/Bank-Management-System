using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SharedClass.clsShared;
using BuisnessLogicLayer;

namespace BankMangmentSystem.Transfer.Controls
{
    public partial class ctrlTransform : UserControl
    {
        
        clsCustomer _Customer;

        clsAccount _Account;

        public delegate void ctrlTransformEventHandler(object sender, int CustomerID);

        public event ctrlTransformEventHandler DataBack;

        int? _CustomerID;

        string _FullName;

        string _NationalID;

        int? _AccountID;
        public ctrlTransform()
        {
            InitializeComponent();
        }


        private void SelectComboBox()
        {
            if(cbSelect.SelectedItem=="CustomerID")
            {
              
                txtInput.InputType= FastUI.FastUILibrary.Core.FastInputType.IntegerOnly;
                _CustomerID =int.Parse(txtInput.FastText);
             

            }

            if (cbSelect.SelectedItem == "FullName")
            {
                txtInput.InputType = FastUI.FastUILibrary.Core.FastInputType.LettersOnly;
                _FullName = txtInput.FastText;
            }


            if (cbSelect.SelectedItem == "NationalID")
            {
                txtInput.InputType = FastUI.FastUILibrary.Core.FastInputType.IntegerOnly;
                _NationalID = txtInput.FastText.Trim();
            }


            if (cbSelect.SelectedItem == "AccountID")
            {
                txtInput.InputType = FastUI.FastUILibrary.Core.FastInputType.IntegerOnly;
                _AccountID = int.Parse(txtInput.FastText.Trim());
            }
        }

        
        private void FindCustomer()
        {
            SelectComboBox();
            if (_CustomerID<0||_AccountID<0)
            {
                MessageBox.Show("Input Correct Number","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            if (_CustomerID == null && string.IsNullOrEmpty(_NationalID) && _AccountID == null && string.IsNullOrEmpty(_FullName))
            {
                MessageBox.Show("Fill Up All The Fileds", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (_CustomerID != null)
            {
                _Account = clsAccount.FindByCustomerID(_CustomerID.Value);
                if (_Account == null)
                {
                    MessageBox.Show("Input Correct Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                _Customer = clsCustomer.Find(_CustomerID.Value);
                if (_Customer == null)
                {
                    MessageBox.Show("Input Correct Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                txtCustomerID.FastText ="Customer ID :"+ _CustomerID.Value.ToString();
                txtFullName.FastText = "Full Name :"+ _Customer.FullName;
                txtDateOfBith.FastText="Date Of Birth :"+_Customer.DateOfBirth.ToString();
                txtNationalID.FastText="National ID :"+_Customer.NationalID.ToString();
                txtAccountID.FastText="Account ID :"+ _Account.AccountID.ToString();

                _CustomerID = _CustomerID.Value;
                return;
            }

            if (_NationalID != null)
            {

                _Customer = clsCustomer.FindByNationalID(_NationalID);
                if (_Customer == null)
                {
                    MessageBox.Show("Input Correct Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                _Account = clsAccount.FindByCustomerID(_Customer.CustomerID);
                if (_Account==null)
                {
                    MessageBox.Show("Input Correct Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                txtCustomerID.FastText = "Customer ID :" + _Customer.CustomerID.ToString();
                txtFullName.FastText = "Full Name :" + _Customer.FullName;
                txtDateOfBith.FastText = "Date Of Birth :" + _Customer.DateOfBirth.ToString();
                txtNationalID.FastText = "National ID :" + _NationalID.ToString();
                txtAccountID.FastText = "Account ID :" + _Account.AccountID.ToString();
                _CustomerID = _Customer.CustomerID;
                return;
            }


            if (_AccountID != null)
            {
                _Customer = clsCustomer.FindByAccountID(_AccountID.Value);
                if (_Customer == null)
                {
                    MessageBox.Show("Input Correct Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                txtCustomerID.FastText = "Customer ID :" + _Customer.CustomerID.ToString();
                txtFullName.FastText = "Full Name :" + _Customer.FullName;
                txtDateOfBith.FastText = "Date Of Birth :" + _Customer.DateOfBirth.ToString();
                txtNationalID.FastText = "National ID :" + _Customer.NationalID.ToString();
                txtAccountID.FastText = "Account ID :" + _AccountID.ToString();
                _CustomerID = _Customer.CustomerID;
                return;
            }

            if (!string.IsNullOrEmpty(_FullName))
            {
                _Customer = clsCustomer.FindByFullName(_FullName);
                if (_Customer == null)
                {
                    MessageBox.Show("Input Correct Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                _Account = clsAccount.FindByCustomerID(_Customer.CustomerID);
                if (_Account == null)
                {
                    MessageBox.Show("Input Correct Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                txtCustomerID.FastText = "Customer ID :" + _Customer.CustomerID.ToString();
                txtFullName.FastText = "Full Name :" + _Customer.FullName;
                txtDateOfBith.FastText = "Date Of Birth :" + _Customer.DateOfBirth.ToString();
                txtNationalID.FastText = "National ID :" + _Customer.NationalID.ToString();
                txtAccountID.FastText = "Account ID :" + _Account.AccountID.ToString();
                _CustomerID = _Customer.CustomerID;
                return;
            }


        }
        private void ctrlTransform_Load(object sender, EventArgs e)
        {

          txtInput.FastText="";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            FindCustomer();
            DataBack?.Invoke(this, _CustomerID.Value);
        }

        private void cbSelect_Click(object sender, EventArgs e)
        {
        }

        private void txtInput_Click(object sender, EventArgs e)
        {
            if (cbSelect.SelectedItem=="")
            {
                MessageBox.Show("Select Search Type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cbSelect.SelectedItem == "CustomerID")
            {

                txtInput.InputType = FastUI.FastUILibrary.Core.FastInputType.IntegerOnly;
                return;

            }

            if (cbSelect.SelectedItem == "FullName")
            {
                txtInput.InputType = FastUI.FastUILibrary.Core.FastInputType.Any;
                return;
            }


            if (cbSelect.SelectedItem == "NationalID")
            {
                txtInput.InputType = FastUI.FastUILibrary.Core.FastInputType.IntegerOnly;
                return;
            }


            if (cbSelect.SelectedItem == "AccountID")
            {
                txtInput.InputType = FastUI.FastUILibrary.Core.FastInputType.IntegerOnly;
                return;
            }
        }
    }
}
