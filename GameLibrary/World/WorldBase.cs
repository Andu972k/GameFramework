using System;
using System.Collections.Generic;
using System.Text;
using GameLibrary.Interfaces;

namespace GameLibrary.World
{
    public abstract class WorldBase : IWorld
    {

        #region InstanceFields

        protected (int x, int y) _worldSize;
        protected List<IObjectInWorld> _itemsInWorld;
        protected IObjectInWorld[,] _realm;

        #endregion

        #region Properties

        public (int x, int y) WorldSize
        {
            get => _worldSize;
        }

        public List<IObjectInWorld> ItemsInWorld
        {
            get => _itemsInWorld;
            set => _itemsInWorld = value;
        }

        public IObjectInWorld[,] Realm
        {
            get => _realm;
        }

        #endregion

        #region Constructor

        protected WorldBase((int x, int y) worldSize, List<IObjectInWorld> itemsInWorld = null)
        {
            _worldSize = worldSize;
            _itemsInWorld = itemsInWorld;
            _realm = new IObjectInWorld[worldSize.x, worldSize.y];
        }

        #endregion

        #region Methods

        protected abstract void InitializeWorld();


        #endregion


    }
}
