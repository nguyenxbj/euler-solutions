using System;
using System.Diagnostics;
using EulerSolutions.Solutions;

namespace EulerSolutions
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			Console.ReadLine();

			var stopwatch = new Stopwatch();
			stopwatch.Start();

			Console.WriteLine("Solution: " + Problem_2.Solution());

			stopwatch.Stop();
			Console.WriteLine("Elapsed time: " + stopwatch.ElapsedMilliseconds);
			Console.ReadLine();
		}
	}
}
