using Core.DigitalPlumber;
using NUnit.Framework;

namespace Tests
{
    public class DigitalPlumberTests
    {
        [Test]
        public void GroupCounts()
        {
            const string input = @"
0 <-> 2
1 <-> 1
2 <-> 0, 3, 4
3 <-> 2, 4
4 <-> 2, 3, 6
5 <-> 6
6 <-> 4, 5";

            var pipes = new Pipes(input);

            Assert.That(pipes.PipesInGroupZero, Is.EqualTo(6));
            Assert.That(pipes.GroupCount, Is.EqualTo(2));
        }
    }
}