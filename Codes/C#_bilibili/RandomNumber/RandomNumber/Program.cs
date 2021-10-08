using System;

namespace RandomNumber
{
	class Program
	{
		static void Main(string[] args)
		{
			while (true)
			{
				Random r = new Random();
				int rNumber = r.Next(1, 11);  //1~10的随机数
				Console.WriteLine(rNumber);
				Console.ReadKey();
			}
			
		}
	}
}
