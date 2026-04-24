using Console_RPG_Game;

Story.PlayCutscene(Story.EnterPlayerNameText, 500, false);
Console.Write("Name: ");
Player player = new Player(Console.ReadLine());
Story.PlayCutscene(Story.AfterNameEntryText, 500, true);

Entity momentEnemy = new Entity();
for (int i = 0; i < 3; i++)
{
    if (i == 0)
    {
        momentEnemy = EnemyFactory.CreateGuardian();
        Console.WriteLine("\nThe Sanctuary Guardian approaches...");
        Console.ReadKey(true);
    }
    if (i == 1)
    {
        momentEnemy = EnemyFactory.CreateArtorias();
        Console.WriteLine("\nThe Abysswalker Artorias approaches...");
        Console.ReadKey(true);
    }
    if (i == 2)
    {
        momentEnemy = EnemyFactory.CreateKalameet();
        Console.WriteLine("\nThe Black Dragon Kalameet approaches...");
        Console.ReadKey(true);
    }

    while (momentEnemy.LifePoints > 0 && player.LifePoints > 0)
    {
        Menu.BattleMenu(player, momentEnemy);
        int option = int.Parse(Console.ReadLine());
        switch (option)
        {
            case 1:
                momentEnemy.LifePoints -= player.Attack();
                break;
        }
        if (momentEnemy.LifePoints <= 0)
        {
            break;
        }
        player.LifePoints -= momentEnemy.Attack(); 
    }
    if (player.LifePoints <= 0)
    {
        break;
    }

    if (i == 0)
    {
        Console.WriteLine("""
            
            Congratulation you won the battle
            and received a new item:
            New item: Belmont Whip
            Your attack power was raised.
            """);
        player.BaseAttack = 20;
    }
    if (i == 1)
    {
        Console.WriteLine("""
            
            Congratulation you won the battle
            and received a new item:
            New item: Strange mushroom.
            Your Life points was raised, and ... You became taller???
            
            """);
        player.MaxLifePoints = 120;
    }
    if (i == 2)
    {
        Console.WriteLine($"""

            Congratulation you won the battle
            and received a new item:
            New item: Blade of Olympus
            Your attack power was raised.

            """);
        player.BaseAttack = 60;
    }
    Console.ReadKey(true);
    Console.Clear();
    player.LifePoints = player.MaxLifePoints;
}
if (player.LifePoints > 0)
{
    Story.PlayCutscene(Story.ManusIntroText, 1200, true);
}
while (boss.LifePoints > 0 && player.LifePoints > 0)
{
    Menu.BattleMenu(player, boss);
    int option = int.Parse(Console.ReadLine());
    switch (option)
    {
        case 1:
            boss.LifePoints -= player.Attack();
            break;
    }
    if (boss.LifePoints <= 0)
    {
        break;
    }
    int ChargeOrAttack = Random.Shared.Next(1, 3);
    if (ChargeOrAttack == 1)
    {
        boss.Charge();
    }
    if (ChargeOrAttack == 2)
    {
        player.LifePoints -= boss.Attack();
    }
    
}
if (boss.LifePoints <= 0)
{
    Story.PlayCutscene(Story.VictoryText, 2500, true);
}
if (player.LifePoints <= 0)
{
    Story.PlayCutscene(Story.DefeatText, 1600, true);
}