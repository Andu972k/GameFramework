using System;
using System.Collections.Generic;
using System.Text;
using GameLibrary.Enemies;
using GameLibrary.Interfaces;

namespace GameLibrary.Factories
{
    class CreatureFactory : IFactory
    {
        public virtual IObjectInWorld Create()
        {
            Random random = new Random();

            return new Creature(random.NextDouble() * 250.0);
        }
    }
}
