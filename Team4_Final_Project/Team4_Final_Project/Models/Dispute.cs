namespace Team4_Final_Project.Models
{
    public enum DisputeStatus { Resolved, Unresolved }
    public class Dispute
    {
        public Int32 DisputeID { get; set; }
        public string Comment { get; set; }
        public DisputeStatus Status { get; set; }
        public Transaction Transaction { get; set; }

    }
}
