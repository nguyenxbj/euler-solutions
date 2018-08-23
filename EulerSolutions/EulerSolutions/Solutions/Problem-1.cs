using System;
using System.Collections.Generic;
using System.Text;

namespace EulerSolutions.Solutions
{
	public class Problem_1
	{
		public static int Solution()
		{
			int maxNumber = 1000;
			int sum = 0;

			for (int i = 1; i < maxNumber; i++)
			{
				if (i % 3 == 0 || i % 5 == 0)
				{
					sum += i;
				}
			}

			return sum;
		}
	}
}
