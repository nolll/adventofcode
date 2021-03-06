using System.Collections.Generic;
using Core.DiskFragmentation;
using Core.Tools;
using NUnit.Framework;

namespace Tests
{
    public class DiskFragmentationTests
    {
        [Test]
        public void UsedSquaresAreCorrect()
        {
            const string input = "flqrgnkx";

            var defragmenter = new DiskDefragmenter(input);

            Assert.That(defragmenter.UsedCount, Is.EqualTo(8108));
        }

        [Test]
        public void FindsRegions()
        {
            const string input = "flqrgnkx";

            var defragmenter = new DiskDefragmenter(input);

            Assert.That(defragmenter.RegionCount, Is.EqualTo(1242));
        }
    }
}