namespace Console_RPG_Game
{
    internal class GenericEnemy
    {
        public string Name;
        public int LifePoints;
        public int BaseAttack;

        public int Attack()
        {
            int missDice = Random.Shared.Next(1, 21);

            if (missDice > 14)
            {
                Console.WriteLine("\nthe enemy attack missed");
                Console.ReadKey(true);
                return 0;
            }
            else
            {
                double attackMultiplier = Random.Shared.Next(7, 15) / 10.0;
                int damage = (int)Math.Round(BaseAttack * attackMultiplier);

                Console.WriteLine($"\nThe enemy dealt {damage} damage");
                Console.ReadKey(true);
                return damage;
            }
        }
    }
}
