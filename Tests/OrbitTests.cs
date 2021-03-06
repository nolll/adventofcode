using Core.Orbits;
using NUnit.Framework;

namespace Tests
{
    public class OrbitTests
    {
        [Test]
        public void ReturnsCorrectNumberOfOrbits()
        {
            const string input = @"COM)B
B)C
C)D
D)E
E)F
B)G
G)H
D)I
E)J
J)K
K)L";

        var calculator = new OrbitCalculator(input);
            var result = calculator.GetOrbitCount();

            Assert.That(result, Is.EqualTo(42));
        }

        [Test]
        public void ReturnsDistanceFromMeToSanta()
        {
            const string input = @"COM)B
B)C
C)D
D)E
E)F
B)G
G)H
D)I
E)J
J)K
K)L
K)YOU
I)SAN";

            var calculator = new OrbitCalculator(input);
            var result = calculator.GetSantaDistance();

            Assert.That(result, Is.EqualTo(4));
        }
    }
}