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
		BookGUI bookView = new BookGUI();
		BookStatus bookStat = new BookStatus();
		public void Run()
		{
			bookStat.BookList();
			bookView.Welcome();
			MenuScreen();
		}
		public void MenuScreen()
		{
			bookView.BookMenu();
			MenuNavigation();
		}
		public void MenuNavigation()
		{
			var navIn = bookView.UserInput();

			switch (navIn)
			{
				case ConsoleKey.D1:
					BorrowBook();
					break;
				case ConsoleKey.D2:
					CheckBorrowed();
					break;
				case ConsoleKey.D0:
					Environment.Exit(0);
					break;
				default:
					break;

			}
		}

		public void CheckBorrowed()
		{
			//bookView.BorrowCheck(bookStat.GetBorrow());
			bookView.AddBook();

			while (true)
			{
				switch (bookView.UserInput())
				{
					case ConsoleKey.Backspace:
						MenuScreen();
						break;
					case ConsoleKey.D1:
						BorrowBook();
						break;
					case ConsoleKey.D0:
						Environment.Exit(0);
						break;

				}
			}

		}
		public void BorrowBook()
		{
			while (true)
			{
				bookView.ShowBooks(bookStat.GetCheckout());
				bookView.AddBook();
			}
		}

		public void SelectBook()
		{
			byte selectNum = 0;

			while (true)
			{
				selectNum = bookView.ByteInput();
				var book = bookStat.RemoveBookByIndex(selectNum);
				bookStat.BorrowBook(book);
			}
		}
	}
}
