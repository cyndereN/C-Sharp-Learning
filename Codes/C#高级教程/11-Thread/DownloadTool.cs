using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Thread
{
	internal class DownloadTool
	{
		public string URL { get; private set; }
		public string Message { get; private set; }

		public DownloadTool(string uRL, string message)
		{
			URL = uRL;
			Message = message;
		}
		public void Download()
		{
			Console.WriteLine("从" + URL + "下载中 ...");
		}
	}
}
