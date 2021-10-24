using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber
{
	class Program
	{
		static Random random = new Random();
		static int GenRandomInt()
		{
			var number = random.Next(0, 100);
			return number;
		}

		static int totalCount = 0;
		static void Main(string[] args)
		{
			int systemNumber = GenRandomInt();
			Console.WriteLine(systemNumber);
			while (true)
			{
				Console.WriteLine("Please input a number between 0 and 99: ");
				totalCount++;
				var inputStr = Console.ReadLine();
				int inputNumber = int.Parse(inputStr);
				if (inputNumber == systemNumber)
				{
					Console.WriteLine($"You've only guessed {totalCount} times to get the right ansewer!");
					break;
				} 
				else
				{
					
					if (inputNumber > systemNumber )
					{
						Console.WriteLine("Too big.");
					}
					else
					{
						Console.WriteLine("Too small.");
					}
				}
			}
			Console.ReadLine();
		}
	}
}
