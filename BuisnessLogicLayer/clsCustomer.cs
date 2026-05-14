using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBankLayer;
using static SharedClass.clsShared;
namespace BuisnessLogicLayer
{
    public class clsCustomer
    {
        public enum enMode{AddNew=1,Update=2}
        enMode Mode = enMode.AddNew;
        public int CustomerID { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public short Gender { get; set; }  // 1 : Male , 2 : Female , 3 : Else
        public DateTime DateOfBirth { get; set; }
        public string NationalID { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }

        public bool IsDeleted { get; set; }
        public DateTime CreatedAt { get; set; }

        public byte[] Row_Version { get; set; }


        public CustomerDTO CDTO 
        { 
            get 
            {
                return new CustomerDTO(this.CustomerID, this.FirstName, this.SecondName, this.ThirdName, this.LastName
                    , this.Gender, this.DateOfBirth, this.NationalID, this.Email, this.Phone, this.Address, this.IsDeleted, this.CreatedAt, this.Row_Version);
            } } 

       public clsCustomer(CustomerDTO CDTO)
        {
            this.CustomerID = CDTO.CustomerID;
            this.FirstName = CDTO.FirstName;
            this.SecondName = CDTO.SecondName;
            this.ThirdName = CDTO.ThirdName;
            this.LastName = CDTO.LastName;
            this.Gender = CDTO.Gender;
            this.DateOfBirth = CDTO.DateOfBirth;
            this.NationalID = CDTO.NationalID;
            this.Email = CDTO.Email;
            this.Phone = CDTO.Phone;
            this.Address = CDTO.Address;
            this.IsDeleted = CDTO.IsDeleted;
            this.CreatedAt = CDTO.CreatedAt;
            this.Row_Version = CDTO.Row_Version;
            this.Mode = enMode.AddNew;
        }

       

        private bool AddNew()
        {
            this.CustomerID = clsCustomers.AddNewCustomer(CDTO);

            return this.CustomerID != -1;
        }

        private bool Update()
        {
            return clsCustomers.UpdateCustomer(CDTO);
        }


        public bool Save() 
        {
            switch (Mode)
            {
                case enMode.AddNew:

                    if (AddNew())
                    
                        Mode = enMode.Update;
                        return true;
                    
                case enMode.Update:

                    return Update();
            }

            return false;  
        }

        public bool Delete()
        {
            return clsCustomers.DeleteCustomer(CDTO);
        }

        public List<clsCustomer> GetAll()
        {
            List<CustomerDTO> customersDTO = clsCustomers.GetAllCustomers();
            List<clsCustomer> customers = new List<clsCustomer>();
            foreach (var CDTO in customersDTO)
            {
                customers.Add(new clsCustomer(CDTO));
            }
            return customers;
        }

    }
}
