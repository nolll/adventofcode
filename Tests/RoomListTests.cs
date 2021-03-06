using Core.RoomValidation;
using NUnit.Framework;

namespace Tests
{
    public class RoomListTests
    {
        [TestCase("aaaaa-bbb-z-y-x-123[abxyz]", true)]
        [TestCase("a-b-c-d-e-f-g-h-987[abcde]", true)]
        [TestCase("not-a-real-room-404[oarel]", true)]
        [TestCase("totally-real-room-200[decoy]", false)]
        public void ValidatesRooms(string input, bool expected)
        {
            var room = new Room(input);

            Assert.That(room.IsValid, Is.EqualTo(expected));
        }
    }
}