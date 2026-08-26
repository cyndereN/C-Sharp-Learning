using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Thread
{
	internal class Student
	{
		public int Age { get; set; }
		public string Name { get; set; }

		public Student(int age, string name)
		{
			Age = age;
			Name = name;
		}
		public Student() { }
	}
}
