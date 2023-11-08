namespace ClashOfClans.Core.Units
{
    public interface IUnit
    {
        int DefensiveHitpoints { get; }
        int OffensiveHitpoints { get; }
        void ReceiveHit(int attackHitpoints, out string lastMessageBeforeDying);
        int Move(int seconds);
    }
}
