using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_栈
{
	internal interface IStackDS<T>
	{
		int Count { get; }//get data number
		int GetLength();
		bool IsEmpty();
		void Clear();
		void Push(T item);
		T Pop();
		T Peek();
	}
}
