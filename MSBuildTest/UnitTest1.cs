using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSBuildTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAddIntegers()
        {
            // Arrange
            int a = 3;
            int b = 5;

            // Act
            int result = AddIntegers(a, b);

            // Assert
            Assert.AreEqual(8, result, "Sum of integers is incorrect");
        }

        [TestMethod]
        public void TestAddFloats()
        {
            // Arrange
            float a = 3.5f;
            float b = 2.5f;

            // Act
            float result = AddFloats(a, b);

            // Assert
            Assert.AreEqual(6.0f, result, "Sum of floats is incorrect");
        }

        [TestMethod]
        public void TestFindAverage()
        {
            // Arrange
            int[] numbers = { 3, 5, 8, 12, 7 };

            // Act
            double average = FindAverage(numbers);

            // Assert
            Assert.AreEqual(7, average, "Average is incorrect");
        }

        public int AddIntegers(int a, int b)
        {
            return a + b;
        }

        public float AddFloats(float a, float b)
        {
            return a + b;
        }

        public double FindAverage(int[] array)
        {
            int sum = 0;
            foreach (int num in array)
            {
                sum += num;
            }
            return (double)sum / array.Length;
        }
    }
}
