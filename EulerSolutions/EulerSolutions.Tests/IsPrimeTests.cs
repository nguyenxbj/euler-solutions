using System;
using Xunit;
using EulerSolutions.Helpers;

namespace EulerSolutions.Tests
{
	public class IsPrimeTests
	{
		[Fact]
		public void IsPrimeTest()
		{
			// Arrange
			int a = 1;

			// Act
			var testA = Toolkit.IsPrime(a);

			// Assert
			Assert.True(testA);
		}
	}
}
