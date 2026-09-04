using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using DataBankLayer;
using static SharedClass.clsShared;
namespace BuisnessLogicLayer
{
    public class clsCustomer
    {
        public enum enMode{AddNew=1,Update=2}
       public enMode Mode = enMode.AddNew;

        public enum enGender { Male = 1, Female = 2, Else = 3 }
        public int CustomerID { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public enGender Gender { get; set; }  // 1 : Male , 2 : Female , 3 : Else
        public DateTime DateOfBirth { get; set; }
        public string NationalID { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }

        public bool IsDeleted { get; set; }
        public DateTime CreatedAt { get; set; }

        public byte[] Row_Version { get; set; }

        public string FullName { get {  return $"{FirstName} {SecondName} {LastName}" ; } }

        public clsAccount Account { get; set; }
        public CustomerDTO CDTO 
        { 
            get 
            {
                return new CustomerDTO(this.CustomerID, this.FirstName, this.SecondName, this.ThirdName, this.LastName
                    ,(short)this.Gender, this.DateOfBirth, this.NationalID, this.Email, this.Phone, this.Address, this.IsDeleted, this.CreatedAt, this.Row_Version);
            } } 

       public clsCustomer(CustomerDTO CDTO,enMode Mode=enMode.AddNew)
        {
            this.CustomerID = CDTO.CustomerID;
            this.FirstName = CDTO.FirstName;
            this.SecondName = CDTO.SecondName;
            this.ThirdName = CDTO.ThirdName;
            this.LastName = CDTO.LastName;
            this.Gender = (enGender)CDTO.Gender;
            this.DateOfBirth = CDTO.DateOfBirth;
            this.NationalID = CDTO.NationalID;
            this.Email = CDTO.Email;
            this.Phone = CDTO.Phone;
            this.Address = CDTO.Address;
            this.IsDeleted = CDTO.IsDeleted;
            this.CreatedAt = CDTO.CreatedAt;
            this.Row_Version = CDTO.Row_Version;
            this.Mode = Mode;
            this.Account = clsAccount.FindByCustomerID(this.CustomerID);
        }

       

        static public clsCustomer Find(int ID)
        {
            CustomerDTO CDTO = clsCustomers.GetCustomerByID(ID);
            if (CDTO == null)
            {
                return null;
            }
           
            return new clsCustomer(CDTO,enMode.Update);
        }

        static public clsCustomer FindByNationalID(string NationalID)
        {
            CustomerDTO CDTO = clsCustomers.GetCustomerByNationalID(NationalID);
            if (CDTO == null)
            {
                return null;
            }

            return new clsCustomer(CDTO, enMode.Update);
        }

        static public clsCustomer FindByFullName(string FullName)
        {
            int Counter = 0;

            StringBuilder FirstName = new StringBuilder();

            for (int i = 0; i < FullName.Length; i++)
            {
                FirstName.Append(FullName[i]);

                if (char.IsWhiteSpace(FullName[i]))
                {
                    Counter = i+1;
                    
                    break;
                }

            }

            StringBuilder secondName = new StringBuilder();

            for (int i = Counter; i < FullName.Length; i++)
            {
                secondName.Append(FullName[i]);

                if (char.IsWhiteSpace(FullName[i]))
                {
                    Counter = i+1;
                    
                    break;
                }

            }

            StringBuilder LastName = new StringBuilder();

            for (int i = Counter; i < FullName.Length; i++)
            {

                LastName.Append(FullName[i]);
                if (char.IsWhiteSpace(FullName[i]))
                {
                    Counter = i+1;
                    
                    break;
                }

            }
            

            CustomerDTO CDTO = clsCustomers.FindCustomerByFullName(FirstName.ToString(),secondName.ToString(),LastName.ToString());
            if (CDTO==null)
            {
                return null;
            }

            return new clsCustomer(CDTO);   

        }

        static public clsCustomer FindByAccountID(int AccountId)
        {
            CustomerDTO CDTO = clsCustomers.GetCustomerByAccountID(AccountId);
            if (CDTO == null)
            {
                return null;
            }

            return new clsCustomer(CDTO, enMode.Update);
        }

        private bool AddNew()
        {
            this.CustomerID = clsCustomers.AddNewCustomer(CDTO);

            return (this.CustomerID != -1);
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
                    {

                        Mode = enMode.Update;
                        return true;
                    }

                    else
                    {
                        return false;
                    }

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
