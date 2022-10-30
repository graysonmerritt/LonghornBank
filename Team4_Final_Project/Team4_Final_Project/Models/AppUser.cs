using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using Team4_Final_Project.Models;

namespace Team_4_Final_Project.Models
{
    public class AppUser : IdentityUser
    {
        [Display(Name = "First Name")]
        public String FirstName { get; set; }
        [Display(Name = "Middle Initital")]
        public String MiddleInitial { get; set; }

        [Display(Name = "Last Name")]
        public String LastName { get; set; }

        [Display(Name = "Street")]
        public String Street { get; set; }
        [Display(Name = "City")]
        public String City { get; set; }
        [Display(Name = "State")]
        public String State { get; set; }
        [Display(Name = "Zipcode")]
        public String Zipcode { get; set; }
        [Display(Name = "Phone Number")]
        public String PhoneNumber { get; set; }
        [Display(Name = "Birthday")]
        public DateTime Birthday { get; set; }

        [Display(Name = "Is Active")]
        public bool IsActive { get; set; }

        [Display(Name = "Accounts")]
        public Account Accounts { get; set; }

    }
}

