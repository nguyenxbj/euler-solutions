using System;
using System.Collections.Generic;
using System.Text;

namespace EulerSolutions.Helpers
{
	public class Toolkit
	{
		/// <summary>
		/// Returns whether the input is a palindrome
		/// </summary>
		/// <param name="number"></param>
		/// <returns></returns>
		public static bool IsPalindrome(int number)
		{
			string uncheckedNumber = number.ToString();

			int i = 0, j = uncheckedNumber.Length - 1;
			while (i < j && i != j)
			{
				if (uncheckedNumber[i] != uncheckedNumber[j])
					return false;
				i++;
				j--;
			}
			
			return true;
		}

		/// <summary>
		/// Returns whether the input is a prime number
		/// </summary>
		/// <param name="number"></param>
		/// <returns></returns>
		public static bool IsPrime(int number)
		{
			return false;
		}
	}
}
