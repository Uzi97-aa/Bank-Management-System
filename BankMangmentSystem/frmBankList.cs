using BankMangmentSystem.Account;
using BankMangmentSystem.Customer;
using BankMangmentSystem.Transfer;
using BankMangmentSystem.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankMangmentSystem
{
    public partial class frmBankList : Form
    {

        frmLogin _Login;
        public frmBankList(frmLogin login)
        {
            InitializeComponent();
            _Login = login;
        }
        public frmBankList()
        {
            InitializeComponent();
        }
        private void frmBankList_Load(object sender, EventArgs e)
        {

        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
           frmListUses frm=new frmListUses();
            frm.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void custmoersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            frmAddUpdateCustomer frm=new frmAddUpdateCustomer();
            frm.ShowDialog();
        }

        private void transferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTransfer frm=new frmTransfer();
            frm.ShowDialog();
        }

        private void accountsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateAccount frm=new frmAddUpdateAccount();
            frm.ShowDialog();
        }
    }
}
