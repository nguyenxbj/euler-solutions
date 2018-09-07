namespace EulerSolutions.Solutions
{
	/// <summary>
	/// Longest Collatz sequence
	/// </summary>
	public class Problem_14
	{
		private static long _startingNum = 999999;

		public static string Solution()
		{
			long highestNumber = 0, longestCollatzSeq = 0;
			//for (long i = _startingNum; i >= 0; i--)
			//{
			//	long temp = NumOfTerms(i);

			//	if (temp > longestCollatzSeq)
			//	{
			//		highestNumber = i;
			//		longestCollatzSeq = temp;
			//	}
			//}

			for (long i = _startingNum; i >= 0; i--)
			{
				long temp = NumOfTermsWhile(i);

				if (temp > longestCollatzSeq)
				{
					highestNumber = i;
					longestCollatzSeq = temp;
				}
			}

			System.Console.WriteLine("Number: {0} returned {1} Collatz terms", highestNumber, longestCollatzSeq);

			return "Done";
		}

		public static long NumOfTerms(long number)
		{
			return numberOfTermsHelper(number);
		}

		private static long numberOfTermsHelper(long number)
		{
			//System.Console.Write(number + " > ");

			if (number == 1)
			{
				return 1;
			}
			else if (number % 2 == 0)
			{
				return 1 + numberOfTermsHelper(number / 2);
			}
			else
			{
				return 1 + numberOfTermsHelper((3 * number) + 1);
			}
		}

		public static long NumOfTermsWhile(long number)
		{
			return numOfTermsWhileHelper(number);
		}

		public static long numOfTermsWhileHelper(long number)
		{
			return 0;
		}
	}
}
