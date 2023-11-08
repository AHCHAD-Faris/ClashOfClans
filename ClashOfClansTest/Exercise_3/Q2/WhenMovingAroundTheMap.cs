using ClashOfClans.Core.Resources;
using ClashOfClans.Core.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClashOfClansTest.Exercise_3.Q2
{
    [TestClass]
    public class WhenInitiatingMovementOnTheMap
    {
        [TestMethod]
        public void With_Bomber_Unit_For_1_second_Then_It_Should_Run_And_Cover_6_Map_Spaces()
        {
            var bomberUnit = new Bomber(MovementType.Run);
            var timeForMovementSeconds = 1;
            var expectedCoveredDistance = 6;

            var actualCoveredDistance = bomberUnit.Move(timeForMovementSeconds);

            Assert.AreEqual(expectedCoveredDistance, actualCoveredDistance);
        }

        [TestMethod]
        public void With_Bomber_Unit_For_6_second_Then_It_Should_Run_And_Cover_36_Map_Spaces()
        {
            var bomberUnit = new Bomber(MovementType.Run);
            var timeForMovementSeconds = 6;
            var expectedCoveredDistance = 36;

            var actualCoveredDistance = bomberUnit.Move(timeForMovementSeconds);

            Assert.AreEqual(expectedCoveredDistance, actualCoveredDistance);
        }
    }
}
