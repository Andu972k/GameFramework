using System;
using System.Collections.Generic;
using System.Text;

namespace GameLibrary.Interfaces
{
    public interface IObjectInWorld
    {

        (int x, int y) Position { get; set; }

    }
}
