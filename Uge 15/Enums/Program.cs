namespace Enums
{
	internal class Program
	{
		enum chess 
		{ 
			pawns = 0,
			bishops = 1,
			rook = 2,
			knight = 3,
			queen = 4,
			king = 5,
		}


		static void Main(string[] args)
		{
			chess piece = chess.queen;
		switch(piece)
			{
				case chess.bishops:
				Console.WriteLine("Du har en løber");
					break;
				case chess.rook:
					Console.WriteLine("Du har et tårn");
					break;
				case chess.pawns:
					Console.WriteLine("Du har en bønde");
					break;
				case chess.knight:
					Console.WriteLine("Du har en springer");
					break;
				case chess.queen:
					Console.WriteLine("Du har en dronning");
					break;
				case chess.king:
					Console.WriteLine("Du har en konge");
					break;
			}


			Console.ReadLine();
		}
	}
}
