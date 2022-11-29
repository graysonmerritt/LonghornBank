using System;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Team4_Final_Project.Models
{
    public enum TransactionProperty
    {
        [Display(Name = "Transaction Number")] TransactionNumber,
        [Display(Name = "Transaction Type")] TransactionType,
        Description,
        Amount
    }

    public enum AscendingOrDescending { Ascending, Descending}

    [Keyless]
    public class SearchViewModel
    {
        //description - string in textbox
        [Display(Name = "Search by Transaction Description:")]
        public string SearchDescription { get; set; }

        //transaction type - single option from drop down - enum created in TRANSACTION
        [Display(Name = "Search by Transaction Type:")]
        public Int32 SelectedType { get; set; }

        //amount search for RANGE of numbers - make sure it is in dollars
        //todo: make sure that you cant have the high amount lower than the low amount
        [Display(Name = "higher than:")]
        public Decimal? SearchAmountLow { get; set; }

        [Display(Name = "and lower than:")]
        public Decimal? SearchAmountHigh { get; set; }


        //transaction number - string in textbgox
        [Display(Name = "Search by Transaction Number:")]
        public string SearchNumber { get; set; }

        //date - RANGE
        [Display(Name = "Beginning Date:")]
        [DataType(DataType.Date)]
        public DateTime? SearchDateBeginning { get; set; }

        [Display(Name = "Ending Date:")]
        [DataType(DataType.Date)]
        public DateTime? SearchDateEnding { get; set; }


        //todo: add sort order
        //each row will have the same data order - transaction number, transaction type, description, and amount
        //BUT! the order of the ROWS is what the user can choose

        //drop down enum of properties to pick which to sort by
        [Display(Name = "Which property would you like to sort by?")]
        public Int32 SelectedProperty { get; set; }


        //radio button of descending or ascending
        [Display(Name = "Ascending or Descending?")]
        public AscendingOrDescending SortOrder { get; set; }



        //order of results =  Transaction number, transaction type, description, and amount.
        //remember the "showing x out of y transactions"

        //they should be able to sort search results from scending or descending
        //link for each transaction into its details
        //employees can do this too


    }
}

