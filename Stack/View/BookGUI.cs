using Stack.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Stack.View
{
	internal class BookGUI
	{
		public void Welcome()
		{
            Console.WriteLine("Welcome Hon's Library!\nHere you borrow books and check which " +
				"books you have borrowed!\n");
        }
		public void BookMenu()
		{
            Console.WriteLine("Please press the corresponding key to navigate the menu:\n" +
				"(1) - Borrow books\n(2) - Check borrowed books\n");
        }
		public void AddMore()
		{
            Console.WriteLine("(Backspace) - Return to the menu screen");
        }

		public void ShowBooks(List<Book> onShelf)
		{

			foreach (Book book in onShelf)
			{
				Console.WriteLine("Book No.:\n{0}", book.IdNum);
				Console.WriteLine("Title:\n{0}", book.Title);
				Console.WriteLine("Author:\n{0}", book.Author);
				Console.WriteLine("Year:\n{0}", book.YearRelease);
				Console.WriteLine("Revision:\n{0}", book.Revision);
			}
		}

		public ConsoleKey UserInput()
		{
			var key = Console.ReadKey(true).Key;
			return key;
		}
	}
}
