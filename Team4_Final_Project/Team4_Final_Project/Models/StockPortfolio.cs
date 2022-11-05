
namespace Team4_Final_Project.Models
{
    public class StockPortfolio
    {
        public Int32 StockPortfolioID { get; set; }

        public AppUser AppUser { get; set; }
        public List<StockTransaction> StockTransactions { get; set; }
    }
}
