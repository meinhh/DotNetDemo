using System;

namespace ConsoleDemo
{
	class Program
	{
		private static Hello _hello = new Hello();

		static void Main(string[] args)
		{
			Console.WriteLine(_hello.GetMessage("Yael"));
		}
	}
}
