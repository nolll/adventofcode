using Core.Computer;
using NUnit.Framework;

namespace Tests
{
    public class IntCodeComputerTests
    {
        [TestCase("1,0,0,0,99", 2)]
        [TestCase("2,3,0,3,99", 2)]
        [TestCase("2,4,4,5,99,0", 2)]
        [TestCase("1,1,1,4,99,5,6,0,99", 30)]
        public void OutputsAreCorrect(string input, int expectedResult)
        {
            var computer = new ConsoleComputer(input);
            computer.Start();
            var result = computer.Result;
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}