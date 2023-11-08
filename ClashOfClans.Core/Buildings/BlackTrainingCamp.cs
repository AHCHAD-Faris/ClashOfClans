using System;
using ClashOfClans.Core.Units;

namespace ClashOfClans.Core.Buildings
{
    public class BlackTrainingCamp
    {
        public static IUnit ProduceUnit(UnitType unitType)
        {
            switch (unitType)
            {
                case UnitType.Dragon:
                    return new Dragon();              
                default:
                    throw new ArgumentException("Invalid unit type");
            }
        }
    }
}
