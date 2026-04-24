namespace Console_RPG_Game
{
    internal class Menu
    {
        /// <summary>
        /// Displays the battle menu for the current player and enemy, showing their names and life points.
        /// </summary>
        /// <param name="player">The player whose status and options are displayed in the battle menu.</param>
        /// <param name="enemy">The enemy whose status is displayed in the battle menu.</param>
        static public void BattleMenu(Entity player, Entity enemy)
        {
            Console.Clear();
            Console.Write(
                $"""

                --------------------------------------------------------------
                Enemy: {enemy.Name,-20}       | Player: {player.Name}
                Life Points: {enemy.LifePoints,-20} | Life Points: {player.LifePoints}

                press 1 to use basic attack: 

                """);
        }
    }
}