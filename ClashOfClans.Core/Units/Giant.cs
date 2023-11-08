using ClashOfClans.Core.Resources;

namespace ClashOfClans.Core.Units
{
    public class Giant : IUnit
    {
        public int DefensiveHitpoints { get; private set; }

        public int OffensiveHitpoints { get; private set; }

        public Giant()
        {
            DefensiveHitpoints = 4500;
            OffensiveHitpoints = 3000;
        }

        public void ReceiveHit(int attackHitpoints, out string lastMessageBeforeDying)
        {
            DefensiveHitpoints -= attackHitpoints;
            if (DefensiveHitpoints <= 0)
            {
                lastMessageBeforeDying = "OUR IRON FISTS WILL BE REMEMBERED FOREVER";
                DefensiveHitpoints = 0; // Ensure hitpoints don't go below 0
            }
            else
            {
                lastMessageBeforeDying = null;
            }
        }

        public int Move(int seconds) => seconds * UnitMovementValues.Walk;
    }
}
