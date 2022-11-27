using System.ComponentModel.DataAnnotations;

namespace Team4_Final_Project.Models
{
    public enum TransactionType { Deposit, Withdrawal, Fee, Transfer}
    public enum TransactionStatus { Completed, Pending, Disputed }
    public enum DistributionStatus { Qualified, Unqualified, NA }

    // TRANSFERS ARE TWO TRANSACTIONS (one withdrawal, one deposit)
    public class Transaction
    {
        public Transaction()
        {
            Disputes ??= new List<Dispute>();
        }

        public Int32 TransactionID { get; set; }
        public Int32 Number { get; set; }
        // amount can be always positive (must have another property to indicate if deposit or withdrawal
        // or amount can be postive for deposit and negative for withdrawal
        public Decimal Amount { get; set; }
        // used more internally
        public String Notes { get; set; }
        // used more on user side

        [DataType(DataType.Date)]
        public DateTime Date { get; set; } 
        public TransactionType Type { get; set; }
        public TransactionStatus Status { get; set; }
        public DistributionStatus DistributionStatus { get; set; }
        public Account Account { get; set; }
        public List<Dispute> Disputes { get; set; }
    }
}
