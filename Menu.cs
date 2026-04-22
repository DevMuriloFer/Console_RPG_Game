namespace Console_RPG_Game
{
    internal class Menu
    {
        /// <summary>
        /// Displays the battle menu for the current player and enemy, showing their names and life points.
        /// </summary>
        /// <param name="p1">The player whose status and options are displayed in the battle menu.</param>
        /// <param name="npc">The enemy whose status is displayed in the battle menu.</param>
        static public void BattleMenu(Player p1, GenericEnemy npc)
        {
            Console.Clear();
            Console.Write($@"
---------------------------------------------------------
Enemy: {npc.Name,-20}       | Player: {p1.Name}
Life Points: {npc.LifePoints,-20} | Life Points: {p1.LifePoints}

press 1 to use basic attack: ");
        }

        /// <summary>
        /// Displays the boss battle menu, showing the current status of the player and the boss enemy.
        /// </summary>
        /// <param name="p1">The player whose status is displayed in the menu.</param>
        /// <param name="npc">The boss enemy whose status is displayed in the menu.</param>
        static public void BossBattleMenu(Player p1, BossEnemy npc)
        {
            Console.Clear();
            Console.Write($@"
---------------------------------------------------------
Enemy: {npc.Name,-20}       | {p1.Name}
Life Points: {npc.LifePoints,-20} | {p1.LifePoints}

press 1 to use basic attack: ");
        }
    }
}