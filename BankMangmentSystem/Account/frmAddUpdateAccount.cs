using BankMangmentSystem.Account.Controls;
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

namespace BankMangmentSystem.Account
{
    public partial class frmAddUpdateAccount : Form
    {

        int? _Customer;
        public frmAddUpdateAccount()
        {
            InitializeComponent();
            
        }

        private void frmAddUpdateAccount_Load(object sender, EventArgs e)
        {
            
            ctrlAccount1.DataBack += ctrlAccounet_databack;

        }

        private void EnsureCustomer()
        {
            ctrlAccount1.DataBack += ctrlAccounet_databack;

            if (_Customer == null || _Customer <= 0)
            {
                MessageBox.Show("Please select a customer first.");
                return;
            }
            btnNext.Visible = true;
        }
        private void ctrlAccounet_databack(object sender, int Customer) 
        {

            _Customer = Customer;
            if (_Customer == null||_Customer <= 0)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            btnNext.Visible = true;
        }

        private void ctrlAccount1_Load(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_Customer == null || _Customer <= 0)
            {
                MessageBox.Show("Please select a customer first.");
                return;
            }

            clsAccount Account = clsAccount.FindByCustomerID(_Customer.Value);
            if (Account != null)
            {
                this.Hide();
                frmAccount frm1=new frmAccount(_Customer.Value,Account.AccountID);
                frm1.ShowDialog();
            }

            else
            {
                this.Hide();
                frmAccount frm2 = new frmAccount(_Customer.Value, -1);
                frm2.ShowDialog();

            }
            

        }

        
    }
}
