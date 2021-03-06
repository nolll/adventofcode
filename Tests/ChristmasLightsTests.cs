using Core.ChristmasLights;
using NUnit.Framework;

namespace Tests
{
    public class ChristmasLightsTests
    {
        [Test]
        public void TurnsOnAllLights()
        {
            var controller = new ChristmasLightsController(5);
            controller.TurnOn(0, 0, 4, 4);

            Assert.That(controller.LitCount, Is.EqualTo(25));
        }

        [Test]
        public void TurnsOnAllLightsTurnsOffFiveLights()
        {
            var controller = new ChristmasLightsController(5);
            controller.TurnOn(0, 0, 4, 4);
            controller.TurnOff(0, 2, 4, 2);

            Assert.That(controller.LitCount, Is.EqualTo(20));
        }

        [Test]
        public void TurnsOnAllLightsTurnsOffFiveLightsTogglesAllLights()
        {
            var controller = new ChristmasLightsController(5);
            controller.TurnOn(0, 0, 4, 4);
            controller.TurnOff(0, 2, 4, 2);
            controller.Toggle(0, 0, 4, 4);

            Assert.That(controller.LitCount, Is.EqualTo(5));
        }
    }
}