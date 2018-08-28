namespace EulerSolutions.Solutions
{
	// A palindromic number reads the same both ways.The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
	// Find the largest palindrome made from the product of two 3-digit numbers.
	public class Problem_4
	{
		private static int _inputNum1 = 999;
		private static int _inputNum2 = 999;

		public static int Solution()
		{
			int largestPalindrome = 0;
			
			for (int i = _inputNum1; i >= 0; i--)
			{
				for (int j = _inputNum2; j >= 0; j--)
				{
					int product = i * j;
					if (product > largestPalindrome && Helpers.Toolkit.IsPalindrome(product))
					{
						largestPalindrome = product;
					}
				}
			}

			return largestPalindrome;
		}
	}
}
