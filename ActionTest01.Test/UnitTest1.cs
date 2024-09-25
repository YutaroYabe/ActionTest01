using ActionTest01;


namespace ActionTest01.Test
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{

			// Arrange
			var calculator = new Calculator();

			// Act
			var result = calculator.Add(2, 3);

			// Assert
			Assert.AreEqual(5, result);


		}

		[TestMethod]
		public void TestMethod2()
		{

			// Arrange
			var calculator = new Calculator();

			// Act
			var result = calculator.Sub(5, 3);

			// Assert
			Assert.AreEqual(2, result);
		}
	}
}