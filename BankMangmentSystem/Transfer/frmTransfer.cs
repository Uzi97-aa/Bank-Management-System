using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankMangmentSystem.Transfer
{
    public partial class frmTransfer : Form
    {
        int _CustomerID1;
        int _CustomerID2;


        public frmTransfer()
        {
            InitializeComponent();
        }

        private void frmTransfer_Load(object sender, EventArgs e)
        {

        }

        private void ctrlTransform1_Load(object sender, EventArgs e)
        {
            
        }

        private void ctrlTransform1_DataBack(object sender, int CustomerID)
        {
            _CustomerID1 = CustomerID;
        }

        private void ctrlTransform2_DataBack(object sender, int CustomerID)
        {
            _CustomerID2 = CustomerID;
        }

        private void fuiButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
