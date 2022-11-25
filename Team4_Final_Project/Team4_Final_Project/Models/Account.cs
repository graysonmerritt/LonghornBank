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


        // Thought I could handel logic here, but 0 is the default account number
        // maybe come back and check if this can be done here instead of controller??
        //TODO: Ask how to handle this
        public String HiddenAccountNumber
        {
          
            get; set;  
        }
        public String Nickname { get; set; }

        public bool isActive { get; set; }  

        [Display(Name = "Type")]
        public AccountType Type { get; set; }


        // sum transcations or sum deposits - withdrawals
        public Decimal Balance { get; set; }

        public String TransferInfo
        {
            get { return Nickname +" xxxxxx" + HiddenAccountNumber + " " + Balance; }
            set { }

        }

        public AppUser AppUser { get; set; }
        public List<Transaction> Transactions { get; set; }

        

    }
}
