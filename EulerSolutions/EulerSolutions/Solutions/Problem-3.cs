using System;

namespace EulerSolutions.Solutions
{
	public class Problem_3
	{
		private static long _primeNum = 600851475143;

		public static string Solution()
		{
			var solution = LargestPrime(_primeNum).ToString();
			Console.WriteLine(solution);
			return solution;
		}

		public static string LargestPrime(long primeNum)
		{
			return "unsolved";
		}
	}
}
