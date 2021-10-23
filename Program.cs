using System;
using UserInput;

namespace RandomGame
{
	class Program
	{
		static void Main(string[] args)
		{
			Random rnd = new Random();
			int randomNumber = rnd.Next(101); // random integers from 0 to 100
			int guess;
			int numGuesses = 0; // counter

			do
			{
				Console.WriteLine("Enter your guess");
				guess = UserInt.Get(); // retrieve user guess
				numGuesses++;

				if (guess == randomNumber)
				{
					Console.WriteLine("You Win!");
				}
				else if (guess > 100 || guess < 0)
				{
					Console.WriteLine("You must enter an integer in [0,100]");
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
