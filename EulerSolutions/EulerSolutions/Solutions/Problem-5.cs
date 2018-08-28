using System.Linq;

namespace EulerSolutions.Solutions
{
	/// <summary>
	/// 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
	/// What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
	/// </summary>
	public class Problem_5
	{
		private static int[] _numbers = Enumerable.Range(1, 20).ToArray();

		public static string Solution()
		{
			int number = 0;
			bool divisible;

			do
			{
				divisible = Helpers.Toolkit.IsDivisibleBy(number, _numbers);
				if (divisible)
					break;
				else
					number++;
			} while (!divisible);

			return number.ToString();
		}
	}
}
