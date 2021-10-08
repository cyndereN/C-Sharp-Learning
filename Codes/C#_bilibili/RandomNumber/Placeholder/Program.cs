using System;

namespace Placeholder
{
	class Program
	{
		static void Main(string[] args)
		{
			int n1 = 20;
			int n2 = 30;

			Console.WriteLine("我{0}了，再过10年我就{1}了", n1, n2);
			Console.WriteLine($"我{n2}了，10年前我{n1}了");
		}
	}
}
