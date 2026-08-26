#define IsShowMessage
//宏
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// attribute: 允许向程序的程序集增加元数据
namespace _09_Attribute
{

	[Info("SiKi", "v1.1", "这个是用来发射核弹的类")]
	internal class Program
	{
		[Obsolete("这个方法弃用了，请使用最新的NewTest方法")] //特性：弃用
		static void Test()
		{
			Console.WriteLine("test");
		}
		static void NewTest()
		{
			Console.WriteLine("NewTest");
		}

		[Conditional("IsShowMessage")]
		static void ShowMessage(string str)
		{
			Console.WriteLine(str);
		}

		[DebuggerStepThrough]
		static void ShowDBGMessage(string message, [CallerLineNumber] int lineNumber = 0, 
			[CallerFilePath] string filePath = "", [CallerMemberName] string memberName = "")
		{
			Console.WriteLine(message);
			Console.WriteLine(lineNumber);
			Console.WriteLine(filePath);
			Console.WriteLine(memberName);
		}
		static void Main(string[] args)
		{
			Test();
			Test();
			ShowMessage("Start of Main");

			Console.WriteLine("Doing work in main");

			ShowMessage("End Of Main");

			ShowDBGMessage("Hello");

			//---
			Type t = typeof(Program);

			bool result = t.IsDefined(typeof(InfoAttribute), false);
			Console.WriteLine(result);

			object[] attributeArray = t.GetCustomAttributes(false);
		}
	}
}
