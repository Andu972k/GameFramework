using System;
using System.Collections.Generic;
using System.Text;
using GameLibrary.Enemies;
using GameLibrary.Interfaces;
using GameLibrary.Weapons;

namespace GameLibrary.World
{
    class World : WorldBase
    {
        public World((int x, int y) worldSize, List<IObjectInWorld> itemsInWorld = null) : base(worldSize, itemsInWorld)
        {
            
            


        }

        protected override void InitializeWorld()
        {
            throw new NotImplementedException();
        }
    }
}
