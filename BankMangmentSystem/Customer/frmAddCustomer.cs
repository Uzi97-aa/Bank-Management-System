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

namespace BankMangmentSystem.Customer
{
    public partial class frmAddCustomer : Form
    {
        enum _enMode { AddNew = 1, Update = 2 }
        _enMode mode = _enMode.AddNew;
        private int _CustomerID;
        public frmAddCustomer()
        {
            InitializeComponent();
            _CustomerID = -1;
            mode = _enMode.AddNew;
        }
        public frmAddCustomer(int CustomerID)
        {
            InitializeComponent();
            _CustomerID = CustomerID;
            mode = _enMode.Update;
        }


        public void LoadCustomerData()
        {
            
          
        }


        public void AddCustomer()
        {
           
        }
        private void frmAddCustomer_Load(object sender, EventArgs e)
        {

        }
    }
}
