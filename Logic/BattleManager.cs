using Console_RPG_Game.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Console_RPG_Game.Logic
{
    internal class BattleManager
    {
        static bool CheckDeath(Entity entity)
        {
            if (entity.LifePoints <= 0)
            {
                return true;
            }
            else return false;
        }
        static void StartBattle(Entity player, Entity enemy)
        {
            while (true)
            {
                
            }
        }
    }
}
