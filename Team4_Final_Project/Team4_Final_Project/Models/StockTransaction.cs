using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace Team4_Final_Project.Models
{
    public class StockTransaction
    {
        public Int32 StockTransactionID { get; set; }
        public Decimal NumberOfShares { get; set; }
        public Decimal Price { get; set; }
        public StockPortfolio StockPortfolio { get; set; }
        public Stock Stock { get; set; }
    }
}
