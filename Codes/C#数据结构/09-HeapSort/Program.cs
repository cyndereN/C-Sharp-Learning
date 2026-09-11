using System;

namespace _09_HeapSort
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] data = { 50, 10, 90, 30, 70, 40, 80, 60, 20 };
			HeapSort(data);
			foreach (int i in data)
			{
				Console.Write(i + " ");
			}
			Console.WriteLine();

			Console.ReadKey();
		}

		public static void HeapSort(int[] data)
		{
			for (int i = data.Length / 2; i >= 1; i--)//遍历这个数的所有非叶结点 ，挨个把所有的子树，变成子大顶堆
			{
				HeapAjust(i, data, data.Length);
				//经过上面的for循环，是把二叉树变成了大顶堆

			}

			for (int i = data.Length; i > 1; i--)
			{//把 编号1 和编号i位置进行交换 
			 // 1 到 (i-1)构造成大顶堆
				int temp1 = data[0];
				data[0] = data[i - 1];
				data[i - 1] = temp1;
				HeapAjust(1, data, i - 1);
			}

		}

		private static void HeapAjust(int numberToAjust, int[] data, int maxNumber)
		{
			int maxNodeNumber = numberToAjust;//最大结点的编号
			int tempI = numberToAjust;
			while (true)
			{
				//把i结点的子树变成大顶堆
				int leftChildNumber = tempI * 2;
				int rightChildNumber = leftChildNumber + 1;
				if (leftChildNumber <= maxNumber && data[leftChildNumber - 1] > data[maxNodeNumber - 1])
				{
					maxNodeNumber = leftChildNumber;
				}
				if (rightChildNumber <= maxNumber && data[rightChildNumber - 1] > data[maxNodeNumber - 1])
				{
					maxNodeNumber = rightChildNumber;
				}
				if (maxNodeNumber != tempI)//发现了一个比i更大的子结点，交换i和maxnodenumber里面的数据
				{
					int temp = data[tempI - 1];
					data[tempI - 1] = data[maxNodeNumber - 1];
					data[maxNodeNumber - 1] = temp;
					tempI = maxNodeNumber;
				}
				else
				{
					break;
				}
			}
		}
	}
}
