using Console_RPG_Game.Helpers;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Console_RPG_Game.Models
{
    internal class Player : Entity
    {
        public int MaxLifePoints;
        public List<string> FullMoveSet = ["Basic Attack"];
        public List<string> AvailableMoveSet = ["Basic Attack"];
        public Player(string name) : base(name, 70, 10, 1)
        {
            MaxLifePoints = 70;
        }

        /// <summary>
        /// Calculates and returns the amount of damage dealt by an attack, applying a random multiplier to the base
        /// attack value.
        /// </summary>
        /// <remarks>The damage value is determined by multiplying the base attack by a random factor
        /// between 0.7 and 1.4, then rounding to the nearest integer. Each call may produce a different result due to
        /// the randomization.</remarks>
        /// <returns>The total damage dealt as an integer value after applying a random multiplier to the base attack.</returns>

        public void ChooseAction(int commandChoosed, Player player, Entity enemy)
        {   
            switch (commandChoosed)
            {
                case 1:
                    BasicAttack(enemy);
                    break;
            }
        }

        protected override int BasicAttack(Entity target)
        {
            int diceRoll = Utils.RollDice(20);
            int damage;

            if (diceRoll > 16)
            {
                damage = (int)Math.Round(BaseAttack * 1.5);
                Menu.DamageDeltMessage(damage);
                Menu.CriticalHitMessage();
                Console.ReadKey();
            }
            else
            {
                damage = BaseAttack;
                Menu.DamageDeltMessage(damage);
                Console.ReadKey();
            }
            target.TakeDamage(damage);
            return damage;
        }

        public void RestoreFullHp()
        {
            LifePoints = MaxLifePoints;
        }

    }
}
