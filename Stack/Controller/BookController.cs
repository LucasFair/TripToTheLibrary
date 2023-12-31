﻿using Stack.Model;
using Stack.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack.Controller
{
	/// <summary>
	/// Class <c>BookController</c> contains all the methods and inputs for the application.
	/// </summary>
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
			bookView.ShowBorrowedBooks(bookStat.GetBorrow());
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
				//bookView.HowToExitApplication();
				SelectBook();
				bookView.AddBook();
				BorrowMore();
			}
		}
		public void BorrowMore()
		{
			bookView.AddMore();

			var select = bookView.UserInput();

			if (select != ConsoleKey.Backspace)
				return;
			else
				MenuScreen();
		}

		public void SelectBook()  // If the input isn't valid, it will show an error message.
		{
			byte selectNum = 0;

			try
			{
				selectNum = bookView.ByteInput();
				var book = bookStat.RemoveBookByIndex(selectNum);
				bookStat.BorrowBook(book);
			}
			catch
			{
				bookView.InvalidInput();
			}
			return;
		}
	}
}
