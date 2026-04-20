
namespace Console_RPG_Game
{
    internal class Player
    {
        public string Name = "Bearer";
        public int MaxLifePoints = 70;
        public int LifePoints = 70;
        public int BaseAttack = 10;

        /// <summary>
        /// Calculates and returns the amount of damage dealt by an attack, applying a random multiplier to the base
        /// attack value.
        /// </summary>
        /// <remarks>The damage value is determined by multiplying the base attack by a random factor
        /// between 0.7 and 1.4, then rounding to the nearest integer. Each call may produce a different result due to
        /// the randomization.</remarks>
        /// <returns>The total damage dealt as an integer value after applying a random multiplier to the base attack.</returns>
        public int Attack()
        {
            double attackMultiplier = Random.Shared.Next(7, 15) / 10.0;
            int damage = (int)Math.Round(BaseAttack * attackMultiplier);
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine($"\nYou dealt {damage} damage");
            return damage;
        }
    }
}
