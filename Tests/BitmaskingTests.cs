using Core.Bitmasking;
using NUnit.Framework;

namespace Tests
{
    public class BitmaskingTests
    {
        [Test]
        public void Part1_SumIsCorrect()
        {
            const string input = @"
mask = XXXXXXXXXXXXXXXXXXXXXXXXXXXXX1XXXX0X
mem[8] = 11
mem[7] = 101
mem[8] = 0";

            var system = new BitmaskSystem1();
            var sum = system.Run(input);

            Assert.That(sum, Is.EqualTo(165));
        }

        [Test]
        public void Part2_SumIsCorrect()
        {
            const string input = @"
mask = 000000000000000000000000000000X1001X
mem[42] = 100
mask = 00000000000000000000000000000000X0XX
mem[26] = 1";

            var system = new BitmaskSystem2();
            var sum = system.Run(input);

            Assert.That(sum, Is.EqualTo(208));
        }
    }
}