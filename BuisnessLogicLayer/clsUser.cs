using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBankLayer;
using static SharedClass.clsShared;
namespace BuisnessLogicLayer
{
    public class clsUser
    {
        public enum enMode { AddNew = 1, Update = 2 }
        enMode Mode = enMode.AddNew;
        public int UserID { get; set; }
        public int? CustomerID { get; set; }
        public int? EmployeeID { get; set; }
        public string UserName { get; set; }
        public string PasswordHash { get; set; }
        public byte Role { get; set; } // 1: Customer, 2: Employee, 3: Admin
        public bool IsDeleted { get; set; }
        public DateTime CreatedAt { get;  set; }
        public byte[] Row_Version { get; }



        public UserDTO UDTO { get { return new UserDTO(this.UserID, this.CustomerID, this.EmployeeID, this.UserName, this.PasswordHash
            , this.Role, this.IsDeleted, this.CreatedAt); } }

        public clsUser(UserDTO UDTO,enMode Mode=enMode.AddNew)
        {
            this.UserID = UDTO.UserID;
            this.CustomerID = UDTO.CustomerID;
            this.EmployeeID = UDTO.EmployeeID;
            this.UserName = UDTO.UserName;
            this.PasswordHash= UDTO.PasswordHash;
            this.Role = UDTO.Role;
            this.IsDeleted = UDTO.IsDeleted;
            this.CreatedAt = UDTO.CreatedAt;
            this.Row_Version = UDTO.Row_Version;
            this.Mode = Mode;
        }

        public clsUser Find(int ID)
        {
            UserDTO UDTO = clsUsers.GetUserByID(ID);
            if (UDTO==null)
            {
                return null;
            }
            return new clsUser(UDTO, Mode);

        }



        public List<UserDTO> GetAllUsers()
        {
            return clsUsers.GetAll();
        }

        private bool AddNew()
        {
            this.UserID = clsUsers.AddNewUser(UDTO);
            return this.UserID != -1;
        }

        private bool Update()
        {
            return clsUsers.UpdateUser(UDTO);
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


        public bool Delete(UserDTO UDTO) 
        {
        
            return clsUsers.DeleteUser(UDTO);
        
        }




    }
}
