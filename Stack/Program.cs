using Stack.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
	internal class Program
	{
		static void Main(string[] args)
		{
			BookController bookCtrl = new BookController();
			bookCtrl.Run();
		}
	}
}
