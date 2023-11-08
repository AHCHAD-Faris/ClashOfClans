using ClashOfClans.Core.Buildings;
using ClashOfClans.Core.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClashOfClansTest.Exercise_2.Q1
{
    [TestClass]
    public class WhenBlueTrainingCampProduces
    {
        [TestMethod]
        public void A_Bomber_Then_It_Should_Have_800_OffensiveHitpoints()
        {
            var newlyCreatedBomber = BlueTrainingCamp.ProduceUnit(UnitType.Bomber);

            Assert.AreEqual(800, newlyCreatedBomber.OffensiveHitpoints);
        }

        [TestMethod]
        public void A_Bomber_Then_It_Should_Have_350_DefensiveHitpoints()
        {
            var newlyCreatedBomber = BlueTrainingCamp.ProduceUnit(UnitType.Bomber);

            Assert.AreEqual(350, newlyCreatedBomber.DefensiveHitpoints);
        }

        [TestMethod]
        public void A_Giant_Then_It_Should_Have_3000_OffensiveHitpoints()
        {
            var newlyCreatedGiant = BlueTrainingCamp.ProduceUnit(UnitType.Giant);

            Assert.AreEqual(3000, newlyCreatedGiant.OffensiveHitpoints);
        }

        [TestMethod]
        public void A_Giant_Then_It_Should_Have_4500_DefensiveHitpoints()
        {
            var newlyCreatedGiant = BlueTrainingCamp.ProduceUnit(UnitType.Giant);

            Assert.AreEqual(4500, newlyCreatedGiant.DefensiveHitpoints);
        }

        [TestMethod]
        public void A_Miner_Then_It_Should_Have_1200_OffensiveHitpoints()
        {
            var newlyCreatedMiner= BlueTrainingCamp.ProduceUnit(UnitType.Miner);

            Assert.AreEqual(1200, newlyCreatedMiner.OffensiveHitpoints);
        }

        [TestMethod]
        public void A_Miner_Then_It_Should_Have_800_DefensiveHitpoints()
        {
            var newlyCreatedMiner = BlueTrainingCamp.ProduceUnit(UnitType.Miner);

            Assert.AreEqual(800, newlyCreatedMiner.DefensiveHitpoints);
        }
    }
}
