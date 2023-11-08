using ClashOfClans.Core.Resources;

namespace ClashOfClans.Core.Units
{
    public class Dragon : IUnit
    {
        public int DefensiveHitpoints { get; private set; }

        public int OffensiveHitpoints { get; private set; }

        public Dragon()
        {
            DefensiveHitpoints = 5000;
            OffensiveHitpoints = 7500;
        }

        public void ReceiveHit(int attackHitpoints, out string lastMessageBeforeDying)
        {
            DefensiveHitpoints -= attackHitpoints;
            if (DefensiveHitpoints <= 0)
            {
                lastMessageBeforeDying = "I WILL RISE AGAIN FROM THE ASHES";
                DefensiveHitpoints = 0; // Ensure hitpoints don't go below 0
            }
            else
            {
                lastMessageBeforeDying = null;
            }
        }

        public int Move(int seconds) => seconds * UnitMovementValues.Fly;
    }
}
