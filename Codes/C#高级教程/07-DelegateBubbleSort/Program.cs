using System;

namespace _06_DelegateBubbleSort
{
	internal class Program
	{
		private static void Sort(int[] sortArray)
		{
			bool swapped = true;
			do
			{
				swapped = false;
				for (int i = 0; i < sortArray.Length - 1; i++)
				{
					if (sortArray[i] > sortArray[i + 1])
					{
						int temp = sortArray[i];
						sortArray[i] = sortArray[i + 1];
						sortArray[i + 1] = temp;
						swapped = true;
					}
				}
			} while (swapped);
		}
		public static void Sort<T>(T[] data, Func<T, T, bool> compare)
		{
			bool swapped = true;
			do
			{
				swapped = false;
				for (int i = 0; i < data.Length - 1; i++)
				{
					if (compare(data[i], data[i + 1]))
					{
						T temp = data[i];
						data[i] = data[i + 1];
						data[i + 1] = temp;
						swapped = true;
					}
				}
			} while (swapped);
		}

		static void Main(string[] args)
		{
			//int[] sortArray = { 34, 3, 2, 3, 1, 4, 56, 6, 2, 34 };
			//Sort(sortArray);
			//foreach(int i in sortArray)
			//{
			//    Console.Write(i + " ");
			//}
			Employee[] employees = {
				new Employee("Bunny",20000),
				new Employee("Mich",10000),
				new Employee("siki",25000),
				new Employee("cc",100000),
				new Employee("Bunny",23000),
				new Employee("Bunny",50000)
			};

			Sort<Employee>(employees, Employee.Compare);

			foreach (Employee emp in employees)
			{
				Console.WriteLine(emp.Name + ":" + emp.Salary);
			}
		}
	}
}
