using System;
using System.Collections.Generic;
using System.Text;

namespace EulerSolutions.Solutions
{
	public class Problem_2
	{
		private static int _maxNum = 4000000;

		public static int Solution()
		{
			return getFibonacciEvensSum(_maxNum);
		}

		private static int getFibonacciEvensSum(int maxNumber)
		{
			int sum = 2, x = 1, y = 2;
			while (y < maxNumber)
			{
				int tempSum = x + y;

				if (tempSum % 2 == 0)
					sum += tempSum;

				x = y;
				y = tempSum;
			}

			return sum;
		}
	}
}
