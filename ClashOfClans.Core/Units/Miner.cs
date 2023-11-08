using ClashOfClans.Core.Resources;

namespace ClashOfClans.Core.Units
{
    public class Miner : IUnit
    {
        public int DefensiveHitpoints { get; private set; }

        public int OffensiveHitpoints { get; private set; }

        public Miner()
        {
            DefensiveHitpoints = 800;
            OffensiveHitpoints = 1200;
        }

        public void ReceiveHit(int attackHitpoints, out string lastMessageBeforeDying)
        {
            DefensiveHitpoints -= attackHitpoints;
            if (DefensiveHitpoints <= 0)
            {
                lastMessageBeforeDying = "we return in the ground";
                DefensiveHitpoints = 0; // Ensure hitpoints don't go below 0
            }
            else
            {
                lastMessageBeforeDying = null;
            }
        }

        public int Move(int seconds) => seconds * UnitMovementValues.TunnelUnder;
    }
}
