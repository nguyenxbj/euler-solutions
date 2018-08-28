using System;
using System.Linq;

namespace EulerSolutions.Solutions
{
	/// <summary>
	/// Sum square difference.
	/// Solved.
	/// </summary>
	public class Problem_6
	{
		private static int[] _numbers = Enumerable.Range(1, 100).ToArray();
		//private static int[] _numbers = Enumerable.Range(1, 10).ToArray();

		public static int Solution()
		{
			int sumOfSquares = 0, squareOfSum = 0;

			foreach (int number in _numbers)
			{
				sumOfSquares += (number*number);
				squareOfSum += number;
			}

			return (squareOfSum * squareOfSum) - sumOfSquares;
		}
	}
}
