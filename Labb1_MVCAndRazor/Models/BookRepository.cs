using System.Collections.Generic;

namespace Labb1_MVCAndRazor.Models
{
    public class BookRepository : IBookRepository
    {
        private readonly AppDbContext _appDbContext;

        public BookRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Book> GetAllBooks
        {
            get
            {
                return _appDbContext.Books;
            }
        }
    }
}
