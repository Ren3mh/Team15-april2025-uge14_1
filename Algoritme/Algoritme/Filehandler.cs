using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritme
{
	public class Filehandler
	{
        private string dataFileName;

        public string DataFileName
        {
            get { return dataFileName; }
        }

        public Filehandler(string DataFileName)
        {
            dataFileName = DataFileName;

        }

        public static List<Student> ReadStudensFromFile(string dataFileName)
		{
			List<Student> students = new List<Student>();
			string line;
			try
			{
				using StreamReader sr = new StreamReader(dataFileName);
				line = sr.ReadLine();

				while (line != null)
				{
					string[] parts = line.Split(',');
					string fullName = parts[0];
					int groupNumber = int.Parse(parts[1]);
					students.Add(new Student(fullName, groupNumber));
					line = sr.ReadLine();
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("Fejl ved læsning" + ex.Message);
			}
			return students;
		}

		public static void WriteStudentsToFile(List<Student> students, string fileName2)
		{
			try
			{
				using (StreamWriter sw = new StreamWriter(fileName2))
				{
					foreach (var student in students)
					{
						sw.WriteLine($"{ student.FullName}, {student.GroupNumber}");
					}
				}
			}
			catch (Exception ex)
				{
				Console.WriteLine("Fejl:" + ex.Message);
				}
		}
	}
}
