namespace EulerSolutions.Solutions
{
	/// <summary>
	/// Summation of primes
	/// </summary>
	public class Problem_10
	{
		public static string Solution()
		{
			var primes = Helpers.Toolkit.GetAllPrimes(2000000);
			long sum = 0;

			foreach(long number in primes)
			{
				sum += number;
			}

			return sum.ToString();
		}
	}
}
