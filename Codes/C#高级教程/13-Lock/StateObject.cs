using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _13_Lock
{
	internal class StateObject
	{
		private Object _lock1 = new Object();
		private Object _lock2 = new Object();


		private int state1 = 5;
		private int state2 = 5;


		public void ChangeState1()
		{
			lock (_lock1) //死锁
			{
				Console.WriteLine(Thread.CurrentThread.ManagedThreadId + "拿到了第1把锁");
				lock (_lock2)
				{
					Console.WriteLine(Thread.CurrentThread.ManagedThreadId + "拿到了第2把锁");
					if (state1 == 5)
					{
						state1++;//读写
						Console.WriteLine("State1 :" + state1 + " :" + Thread.CurrentThread.ManagedThreadId);
					}
					state1 = 5;

					if (state2 == 5)
					{
						state2++;//读写
						Console.WriteLine("State2 :" + state2 + " :" + Thread.CurrentThread.ManagedThreadId);
					}
					state2 = 5;
				}

			}
		}
		public void ChangeState2()
		{
			lock (_lock1) //死锁
			{
				Console.WriteLine(Thread.CurrentThread.ManagedThreadId + "拿到了第1把锁");
				lock (_lock2)
				{
					Console.WriteLine(Thread.CurrentThread.ManagedThreadId + "拿到了第2把锁");
					if (state1 == 5)
					{
						state1++;//读写
						Console.WriteLine("State1 :" + state1 + " :" + Thread.CurrentThread.ManagedThreadId);
					}
					state1 = 5;

					if (state2 == 5)
					{
						state2++;//读写
						Console.WriteLine("State2 :" + state2 + " :" + Thread.CurrentThread.ManagedThreadId);
					}
					state2 = 5;
				}

			}
		}
	}
}
