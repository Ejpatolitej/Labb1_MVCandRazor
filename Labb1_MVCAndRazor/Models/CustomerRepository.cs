using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Labb1_MVCAndRazor.Models
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly AppDbContext _appDbContext;

        public CustomerRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Customer> GetAllCustomers
        {
            get
            {
                return _appDbContext.Customers;
            }
        }

        public Customer GetCustomerById(int customerId)
        {
            return _appDbContext.Customers.Include(l => l.Loans)
                .ThenInclude(b => b.book)
                .FirstOrDefault(c => c.CustomerID == customerId);
        }
    }
}
