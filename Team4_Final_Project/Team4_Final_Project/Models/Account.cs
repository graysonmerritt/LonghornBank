using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

public enum AccountType { "Checking", "Savings"}
namespace Team4_Final_Project.Models
{
    public class Account
    {

        [Display(Name = "First Name")]
        public AccountType Type { get; set; }
    }
}
