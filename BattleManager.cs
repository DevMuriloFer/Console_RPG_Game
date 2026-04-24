using System;
using System.Collections.Generic;
using System.Text;

namespace Console_RPG_Game
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
        static void StartBattle()
        {
            while (true)
            {
                
            }
        }
    }
}
