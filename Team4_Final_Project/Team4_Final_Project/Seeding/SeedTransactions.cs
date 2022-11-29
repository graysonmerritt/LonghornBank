using Team4_Final_Project.DAL;
using Team4_Final_Project.Models;

namespace Team4_Final_Project.Seeding
{
    public class SeedTransactions
    {

        public static void SeedAllTransactions(AppDbContext db)
        {
            List<Transaction> AllTransactions = new List<Transaction>();



            AllTransactions.Add(new Transaction
            {
                Number = 1,
                Type = TransactionType.Deposit,
                Amount = 4000.00m,
                Date = new DateTime(2022,01,15),
                Status = TransactionStatus.Completed,
                Notes = "",
                DistributionStatus = DistributionStatus.NA,
                Account = db.Accounts.FirstOrDefault(a => a.AccountNumber == 2290000021),

            });
        }
        }
}

