using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClashOfClans.Core.Buildings;
using ClashOfClans.Core.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClashOfClansTest.Exercise_2.Q1
{
    [TestClass]
    public class WhenBlackTrainingCampProduces
    {
        [TestMethod]
        public void A_Dragon_Then_It_Should_Have_7500_OffensiveHitpoints()
        {
            var newlyCreatedDragon = BlackTrainingCamp.ProduceUnit(UnitType.Dragon);

            Assert.AreEqual(7500, newlyCreatedDragon.OffensiveHitpoints);
        }

        [TestMethod]
        public void A_Dragon_Then_It_Should_Have_5000_DefensiveHitpoints()
        {
            var newlyCreatedDragon = BlackTrainingCamp.ProduceUnit(UnitType.Dragon);

            Assert.AreEqual(5000, newlyCreatedDragon.DefensiveHitpoints);
        }
    }
}
