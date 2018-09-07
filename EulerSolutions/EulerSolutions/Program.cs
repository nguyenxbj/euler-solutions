using System;
using System.Diagnostics;
using System.Reflection;
using EulerSolutions.Solutions;

namespace EulerSolutions
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			Console.WriteLine("Welcome to BJ's Project Euler solutions. Press Enter to begin!");
			Console.WriteLine();

			int problemId;
			bool response;
			do
			{
				Console.Write("Which problem solution would you like to run? ");
				response = int.TryParse(Console.ReadLine(), out problemId);

				if (!response)
				{
					Console.WriteLine("Please enter a valid number!");
					Console.WriteLine();
				}
			} while (!response);

			Console.WriteLine(String.Format("Running the solution for problem {0}...", problemId));

			var stopwatch = new Stopwatch();
			stopwatch.Start();

			var solution = Caller(String.Format("EulerSolutions.Solutions.Problem_{0}", problemId), "Solution");
			Console.WriteLine("Solution: {0}", solution);

			stopwatch.Stop();

			Console.WriteLine();
			Console.WriteLine("Elapsed time: {0} milliseconds", stopwatch.ElapsedMilliseconds.ToString());
			Console.WriteLine("Press any key to end the program");
			Console.ReadLine();
		}

		private static object Caller(string myClass, string myMethod)
		{
			try
			{
				// Get a type from the string
				Type type = Type.GetType(myClass);

				// Create an instance of that Type
				Object obj = Activator.CreateInstance(type);

				// Retreive method
				MethodInfo methodInfo = type.GetMethod(myMethod);

				//Invoke method on the instance just created above
				return methodInfo.Invoke(obj, null);
			}
			catch(Exception ex)
			{
				return ex.Message;
			}
		}
	}
}
