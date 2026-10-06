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

namespace BankMangmentSystem.Account.Controls
{
    public partial class ctrlAccount : UserControl
    {
        clsCustomer _Customer;

        

        public delegate void ctrlAccountEventHandler(object sender, int CustomerID);

        public event ctrlAccountEventHandler DataBack;

        int? _CustomerID;

        string _FullName;

        string _NationalID;

      
        public ctrlAccount()
        {
            InitializeComponent();
        }


        private void SelectComboBox()
        {
            //switch (cbSelect.SelectedItem)
            //{
            //    case  "CustomerID":

            //        txtInput.InputType = FastUI.FastUILibrary.Core.FastInputType.IntegerOnly;
            //        _CustomerID = int.Parse(txtInput.FastText);
            //        break;

            //    case "FullName":
            //        txtInput.InputType = FastUI.FastUILibrary.Core.FastInputType.LettersOnly;
            //        _FullName = txtInput.FastText;
            //        break;

            //    case "NationalID":
            //        txtInput.InputType = FastUI.FastUILibrary.Core.FastInputType.IntegerOnly;
            //        _NationalID = txtInput.FastText.Trim();
            //        break;

            //}

          

                if (cbSelect.SelectedItem == "CustomerID")
                {

                    txtInput.InputType = FastUI.FastUILibrary.Core.FastInputType.IntegerOnly;
                    _CustomerID = int.TryParse(txtInput.FastText, out int result) ? result : (int?)null;


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

            
          


            }


        private void FindCustomer()
        {
            SelectComboBox();
            if (_CustomerID < 0 )
            {
                MessageBox.Show("Input Correct Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_CustomerID == null && string.IsNullOrEmpty(_NationalID) &&  string.IsNullOrEmpty(_FullName))
            {
                MessageBox.Show("Fill Up All The Fileds", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (_CustomerID != null)
            {
               
                _Customer = clsCustomer.Find(_CustomerID.Value);
                if (_Customer == null)
                {
                    MessageBox.Show("Input Correct Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                txtCustomerID.FastText = "Customer ID :" + _CustomerID.Value.ToString();
                txtFullName.FastText = "Full Name :" + _Customer.FullName;
                txtDateOfBith.FastText = "Date Of Birth :" + _Customer.DateOfBirth.ToString();
                txtNationalID.FastText = "National ID :" + _Customer.NationalID.ToString();

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
                
                txtCustomerID.FastText = "Customer ID :" + _Customer.CustomerID.ToString();
                txtFullName.FastText = "Full Name :" + _Customer.FullName;
                txtDateOfBith.FastText = "Date Of Birth :" + _Customer.DateOfBirth.ToString();
                txtNationalID.FastText = "National ID :" + _NationalID.ToString();
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

               
                txtCustomerID.FastText = "Customer ID :" + _Customer.CustomerID.ToString();
                txtFullName.FastText = "Full Name :" + _Customer.FullName;
                txtDateOfBith.FastText = "Date Of Birth :" + _Customer.DateOfBirth.ToString();
                txtNationalID.FastText = "National ID :" + _Customer.NationalID.ToString();
                _CustomerID = _Customer.CustomerID;
                return;
            }


        }

        public void ctrlAccount_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            FindCustomer();
            if (_CustomerID.HasValue)
            {
                DataBack?.Invoke(this, _CustomerID.Value);
            }
        }

        private void cbSelect_Click(object sender, EventArgs e) {

            

        }

        private void txtInput_Click(object sender, EventArgs e)
        {
            if (cbSelect.SelectedItem == "")
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
        }
    }
}
