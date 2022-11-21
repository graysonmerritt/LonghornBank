
namespace Team4_Final_Project.Models
{
    public class StockPortfolio
    {
        public StockPortfolio()
        {
            StockTransactions ??= new List<StockTransaction>();
        }
        public Int32 StockPortfolioID { get; set; }
        public Int64 AccountNumber { get; set; }
        // Thought I could handel logic here, but 0 is the default account number
        // maybe come back and check if this can be done here instead of controller??
        //TODO: Ask how to handle this
        public String HiddenAccountNumber
        {

            get; set;
        }
        public String Nickname { get; set; }
        // TODO: may have to remigrate
        public Decimal Balance { get; set; }
        public bool Balanced { get; set; }

        public Decimal Gain { get; set; }
        public Decimal AvailableCash { get; set; }
        public Decimal Fee { get; set; }
        public Decimal Bonus { get; set; }
        public AppUser AppUser { get; set; }
        public bool IsActive { get; set; }
        public List<StockTransaction> StockTransactions { get; set; }
    }
}
