using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Persistens
{
	public class DataHandler
	{
		private string dataFileName;

		public string DataFileName
		{
			get { return dataFileName; }
		}

		public DataHandler (string DataFileName)
		{
			dataFileName = DataFileName;				

		}
		public void SavePerson(Person person)
		{
			string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

			string textOutput = person.MakeTitle();
			// string[] textOutput = person.title.Split(';');

			using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, dataFileName)))
				//foreach (string value in textOutput)	
				outputFile.WriteLine(textOutput);
		}


		public void SavePersons(Person person)
		{
			Console.WriteLine("Vil du indlæse en ny person? y eller n");
			string choice = Console.ReadLine();
			while (choice != "n")
			{

				string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

				string textOutput = person.MakeTitle();

				using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, dataFileName), true))

					outputFile.WriteLine(textOutput);
				
				Console.WriteLine("Vil du indlæse endnu en person?");
				choice = Console.ReadLine();
			}		
			
		}

		public Person LoadPerson()
		{
			Person loadedPerson = new Person();
			string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

			using (StreamReader reader = new StreamReader(Path.Combine(docPath, dataFileName)))
			{
				string Line = reader.ReadLine();
				string[] LineParts = Line.Split(';');
				loadedPerson.Name = LineParts[0];
				loadedPerson.BirthDate = DateTime.Parse(LineParts[1]);
				loadedPerson.Height = double.Parse(LineParts[2]);
				loadedPerson.IsMarried = bool.Parse(LineParts[3]);
				loadedPerson.NoOfChildren = int.Parse(LineParts[4]);

			}
			return loadedPerson;
        }

	}
}
