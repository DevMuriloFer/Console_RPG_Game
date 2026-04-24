using System;
using System.Collections.Generic;
using System.Text;

namespace Console_RPG_Game
{
    internal class Entity
    {
        public string Name;
        public int LifePoints;
        public int BaseAttack;

        public Entity()
        {

        }

        public Entity(string name, int lifePoints, int baseAttack)
        {
            Name = name;
            LifePoints = lifePoints;
            BaseAttack = baseAttack;
        }
    }
}
