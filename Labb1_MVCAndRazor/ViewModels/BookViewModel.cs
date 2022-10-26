using Labb1_MVCAndRazor.Models;
using System.Collections.Generic;

namespace Labb1_MVCAndRazor.ViewModels
{
    public class BookViewModel
    {
        public IEnumerable<Book> Books { get; set; }
    }
}
