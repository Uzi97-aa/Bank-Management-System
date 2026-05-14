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
        public int AccountID { get; set; }
        public int CustomerID { get; set; }

        public int BranchID { get; set; }
        public string AccountNumber { get; set; }
        public byte AccountType { get; set; }
        public string CurrencyCode { get; set; }
        public byte Status { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedAt { get; private set; }
        public byte[] Row_Version { get; private set; }


        public AccountsDTO ADTO
        {
            get
            {
            return new AccountsDTO(this.AccountID, this.CustomerID, this.BranchID, this.AccountNumber, this.AccountType
            ,this.CurrencyCode, this.Status, this.IsDeleted, this.CreatedAt, this.Row_Version);
            }
        }


        public clsAccount(AccountsDTO ADTO, enMode Mode = enMode.Add)
        {
            this.AccountID = ADTO.AccountID;
            this.CustomerID = ADTO.CustomerID;
            this.BranchID = ADTO.BranchID;
            this.AccountNumber = ADTO.AccountNumber;
            this.AccountType = ADTO.AccountType;
            this.CurrencyCode = ADTO.CurrencyCode;
            this.Status = ADTO.Status;
            this.IsDeleted = ADTO.IsDeleted;
            this.CreatedAt = ADTO.CreatedAt;
            this.Row_Version = ADTO.Row_Version;
            this.Mode = Mode;
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
                    
                        Mode=enMode.Update;
                        return true;
                    
                    
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
