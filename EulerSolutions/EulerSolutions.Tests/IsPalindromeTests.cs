using System;
using Xunit;
using EulerSolutions.Helpers;

namespace EulerSolutions.Tests
{
	public class IsPalindromeTests
	{
		[Fact]
		public void IsPalindromeTestA()
		{
			// Arrange
			int a = 1;

			// Act
			var testA = Toolkit.IsPalindrome(a);

			// Assert
			Assert.True(testA);
		}

		[Fact]
		public void IsPalindromeTestB()
		{
			// Arrange
			int b = 21;

			// Act
			var testB = Toolkit.IsPalindrome(b);
			
			// Assert
			Assert.False(testB);
		}

		[Fact]
		public void IsPalindromeTestC()
		{
			// Arrange
			int c = 432;

			// Act
			var testC = Toolkit.IsPalindrome(c);

			// Assert
			Assert.False(testC);
		}

		[Fact]
		public void IsPalindromeTestD()
		{
			// Arrange
			int d = 50605;

			// Act
			var testD = Toolkit.IsPalindrome(d);

			// Assert
			Assert.True(testD);
		}

		[Fact]
		public void IsPalindromeTestE()
		{
			// Arrange
			int e = 606606;

			// Act
			var testE = Toolkit.IsPalindrome(e);

			// Assert
			Assert.True(testE);
		}
	}
}
