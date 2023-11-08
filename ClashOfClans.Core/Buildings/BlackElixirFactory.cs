using ClashOfClans.Core.Resources;
using ClashOfClans.Core.Exceptions;

namespace ClashOfClans.Core.Buildings
{
    public class BlackElixirFactory
    {
        public static int ProduceElixir(int gems, int blueElixir)
        {
            //Validation logic is encapsulated in a separate method
            ValidateInput(gems, blueElixir);

            //Calculation logic is encapsulated in a separate method
            int blackElixirQuantity = CalculateBlackElixirQuantity(gems, blueElixir); 

            return blackElixirQuantity;
        }

        private static void ValidateInput(int gems, int blueElixir)
        {
            if (gems < ElixirConstants.GemsRequiredOption2 ||
                blueElixir < ElixirConstants.BlueElixirRequiredOption1)
            {
                throw new DwarfsAngryException();
            }

            //Validation of exact quantities is encapsulated in a separate method
            if (!IsValidQuantity(gems, blueElixir))
            {
                throw new InvalidQuantityException();
            }
        }

        private static int CalculateBlackElixirQuantity(int gems, int blueElixir)
        {
            int blackElixirQuantity;

            if (gems % ElixirConstants.GemsRequiredOption2 == 0 &&
                blueElixir % ElixirConstants.BlueElixirRequiredOption2 == 0)
            {
                blackElixirQuantity = gems / ElixirConstants.GemsRequiredOption2 * ElixirConstants.BlackElixirMultiplier;
            }
            else
            {
                blackElixirQuantity = gems / ElixirConstants.GemsRequiredOption1 * ElixirConstants.BlackElixirMultiplier;
            }

            return blackElixirQuantity;
        }

        private static bool IsValidQuantity(int gems, int blueElixir) 
            =>  (gems / ElixirConstants.GemsRequiredOption2 == blueElixir / ElixirConstants.BlueElixirRequiredOption2) 
             || (gems / ElixirConstants.GemsRequiredOption1 == blueElixir / ElixirConstants.BlueElixirRequiredOption1);
    }
}
