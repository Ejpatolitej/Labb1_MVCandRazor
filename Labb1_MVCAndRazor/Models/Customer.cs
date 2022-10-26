using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Labb1_MVCAndRazor.Models
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }

        [Required]
        [StringLength(100)]
        public string CustomerName { get; set; }

        [Required]
        [EmailAddress]
        public string CustomerEmail { get; set; }

        [Required]
        public string CustomerPhone { get; set; }

        public List<Loan> Loans { get; set; }

    }
}
