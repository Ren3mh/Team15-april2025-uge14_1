using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritme
{
	public class DataHandler
	{
		private string dataFileName;

		public string DataFileName
		{
			get { return dataFileName; }
		}

		public DataHandler(string DataFileName)
		{
			dataFileName = DataFileName;

		}
		public void SaveStudent(Student student)
		{
			string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

			string textOutput = student.MakeTitle();
			// string[] textOutput = Student.title.Split(';');

			using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, dataFileName)))
				//foreach (string value in textOutput)	
				outputFile.WriteLine(textOutput);
		}


		public void SaveStudents(Student student)
		{
			Console.WriteLine("Vil du indlæse en ny Student? y eller n");
			string choice = Console.ReadLine();
			while (choice != "n")
			{

				string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

				string textOutput = student.MakeTitle();

				using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, dataFileName), true))

					outputFile.WriteLine(textOutput);

				Console.WriteLine("Vil du indlæse endnu en Student?");
				choice = Console.ReadLine();
			}

		}

		public Student LoadStudent(string fullName, int groupNumber)
		{
			Student loadedStudent = new Student(fullName, groupNumber);
			string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

			using (StreamReader reader = new StreamReader(Path.Combine(docPath, dataFileName)))
			{
				string Line = reader.ReadLine();
				string[] LineParts = Line.Split(',');
				loadedStudent.FullName = LineParts[0];
				loadedStudent.GroupNumber = int.Parse(LineParts[1]);

			}
			return loadedStudent;
		}

	}  
}