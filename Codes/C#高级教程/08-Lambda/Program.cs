using System;

namespace _08_Lambda
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Func<int, int, int> plus = delegate (int a, int b)
			//{
			//	return a + b;
			//};
			//Func<int, int, int> plus = (a, b) => { return a + b; };
			Func<int, int, int> plus = (a, b) => a + b;
			int res = plus(1, 2);
			Console.WriteLine(res);

			Func<double, double> square = x => x * x;

			int a = 5;
			Func<int, int> f = x => x + a;
			Console.WriteLine(f(4));
			a = 8;
			Console.WriteLine(f(4));

			TestDelegate td = Test1;
			td += Test2;


			td();
		}

		// 事件是基于委托的 具有一种特殊签名的委托，为委托提供了发布/订阅机制，是受限制的委托（主要为了安全性吧）q
		static event TestDelegate td;
		private delegate void TestDelegate();
		private static void Test1() { Console.WriteLine("1"); }
		private static void Test2() { Console.WriteLine("2"); }
	}
}
