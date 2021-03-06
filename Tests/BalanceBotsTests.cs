using Core.BalanceBots;
using NUnit.Framework;

namespace Tests
{
    public class BalanceBotsTests
    {
        [Test]
        public void FindsBot()
        {
            const string input = @"
value 5 goes to bot 2
bot 2 gives low to bot 1 and high to bot 0
value 3 goes to bot 1
bot 1 gives low to output 1 and high to bot 0
bot 0 gives low to output 2 and high to output 0
value 2 goes to bot 2";

            var botSimulator = new BotSimulator(input);
            var botId = botSimulator.FindIdByChips(2, 5);

            Assert.That(botId, Is.EqualTo(2));
        }
    }
}