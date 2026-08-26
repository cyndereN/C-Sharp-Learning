using System;
using System.Threading;

namespace _11_Thread
{
	internal class Program
	{
		public struct Data
		{
			public string message;
			public int age;
		}

		static void Test()
		{
			Console.WriteLine("Started");
			Thread.Sleep(1000);
			Console.WriteLine("Completed");
		}
		static void Download(Object o)
		{
			//string str = o as string;
			Data data = (Data)o;//null
			Console.WriteLine(data.age);
		}
		static void ThreadMain()
		{
			Console.WriteLine("Thread +" + Thread.CurrentThread.Name + " started");
			Thread.Sleep(3000);
			Console.WriteLine("Thread +" + Thread.CurrentThread.Name + " end");
		}

		static void Main(string[] args)
		{
			//Thread t = new Thread(Test);
			//Thread t = new Thread(() => Console.WriteLine("Child Thread：" + Thread.CurrentThread.ManagedThreadId));
			//Thread t = new Thread(delegate () {

			//});
			//t.Start();
			//Console.WriteLine("Main completed:"+Thread.CurrentThread.ManagedThreadId);
			Data data = new Data();
			data.message = "";
			data.age = 12;

			Thread t = new Thread(Download);
			//t.Start("http://www.xxx.comn/xx/xx/xxx.mp4");
			t.Start(data);
			Console.WriteLine("Main completed:" + Thread.CurrentThread.ManagedThreadId);

			DownloadTool downloadTool = new DownloadTool("httpwx.xxxx/xx/xx", "sdfsfd");
			Thread t2 = new Thread(downloadTool.Download);
			t2.Start();

			var t3 = new Thread(ThreadMain) { IsBackground = true };
			// 前台结束 会扫描后台线程结束掉
			t3.Start();
			Console.WriteLine("Main thread ending now.");
			//t3.Abort();

			//Student student = new Student(20, "战三");
			//Student student2 = new Student() { Age = 15, Name = "Micheal" };

			Thread a = new Thread(A);
			Thread b = new Thread(B);

			a.Priority = ThreadPriority.Highest;
			b.Priority = ThreadPriority.Lowest;

			//a.Start();
			//b.Start();

			// 线程池所有线程都是后台
			// 不能给入池的线程设置优先级或名称
			for (int i = 0; i < 10; i++)
			{
				ThreadPool.QueueUserWorkItem(Download);
			}
			Thread.Sleep(5000);
		}

		static void DownloadPool(Object state)
		{
			for (int i = 0; i < 3; i++)
			{
				Console.WriteLine("DownLoading ...:" + Thread.CurrentThread.ManagedThreadId);
				Thread.Sleep(100);
			}
		}

		static void A()
		{
			while (true)
			{
				Console.Write("A");
			}
		}
		static void B()
		{
			while (true)
			{
				Console.Write("B");
			}
		}

	}
}
