namespace Console_RPG_Game
{
    internal class FinalBossEnemy : Entity
    {
        public FinalBossEnemy(string name, int lifePoints, int baseAttack) : base(name, lifePoints, baseAttack)
        {

        }

        /// <summary>
        /// Doubles the base attack value by channeling additional power.
        /// </summary>
        /// <remarks>Call this method to increase the attack strength.</remarks>
        public void Charge()
        {
            Console.WriteLine("Manus channels the power of the void and grows stronger");
            Console.ReadKey(true);
            BaseAttack = BaseAttack * 2;
        }
        /// <summary>
        /// Performs an attack and returns the base attack value.
        /// </summary>
        /// <returns>The base attack value as an integer.</returns>
        public int Attack()
        {
            Console.WriteLine("Manus is consuming you with the Void");
            Console.ReadKey(true);
            return BaseAttack;
        }
    }
}
