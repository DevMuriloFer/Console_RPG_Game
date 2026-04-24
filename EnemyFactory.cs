using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace Console_RPG_Game
{
    internal class EnemyFactory
    {
        //------------------------------
        // GENERIC ENEMIES
        //------------------------------
        public static RegularBossEnemy CreateGuardian()
        {
            return new RegularBossEnemy("Guardian", 40, 10);
        }
        public static RegularBossEnemy CreateArtorias()
        {
            return new RegularBossEnemy("Artorias", 70, 15);
        }
        public static RegularBossEnemy CreateKalameet()
        {
            return new RegularBossEnemy("Kalameet", 120, 20);
        }
        //------------------------------
        // FINAL BOSS
        //------------------------------
        public static FinalBossEnemy CreateManus()
        {
            return new FinalBossEnemy("Manus", 200, 30);
        }
    }
}
