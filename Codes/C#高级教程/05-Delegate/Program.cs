// 如果要把方法当作参数来传递的话就要用到委托
// 简单来说委托是一个类型 这个类型可以赋值一个方法的引用
using System;

namespace _05_Delegate
{
	internal class Program
	{
		delegate void IntMethodInvoker(int x);
		delegate long TwoLong(long a, long b);
		delegate string GetAString();

		static void Main(string[] args)
		{
			IntMethodInvoker invoker = null;
			TwoLong invoker2 = null;

			invoker = Program.test;
			invoker(100);
			if (invoker2 != null)
			{
				invoker2(2, 23);
			}


			int x = 1123;
			GetAString getAString = x.ToString;
			Console.WriteLine(getAString());

			getAString = new GetAString(x.ToString);
			Console.WriteLine(getAString());

			DoubleOpDelegate[] operations = { MathOp.MultiplayByTwo, MathOp.Square };
			foreach (DoubleOpDelegate op in operations)
			{
				//Console.WriteLine(op(3));
				ProcessAndDisplayRes(op, 4);
			}

			// action
			Action method = Test1;
			method();

			Action<int> method2 = Test2;
			method2(324);

			Action<int, double> method3 = Test3;
			method3(34, 213.4);

			// func 
			Func<string> f = TestFunc1;
			Console.WriteLine(f());

			Func<int, double, string> f2 = TestFunc2;
			Console.WriteLine(f2(3, 4));
		}

		delegate double DoubleOpDelegate(double x);

		static void ProcessAndDisplayRes(DoubleOpDelegate op, double value)
		{
			double result = op(value);
			Console.WriteLine("Result:" + result);
		}

		private static void test(int x)
		{
			Console.WriteLine("我是test方法：" + x);
		}

		// aciton 委托：返回值为void
		private static void Test1()
		{
			Console.WriteLine("test1");
		}
		private static void Test2(int x)
		{
			Console.WriteLine("test2" + x);
		}
		private static void Test3(int x, double y)
		{
			Console.WriteLine("test3" + x + y);
		}

		// func 委托：必须指向有返回值的
		private static string TestFunc1()
		{
			return "testfunc";
		}
		private static string TestFunc2(int x, double y)
		{
			return "testfunc" + x + y;
		}
	}
}

