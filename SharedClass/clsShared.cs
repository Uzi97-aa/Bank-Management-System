using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedClass
{

   
    public class clsShared
    {
        public class AccountsDTO
        {

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
            public AccountsDTO(int AccountID, int CustomerID, int BranchID, string AccountNumber, byte AccountType,
                string CurrencyCode, byte Status, bool IsDeleted, DateTime CreatedAt, byte[] Row_Version)
            {
                this.AccountID = AccountID;
                this.CustomerID = CustomerID;
                this.BranchID = BranchID;
                this.AccountNumber = AccountNumber;
                this.AccountType = AccountType;
                this.CurrencyCode = CurrencyCode;
                this.Status = Status;
                this.IsDeleted = IsDeleted;
                this.CreatedAt = CreatedAt;
                this.Row_Version = Row_Version;
            }



        }


        public class AuditLogDTO
        {
            public int LogID { get; set; }
            public int UserID { get; set; }
            public short ActionType { get; set; }     // 1 : CREATE , 2 : UPDATE , 3 : DELETE , 4 : TRANSACTION , 5 : LOGIN
            public short EntityTypeID { get; set; }
            public int EntityID { get; set; }
            public string OldValue { get; set; }
            public string NewValue { get; set; }
            public string IPAddress { get; set; }

            public AuditLogDTO(int logID, int userID, short actionType, short entityTypeID,
                int entityID, string oldValue, string newValue, string iPAddress)
            {
                this.LogID = logID;
                this.UserID = userID;
                this.ActionType = actionType;
                this.EntityTypeID = entityTypeID;
                this.EntityID = entityID;
                this.OldValue = oldValue;
                this.NewValue = newValue;
                this.IPAddress = iPAddress;


            }

        }


        public class BalanceDTO
        {
            public int AccountID { get; set; }
            public string AccountNumber { get; set; }
            public string CurrencyCode { get; set; }
            public decimal Balance { get; set; }

            public BalanceDTO(int AccountID, string AccountNumber, string CurrencyCode, decimal Balance)
            {
                this.AccountID = AccountID;
                this.AccountNumber = AccountNumber;
                this.CurrencyCode = CurrencyCode;
                this.Balance = Balance;

            }
        }


        public class BranchsDTO
        {
            public int BranchID { get; set; }
            public string BranchName { get; set; }
            public string Address { get; set; }
            public string City { get; set; } = string.Empty;
            public string Country { get; set; } = string.Empty;
            public BranchsDTO(int BranchID, string BranchName, string Address, string City, string Country)
            {
                this.BranchID = BranchID;
                this.BranchName = BranchName;
                this.Address = Address;
                this.City = City;
                this.Country = Country;
            }
        }



        public class CurrenciesDTO
        {
            public string CurrencyCode { get; set; }
            public string Name { get; set; }
            public string Symbol { get; set; }
            public bool IsActive { get; set; }

            public CurrenciesDTO(string CurrencyCode, string Name, string Symbol, bool IsActive)
            {
                this.CurrencyCode = CurrencyCode;
                this.Name = Name;
                this.Symbol = Symbol;
                this.IsActive = IsActive;

            }
        }



        public class CustomerDTO
        {
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


            public CustomerDTO(int customerID, string firstName, string secondName, string thirdName, string lastName, short gender, DateTime dateOfBirth
                , string nationalID, string email
                , string phone, string address, bool isDeleted, DateTime createdAt, byte[] row_Version)
            {
                this.CustomerID = customerID;
                this.FirstName = firstName;
                this.SecondName = secondName;
                this.ThirdName = thirdName;
                this.LastName = lastName;
                this.Gender = gender;
                this.DateOfBirth = dateOfBirth;
                this.NationalID = nationalID;
                this.Email = email;
                this.Phone = phone;
                this.Address = address;
                this.IsDeleted = isDeleted;
                this.CreatedAt = createdAt;
                this.Row_Version = row_Version;

            }



        }



        public class EmployeeDTO
        {
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
            public byte[] Row_Version { get; set; }


            public EmployeeDTO(int employeeID, int? branchID, string firstName, string lastName, string jobTitle, string email, string phone, DateTime hireDate,
                short status, bool isDeleted, DateTime createdAt, byte[] row_Version)
            {
                this.EmployeeID = employeeID;
                this.BranchID = branchID;
                this.FirstName = firstName;
                this.LastName = lastName;
                this.JobTitle = jobTitle;
                this.Email = email;
                this.Phone = phone;
                this.HireDate = hireDate;
                this.Status = status;
                this.IsDeleted = isDeleted;
                this.CreatedAt = createdAt;
                this.Row_Version = row_Version;
            }
        }




        public class EntityTypesDTO
        {
            public short EntityTypeID { get; set; }
            public short TableName { get; set; }

            public EntityTypesDTO(short entityTypeID, short tableName)
            {
                this.EntityTypeID = entityTypeID;
                this.TableName = tableName;
            }
        }



        public class ExchangeRateDTO
        {
            public int RateID { get; set; }
            public string FromCurrencyCode { get; set; }
            public string ToCurrencyCode { get; set; }
            public double Rate { get; set; }
            public DateTime EffectiveDate { get; set; }
            public DateTime CreatedAt { get; }



            public ExchangeRateDTO(int rateID, string fromCurrencyCode, string toCurrencyCode,
                                   double rate, DateTime effectiveDate, DateTime createdAt)
            {
                this.RateID = rateID;
                this.FromCurrencyCode = fromCurrencyCode;
                this.ToCurrencyCode = toCurrencyCode;
                this.Rate = rate;
                this.EffectiveDate = effectiveDate;
                this.CreatedAt = createdAt;
            }
        }



        public class PostingsDTO
        {

            public int PostingID { get; set; }
            public int GroupID { get; set; }
            public int AccountID { get; set; }
            public byte TransactionType { get; set; }  // -- 1 : DEBIT, 2 : CREDIT
            public decimal Amount { get; set; }
            public string Reference { get; set; }
            public int? Reversal_Of_PostingID { get; set; }
            public DateTime CreatedAt { get; set; }
            public byte[] Row_Version { get; set; }

            public PostingsDTO(int PostingID, int GroupID, int AccountID, byte TransactionType, decimal Amount,
                string Reference, int? Reversal_Of_PostingID, DateTime CreatedAt, byte[] Row_Version)
            {
                this.PostingID = PostingID;
                this.GroupID = GroupID;
                this.AccountID = AccountID;
                this.TransactionType = TransactionType;
                this.Amount = Amount;
                this.Reference = Reference;
                this.Reversal_Of_PostingID = Reversal_Of_PostingID;
                this.CreatedAt = CreatedAt;
                this.Row_Version = Row_Version;
            }

        }



        public class TransactionGroupsDTO
        {

            public int GroupoID { get; set; }

            public string Description { get; set; }
            public byte Status { get; set; }   //1 : PENDING , 2 : POSTED , 3 : REVERSED 
            public int ExchangeRateID { get; set; }
            public DateTime CreatedAt { get; set; }
            public int CreatedByUserID { get; set; }
            public int BranchID { get; set; }

            public byte[] Row_Version { get; set; }
            public TransactionGroupsDTO(int GroupoID, string Description, byte Status, int ExchangeRateID,
                DateTime CreatedAt, int CreatedByUserID, int BranchID, byte[] Row_Version)
            {
                this.GroupoID = GroupoID;
                this.Description = Description;
                this.Status = Status;
                this.ExchangeRateID = ExchangeRateID;
                this.CreatedAt = CreatedAt;
                this.CreatedByUserID = CreatedByUserID;
                this.BranchID = BranchID;
                this.Row_Version = Row_Version;
            }

        }




        public class UserDTO
        {
            public int UserID { get; set; }
            public int? CustomerID { get; set; }
            public int? EmployeeID { get; set; }
            public string UserName { get; set; }
            public string PasswordHash { get; set; }
            public byte Role { get; set; } // 1: Customer, 2: Employee, 3: Admin
            public bool IsDeleted { get; set; }
            public DateTime CreatedAt { get; set; }
            public byte[] Row_Version { get; }


            public UserDTO(int userID, int? customerID, int? employeeID, string userName, string passwordHash, byte role, bool isDeleted,
                DateTime createdAt)
            {
                this.UserID = userID;
                this.CustomerID = customerID;
                this.EmployeeID = employeeID;
                this.UserName = userName;
                this.PasswordHash = passwordHash;
                this.Role = role;
                this.IsDeleted = isDeleted;
                this.CreatedAt = createdAt;



            }

        }


    }
}
