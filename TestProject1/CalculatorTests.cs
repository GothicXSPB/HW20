namespace Lesson16.Test
{
    public class CalculatorTests
    {
        [TestCase(4, -3, -3, 0)]
        [TestCase(2, 8, -2, -5)]
        [TestCase(2, -8, 2, 5)]
        [TestCase(-2, -3, 5, -4)]
        public void SolutionLinearEquationsTest(double a, double b, double c, double expected)
        {
            double actual = Calculator.SolutionLinearEquations(a, b, c);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 0, 0)]
        [TestCase(-2, 2, -4)]
        [TestCase(3, 3, 9)]
        [TestCase(1, 0, 1)]
        [TestCase(5, -20, -15)]
        [TestCase(100, 1, 101)]
        [TestCase(0, 1, -1)]
        [TestCase(-5, 2, -7)]
        [TestCase(-5, 0, -5)]

        public void BiggerOrLessTest(int a, int b, int expected)
        {
            int actual = Calculator.BiggerOrLess(a, b);

            Assert.AreEqual(expected, actual);
        }
        [TestCase(0, true)]
        [TestCase(5, true)]
        [TestCase(25, true)]
        [TestCase(45, true)]
        [TestCase(-5, false)]
        [TestCase(11, false)]
        [TestCase(100500, false)]
        public void CheckRangeTest(int digital, bool expected)
        {
            bool actual = Calculator.CheckRange(digital);

            Assert.AreEqual(expected, actual);
        }
        [TestCase(-6,6,0)]
        [TestCase(-7,7,0)]
        [TestCase(-7,0,-7)]
        [TestCase(0,15,21)]
        public void SumDigitalFissileOnSevenTest(int a,int b, int expected)
        {
            int actual = Calculator.SumDigitalFissileOnSeven(a, b);

            Assert.AreEqual(expected, actual);

        }
        [TestCase(2,1)]
        [TestCase(3,2)]
        [TestCase(4,3)]
        [TestCase(5,5)]
        public void NumberOfFibonacciTest(int a,int expected)
        {
            int actual = Calculator.NumberOfFibonacci(a);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(121,2)]
        [TestCase(777,3)]
        [TestCase(0,0)]
        [TestCase(-12,1)]

        public void NumberOfOddNumbersTest(int a, int expected)
        {
            int actual = Calculator.NumberOfOddNumbers(a);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(123,321)]
        [TestCase(0,0)]
        [TestCase(808,808)]
        public void MirrorDigital(int a, int expected)
        {
            int actual = Calculator.MirrorDigital(a);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(123,43,true)]
        [TestCase(122,43,false)]
        [TestCase(0,43,false)]        
        public void CompareNumbers(int a, int b, bool expected)
        {
            bool actual = Calculator.CompareNumbers(a, b);
            Assert.AreEqual(expected, actual);
        }
    }
}