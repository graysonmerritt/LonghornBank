﻿namespace Team4_Final_Project.Models
{
    public enum TransactionType { Deposit, Withdrawal, Fee, Transfer}
    public enum TransactionStatus { Approved, Pending }
    public enum DistributionStatus { Qualified, Unqualified }

    // TRANSFERS ARE TWO TRANSACTIONS (one withdrawal, one deposit)
    public class Transaction
    {
        public Transaction()
        {
            Disputes ??= new List<Dispute>();
        }

        public Int32 TransactionID { get; set; }
        public Int32 Number { get; set; }
        public Decimal Amount { get; set; }
        public String Notes { get; set; }   
        public DateTime Date { get; set; } 
        public TransactionType Type { get; set; }
        public TransactionStatus Status { get; set; }
        public DistributionStatus DistributionStatus { get; set; }
        public Account Account { get; set; }
        public List<Dispute> Disputes { get; set; }
    }
}
