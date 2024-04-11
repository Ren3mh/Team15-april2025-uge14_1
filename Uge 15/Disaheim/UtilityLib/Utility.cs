using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Disaheim;

namespace UtilityLib
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
		public Utility(Course course)
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

		public static double GetValueOfCourse(Course course)
		{
			double påbegyndtTime = 0;
			double timePris = 875.00;
            double remain = (course.DurationInMinutes % 60);
			if (remain > 0) 
			{
				påbegyndtTime = 1;
			}


			double påbegyndtTimeTotal = (course.DurationInMinutes / 60) + påbegyndtTime;
            return (påbegyndtTimeTotal) * timePris;
		}
	}
}
