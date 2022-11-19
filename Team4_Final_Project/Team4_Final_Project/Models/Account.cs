using System.ComponentModel.DataAnnotations;
using System.Security.Principal;
using System.Xml.Linq;
// no difference between checking and savings
public enum AccountType { Checking, Savings, IRA}
namespace Team4_Final_Project.Models
{
    public class Account
    {
        
        public Int32 AccountID { get; set; }
        public Int64 AccountNumber { get; set; }
        // TODO: check if i'm insane on this one
        public String HiddenAccountNumber
        {
            get { return AccountNumber.ToString().Substring(HiddenAccountNumber.Length - 4); }
            set { }
        }
        public String Nickname { get; set; }

        public bool isActive { get; set; }  

        [Display(Name = "Type")]
        public AccountType Type { get; set; }


        // sum transcations or sum deposits - withdrawals
        public Decimal Balance { get; set; }

        public AppUser AppUser { get; set; }
        public List<Transaction> Transactions { get; set; }

        

    }
}
