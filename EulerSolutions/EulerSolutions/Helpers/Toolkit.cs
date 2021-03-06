﻿using System.Collections.Generic;

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
		public static bool IsPrime(int candidate)
		{
			// Test whether the parameter is a prime number.
			if ((candidate & 1) == 0)
			{
				if (candidate == 2)
				{
					return true;
				}
				else
				{
					return false;
				}
			}
			// Note:
			// ... This version was changed to test the square.
			// ... Original version tested against the square root.
			// ... Also we exclude 1 at the end.
			for (int i = 3; (i * i) <= candidate; i += 2)
			{
				if ((candidate % i) == 0)
				{
					return false;
				}
			}
			return candidate != 1;
		}

		/// <summary>
		/// Returns whether the given number can be evenly divided by all numbers in the given array
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

		/// <summary>
		/// Returns a list of all prime numbers up to the given number
		/// </summary>
		/// <param name="maxNumber"></param>
		/// <returns></returns>
		public static List<int> GetAllPrimes(long maxNumber)
		{
			List<int> primes = new List<int>();
		
			int number = 2;
			while (number <= maxNumber)
			{
				if (IsPrime(number))
					primes.Add(number);

				number++;
			}

			return primes;
		}

		/// <summary>
		/// Returns a list of all factors of the given number
		/// </summary>
		/// <param name="number"></param>
		/// <returns></returns>
		public static List<int> GetFactors(long number)
		{
			List<int> list = new List<int>();

			for (int i = 1; i <= number; i++)
			{
				if (number % i == 0)
					list.Add(i);
			}

			return list;
		}
	}
}
