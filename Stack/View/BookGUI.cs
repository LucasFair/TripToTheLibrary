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
			Console.WriteLine("Welcome Hon's Library!\nHere you can borrow books and check which " +
				"books you have borrowed!\n");
		}
		public void BookMenu()
		{
			Console.WriteLine("Please press the corresponding key to navigate the menu:\n" +
				"(1) - Borrow books\n(2) - Check borrowed books\n(0) - Exit application\n");
		}

		public void AddBook()
		{
			Console.WriteLine("Type the number of the book you you want to borrow:\n");
		}
		public void HowToExitApplication()
		{
			Console.WriteLine("Press 0 to exit the application.");
		}
		public void AddMore()
		{
			Console.WriteLine("Press backspace to return to the front page.\n" +
				"Otherwise press any key to add another book.\n");
		}

		public void ShowBooks(List<Book> onShelf)
		{
			Console.Clear();

			foreach (Book book in onShelf)
			{
				Console.WriteLine("Book No.:\n{0}", book.IdNum);
				Console.WriteLine("Title:\n{0}", book.Title);
				Console.WriteLine("Author:\n{0}", book.Author);
				Console.WriteLine("Year:\n{0}", book.YearRelease);
				Console.WriteLine("Revision:\n{0}", book.Revision + "\n");
				Console.WriteLine(string.Empty);
			}
		}

		public void ShowBorrowedBooks(Stack<Book> onShelf)
		{
			Console.Clear();
			Console.WriteLine("Here's what you've borrowed:\n");

			foreach (Book book in onShelf)
			{
				Console.WriteLine("Book No.:\n{0}", book.IdNum);
				Console.WriteLine("Title:\n{0}", book.Title);
				Console.WriteLine("Author:\n{0}", book.Author);
				Console.WriteLine("Year:\n{0}", book.YearRelease);
				Console.WriteLine("Revision:\n{0}", book.Revision + "\n");
				Console.WriteLine(string.Empty);
			}
		}
		public void BorrowCheck(Book book)
		{
			Console.WriteLine("{0} by {1} was borrowed by you.\n");
		}

		public ConsoleKey UserInput()
		{
			var key = Console.ReadKey(true).Key;
			return key;
		}
		public byte ByteInput()
		{
			return byte.Parse(Console.ReadLine());
		}

		public void InvalidInput()
		{
			Console.WriteLine("The input is invalid!");
		}
	}
}
