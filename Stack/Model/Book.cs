using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack.Model
{
	public class Book
	{
		private string _title;
		private string _author;
		private short _yearRelease;
		private byte _revision;
		private ushort _idNum;

		public string Title
		{
			get { return _title; }
			set { _title = value; }
		}
		public string Author
		{
			get { return _author; }
			set { _author = value; }
		}
		public short YearRelease
		{
			get { return _yearRelease; }
			set { _yearRelease = value; }
		}
		public byte Revision
		{
			get { return _revision; }
			set { _revision = value; }
		}
		public ushort IdNum
		{
			get { return _idNum; }
			set { _idNum = value; }
		}

		public Book()
		{
			_title = "";
			_author = "";
			_yearRelease = 0;
			_revision = 0;
			_idNum = 0;
		}

		public Book(string title, string author)
		{
			_title = title;
			_author = author;
		}
		public Book(string title, string author, short yearRelease, byte revision) : this(title, author)
		{
			_yearRelease = yearRelease;
			_revision = revision;
		}
		public Book(string title, string author, short yearRelease, byte revision, ushort idNum) : this(title, author, yearRelease, revision)
		{
			_idNum = idNum;
		}
	}
}