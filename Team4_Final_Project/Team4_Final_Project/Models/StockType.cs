namespace Team4_Final_Project.Models
{
    public class StockType
    {
        public Int32 StockTypeID { get; set; }
        public String StockTypeName { get; set; }
        public List<Stock> Stocks { get; set; }
    }
}
