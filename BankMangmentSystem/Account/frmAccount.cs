using BankMangmentSystem.Currency;
using BuisnessLogicLayer;
using FastUI.FastUILibrary.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SharedClass.clsShared;
namespace BankMangmentSystem
{
    public partial class frmAccount : Form
    {
        int _CustomerID;
        int _AccountID;
        int _BranchID;
        AccountsDTO _AccountDTO;
        public clsAccount _Account;

      public  enum enType 
        { AddNewAccount = 1,
            UpdateAccount = 2
        }


        enType _enType;

       
      
        public frmAccount(int CustomerID,int AccountID)
        {
            InitializeComponent();
            _CustomerID = CustomerID;
            _AccountID = AccountID;
            if (_AccountID==-1)
            {
                _enType = enType.AddNewAccount;
            }
            else
            {
                _enType = enType.UpdateAccount;
            }
        }
        private void AddNewAccount()
        {
           
            if (clsAccount.FindByCustomerID(_CustomerID)!=null)
            {
                MessageBox.Show("This Customer Has An Account. Please choose Another Customer","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            _AccountDTO = new AccountsDTO
            (
                 1,
                _CustomerID,
                int.Parse(txtBranchID.FastText),
                txtAccountNumber.FastText,
                (byte)(cbAccountStatus.SelectedIndex+1),
                int.Parse(txtCurrencyID.FastText),
                1,
                false,
                DateTime.Now,
                new byte[0]
            );

            _Account=new clsAccount(_AccountDTO);


            if (_Account.AccountID <= 0)
            {
                MessageBox.Show("Invalid Account ID for Adding.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_Account.Save())
            {
                MessageBox.Show("Account created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblAccount.Text = "Account ID : " + _Account.AccountID.ToString();
                return;
            }
            else
            {
                MessageBox.Show("Failed to create account.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }



        private void UpdateAccount()
        {

            _Account= clsAccount.FindByID(_AccountID);
            if (_Account == null) 
            {
                MessageBox.Show("There is no Account for this Customer","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            lblAccount.Text = _AccountID.ToString();
            txtAccountNumber.FastText = _Account.AccountNumber;
            txtCurrencyID.FastText = _Account.CurrencyID.ToString();
            txtCustomerID.FastText = _CustomerID.ToString();
            txtBranchID.FastText = _Account.BranchID.ToString();

            if (cbAccountStatus.Items != null)
            {
                for (int i = 0; i < cbAccountStatus.Items.Length; i++)
                {
                    if (cbAccountStatus.Items[i] == _Account.AccountType.ToString())
                    {
                        // Instead of setting SelectedIndex, set the selected item if possible
                        // This assumes FuiComboBox has a method or property to select by value.
                        // If not, you may need to set the underlying value that controls selection.
                        // For now, set the selected item via a workaround:
                        typeof(FuiComboBox)
                            .GetProperty(cbAccountStatus.Items[i])
                            ?.SetValue(cbAccountStatus, cbAccountStatus.Items[i]);
                        break;
                    }
                }
            }
            
            lblAccount.Enabled = false;
            txtAccountNumber.Enabled = false;
            txtCurrencyID.Enabled = false;
            txtCustomerID.Enabled = false;
            txtBranchID.Enabled = false;
            cbAccountStatus.Enabled = false;

        }

        private void SaveTheUpdate() {

            byte statusValue = byte.Parse((cbStatus.SelectedIndex+1).ToString());



            _AccountDTO = new AccountsDTO
            (
                 _AccountID,
                _CustomerID,
                _Account.BranchID,
                _Account.AccountNumber,
                (byte)_Account.AccountType,
                _Account.CurrencyID,
                statusValue,
                _Account.IsDeleted,
                _Account.CreatedAt,
                _Account.Row_Version
            );

            _Account=new clsAccount(_AccountDTO,clsAccount.enMode.Update);

            if (_Account.Save())
            {
                MessageBox.Show("Account updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                MessageBox.Show("Failed to update account.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }


        private void frmAccount_Load(object sender, EventArgs e)
        {
            //if (clsAccount.FindByCustomerID(_CustomerID) != null)
            //{
            //    MessageBox.Show("This Customer Has An Account. Please choose Another Customer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            //txtAccountNumber.FastText ="";
            //txtCustomerID.FastText =_CustomerID.ToString();
            //txtCustomerID.Enabled = false;
            //txtBranchID.FastText ="";
            //txtCurrencyID.FastText ="";

            txtCustomerID.FastText = _CustomerID.ToString();
            txtCustomerID.Enabled = false;



            if (_enType == enType.UpdateAccount)
            {
                cbStatus.Visible = true;
                UpdateAccount();
                lblAccount.Text = "Account ID : " + _Account.AccountID.ToString();
                lblAccount.Enabled = false;

            }

            }

        private void fuiButton2_Click(object sender, EventArgs e)
        {
            frmCurrencyList frm=new frmCurrencyList();
            frm.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAccountNumber.FastText)&& string.IsNullOrEmpty(txtCustomerID.FastText) &&
                string.IsNullOrEmpty(txtBranchID.FastText) && string.IsNullOrEmpty(txtCurrencyID.FastText))
            {
                MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_enType==enType.AddNewAccount)
            {
                AddNewAccount();
                lblAccount.Text ="Account ID : "+ _Account.AccountID.ToString();
                return;
            }

            if (_enType==enType.UpdateAccount)
            {
                if (_AccountID <= 0)
                {
                    MessageBox.Show("Invalid Account ID for update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                SaveTheUpdate();
                lblAccount.Text = "Account ID : " + _Account.AccountID.ToString();
                return;
            }

        }
    }
}
