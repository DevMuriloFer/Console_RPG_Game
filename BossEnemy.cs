namespace Console_RPG_Game
{
    internal class BossEnemy
    {
        public string Name = "Manus";
        public int LifePoints = 200;
        public int BaseAttack = 40;

        public void Charge()
        {
            Console.WriteLine("Manus channels the power of the void and grows stronger");
            Console.ReadKey(true);
            BaseAttack = BaseAttack * 2;
        }
        public int Attack()
        {
            Console.WriteLine("Manus is consuming you with the Void");
            Console.ReadKey(true);
            return BaseAttack;
        }
    }
}
