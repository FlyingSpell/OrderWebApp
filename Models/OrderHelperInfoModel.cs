using System;
using System.ComponentModel.DataAnnotations;

namespace OrderWebApp.Models
{
    public class OrderHelperInfo
    {
        [Key]
        public DateTime Date { get; set; }
        [Required]
        public int      CreatedOrdersAmount { get; set; }
    }
}
