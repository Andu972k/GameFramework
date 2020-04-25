using System;
using System.Collections.Generic;
using System.Text;
using GameLibrary.DefensiveTools;
using GameLibrary.Interfaces;

namespace GameLibrary.Factories
{
    class DefensiveToolFactory : IFactory
    {
        public virtual IObjectInWorld Create()
        {
            Random random = new Random();
            return new DefensiveTool(random.NextDouble() * 75);
        }
    }
}
