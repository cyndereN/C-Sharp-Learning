using System;
using System.Threading.Tasks;
using System.Threading;

namespace _12_Task
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//static void Test()
			//{
			//    for(int i = 0; i < 10000; i++)
			//    {
			//        Console.Write("A");
			//    }
			//}

			static void FirstDownload()
			{
				Console.WriteLine("Downloading");
				Thread.Sleep(2000);
			}

			static void SecondAlert(Task t)
			{
				Console.WriteLine("什么什么下载完成");
			}

			static void Main(string[] args)
			{
				//TaskFactory tf = new TaskFactory();
				//Task t = tf.StartNew(Test);
				// TASK也是放到threadpool里面

				//Task t = new Task(Test);
				//t.Start();
				Task t1 = new Task(FirstDownload);

				Task t2 = t1.ContinueWith(SecondAlert);

				// Task t3 = t2.ContinueWith(SecondAlert);

				t1.Start();

				Thread.Sleep(5000);
			}
		}
	}
}
