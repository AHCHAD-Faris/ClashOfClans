using ClashOfClans.Core.Resources;

namespace ClashOfClans.Core.Units
{
    public class Bomber : IUnit
    {
        public int DefensiveHitpoints { get; private set; }

        public int OffensiveHitpoints { get; private set; }

        public MovementType MovementType { get; private set; }

        public Bomber(MovementType? movementType = null)
        {
            DefensiveHitpoints = 350;
            OffensiveHitpoints = 800;
            MovementType = movementType != null ? movementType.Value : MovementType.Walk;
        }

        public void ReceiveHit(int attackHitpoints, out string lastMessageBeforeDying)
        {
            DefensiveHitpoints -= attackHitpoints;
            if (DefensiveHitpoints <= 0)
            {
                lastMessageBeforeDying = "WHEN YOU play with Explosives is dangerous bussiness";
                DefensiveHitpoints = 0; // Ensure hitpoints don't go below 0
            }
            else
            {
                lastMessageBeforeDying = null;
            }
        }

        public int Move(int seconds)
        {
            int movementRate = MovementType == MovementType.Run 
                ? UnitMovementValues.Run 
                : UnitMovementValues.Walk;

            return seconds * movementRate;
        }
    }
}
