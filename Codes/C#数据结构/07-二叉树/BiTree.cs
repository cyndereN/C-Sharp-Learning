using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_二叉树
{
	class BiTree<T>
	{

		private T[] data;
		private int count = 0;
		public BiTree(int capacity)// 这个参数是当前二叉树的容量，容量就是最多可以存储的数据个数， 数量count代表当前保存了多少个数据
		{
			data = new T[capacity];
		}
		public bool Add(T item)
		{
			if (count >= data.Length)
				return false;
			data[count] = item;
			count++;
			return true;
		}

		public void FirstTraversal()
		{
			FirstTraversal(0);
		}
		private void FirstTraversal(int index)
		{
			if (index >= count) return;
			//得到要遍历的这个结点的编号 
			int number = index + 1;
			if (data[index].Equals(-1)) return;
			Console.Write(data[index] + " ");
			//得到左子结点的编号
			int leftNumber = number * 2;
			int rightNumber = number * 2 + 1;
			FirstTraversal(leftNumber - 1);
			FirstTraversal(rightNumber - 1);
		}

		public void MiddleTraversal()
		{
			MiddleTraversal(0);
		}
		private void MiddleTraversal(int index)
		{
			if (index >= count) return;
			//得到要遍历的这个结点的编号 
			int number = index + 1;
			if (data[index].Equals(-1)) return;
			//得到左子结点的编号
			int leftNumber = number * 2;
			int rightNumber = number * 2 + 1;
			MiddleTraversal(leftNumber - 1);
			Console.Write(data[index] + " ");
			MiddleTraversal(rightNumber - 1);
		}

		public void LastTraversal()
		{
			LastTraversal(0);
		}
		private void LastTraversal(int index)
		{
			if (index >= count) return;
			//得到要遍历的这个结点的编号 
			int number = index + 1;
			if (data[index].Equals(-1)) return;
			//得到左子结点的编号
			int leftNumber = number * 2;
			int rightNumber = number * 2 + 1;
			LastTraversal(leftNumber - 1);
			LastTraversal(rightNumber - 1);
			Console.Write(data[index] + " ");
		}

		public void LayerTraversal()
		{
			for (int i = 0; i < count; i++)
			{
				if (data[i].Equals(-1)) continue;
				Console.Write(data[i] + " ");
			}
			Console.WriteLine();
		}
	}
}
