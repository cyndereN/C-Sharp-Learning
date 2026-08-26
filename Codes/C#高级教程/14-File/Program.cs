using System;
using System.IO;

namespace _14_File
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//FileInfo DirectoryInfo
			//FileInfo myFile = new FileInfo(@"E:\VS Workspace\第四季-高级篇\24-文件操作\TextFile1.txt");
			//myFile.CopyTo(@"E:\VS Workspace\第四季-高级篇\24-文件操作\TextFile2.txt");

			//File.Copy(@"E:\VS Workspace\第四季-高级篇\24-文件操作\TextFile1.txt",
			//    @"E:\VS Workspace\第四季-高级篇\24-文件操作\TextFile3.txt");

			//DirectoryInfo myFolder = new DirectoryInfo(@"E:\VS Workspace\第四季-高级篇\24-文件操作\create");
			//myFolder.Exists

			//完整路径-绝对路径   相对路径

			//c d e  Linux  /

			//Directory.CreateDirectory(@"create2\child");

			//Console.WriteLine( myFolder.Root.FullName );

			//FileInfo myFile = new FileInfo(@"E:\VS Workspace\第四季-高级篇\24-文件操作\TextFile1.txt");

			//myFile.LastWriteTime = DateTime.Now;

			//string pathstr = Path.Combine("E:", "VS Workspace");
			//Console.WriteLine(pathstr);

			//string text = File.ReadAllText(@"E:\VS Workspace\第四季-高级篇\24-文件操作\TextFile1.txt",System.Text.Encoding.ASCII);
			//Console.WriteLine(text);

			//string[] strArray = File.ReadAllLines(@"E:\VS Workspace\第四季-高级篇\24-文件操作\TextFile1.txt");
			//foreach (string str in strArray)
			//{
			//    Console.WriteLine(str);
			//}
			//byte[] bArray = File.ReadAllBytes(@"E:\VS Workspace\第四季-高级篇\24-文件操作\TextFile1.txt");
			// 01010101

			//File.WriteAllText(@"E:\VS Workspace\第四季-高级篇\24-文件操作\TextFile1.txt", "www.sikiedu.com");

			File.WriteAllLines(@"E:\VS Workspace\第四季-高级篇\24-文件操作\TextFile1.txt", new string[] { "1111", "2222" });

		}
	}
}
