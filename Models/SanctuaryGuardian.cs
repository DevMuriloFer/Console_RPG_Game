using Console_RPG_Game.Helpers;

namespace Console_RPG_Game.Models
{
    internal class SanctuaryGuardian : Entity
    {
        public SanctuaryGuardian() : base("Sanctuary Guardian", 50, 10, 1)
        {

        }
        public override void DetermineAction(Entity target)
        {
            int diceRoll = Utils.RollDice(MoveSetSize);
            switch (diceRoll)
            {
                case 1:
                    BasicAttack(target);
                    break;
            }
        }
    }
}
