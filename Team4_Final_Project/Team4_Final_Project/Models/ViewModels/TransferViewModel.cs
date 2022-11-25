
using System.ComponentModel.DataAnnotations;

namespace Team4_Final_Project.Models.ViewModels
{
    public class TransferViewModel
    {
        [Display(Name = "From Account:")]
        public Int32 FromAccountID { get; set; }

        [Display(Name = "To Account:")]
        public Int32 ToAccountID { get; set; }
       
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        [Required()]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [Required()]
        public decimal Amount { get; set; }

        public string Comment { get; set; }
    }
}
