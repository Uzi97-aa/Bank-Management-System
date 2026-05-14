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
    public class clsEmployee
    {

        public enum enMode { AddNew = 1, Update = 2 }
        enMode Mode = enMode.AddNew;

        public int EmployeeID { get; set; }
        public int? BranchID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string JobTitle { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime HireDate { get; set; }
        public short Status { get; set; }  //  1 : Active , 2 : Suspended , 3 : Terminated
        public bool IsDeleted { get; set; }

        public DateTime CreatedAt { get; set; }
        public byte[] Row_Version { get;private set; }

        public EmployeeDTO EDTO { get {
                return (new EmployeeDTO(this.EmployeeID, this.BranchID??0, this.FirstName, this.LastName, this.JobTitle,
            this.Email, this.Phone, this.HireDate, this.Status, this.IsDeleted, this.CreatedAt,this.Row_Version)); } }


        public clsEmployee(EmployeeDTO EDTO,enMode Mode=enMode.AddNew)
        {
            this.EmployeeID = EDTO.EmployeeID;
            this.BranchID = EDTO.BranchID;
            this.FirstName = EDTO.FirstName;
            this.LastName = EDTO.LastName;
            this.JobTitle = EDTO.JobTitle;
            this.Email = EDTO.Email;
            this.Phone = EDTO.Phone;
            this.HireDate = EDTO.HireDate;
            this.Status = EDTO.Status;
            this.IsDeleted = EDTO.IsDeleted;
            this.Row_Version = EDTO.Row_Version;
            this.Mode= Mode;
        }

        public static clsEmployee Find(int ID)
        {
            
            EmployeeDTO EDTO= DataBankLayer.clsEmployee.GetEmployeeByID(ID);
            if (EDTO==null)
            {
                return null;
            }
            return new clsEmployee(EDTO,enMode.Update);
        }

        private bool AddNew()
        {

          int ID=  this.EmployeeID = DataBankLayer.clsEmployee.AddNewEmployee(EDTO);
            return ID!=-1;

        }

        private bool Update()
        {
            return DataBankLayer.clsEmployee.UpdateEmployee(EDTO);
        }

        public bool Delete(EmployeeDTO EDTO)
        {
            return DataBankLayer.clsEmployee.DeleteEmployee(EDTO);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (AddNew())
                    {
                       Mode=enMode.Update;
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


        public List<EmployeeDTO> GetAll() 
        {
            return DataBankLayer.clsEmployee.GetAll();
        }



    }


    
}
