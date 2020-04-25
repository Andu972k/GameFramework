using System;
using System.Collections.Generic;
using System.Text;
using GameLibrary.Interfaces;
using GameLibrary.Weapons;

namespace GameLibrary.Factories
{
    public class WeaponFactory : IFactory
    {
        public virtual IObjectInWorld Create()
        {
            Random random = new Random();
            return new Weapon(random.NextDouble() * 75);
        }
    }
}
