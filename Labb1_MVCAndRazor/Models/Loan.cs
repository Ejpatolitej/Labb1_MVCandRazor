using System.Collections.Generic;

namespace Labb1_MVCAndRazor.Models
{
    public class Loan
    {
        public int LoanID { get; set; }
        public int BookID { get; set; }
        public Book book { get; set; }
        public int CustomerID { get; set; }
        public Customer customer { get; set; }
        public bool IsReturned { get; set; }

    }
}
