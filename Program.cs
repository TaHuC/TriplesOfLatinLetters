using System;

namespace TriplesOfLatinLetters
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());

			for (int first = 0; first < n; first++)
			{
				for (int second = 0; second < n; second++)
				{
					for (int last = 0; last < n; last++)
					{
						char latter1 = (char)('a' + first);
						char latter2 = (char)('a' + second);
						char latter3 = (char)('a' + last);

						Console.WriteLine("{0}{1}{2}", latter1, latter2, latter3);
					}
				}
			}
		}
	}
}
