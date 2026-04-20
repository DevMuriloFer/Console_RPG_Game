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
            Console.Write($@"
---------------------------------------------------------
Enemy: {npc.Name,-20}       | {p1.Name}
Life Points: {npc.LifePoints,-20} | {p1.LifePoints}

press 1 to use basic attack: ");
        }

        /// <summary>
        /// Displays a sequence of narrative messages before the boss fight starts.
        /// </summary>
        /// <remarks>This method pauses for user input between each message to allow the player to read
        /// the narrative.</remarks>
        static public void ManusCutScene()
        {
            Console.WriteLine($@"
.
.
.
.
.
.
.
.
.
.
.
.
.
.
.
.
.
.
.
.
.
.
.
.
.
.
You've have entered the void");
            Console.ReadKey(true);
            Console.WriteLine($@"
.
.
.
.
.
.
.
.
.
.
.
.
.
.
.
.
.
.
.
.
.
.
.
.
.
.
.
The only thing you can see is the fading glow of your blade 
and a huge dark figure arising in the distance");
            Console.ReadKey(true);
            Console.WriteLine($@"
.
.
.
.
.
.
.
.
.
.
.
.
.
.
.
.

.
.
.
.
.
.
.
Your fate has been sealed.");
             Console.ReadKey(true);
            Console.WriteLine($@"
.
.
.
.
.
.
.
.
.
.
.
.
.
.
.
.
.
.
.
.
.");

        }

        /// <summary>
        /// Displays a narrative victory message to the user upon defeating the final opponent.
        /// </summary>
        /// <remarks>This method pauses execution and waits for the user to press a key before continuing.
        /// Intended for use at the conclusion of the game to present the final story outcome.</remarks>
        static public void VictoryMessage()
        {
            Console.WriteLine($@"
You defeated Manus... Now... You find yourself within this abyss of emptiness.
You see nothing... except... except for a glow emanating from your pocket!
In that moment, you remember the object — until then worthless —
given to you at the start of your journey: a simple, pale flower.
What once seemed insignificant now appears to tear away at the void, bit by bit...
but you... neither time nor endurance remain for you.
All that is left is to embrace your final moments
and witness the victorious conclusion of your journey's end. But at what cost?...");
            Console.ReadKey(true);
        }

        /// <summary>
        /// Displays a defeat message to the user and waits for a key press before continuing.
        /// </summary>
        /// <remarks>This method writes a multi-line defeat message to the console and pauses execution
        /// until the user presses a key.</remarks>
        static public void DefeatMessage()
        {
            Console.WriteLine($@"
Your journey ends here. Your strength was not enough
to overcome the shadows of this world. Darkness claims you.
");
            Console.ReadKey(true);
        }
    }
}

