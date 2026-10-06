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
namespace BankMangmentSystem.Transfer
{
    public partial class frmTransfer : Form
    {
        clsTransactionGroup _Transfer1;
        clsTransactionGroup _Transfer2;
        clsUser _User1;
        clsUser _User2;
        public frmTransfer()
        {
            InitializeComponent();
        }

        private void frmTransfer_Load(object sender, EventArgs e)
        {
            ctrlUserWithFilter1.DataBack += CtrlUserWithFilter1_DataBack;
            ctrlUserWithFilter2.DataBack += CtrlUserWithFilter2_DataBack;
        }

        private void CtrlUserWithFilter1_DataBack(object sender, clsUser user)
        {
            _User1 = user;
            
        }

        private void CtrlUserWithFilter2_DataBack(object sender, clsUser user)
        {
            _User2 = user;
        }

        private void FilledTransferDetails()
        {
            if (_User1 == null || _User2 == null)
            {
                MessageBox.Show("Please select both users before transferring.", "Error", MessageBoxButtons.OK);
                return;
            }
            if (_User1.UserID == _User2.UserID)
            {
                MessageBox.Show("Don't Play With Your Tail :-) , Cannot transfer to the same user.", "Error", MessageBoxButtons.OK);
                return;
            }
            if (_User1.UserID==10)
            {
                string Description = $"Transfer from {_User1.UserName} to {_User2.UserName}";
                int CreatedByUserID = _User1.UserID;
                int BranchID = 3;
                int? ExchangeRateID = null;
            }
            

        }

        private void AddNewTransfer()
        {
          
            
            

        }
        private void btnTransfer_Click(object sender, EventArgs e)
        {
            if (_User1 == null || _User2 == null)
            {
                MessageBox.Show("Please select both users before transferring.","Error",MessageBoxButtons.OK);
                return;
            }
            if (_User1.UserID == _User2.UserID)
            {
                MessageBox.Show("Don't Play With Your Tail :-) , Cannot transfer to the same user.", "Error", MessageBoxButtons.OK);
                return;
            }

        }
    }
}
