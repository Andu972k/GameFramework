using System;
using System.Collections.Generic;
using System.Text;

namespace GameLibrary.Interfaces
{
    interface IObstacle : IObjectInWorld, IDefenseObject
    {

        double Hp { get; set; }


    }
}
