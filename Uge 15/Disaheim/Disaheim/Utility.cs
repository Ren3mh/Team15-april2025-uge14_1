using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
	public class Utility
	{
		public Utility()
		{
		
		}

		public Utility(Book book) 
		{ 
			
		}
		public Utility(Amulet amulet)
		{

		}

		public static Double GetValueOfBook(Book book)
		{
            return book.Price;
		}
		public static double GetValueOfAmulet(Amulet amulet)
		{
			if (amulet.Quality == Level.low)
				return 12.5;
			else if (amulet.Quality == Level.medium)
				return 20.0;
			else if (amulet.Quality == Level.high)
				return 27.5;
			else
				return 20.0;
		}
	}
}
