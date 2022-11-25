﻿using System.ComponentModel.DataAnnotations;
public enum StockTransactionType { Purchase, Withdrawal, Fee, Transfer }

namespace Team4_Final_Project.Models
{
    public class StockTransaction
    {
        public Int32 StockTransactionID { get; set; }
        public Decimal NumberOfShares { get; set; }
        public Decimal Price { get; set; }
        public StockTransactionType TransactionType { get; set; }

        public StockPortfolio StockPortfolio { get; set; }

        public Stock Stock { get; set; }


        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal ExtendedPrice
        {
            get { return NumberOfShares * Price; }
            set { }

        }
    }
}
