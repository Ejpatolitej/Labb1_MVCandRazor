using Labb1_MVCAndRazor.Models;
using System.Collections;
using System.Collections.Generic;

namespace Labb1_MVCAndRazor.ViewModels
{
    public class CustomerViewModel
    {
        public Customer customer { get; set; }
        public IEnumerable<Customer> Customers { get; set; }
        public IEnumerable<Loan> Loans { get; set; }
        public IEnumerable<Book> Books { get; set; }
    }
}
