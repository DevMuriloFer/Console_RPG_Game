
namespace Console_RPG_Game
{
    internal class Player
    {
        public string Name = "Bearer";
        public int MaxLifePoints = 70;
        public int LifePoints = 70;
        public int BaseAttack = 10;

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
