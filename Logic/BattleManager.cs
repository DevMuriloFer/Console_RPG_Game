using Console_RPG_Game.Helpers;
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
        public static void StartBattle(Player player, Entity enemy)
        {
            while (true)
            {
                Menu.BattleMenu(player, enemy);

                int commandChosen = Menu.GetPlayerCommand(player);
                player.ChooseAction(commandChosen, player, enemy);

                if (CheckDeath(enemy))
                {
                    break;
                }

                enemy.DetermineAction(player);

                if (CheckDeath(player))
                {
                    PlayerDeathEndGame();
                }
            }
        }
        public static void PlayerDeathEndGame()
        {
            Story.PlayCutscene(Story.DefeatText,1500, true);
            Environment.Exit(0);
        }
    }
}
