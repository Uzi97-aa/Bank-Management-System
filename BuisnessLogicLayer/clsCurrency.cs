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
    public class clsCurrency
    {

        public enum enMode { Add=1,Update=2}
        enMode Mode = enMode.Add;
        public string CurrencyCode { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }
        public bool IsActive { get; set; }

        public CurrenciesDTO CDTO { get { return new CurrenciesDTO(this.CurrencyCode, this.Name, this.Symbol, this.IsActive); } }


        public clsCurrency(CurrenciesDTO CDTO, enMode Mode=enMode.Add)
        {
            this.CurrencyCode = CDTO.CurrencyCode;
            this.Name = CDTO.Name;
            this.Symbol = CDTO.Symbol;
            this.IsActive = CDTO.IsActive;

            this.Mode=Mode;

        }


        public clsCurrency FindCurrency(string CurrencyCode)
        {
            CurrenciesDTO CDTO = clsCurrencies.Find(CurrencyCode);
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
            return clsCurrencies.DeactivateCurrency(CDTO.CurrencyCode);
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

    }
}
