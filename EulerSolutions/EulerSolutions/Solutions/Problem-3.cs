using System;
using System.Collections.Generic;
using System.Text;

namespace EulerSolutions.Solutions
{
	public class Problem_3
	{
		private static long _primeNum = 600851475143;

		public static string Solution()
		{
			return LargestPrime(_primeNum).ToString();
		}

		public static long LargestPrime(long primeNum)
		{
			for (long i = primeNum; i > 1; i--)
			{
				if (primeNum % i == 0)
				{
					if (IsPrime(i))
						return i;
				}
			}
			
			return 0;
		}


		public static Boolean IsPrime(long number)
		{
			if (number % 2 == 0)
				return false;
			// use recursion?
			return true;
		}
	}
}
