namespace Team4_Final_Project.Models
{
    public class Stock
    {
        public Stock()
        {
            StockTransactions ??= new List<StockTransaction>();
        }
        public Int32 StockId { get; set; }
        public String StockTicker { get; set; }

        public String StockName { get; set; }
        public Decimal StockPrice { get; set; }
        public StockType StockType { get; set; }
        List<StockTransaction> StockTransactions { get; set; }
    }
}
