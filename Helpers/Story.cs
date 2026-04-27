using System;
using System.Collections.Generic;
using System.Text;

namespace Console_RPG_Game.Helpers
{
    internal static class Story
    {
        // Text that asks for the user name
        public const string EnterPlayerNameText = """
            You approach a strange figure that says:
            What is your name, traveler?:
            """;

        // Response for the user name input
        public const string AfterNameEntryText = """
            At least you know your own name. Heh heh heh...
            Here, take this and leave me alone.
            [WAIT]
            [CLEAR]
            [WAIT]
            ...After a long travel...
            """;

        // Final Boss Manus intro
        public const string ManusIntroText = """
            [WAIT]
            You've have entered the void
            [WAIT]
            The only thing you can see is the fading glow of your blade 
            and a huge dark figure arising in the distance
            [WAIT]
            Your fate has been sealed.
            [WAIT]
            """;

        public const string VictoryText = """
            You defeated Manus... Now... You find yourself within this abyss of emptiness.
            You see nothing... except... except for a glow emanating from your pocket!
            In that moment, you remember the object — until then worthless —
            Given to you at the start of your journey: a simple, pale flower.
            What once seemed insignificant now appears to tear away at the void, bit by bit...
            But you... neither time nor endurance remain for you.
            All that is left is to embrace your final moments
            And witness the victorious conclusion of your journey's end.
            But at what cost?...
            """;

        public const string DefeatText = """
            Your journey ends here. Your strength was not enough
            to overcome the shadows of this world. 
            Darkness claims you.
            """;

        /// <summary>
        /// Displays a cutscene by outputting the specified text to the console, processing special commands, and
        /// optionally pausing for user input at the end.
        /// </summary>
        /// <remarks>Lines containing [WAIT] will trigger a dramatic pause, and lines containing [CLEAR]
        /// will clear the console. All other lines are displayed with the specified pause between them. This method
        /// clears the console at the start of the cutscene.</remarks>
        /// <param name="text">The text of the cutscene to display. May include special commands such as [WAIT] to insert a dramatic pause
        /// or [CLEAR] to clear the console.</param>
        /// <param name="waitTime">The amount of time, in milliseconds, to wait after displaying each line of text that does not contain a
        /// special command. Must be non-negative.</param>
        /// <param name="hasPause">true to pause and wait for a key press after the cutscene finishes; otherwise, false.</param>
        public static void PlayCutscene(string text, int waitTime, bool hasPause)
        {
            Console.Clear();
            foreach(string line in text.Split('\n'))
            {
                if (line.Contains("[WAIT]"))
                {
                    Utils.DramaticPause(6);
                }
                else if (line.Contains("[CLEAR]"))
                {
                    Console.Clear();
                }
                else 
                {
                    for(int i = 0; i < line.Length; i++)
                    {
                        Console.Write(line[i]);
                        Thread.Sleep(25);

                    }
                    Console.Write("\n");
                    Thread.Sleep(waitTime);
                }
            }
            if (hasPause == true)
            {
                Console.ReadKey();
            }
        }
    }
}
