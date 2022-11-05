namespace Team4_Final_Project.Models
{
    // TRANSFERS ARE TWO TRANSACTIONS (one withdrawal, one deposit)
    public class Transaction
    {
        public Int32 TransactionID { get; set; }

        public Account Account { get; set; }
    }
}
