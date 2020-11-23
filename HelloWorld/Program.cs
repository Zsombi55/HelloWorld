/*
 * Created by SharpDevelop.
 * User: Zsombor
 * Date: 2020-11-23
 * Time: 20:22
 * FTIT Course exercise 1
 */
using System;
using System.IO;

namespace HelloWorld
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.Write("Enter your name: ");
			string name = Console.ReadLine();
			PrintHello(name);
			
			PrintFromFile(@"D:\SULI\C# .NET\HelloWorld\HelloWorld\InputFile.txt");

			Console.ReadKey();
		}
		
		static void PrintHello(string name) {
			Console.WriteLine("Hello, " + name + "\n");
		}
		
		static void PrintFromFile(string path) {
			if(File.Exists(path)) {
				string textFromFile = File.ReadAllText(path);
				Console.WriteLine(textFromFile);
			}
			else {
				Console.WriteLine("The file doesn't exist or path is wrong.");
			}
		}
	}
}