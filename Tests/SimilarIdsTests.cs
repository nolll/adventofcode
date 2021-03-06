using System.Collections.Generic;
using Core.Boxes;
using NUnit.Framework;

namespace Tests
{
    public class SimilarIdsTests
    {
        [Test]
        public void NoSimilarIds()
        {
            var ids = new List<string> { "abcde", "fghij" };
            var similarIds = SimilarIdsPuzzle.GetSimilarIds(ids);
            Assert.AreEqual(0, similarIds.Count);
        }

        [Test]
        public void EqualIdsIds_ReturnsNoMatch()
        {
            var ids = new List<string> { "abcde", "abcde" };
            var similarIds = SimilarIdsPuzzle.GetSimilarIds(ids);
            Assert.AreEqual(0, similarIds.Count);
        }

        [Test]
        public void OneSimilarId()
        {
            var ids = new List<string> { "abcde", "abcdX" };
            var similarIds = SimilarIdsPuzzle.GetSimilarIds(ids);
            Assert.AreEqual(2, similarIds.Count);
        }

        [Test]
        public void TwoSimilarIds_ReturnsOnlyFirstMatch()
        {
            var ids = new List<string> { "abcde", "abcdX", "fghij", "fghiX" };
            var similarIds = SimilarIdsPuzzle.GetSimilarIds(ids);
            Assert.AreEqual(2, similarIds.Count);
        }
    }
}