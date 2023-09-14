using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack.Model
{
	/// <summary>
	/// Class <c>BookStatus</c> contains the data for the available books and the checked out books.
	/// It also contains the book make-data, meaning, the added books, and takes into index and push to stack,
	/// as well as peek, into account.
	/// </summary>
	public class BookStatus
	{

		List<Book> onShelf = new List<Book>();

		Stack<Book> offShelf = new Stack<Book>();

		public List<Book> GetCheckout()
		{ return onShelf; }
		public Stack<Book> GetBorrow()
		{ return offShelf; }

		public void BookList()
		{
			onShelf.Add(new Book("Deneb, Altair & Vega: The Triangle of Love", "Zanarkand, Jonas", 1989, 3, 0));
			onShelf.Add(new Book("Lack of Sleep, Lack of Focus, Lack of Help <A Self-Help Guide>", "天津飯", 1990, 1, 1));
			onShelf.Add(new Book("Deodorant vs Cologne", "DJ COOL", 2008, 15, 2));
			onShelf.Add(new Book("The Stack is Rising - Overflowing", "Klik, Rune", 1994, 1, 3));
			onShelf.Add(new Book("Headache", "Ali, Lucas", 1867, 2, 4));
		}

		public void BorrowBook(Book book)
		{
			offShelf.Push(book);
		}

		public void PeekAtBookStack()
		{
			offShelf.Peek();
		}

		public Book RemoveBookByIndex(byte bookIndex)
		{
			bookIndex -= 1;
			var book = onShelf[bookIndex];
			onShelf.RemoveAt(bookIndex);

			return book;
		}


	}
}
