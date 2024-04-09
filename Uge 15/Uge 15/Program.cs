namespace Uge_15
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/* string[] names = { "Anders", "Søren", "Kenneth", "Mark", "Sebastian" };

			for (int i = 0; i < names.Length; i++)
			{
				Console.WriteLine(names[i]);
			}
			foreach (string name in names) 
			{ 
				Console.WriteLine(name);
			}
			*/

			List<Friend> friends = new List<Friend>();

			/* 
			 * friends.Add(new Friend("Fido"));
			friends.Add(new Friend("Sofus"));

			Console.WriteLine("Skriv navnet på den nye ven");
			friends.Add(new Friend(Console.ReadLine()));
			*/
			string linie = "";

			while (1 == 1)
			{
				
				linie = Console.ReadLine();
				if (linie == "slut")
					break;
				friends.Add(new Friend(linie));
				Console.Clear();
				//for (int i = 0; i < friends.Count; i++)
				//{
				//	Console.WriteLine(friends[i].name);
				//}
				foreach (Friend friend in friends)
				{
					Console.WriteLine(friend.name);
				}
			}
			Console.ReadLine();
		}

		class Friend 
		{
			public string name;

			public Friend(string name)
			{
				this.name = name;
			}	
		}

	}
}
