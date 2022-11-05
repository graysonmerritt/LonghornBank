namespace Team4_Final_Project.Models
{
    public class Stock
    {
        public Int32 StockId { get; set; }
        public String StockTicker { get; set; }
        public Decimal StockPrice { get; set; }
        public StockType StockType { get; set; }
        List<StockTransaction> StockTransactions { get; set; }
    }
}
