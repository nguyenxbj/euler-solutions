using System;
using System.Diagnostics;
using EulerSolutions.Solutions;

namespace EulerSolutions
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			Console.WriteLine("Press Enter to begin!");
			Console.ReadLine();

			var stopwatch = new Stopwatch();
			stopwatch.Start();

			Problem_3.Solution();

			stopwatch.Stop();

			Console.WriteLine();
			Console.WriteLine("Elapsed time: {0} milliseconds", stopwatch.ElapsedMilliseconds.ToString());
			Console.ReadLine();
		}
	}
}
