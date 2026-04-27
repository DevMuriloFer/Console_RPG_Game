using Console_RPG_Game.Helpers;
using Console_RPG_Game.Logic;
using Console_RPG_Game.Models;

Story.PlayCutscene(Story.EnterPlayerNameText, 500, false);
Console.Write("Name: ");
Player player = new Player(Console.ReadLine());
Story.PlayCutscene(Story.AfterNameEntryText, 500, true);

Entity currentEnemy;

for (int i = 0; i < 4; i++)
{
    if (i == 0)
    {
        currentEnemy = new SanctuaryGuardian();
        BattleManager.StartBattle(player, currentEnemy);
        player.RestoreFullHp();
        // This part will be refactored in the future into an XP and Items system
        Console.WriteLine("Congratulation you killed the Guardian and obtained a new item: ");
        Console.WriteLine("Item: Manticore's Whip; your attack was raised");
        Console.ReadKey();
        player.BaseAttack += 20;
    }
    if (i == 1)
    {
        currentEnemy = new Artorias();
        BattleManager.StartBattle(player, currentEnemy);
        
        // This part will be refactored in the future into an XP and Items system
        Console.WriteLine("Congratulation you killed Artorias and obtained a new item: ");
        Console.WriteLine("Item: Artoria's Armor; your LifePoints was raised");
        Console.ReadKey();
        player.MaxLifePoints += 40;
        //-----------------------------------------------------------------------

        player.RestoreFullHp();
    }
    if (i == 2)
    {
        currentEnemy = new Kalameet();
        BattleManager.StartBattle(player, currentEnemy);
        player.RestoreFullHp();
        // This part will be refactored in the future into an XP and Items system
        Console.WriteLine("Congratulation you killed Kalameet the Dragon and obtained a new item: ");
        Console.WriteLine("Item: Power within; your attack was raised");
        Console.ReadKey();
        player.BaseAttack += 30;
    }

    if (i == 3)
    {
        Story.PlayCutscene(Story.ManusIntroText, 1200, true);
        currentEnemy = new Manus();
        BattleManager.StartBattle(player, currentEnemy);
    }
}
Story.PlayCutscene(Story.VictoryText, 1200, true);
