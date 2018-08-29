namespace EulerSolutions.Solutions
{
	/// <summary>
	/// Special Pythagorean triplet
	/// </summary>
	public class Problem_9
	{
		public static string Solution()
		{
			int sum = 1000, product = 0;
			for (int a = 1; a <= (sum / 3); a++)
			{
				for (int b = a + 1; b <= (sum / 2); b++)
				{
					int c = sum - a - b;
					if (c > 0 && (a * a + b * b == c * c)) {
						System.Console.WriteLine("a, b, c: {0}, {1}, {2}", a, b, c);
						product = a * b * c;
						System.Console.WriteLine("Product of a, b, and c: {0}", product);
					}
				}
			}

			return product.ToString();
		}
	}
}
