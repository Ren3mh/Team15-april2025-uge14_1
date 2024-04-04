﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritme
{
	public class Student
	{
		public string FullName { get; set; }
		public int GroupNumber { get; set; }

		public Student(string fullName, int groupNumber)
		{
			FullName = fullName;
			GroupNumber = groupNumber;
		}

		public string MakeTitle()
		{
			return FullName + ", " + GroupNumber;
		}
	}
}
