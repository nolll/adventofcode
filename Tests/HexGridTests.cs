using Core.HexGrid;
using NUnit.Framework;

namespace Tests
{
    public class HexGridTests
    {
        [TestCase("ne,ne,ne", 3)]
        [TestCase("ne,ne,sw,sw", 0)]
        [TestCase("ne,ne,s,s", 2)]
        [TestCase("se,sw,se,sw,sw", 3)]
        public void DistanceIsCorrect(string input, int expected)
        {
            var navigator = new HexGridNavigator(input);

            Assert.That(navigator.EndDistance, Is.EqualTo(expected));
        }
    }
}