using System;
using System.Collections.Generic;
using System.Text;

namespace Console_RPG_Game
{
    internal static class Utils
    {
        /// <summary>
        /// Inserts a dramatic pause by printing a series of dots to the console, each followed by a short delay.
        /// </summary>
        /// <param name="pauses">The number of dots to print, representing the length of the pause. Must be zero or greater.</param>
        public static void DramaticPause(int pauses)
        {
            for (int i = 0; i < pauses; i++)
            {
                Console.WriteLine(".");
                Thread.Sleep(400);
            }
        }
    }
}
