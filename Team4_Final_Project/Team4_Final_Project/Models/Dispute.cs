using System.ComponentModel.DataAnnotations;

namespace Team4_Final_Project.Models
{
    public enum DisputeStatus { Submitted, Accepted, Rejected, Adjusted }
    public class Dispute
    {
        public Int32 DisputeID { get; set; }
        [Required]
        public string Note { get; set; }

        public string AdminNote { get; set; }
        [Required]
        public DisputeStatus Status { get; set; }
        [Required]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public Decimal CorrectAmount { get; set; }
        [Required]
        public Transaction Transaction { get; set; }

    }
}
