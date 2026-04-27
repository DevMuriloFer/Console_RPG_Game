using Console_RPG_Game.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Console_RPG_Game.Models
{
    internal class Entity
    {
        public string Name;
        public int LifePoints;
        public int BaseAttack;
        protected int MoveSetSize;

        public Entity()
        {

        }

        public Entity(string name, int lifePoints, int baseAttack, int moveSetSize)
        {
            Name = name;
            LifePoints = lifePoints;
            BaseAttack = baseAttack;
            MoveSetSize = moveSetSize;
        }
        public void TakeDamage(int damage)
        {
            LifePoints -= damage;
        }
        protected virtual int BasicAttack(Entity target)
        {
            int diceRoll = Utils.RollDice(20);
            int damage = 0;

            if (diceRoll > 17)
            {
                damage = (int)Math.Round(BaseAttack * 1.5);
                Menu.DamageReceivedMessage(damage);
                Menu.CriticalHitMessage();
            }
            else
            {
                damage = BaseAttack;
                Menu.DamageReceivedMessage(damage);
            }
            target.TakeDamage(damage);
            return damage;
        }
        public virtual void DetermineAction(Entity target)
        {
            int diceRoll = Utils.RollDice(MoveSetSize);
            switch (diceRoll)
            {
                case 1:
                    BasicAttack(target);
                    break;
            }
        }
    }
}
