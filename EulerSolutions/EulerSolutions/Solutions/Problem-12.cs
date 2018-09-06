using System.Collections.Generic;

namespace EulerSolutions.Solutions
{
	/// <summary>
	/// Highly divisible triangular number
	/// </summary>
	public class Problem_12
	{
		private static int _numFactors = 500;
		public static string Solution()
		{
			//long triangle = 0, index = 0;
			//int count = 0;
			//do
			//{
			//	index++;
			//	triangle += index;
			//	var factors = Helpers.Toolkit.GetFactors(triangle);
			//	count = factors.Count;
			//	System.Console.Write("\rtriangle: {0}, index: {1}, count: {2}     ", triangle, index, count);
			//} while (count < 500);
			//System.Console.WriteLine();

			//return triangle.ToString();

			long n = 1, d = 1;

			while (Tau(d) <= _numFactors)
			{
				System.Console.Write("\rn: {0}, d: {1}     ", n, d);
				n++;
				d += n;
			}
			System.Console.WriteLine(d);

			return d.ToString();
		}

		public static long Tau(long number)
		{
			if (number == 1)
				return 1;

			long num = number, i = 2, p = 1;

			while (i * i <= num)
			{
				long c = 1;
				while (num % i == 0)
				{
					num /= i;
					c++;
				}
				i++;
				p *= c;
			}

			if (num == number || num > 1)
				p *= 1 + 1;

			return p;
		}
	}
}
