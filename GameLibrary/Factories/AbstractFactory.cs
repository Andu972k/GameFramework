using System;
using System.Collections.Generic;
using System.Text;
using GameLibrary.Enum;
using GameLibrary.Interfaces;

namespace GameLibrary.Factories
{
    public class AbstractFactory
    {

        public static IFactory CreateFactory(FactoryType factoryType)
        {
            switch (factoryType)
            {
                case FactoryType.Creature: return new CreatureFactory();
                case FactoryType.Weapon: return new WeaponFactory();
                case FactoryType.DefensiveTool: return new DefensiveToolFactory();
            }

            return new CreatureFactory();
        }

    }
}
