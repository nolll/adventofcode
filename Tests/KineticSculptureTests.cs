using System.Runtime.InteropServices;
using Core.KineticSculptureTiming;
using NUnit.Framework;

namespace Tests
{
    public class KineticSculptureTests
    {
        [TestCase(5, 4, 0, false)]
        [TestCase(5, 4, 1, true)]
        [TestCase(5, 4, 2, false)]

        [TestCase(2, 1, 0, false)]
        [TestCase(2, 1, 1, true)]
        public void CapsulePassesDisc(int positions, int startPos, int time, bool expected)
        {
            var disc = new KineticSculptureDisc(positions, startPos);
            var pos = disc.Passed(time);

            Assert.That(pos, Is.EqualTo(expected));
        }

        [Test]
        public void CapsulePassesAtTime5()
        {
            const string input = @"
Disc #1 has 5 positions; at time=0, it is at position 4.
Disc #2 has 2 positions; at time=0, it is at position 1.";

            var sculpture = new KineticSculpture(input);
            
            Assert.That(sculpture.TimeToPressButton, Is.EqualTo(5));
        }
    }
}