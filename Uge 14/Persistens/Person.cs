using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistens
{
	public class Person
	{
		public string Name;
		public DateTime BirthDate;
		public double Height;
		public bool IsMarried;
		public int NoOfChildren;
		public string title;


		public Person()
		{

		}

		public Person(string name, DateTime birthDate, double height, bool isMarried, int noOfChildren)
        {
            Name = name;
            BirthDate = birthDate;
            Height = height;
			IsMarried = isMarried;
			NoOfChildren = noOfChildren;
        }

		public string MakeTitle()
		{
			//string bDay = BirthDate.ToString();
			//string hgt = Height.ToString();
			//string iM = IsMarried.ToString


			return Name + ";" + BirthDate.ToString() + ";" + Height.ToString() +";"+ IsMarried.ToString() + ";" + NoOfChildren.ToString();
		}
    }
}
	