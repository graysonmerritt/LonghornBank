
namespace Team4_Final_Project.Models
{
    public class StockPortfolio
    {
        public StockPortfolio()
        {
            StockTransactions ??= new List<StockTransaction>();
        }
        public Int32 StockPortfolioID { get; set; }
        public bool Balanced { get; set; }

        public Decimal Gain { get; set; }
        public Decimal AvailableCash { get; set; }
        public Decimal Fee { get; set; }
        public Decimal Bonus { get; set; }
        public AppUser AppUser { get; set; }
        public List<StockTransaction> StockTransactions { get; set; }
    }
}
