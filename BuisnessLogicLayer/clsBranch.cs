using DataBankLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SharedClass.clsShared;
namespace BuisnessLogicLayer
{
    public class clsBranch
    {
        public enum enMode { create = 1, Update = 2 }
        enMode Mode = enMode.create;

        public int BranchID { get; set; }
        public string BranchName { get; set; }
        public string Address { get; set; }
        public string City { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;

        public BranchsDTO BDTO
        {
            get
            {
                return new BranchsDTO(this.BranchID, this.BranchName, this.Address, this.City, this.Country);
            }
        }


        public clsBranch(BranchsDTO BDTO, enMode Mode = enMode.create)
        {
            this.BranchID = BDTO.BranchID;
            this.BranchName = BDTO.BranchName;
            this.Address = BDTO.Address;
            this.City = BDTO.City;
            this.Country = BDTO.Country;
            this.Mode = Mode;
        }

        private bool CreateBranch()
        {
            int ID = this.BranchID = clsBranchs.AddBranch(BDTO);
            return ID != -1 ? true : false;
        }

        private bool UpdateBranch()
        {
            return clsBranchs.UpdateBranch(BDTO);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.create:
                    if (CreateBranch())
                        Mode = enMode.Update;
                    return true;

                case enMode.Update:
                    return UpdateBranch();
            }
            return false;
        }

        public bool Delete()
        {
            return clsBranchs.DeleteBranch(this.BranchID);

        }
    }
}
