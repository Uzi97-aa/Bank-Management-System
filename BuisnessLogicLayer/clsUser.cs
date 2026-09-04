using BCrypt.Net;
using DataBankLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Authentication;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static SharedClass.clsShared;
namespace BuisnessLogicLayer
{
    public class clsUser
    {
        public enum enMode { AddNew = 1, Update = 2 }
        public enum enRole { Customer = 1, Employee = 2, Admin = 3 }
        enMode Mode = enMode.AddNew;
        public int UserID { get; set; }
        public int? CustomerID { get; set; }
        public int? EmployeeID { get; set; }
        public string UserName { get; set; }
        // Backing field and property that ensures a plain password is hashed once,
        // and an already-hashed string (64 hex chars) is preserved.
        private string _passwordHash;
        public string PasswordHash
        {
            get => _passwordHash;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    _passwordHash = value;
                    return;
                }

                // SHA-256 hex is 64 lowercase hex chars. If value already matches that pattern, assume it's hashed.
                if (Regex.IsMatch(value, "^[a-f0-9]{64}$"))
                {
                    _passwordHash = value;
                }
                else
                {
                    _passwordHash = ComputeHash(value);
                }
            }
        }
        public enRole Role { get; set; } // 1: Customer, 2: Employee, 3: Admin
        public bool IsDeleted { get; set; }
        public bool IsActive {  get; set; }
        public DateTime CreatedAt { get;  set; }
        public byte[] Row_Version { get; }



        public UserDTO UDTO { get { return new UserDTO(this.UserID, this.CustomerID, this.EmployeeID, this.UserName
            ,this.PasswordHash.ToString()
            , (byte)this.Role, this.IsDeleted,this.IsActive, this.CreatedAt,this.Row_Version); } }

        public clsUser(UserDTO UDTO,enMode Mode=enMode.AddNew)
        {
            this.UserID = UDTO.UserID;
            this.CustomerID = UDTO.CustomerID;
            this.EmployeeID = UDTO.EmployeeID;
            this.UserName = UDTO.UserName;
            this.PasswordHash= UDTO.PasswordHash;
            this.Role =(enRole) UDTO.Role;
            this.IsDeleted = UDTO.IsDeleted;
            this.IsActive = UDTO.IsActive;
            this.CreatedAt = UDTO.CreatedAt;
            this.Row_Version = UDTO.Row_Version;
            this.Mode = Mode;
        }

     static public clsUser Find(int ID)
        {
            UserDTO UDTO = clsUsers.GetUserByID(ID);
            if (UDTO==null)
            {
                return null;
            }
            return new clsUser(UDTO,enMode.Update);

        }
        static public clsUser FindByUserName(string UserName)
        {
            UserDTO UDTO = clsUsers.GetUserByUserName(UserName);
            if (UDTO == null)
            {
                return null;
            }
            return new clsUser(UDTO, enMode.Update);

        }

        static public clsUser FindByUserNameAndPassword(string UserName,string Password)
        {
            UserDTO UDTO=clsUsers.GetUserByUserNameAndPassword(UserName, Password);
            if (UDTO == null)
            {
                return null;
            }
            return new clsUser(UDTO, enMode.Update);
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

        public static string ComputeHashWithBCrypt(string input)
        {
            //SHA is Secutred Hash Algorithm.
            // Create an instance of the SHA-256 algorithm
            return BCrypt.Net.BCrypt.HashPassword(input);
        }




        public static string ComputeHash(string input)
        {
            //SHA is Secutred Hash Algorithm.
            // Create an instance of the SHA-256 algorithm
            using (SHA256 sha256 = SHA256.Create())
            {
                // Compute the hash value from the UTF-8 encoded input string
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));

                // Convert the byte array to a lowercase hexadecimal string
                return BitConverter.ToString(hashBytes).Replace("-", "").ToLower().Trim();
            }
        }


         static public DataTable GetAllUser() 
        { 
            DataTable dt = clsUsers.GetAllUsers();
            return dt;
        }




    }



}
