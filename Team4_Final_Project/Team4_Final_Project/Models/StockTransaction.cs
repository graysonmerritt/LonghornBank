using Microsoft.Extensions.Diagnostics.HealthChecks;
using System.ComponentModel.DataAnnotations;

namespace Team4_Final_Project.Models
{
    public enum StockTransactionType { Purchase, Withdrawal, Fee, Transfer }
    public class StockTransaction
    {
        public Int32 StockTransactionID { get; set; }
        public Decimal NumberOfShares { get; set; }
        public Decimal Price { get; set; }
        public StockTransactionType Type { get; set; }

        public StockPortfolio StockPortfolio { get; set; }

        public Stock Stock { get; set; }


        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal ExtendedPrice
        {
            get { return NumberOfShares * Price; }
            set { }

        }
    }
}
