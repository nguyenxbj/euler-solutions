using System;
using System.Numerics;

namespace EulerSolutions.Solutions
{
	/// <summary>
	/// Large sum
	/// </summary>
	public class Problem_13
	{
		public static string Solution()
		{
			string[] lines = System.IO.File.ReadAllLines("E:/Apps/euler-solutions/EulerSolutions/EulerSolutions/Files/13.txt");
			System.Console.WriteLine("Contents of this text file are: ");

			BigInteger sum = 0;

			try
			{
				foreach (string line in lines)
				{
					System.Console.WriteLine("\t" + line);
					sum += BigInteger.Parse(line);
				}
			} catch (Exception ex)
			{
				System.Console.WriteLine(ex);
			}

			Console.WriteLine(sum.ToString());
			return sum.ToString().Substring(0, 10);
		}
	}
}
