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
			if (number == 0)
				return false;
			else if (number == 1)
				return true;
			
			// TODO
			return false;
		}

		/// <summary>
		/// Returns whether number can be evenly divided by all numbers in the giving array
		/// </summary>
		/// <param name="number"></param>
		/// <param name="numbers"></param>
		/// <returns></returns>
		public static bool IsDivisibleBy(int number, int[] numbers)
		{
			if (number == 0)
				return false;

			foreach(int divisor in numbers)
			{
				if (number % divisor != 0)
					return false;
			}

			return true;
		}

		public static long NthPrime(long n)
		{
			return 0;
		}
	}
}
