using System;
using System.Collections.Generic;
using System.Text;

namespace GameLibrary.Interfaces
{
    public interface IWorld
    {

        #region Properties

        (int x, int y) WorldSize { get; }

        List<IObjectInWorld> ItemsInWorld { get; set; }

        IObjectInWorld[,] Realm { get;  }

        #endregion







    }
}
