using System;

namespace UserInput
{
	class UserInt
	{
		public static int Get()
		{
			int guess;
			try
			{
				guess = Convert.ToInt32(Console.ReadLine());
			}
			catch (FormatException e)
			{
				guess = 101;
			}
			return guess;
		}
	}
}

