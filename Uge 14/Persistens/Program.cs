using System.Xml.Linq;

namespace Persistens
{
	internal class Program
	{
		static void Main(string[] args)
		{
            //Person person = new Person("Anders Andersen", new DateTime(1975, 8, 24), 175.9, true, 3);

            // DataHandler handler = new DataHandler("Data.txt");
            //handler.SavePerson(person);

            //Console.Write("Writing person: ");
            //Console.WriteLine(person.MakeTitle());


            DataHandler handler = new DataHandler("Data.txt");
            handler.LoadPerson();

            Console.WriteLine("Hej gutter/inder");
            Console.ReadLine();	
		}
	}
}
