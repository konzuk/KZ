using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Tables.Master.Common
{
    public class ExchangeRateTable : TableBase
    {
        //Field
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ExchangeRateId { get; set; }
        public double BuyRate { get; set; }
        public double SaleRate { get; set; }


        //FK
        [Index("ExchangeRate_Index", 1, IsUnique = true)]
        public int FromCurrencyId { get; set; }
        [ForeignKey("FromCurrencyId"), InverseProperty("FromExchangeRateTables")]
        public virtual CurrencyTable FromCurrencyTable { get; set; }
        
        [Index("ExchangeRate_Index", 2, IsUnique = true)]
        public int ToCurrencyId { get; set; }
        [ForeignKey("ToCurrencyId"), InverseProperty("ToExchangeRateTables")]
        public virtual CurrencyTable ToCurrencyTable { get; set; }


        //C-FK
        
   
        
       

    }
}
