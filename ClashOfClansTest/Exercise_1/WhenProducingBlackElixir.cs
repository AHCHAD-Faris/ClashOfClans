using ClashOfClans.Core.Buildings;
using ClashOfClans.Core.Exceptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClashOfClansTest.Exercise_1
{
    /// <summary>
    /// The provided test cases cover the primary scenarios that need to be tested, no additional test cases required
    /// </summary>
    [TestClass]
    public class WhenProducingBlackElixir
    {
        [TestMethod]
        [ExpectedException(typeof(DwarfsAngryException))]
        public void And_Gems_Supplied_Are_Not_Enough_Throw_DwarfsAngryException()
        {
            // Arrange
            int gems = 1;
            int blueElixir = 200;

            // Act
            BlackElixirFactory.ProduceElixir(gems, blueElixir);

            // No Assert needed, should throw DwarfsAngryException
        }

        [TestMethod]
        [ExpectedException(typeof(DwarfsAngryException))]
        public void And_BlueElixir_Supplied_Is_Not_Enough_Throw_DwarfsAngryException()
        {
            // Arrange
            int gems = 5;
            int blueElixir = 199;

            // Act
            BlackElixirFactory.ProduceElixir(gems, blueElixir);

            // No Assert needed, should throw DwarfsAngryException
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidQuantityException))]
        public void With_3_Gems_And_400_BlueElixir_Should_Throw_InvalidQuantityException()
        {
            // Arrange
            int gems = 3;
            int blueElixir = 400;

            // Act
            BlackElixirFactory.ProduceElixir(gems, blueElixir);

            // No Assert needed, should throw InvalidQuantityException
        }

        [TestMethod]
        public void With_2_Gems_And_500_BlueElixir_Should_Produce_100_BlackElixir()
        {
            // Arrange
            int gems = 2;
            int blueElixir = 500;

            // Act
            int blackElixirProduced = BlackElixirFactory.ProduceElixir(gems, blueElixir);

            // Assert
            Assert.AreEqual(100, blackElixirProduced);
        }

        [TestMethod]
        public void With_5_Gems_And_200_BlueElixir_Should_Produce_100_BlackElixir()
        {
            // Arrange
            int gems = 5;
            int blueElixir = 200;

            // Act
            int blackElixirProduced = BlackElixirFactory.ProduceElixir(gems, blueElixir);

            // Assert
            Assert.AreEqual(100, blackElixirProduced);
        }
    }
}
