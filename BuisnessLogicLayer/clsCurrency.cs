using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using DataBankLayer;
using static SharedClass.clsShared;
namespace BuisnessLogicLayer
{
    public class clsCurrency
    {

        public enum enMode { Add=1,Update=2}
        enMode Mode = enMode.Add;
        public int CurrencyID { get; set; }
        public string CurrencyCode { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }
        public bool IsActive { get; set; }

        public CurrenciesDTO CDTO { get { return new CurrenciesDTO(this.CurrencyID, this.CurrencyCode, this.Name, this.Symbol, this.IsActive); } }


        public clsCurrency(CurrenciesDTO CDTO, enMode Mode=enMode.Add)
        {
            this.CurrencyID = CDTO.CurrencyID;
            this.CurrencyCode = CDTO.CurrencyCode;
            this.Name = CDTO.Name;
            this.Symbol = CDTO.Symbol;
            this.IsActive = CDTO.IsActive;

            this.Mode=Mode;

        }


        public clsCurrency FindCurrency(int CurrencyID)
        {
            CurrenciesDTO CDTO = clsCurrencies.Find(CurrencyID);
            if (CDTO != null)
            {
                return new clsCurrency(CDTO, enMode.Update);
            }
            return null;
        }


         private bool AddNewCurrency()
        {

            string Currency =clsCurrencies.AddCurrency(CDTO);

            if (!string.IsNullOrEmpty(Currency))
            {
                return true;
            }
            return false;

        }


        private bool UpdateCurrency()
        {
            return clsCurrencies.UpdateCurrency(CDTO);
        }

        static public bool DeActivate(CurrenciesDTO CDTO)
        {
            return clsCurrencies.DeactivateCurrency(CDTO.CurrencyID);
        }


        public bool Save()
        {
            if (this.Mode == enMode.Add)
            {
                this.Mode = enMode.Update;
                return AddNewCurrency();
            }
            else
            {
                return UpdateCurrency();
            }
        }

        public List<CurrenciesDTO> GetAllActiveCurrencies()
        {
            return clsCurrencies.GetAllCurrencies();
        }


        static public DataTable GetAllCurrencies()
        {
           return clsCurrencies.GetAllCurrenciesDatatable();
        }


    }
}
