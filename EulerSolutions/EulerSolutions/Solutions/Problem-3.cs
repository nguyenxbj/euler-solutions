using System;

namespace EulerSolutions.Solutions
{
	public class Problem_3
	{
		private static long _primeNum = 40649; //600851475143;

		public static string Solution()
		{
			return LargestPrime(_primeNum).ToString();
		}

		public static long LargestPrime(long primeNum)
		{
			for (long i = primeNum; i > 1; i--)
			{
				Console.Write("\rChecking: {0}", i);

				if (primeNum % i == 0)
				{
					if (IsPrime(i))
						return i;
				}
			}
			
			return 0;
		}


		public static bool IsPrime(long number)
		{
			if (number < 4)
				return true;
			if (number % 2 == 0)
				return false;
			//if (Math.Sqrt(number))
			return IsPrime(number - 1);
		}
	}
}
