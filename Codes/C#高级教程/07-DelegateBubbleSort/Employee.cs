using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_DelegateBubbleSort
{
	internal class Employee
	{
		public string Name { get; private set; }
		public double Salary { get; private set; }

		public Employee(string name, double salary)
		{
			Name = name;
			Salary = salary;
		}

		public static bool Compare(Employee e1, Employee e2)
		{
			return e1.Salary > e2.Salary;
		}
	}
}
