using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
// no differnce between checking and savings
public enum AccountType { Checking, Savings, IRA}
namespace Team4_Final_Project.Models
{
    public class Account
    {
        public Int32 AccountID { get; set; }

        [Display(Name = "Type")]
        public AccountType Type { get; set; }

        public AppUser AppUser { get; set; }
        public List<Transaction> Transactions { get; set; }

        // sum transcations or sum deposits - withdrawals
        public Decimal Balance { get; set; }

    }
}
