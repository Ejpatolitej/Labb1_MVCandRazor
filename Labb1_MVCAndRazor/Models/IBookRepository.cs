using System.Collections.Generic;

namespace Labb1_MVCAndRazor.Models
{
    public interface IBookRepository
    {
        IEnumerable<Book> GetAllBooks { get; }
    }
}
