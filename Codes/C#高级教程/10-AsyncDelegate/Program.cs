using System;
using System.Threading;

namespace _10_AsyncDelegate
{
	internal class Program
	{
		static void Test()
		{
			Console.WriteLine("Test Started");


			Console.WriteLine("Test Running");
			Thread.Sleep(3000);

			Console.WriteLine("Test Completed");
		}

		delegate void TestDelegate();

		static void Main(string[] args)
		{
			TestDelegate testDelegate = Test;

			//testDelegate();

			testDelegate.BeginInvoke(null, null);

			Console.WriteLine("Main Completed");

		}
	}
}
