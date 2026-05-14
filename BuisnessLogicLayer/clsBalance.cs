using DataBankLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SharedClass.clsShared;
namespace BuisnessLogicLayer
{
    public  class clsBalance
    {

        public int AccountID { get; set; }
        public string AccountNumber { get; set; }
        public string CurrencyCode { get; set; }
        public decimal Balance { get; set; }

        public BalanceDTO BDTO
        {
            get
            {
                return new BalanceDTO
                (
                   this.AccountID,
                   this.AccountNumber,
                   this.CurrencyCode,
                   this.Balance
                );
            }
        }


        public clsBalance(BalanceDTO BDTO)
        {
            this.AccountID = BDTO.AccountID;
            this.AccountNumber = BDTO.AccountNumber;
            this.CurrencyCode = BDTO.CurrencyCode;
            this.Balance = BDTO.Balance;
        }

        public static List<clsBalance> GetBalances()
        {
            List<clsBalance> balances = new List<clsBalance>();
            List<BalanceDTO> balanceDTOs = clsBalances.GetBalances();
            foreach (BalanceDTO BDTO in balanceDTOs)
            {
                balances.Add(new clsBalance(BDTO));
            }
            return balances;
        }


    }
}
