using System;
using Xunit;
using Xunit.Abstractions;

namespace Asp_Dot_NetDemo.xUnitTestProject
{
    public class UnitTest1
    {
        private readonly ITestOutputHelper _testOutputHelper;

        public UnitTest1(
            ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
        }

        [Fact]
        public void Test1()
        {
            // ARRANGE
            int expectedResult = 25;
            int actualResult;
            int a = 9, b = 15;

            // ACT
            actualResult = a + b;

            _testOutputHelper.WriteLine($"input values are {a} and {b}");
            _testOutputHelper.WriteLine($"expectedResult = {expectedResult}, ActualResult = {actualResult}");
            if(expectedResult == actualResult)
            {
                _testOutputHelper.WriteLine($"Test Passed");
            }
            else
            {
                _testOutputHelper.WriteLine($"Test Failed");
            }

            // ASSERT
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
