using System.Collections;
using System.Collections.Generic;

namespace Labb1_MVCAndRazor.Models
{
    public interface ICustomerRepository
    {
        IEnumerable<Customer> GetAllCustomers { get; }
        Customer GetCustomerById(int customerId);
    }
}
