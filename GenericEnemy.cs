namespace Console_RPG_Game
{
    internal class RegularBossEnemy : Entity
    {
        public RegularBossEnemy(string name, int lifePoints, int baseAttack) : base(name, lifePoints, baseAttack)
        {

        }

        /// <summary>
        /// Calculates and returns the amount of damage dealt by an enemy attack, or zero if the attack misses.
        /// </summary>
        /// <remarks>The method uses random chance to determine whether the attack hits or misses, and to
        /// calculate the damage amount if the attack is successful.</remarks>
        /// <returns>The amount of damage dealt as an integer. Returns 0 if the attack misses.</returns>
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
