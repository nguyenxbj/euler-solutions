namespace EulerSolutions.Solutions
{
	/// <summary>
	/// 10001st prime
	/// </summary>
	public class Problem_7
	{
		public static string Solution()
		{
			int counter = 1, number = 3;
			while (counter < 10001)
			{
				if (Helpers.Toolkit.IsPrime(number))
					counter++;

				System.Console.Write("\rcounter: {0}, number: {1}", counter, number);
				number++;
			}
			number--;
			System.Console.WriteLine();

			return number.ToString();
		}
	}
}
