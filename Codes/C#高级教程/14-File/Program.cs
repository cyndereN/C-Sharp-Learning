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

			////////////////////////////////////////////////////////////////////////////////////////////////////////////////

			DateTime before = DateTime.Now;
			FileStream readFileStream = new FileStream(@"E:\VS Workspace\file.zip", FileMode.Open, FileAccess.Read);

			//readFileStream.ReadByte();

			FileStream writeFileStream = new FileStream(@"E:\VS Workspace\fileCopy.zip", FileMode.Create, FileAccess.Write);

			//writeFileStream.WriteByte();
			//int nextByte = -1;
			//while( (nextByte=readFileStream.ReadByte()) != -1)
			//{
			//    writeFileStream.WriteByte((byte)nextByte);
			//}

			int length = 1024;

			byte[] buffer = new byte[length];
			int count = -1;
			//int count = readFileStream.Read(buffer, 0, 1024);

			//writeFileStream.Write(buffer, 0, count);
			while ((count = readFileStream.Read(buffer, 0, length)) != 0)
			{
				writeFileStream.Write(buffer, 0, count);
			}


			writeFileStream.Close();
			readFileStream.Close();
			DateTime after = DateTime.Now;

			TimeSpan ts = after.Subtract(before);
			Console.WriteLine(ts.TotalMilliseconds);

			//string sourceFile = @"E:\VS Workspace\第四季-高级篇\26-文本读取流和写入流\TextFile1.txt";
			//StreamReader reader = new StreamReader(sourceFile);

			//FileStream fs = new FileStream(sourceFile,FileMode.Open);
			//StreamReader reader = new StreamReader(fs);

			//FileInfo myFile = new FileInfo(sourceFile);
			//myFile.OpenText();
			//string line = reader.ReadLine();
			//Console.WriteLine(line);

			//string line = null;

			//while( (line = reader.ReadLine())!=null)
			//{
			//    Console.WriteLine(line);
			//}

			//reader.ReadToEnd();

			//reader.Read();
			//char[] buffer = new char[1024];
			//reader.Read(buffer, 0, 1024);

			//reader.Close();

			//Stream

			string sourceFile = @"E:\VS Workspace\第四季-高级篇\26-文本读取流和写入流\TextFile1.txt";
			string destinationFile = @"E:\VS Workspace\第四季-高级篇\26-文本读取流和写入流\TextFileCopy.txt";
			StreamReader reader = new StreamReader(sourceFile);
			StreamWriter writer = new StreamWriter(destinationFile, true);

			string line = null;
			while ((line = reader.ReadLine()) != null)
			{
				writer.WriteLine(line);
			}
			writer.Close();
			reader.Close();

		}
	}
}
