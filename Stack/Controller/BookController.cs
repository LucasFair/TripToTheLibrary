using Stack.Model;
using Stack.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack.Controller
{
	public class BookController
	{
		BookGUI bookGUI = new BookGUI();
		BookStatus bookStat = new BookStatus();
		public void Run()
		{
			bookStat.BookList();
			bookGUI.ShowBooks(bookStat.GetCheckout());
		}
	}
}
