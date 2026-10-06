using DataBankLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SharedClass.clsShared;
namespace BuisnessLogicLayer
{
    public class clsAccount
    {

        public  enum enMode { Add = 1, Update = 2 }
        
        enMode Mode = enMode.Add;

        public enum enStatus { Active = 1, Inactive = 2, Closed = 3 }  //--1 : ACTIVE , 2 : FROZEN , 3 : CLOSED
        public enum enAccountType { SAVINGS=1, CURRENT=2, FIXED=3 }
        public int AccountID { get; set; }
        public int CustomerID { get; set; }

        public int BranchID { get; set; }
        public string AccountNumber { get; set; }
        public enAccountType AccountType { get; set; }
        public int CurrencyID { get; set; }
        public enStatus Status { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedAt { get; set; }
        public byte[] Row_Version { get; set; }


        public AccountsDTO ADTO
        {
            get
            {
            return new AccountsDTO(this.AccountID, this.CustomerID, this.BranchID, this.AccountNumber,(byte)this.AccountType
            ,this.CurrencyID,(byte) this.Status, this.IsDeleted, this.CreatedAt, this.Row_Version);
            }
        }


        public clsAccount(AccountsDTO ADTO, enMode Mode = enMode.Add)
        {
            this.AccountID = ADTO.AccountID;
            this.CustomerID = ADTO.CustomerID;
            this.BranchID = ADTO.BranchID;
            this.AccountNumber = ADTO.AccountNumber;
            this.AccountType = (enAccountType)ADTO.AccountType;
            this.CurrencyID = ADTO.CurrencyID;
            this.Status =(enStatus) ADTO.Status;
            this.IsDeleted = ADTO.IsDeleted;
            this.CreatedAt = ADTO.CreatedAt;
            this.Row_Version = ADTO.Row_Version;
            this.Mode = Mode;
        }


        static public clsAccount FindByID(int ID)
        {
            AccountsDTO ADTO = clsAccounts.GetByID(ID);
            if (ADTO==null)
            {
                return null;
            }
            return new clsAccount(ADTO,enMode.Update);
        }
         public clsAccount FindID(int ID)
        {
            AccountsDTO ADTO = clsAccounts.GetByID(ID);
            if (ADTO == null)
            {
                return null;
            }
            return new clsAccount(ADTO, enMode.Update);
        }

    static  public clsAccount FindByCustomerID(int CustomerID)
        {
            AccountsDTO ADTO = clsAccounts.GetByCustomerID(CustomerID);
            if (ADTO == null)
            {
                return null;
            }
            return new clsAccount(ADTO, enMode.Update);
        }


     


        private bool OpenAccount()
        {
            int ID = this.AccountID = clsAccounts.OpenAccount(ADTO);

            return ID != -1;
        }


        private bool UpdateAccount()
        {
            return clsAccounts.UpdateStatus(ADTO);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.Add:
                    if (OpenAccount())
                    { 

                    Mode = enMode.Update;
                    return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                            return UpdateAccount();
                default:
                            return false;
                        }
            
        }


        public List<AccountsDTO> GetAll()
        {
            return clsAccounts.GetAll();
        }



    }
}
