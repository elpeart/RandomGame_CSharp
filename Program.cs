using System;

namespace RandomGame
{
	class Program
	{
		static void Main(string[] args)
		{
			int randomNumber = 62;
			int guess;
			int numGuesses = 0;

			do
			{
				Console.WriteLine("Enter your guess");
				guess = Convert.ToInt32(Console.ReadLine());
				numGuesses++;

				if (guess == randomNumber)
				{
					Console.WriteLine("You Win!");
				}
				else if (guess > randomNumber)
				{
					Console.WriteLine("Too high");
				}
				else if (guess < randomNumber)
				{
					Console.WriteLine("Too low");
				}

				if (numGuesses > 10)
				{
					Console.WriteLine("You Lose!");
					break;
				}
			}
			while (guess != randomNumber);
		}
	}
}
