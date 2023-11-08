using System;

namespace ClashOfClans.Core.Buildings
{
    public class BlackElixirExtractor
    {
        public static int ProduceElixir(int gems, int blueElixir)
        {
            var blackElixirQuantity = 0;

            if (gems < 2 || blueElixir < 200)
            {
                throw new DwarfsAngryException();
            }

            if (((gems % 2 != 0) && (blueElixir % 500 != 0)) || ((gems % 5 != 0) && (blueElixir % 200 != 0)))
            {
                throw new InvalidQuantityException();
            }

            if ((gems / 2 != blueElixir / 500) || (gems / 5 != blueElixir / 200))
            {
                throw new InvalidQuantityException();
            }

            blackElixirQuantity = (gems * blueElixir) / 10;

            return blackElixirQuantity;
        }
    }

    public class DwarfsAngryException : Exception
    {
        public DwarfsAngryException()
            : base("You must be joking, we can not work so cheap !!!!")
        {
        }
    }

    public class InvalidQuantityException : Exception
    {
        public InvalidQuantityException()
            : base("ARGHHHHH !!! We told you we do not like computations.Provide us the exact quantities")
        {
        }
    }
}
