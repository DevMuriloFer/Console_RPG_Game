using Console_RPG_Game.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Console_RPG_Game.Models
{
    internal class Kalameet : Entity
    {
        public Kalameet() : base("Kalameet", 150, 20, 1){}

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
