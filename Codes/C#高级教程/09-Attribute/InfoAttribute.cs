using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Attribute
{
	// sealed: 不能被继承
	[AttributeUsage(AttributeTargets.Class)]
	internal sealed class InfoAttribute : Attribute
	{
		public string developer;
		public string version;
		public string description;

		public InfoAttribute(string developer, string version, string description)
		{
			this.developer = developer;
			this.version = version;
			this.description = description;
		}
	}
}
