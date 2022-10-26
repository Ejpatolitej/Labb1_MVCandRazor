using System.Collections.Generic;

namespace Labb1_MVCAndRazor.Models
{
    public class Book
    {
        public int BookID { get; set; }
        public string Title { get; set; }
        public List<Loan> Loans { get; set; }

    }
}
