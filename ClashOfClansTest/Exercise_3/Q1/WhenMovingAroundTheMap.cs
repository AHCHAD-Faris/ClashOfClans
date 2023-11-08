using ClashOfClans.Core.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClashOfClansTest.Exercise_3.Q1
{
    [TestClass]
    public class WhenInitiatingMovementOnTheMap
    {
        [TestMethod]
        public void With_Dragon_Unit_For_1_second_Then_It_Should_Fly_And_Cover_8_Map_Spaces()
        {
            var dragonUnit = new Dragon();
            var timeForMovementSeconds = 1;
            var expectedCoveredDistance = 8;

            var actualCoveredDistance = dragonUnit.Move(timeForMovementSeconds);

            Assert.AreEqual(expectedCoveredDistance, actualCoveredDistance);
        }

        [TestMethod]
        public void With_Bomber_Unit_For_1_second_Then_It_Should_Walk_And_Cover_3_Map_Spaces()
        {
            var bomberUnit = new Bomber();
            var timeForMovementSeconds = 1;
            var expectedCoveredDistance = 3;

            var actualCoveredDistance = bomberUnit.Move(timeForMovementSeconds);

            Assert.AreEqual(expectedCoveredDistance, actualCoveredDistance);
        }

        [TestMethod]
        public void With_Giant_Unit_For_1_second_Then_It_Should_Walk_And_Cover_3_Map_Spaces()
        {
            var giantUnit = new Giant();
            var timeForMovementSeconds = 1;
            var expectedCoveredDistance = 3;

            var actualCoveredDistance = giantUnit.Move(timeForMovementSeconds);

            Assert.AreEqual(expectedCoveredDistance, actualCoveredDistance);
        }

        [TestMethod]
        public void With_Miner_Unit_For_1_second_Then_It_Should_TunnelUnder_And_Cover_5_Map_Spaces()
        {
            var minerUnit = new Miner();
            var timeForMovementSeconds = 1;
            var expectedCoveredDistance = 5;

            var actualCoveredDistance = minerUnit.Move(timeForMovementSeconds);

            Assert.AreEqual(expectedCoveredDistance, actualCoveredDistance);
        }
    }
}
