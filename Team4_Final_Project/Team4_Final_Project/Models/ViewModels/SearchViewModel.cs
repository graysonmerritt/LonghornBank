using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Team4_Final_Project.Models.ViewModels
{
    public class SearchViewModel
    {
        // pay attention to what we can make nullable with the ? operator
        public Int32 SearchViewModelID { get; set; }

        public Account Account { get; set; }

        [Display(Name = "Search by description:")]
        public string Description { get; set; }

        [Display(Name = "Search Transaction Type:")]
        public TransactionType? SelectedTransactionType { get; set; }

        [Display(Name = "Amount Greater Than:")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal AmountLower { get; set; }

        [Display(Name = "Amount Less Than:")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal AmountUpper { get; set; }

        [Display(Name = "Search by Transaction Number:")]
        public string TransactionNumber { get; set; }

        [Display(Name = "From Date:")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0: MM/dd/yyyy}")]
        public DateTime? DateLower { get; set; }

        [Display(Name = "To Date:")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0: MM/dd/yyyy}")]
        public DateTime? DateUpper { get; set; }
       
    }
}
