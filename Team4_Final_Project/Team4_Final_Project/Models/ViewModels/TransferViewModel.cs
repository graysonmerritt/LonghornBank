
using System.ComponentModel.DataAnnotations;

namespace Team4_Final_Project.Models.ViewModels
{
    public class TransferViewModel
    {
        [Display(Name = "From Account:")]
        public Int32 FromAccountID { get; set; }

        [Display(Name = "To Account:")]
        public Int32 ToAccountID { get; set; }

        [Display(Name = "Include fee as a seperate transaction? (Unqualified IRA only)")]
        public bool IncludeFee { get; set; }

        // TODO: check out a weird feature on this date property
        [Required]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [Required]
        public decimal Amount { get; set; }
    }
}
