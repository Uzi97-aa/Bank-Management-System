using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBankLayer;
using static SharedClass.clsShared;
namespace BuisnessLogicLayer
{
    public class clsTransactionGroup
    {
        public enum enMode { create = 1, Update = 2 }
        enMode Mode = enMode.create;

        public enum TransactionGroupStatus
        {
            Pending = 1,
            Posted = 2,
            Reversed = 3
        }
        public int GroupoID { get; set; }

        public string Description { get; set; }
        public TransactionGroupStatus Status { get; set; }
        public int ExchangeRateID { get; set; }
        public DateTime CreatedAt { get; set; }
        public int CreatedByUserID { get; set; }
        public int BranchID { get; set; }

        public byte[] Row_Version { get; set; }

        public TransactionGroupsDTO TDTO
        {
            get
            {
                return new TransactionGroupsDTO(this.GroupoID, this.Description, (byte)this.Status, this.ExchangeRateID,
                    this.CreatedAt, this.CreatedByUserID, this.BranchID, this.Row_Version);
            }
        }


        public clsTransactionGroup(TransactionGroupsDTO TDTO, enMode Mode = enMode.create)
        {
            this.GroupoID = TDTO.GroupoID;
            this.Description = TDTO.Description;
            this.Status = (TransactionGroupStatus)TDTO.Status;
            this.ExchangeRateID = TDTO.ExchangeRateID;
            this.CreatedAt = TDTO.CreatedAt;
            this.CreatedByUserID = TDTO.CreatedByUserID;
            this.BranchID = TDTO.BranchID;
            this.Row_Version = TDTO.Row_Version;
            this.Mode = Mode;
        }


        private bool CreateTransactionGroup()
        {
            int ID = this.GroupoID = clsTransactionGroups.OpenTransactionGroup(TDTO);
            return ID != -1 ? true : false;
        }

        public static clsTransactionGroup FindByID(int GroupID)
        {
            TransactionGroupsDTO TDTO = clsTransactionGroups.FindByID(GroupID);
            if (TDTO != null)
                return new clsTransactionGroup(TDTO, enMode.Update);
            else
                return null;
        }


        public bool Save()
        {
            switch (Mode)
            {
                case enMode.create:
                    if (CreateTransactionGroup())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;
                case enMode.Update:
                //  return clsTransactionGroups.UpdateTransactionGroup(TDTO);
                default:
                    return false;
            }
        }

        public bool Post(int GroupID, byte[] Row_Version)
        {
            if (FindByID(GroupID)!=null)
            {
                return clsTransactionGroups.PostTransactionGroup(GroupID, Row_Version);
            }

           return false;
        }
        // public bool Reverse()
        //{
        //    return clsTransactionGroups.ReverseTransactionGroup(TDTO);


        //}
    }
}