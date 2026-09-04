using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BuisnessLogicLayer;
using static SharedClass.clsShared;
namespace BankMangmentSystem.Customer
{
    public partial class frmAddUpdateCustomer : Form
    {
        frmAddUpdateCustomer frm;
        public delegate void CustomerDataBack(object sender,int CustomerID);

        public event CustomerDataBack databack;

        public  CustomerDTO customerDTO;


        clsCustomer Customer;
      public  enum _enMode { AddNew = 1, Update = 2 }
        _enMode mode = _enMode.AddNew;
        private int _CustomerID;
        public frmAddUpdateCustomer()
        {
            InitializeComponent();
            _CustomerID = -1;
            mode = _enMode.AddNew;
            

        }
        public frmAddUpdateCustomer(int CustomerID)
        {
            InitializeComponent();
            _CustomerID = CustomerID;
            mode = _enMode.Update;
        }


        private void LoadCustomerData()
        {
    
          Customer=clsCustomer.Find(_CustomerID);
            if (Customer==null)
            {
                MessageBox.Show("Customer not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }

            txtFirstName.Text = Customer.FirstName;
            txtSecondName.Text = Customer.SecondName;
            txtThirdName.Text = Customer.ThirdName;
            txtLastName.Text = Customer.LastName;
            cbGender.TabIndex = (short)Customer.Gender;
            dtbDate.Value = Customer.DateOfBirth;
            txtPhone.Text = Customer.Phone;
            txtEmail.Text = Customer.Email;
            txtAddress.Text = Customer.Address;
            txtNationalID.Text = Customer.NationalID;

           

        }

        private void ResetForm()
        {
            lblCustomer.Visible = false;
            txtFirstName.Text = "";
            txtSecondName.Text = "";
            txtThirdName.Text = "";
            txtLastName.Text = "";
            cbGender.TabIndex = 0;
           
            txtPhone.Text = "";
            txtEmail.Text = "";
            txtAddress.Text = "";
            txtNationalID.Text = "";

        }       

        //Add new custmer by filled up filds and make delegation to previous form
        private void AddCustomer()
        {
            // Validate gender
            if (cbGender.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a valid gender.");
                return;
            }

            // Parse date safely
            //DateTime dob;
            //var dateText = Date.Text?.Trim(); // FuiDate.Text assumed
            //if (!DateTime.TryParse(dateText, out dob))
            //{
            //    MessageBox.Show("Please enter a valid date of birth.");
            //    return;
            //}

            customerDTO = new CustomerDTO(
                _CustomerID,
                txtFirstName.FastText,
                txtSecondName.FastText,
                txtThirdName.FastText,
                txtLastName.FastText,
                (short)(cbGender.SelectedIndex + 1),
                dtbDate.Value,
                txtNationalID.FastText,
                txtEmail.FastText,
                txtPhone.FastText,
                txtAddress.FastText,
                false,
                DateTime.Now,
                new byte[0]
            );

            //customerDTO.CustomerID = _CustomerID;
            //customerDTO.FirstName = txtFirstName.Text;
            //customerDTO.SecondName = txtSecondName.Text;
            //customerDTO.ThirdName = txtThirdName.Text;
            //customerDTO.LastName = txtLastName.Text;
            //customerDTO.Gender = (short)(cbGender.SelectedIndex + 1);
            //customerDTO.DateOfBirth = Convert.ToDateTime(Date.Text);
            //customerDTO.NationalID = txtNationalID.Text;
            //customerDTO.Email = txtEmail.Text;
            //customerDTO.Phone = txtPhone.Text;
            //customerDTO.Address = txtAddress.Text;
            //customerDTO.IsDeleted = false;
            //customerDTO.CreatedAt = DateTime.Now;
            //customerDTO.Row_Version = new byte[0];

          

           

            Customer = new clsCustomer(customerDTO);

            if (Customer==null)
            {
                MessageBox.Show("Customer object is null. Cannot add customer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }

            if (Customer.Save())
            {
                if (Customer.CustomerID == -1)
                {
                    MessageBox.Show("Failed to save customer. Customer ID is invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show("Customer is Added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                databack?.Invoke(this, customerDTO.CustomerID);
                lblCustomer.Visible = true;
                lblCustomer.Text = $"Customer ID: {Customer.CustomerID}";
            }
            else
            {
                MessageBox.Show("Customer object is null. Cannot add customer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            
        }

        //for update some attribute
        private void UpdateCustomer()
        {
           Customer=clsCustomer.Find(_CustomerID);
            if (Customer == null)
            {
                MessageBox.Show("Customer not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }
           
            Customer.Email = txtEmail.FastText;
            Customer.Phone = txtPhone.FastText;
            Customer.Address = txtAddress.FastText;
            
            txtFirstName.Enabled=false;
            txtSecondName.Enabled=false;
            txtThirdName.Enabled=false;
            txtLastName.Enabled = false;
            txtNationalID.Enabled = false;
            cbGender.Enabled= false;
            

            


            if (Customer.Save())
            {
                if (Customer.CustomerID == -1)
                {
                    MessageBox.Show("Failed to save customer. Customer ID is invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show("Customer is Updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                databack?.Invoke(this, customerDTO.CustomerID);
                lblCustomer.Visible = true;
                lblCustomer.Text = $"Customer ID: {Customer.CustomerID}";
            }
            else
            {
                MessageBox.Show("Customer object is null. Cannot Update customer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        private void frmAddCustomer_Load(object sender, EventArgs e)
        {
        ResetForm();
            if (mode == _enMode.Update)
            {
                LoadCustomerData();
                btnADD.Text = "Update";
                
                frm.Text= btnADD.Text;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbGender_Click(object sender, EventArgs e)
        {
           
        }

 

        private void label1_Click(object sender, EventArgs e)
        {

        }



     

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnADD_Click_2(object sender, EventArgs e)
        {
            if (mode == _enMode.AddNew)
            {
                AddCustomer();
            }
            else if (mode == _enMode.Update)
            {
                UpdateCustomer();
            }
        }
    }
}
