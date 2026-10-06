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
namespace BankMangmentSystem.Currency
{
    public partial class frmCurrencyList : Form
    {
        DataTable dt= clsCurrency.GetAllCurrencies();

        public frmCurrencyList()
        {
            InitializeComponent();
        }


        private void LoadData()
        {
            dgvCurrencyList.DataSource = dt;

            dgvCurrencyList.Columns["CurrencyID"].HeaderText = "Currency ID";
            dgvCurrencyList.Columns["CurrencyID"].Width = 150;

            dgvCurrencyList.Columns["Name"].HeaderText = "Currency Name";
            dgvCurrencyList.Columns["Name"].Width = 150;

            dgvCurrencyList.Columns["Symbol"].HeaderText = "Currency Symbol";
            dgvCurrencyList.Columns["Symbol"].Width = 150;

            dgvCurrencyList.Columns["CurrencyCode"].HeaderText = "Currency Code";
            dgvCurrencyList.Columns["CurrencyCode"].Width = 150;

            dgvCurrencyList.Columns["IsActive"].HeaderText = "Is Active";
            dgvCurrencyList.Columns["IsActive"].Width = 150;

            lblRecord.Text = dt.Rows.Count.ToString();
        }


        private void frmCurrencyList_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
