using System;
using System.ComponentModel.DataAnnotations;

namespace OrderWebApp.Models
{
    public class Order
    {
        [Key]
        public String   Id { get; set; }
        [Required]
        public int      CreationId { get; set; }
        [Required]
        public String   Number { get; set; }
        [Required]
        public DateTime CreationDate { get; set; }
        [Required]
        public String   SenderCity { get; set; }
        [Required]
        public String   SenderAddress { get; set; }
        [Required]
        public String   RecipientCity { get; set; }
        [Required]
        public String   RecipientAddress { get; set; }
        [Required]
        public int      PackageWeightInkilograms { get; set; }
        [Required]
        public DateTime PackagePickUpDate { get; set; }
    }
}
