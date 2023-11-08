using System;
using ClashOfClans.Core.Units;

namespace ClashOfClans.Core.Buildings
{
    public class BlueTrainingCamp
    {
        public static IUnit ProduceUnit(UnitType unitType)
        {
            switch (unitType)
            {
                case UnitType.Giant:
                    return new Giant();
                case UnitType.Miner:
                    return new Miner();
                case UnitType.Bomber:
                    return new Bomber();
                default:
                    throw new ArgumentException("Invalid unit type");
            }
        }
    }
}
