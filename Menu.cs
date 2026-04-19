namespace Console_RPG_Game
{
    internal class Menu
    {
        static public void BattleMenu(Player p1, GenericEnemy npc)
        {
            Console.Write($@"
---------------------------------------------------------
Enemy: {npc.Name,-20}       | Player: {p1.Name}
Life Points: {npc.LifePoints,-20} | Life Points: {p1.LifePoints}

press 1 to use basic attack: ");
        }

        static public void BossBattleMenu(Player p1, BossEnemy npc)
        {
            Console.Write($@"
---------------------------------------------------------
Enemy: {npc.Name,-20}       | {p1.Name}
Life Points: {npc.LifePoints,-20} | {p1.LifePoints}

press 1 to use basic attack: ");
        }

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

