namespace Algoritme
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string fileName = "students.txt";

			List<Student> students = Filehandler.ReadStudensFromFile(fileName);

			string fileName2 = "BubbleStudents.txt";
			SorteringsAlgoritmer.BubbleSort(students);
			Filehandler.WriteStudentsToFile(students, fileName2);
		}
	}
}
