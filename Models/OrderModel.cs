using System;

namespace OrderWebApp.Models
{
    public class Order
    {
        public String   SenderCity { get; set; }
        public String   SenderAddress { get; set; }
        public String   RecipientCity { get; set; }
        public String   RecipientAddress { get; set; }
        public int      PackageWeightInkilograms { get; set; }
        public DateTime PackagePickUpDate { get; set; }

    }
}
