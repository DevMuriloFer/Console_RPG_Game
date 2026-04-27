using Console_RPG_Game.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Console_RPG_Game.Models
{
    internal class Artorias : Entity
    {
        public Artorias() : base("Artorias", 70, 15, 1) { }

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
