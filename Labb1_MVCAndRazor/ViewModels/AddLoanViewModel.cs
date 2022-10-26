using Labb1_MVCAndRazor.Models;
using System.Collections;
using System.Collections.Generic;

namespace Labb1_MVCAndRazor.ViewModels
{
	public class AddLoanViewModel
	{
		public int CustomerId { get; set; }
		public IEnumerable<Book> Books { get; set; }
		public int BookId { get; set; }
	}
}
