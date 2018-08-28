using System;
using System.Diagnostics;
using EulerSolutions.Solutions;

namespace EulerSolutions
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			Console.WriteLine("Welcome to BJ's Project Euler solutions. Press Enter to begin!");
			Console.ReadLine();

			var stopwatch = new Stopwatch();
			stopwatch.Start();

			Console.WriteLine(Problem.Solution());

			stopwatch.Stop();

			Console.WriteLine();
			Console.WriteLine("Elapsed time: {0} milliseconds", stopwatch.ElapsedMilliseconds.ToString());
			Console.ReadLine();
		}
	}
}
