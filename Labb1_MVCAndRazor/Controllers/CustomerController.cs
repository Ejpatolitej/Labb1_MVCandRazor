using Labb1_MVCAndRazor.Models;
using Labb1_MVCAndRazor.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace Labb1_MVCAndRazor.Controllers
{
    public class CustomerController : Controller
    {
        private readonly AppDbContext _appDbContext;
        private readonly ICustomerRepository _customerRepository;

        public CustomerController(ICustomerRepository customerRepository, AppDbContext appDbContext)
        {
            _customerRepository = customerRepository;
            _appDbContext = appDbContext;
        }

        public ViewResult Index()
        {
            IEnumerable<Customer> customers;

            customers = _customerRepository.GetAllCustomers;

            return View(new CustomerViewModel { Customers = customers });
        }

        public IActionResult Details(int id)
        {
            var customer = _customerRepository.GetCustomerById(id);
            if (customer == null)
            {
                return NotFound();
            }
            return View(customer);
        }

        public ViewResult AddCustomer()
        {
            return View();
        }

        public ViewResult NewLoan(int id)
        {
            AddLoanViewModel addLoanViewModel = new AddLoanViewModel
            {
                CustomerId = id,
                Books = _appDbContext.Books
            };
            return View(addLoanViewModel);
        }

        public ViewResult UpdateCustomer(int id)
        {
            Customer customer = _customerRepository.GetCustomerById(id);
            return View(customer);
        }

        [HttpPost]
        public async Task<IActionResult> AddCustomer(Customer customer)
        {
            _appDbContext.Add(customer);
            await _appDbContext.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public async Task<IActionResult> UpdateCustomer(Customer customer)
        {
            var customerToUpdate = await _appDbContext.Customers.FindAsync(customer.CustomerID);
            if (customerToUpdate == null)
            {
                return BadRequest("Customer not found.");
            }

            customerToUpdate.CustomerName = customer.CustomerName;
            customerToUpdate.CustomerEmail = customer.CustomerEmail;
            customerToUpdate.CustomerPhone = customer.CustomerPhone;

            _appDbContext.Update(customerToUpdate);
            await _appDbContext.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteCustomer(int id)
        {
            var customerToDelete = await _appDbContext.Customers.FindAsync(id);
            _appDbContext.Customers.Remove(customerToDelete);
            await _appDbContext.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> ReturnBook(int loanId, int customerId)
        {
            var bookToReturn = await _appDbContext.Loans.FindAsync(loanId);
            bookToReturn.IsReturned = true;
            await _appDbContext.SaveChangesAsync();
            return RedirectToAction(nameof(Details), new {id=customerId});
        }

        public async Task<IActionResult> AddLoan(int bookId, int customerId)
        {
            var bookToLoan = await _appDbContext.Loans.AddAsync(new Loan { BookID = bookId, CustomerID = customerId, IsReturned = false });
            await _appDbContext.SaveChangesAsync();
            return RedirectToAction(nameof(Details), new { id = customerId });
        }
    }
}
