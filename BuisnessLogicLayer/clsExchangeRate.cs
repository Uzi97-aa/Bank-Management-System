using DataBankLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SharedClass.clsShared;
namespace BuisnessLogicLayer
{
    public class clsExchangeRate
    {
      public  enum enMode { Add = 1, Update = 2 }
        enMode Mode = enMode.Add;

        public int RateID { get; set; }
        public string FromCurrencyCode { get; set; }
        public string ToCurrencyCode { get; set; }
        public double Rate { get; set; }
        public DateTime EffectiveDate { get; set; }
        public DateTime CreatedAt { get; }

        public ExchangeRateDTO ERDTO { get { return new ExchangeRateDTO(this.RateID, this.FromCurrencyCode,
            this.ToCurrencyCode, this.Rate, this.EffectiveDate, this.CreatedAt); } }

        public clsExchangeRate(ExchangeRateDTO ERDTO, enMode Mode = enMode.Add)
        {
            this.RateID = ERDTO.RateID;
            this.FromCurrencyCode = ERDTO.FromCurrencyCode;
            this.ToCurrencyCode = ERDTO.ToCurrencyCode;
            this.Rate = ERDTO.Rate;
            this.EffectiveDate = ERDTO.EffectiveDate;
            this.CreatedAt = ERDTO.CreatedAt;
            this.Mode = Mode;
        }

        public static clsExchangeRate FindExchangeRate(int ID)
        {
            ExchangeRateDTO ERDTO = clsExchangeRates.GetByID(ID);
            if (ERDTO == null)
            {
                return null;
            }
            return new clsExchangeRate(ERDTO, enMode.Update);
        }

        private bool AddNewExchangeRate()
        {
            int NewID = clsExchangeRates.Add(ERDTO);
            if (NewID != -1)
            {
                this.RateID = NewID;
                return true;
            }
            return false;
        }

        private bool UpdateExchangeRate()
        {
            return clsExchangeRates.Update(ERDTO);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.Add:
                    if (AddNewExchangeRate())
                    
                        Mode = enMode.Update;
                        return true;
                    
                    
                case enMode.Update:
                    return UpdateExchangeRate();
                default:
                    return false;
            }
        }

        public static List<ExchangeRateDTO> GetAll()
        {
            return clsExchangeRates.GetAll();
        }

        public static List<ExchangeRateDTO> GetLatest(string fromCurrencyCode, string toCurrencyCode)
        {
            return clsExchangeRates.GetLatest(fromCurrencyCode, toCurrencyCode);
        }

        public static bool DeleteExchangeRate(ExchangeRateDTO ERDTO)
        {
            return clsExchangeRates.Delete(ERDTO.RateID);
        }




    }
}
