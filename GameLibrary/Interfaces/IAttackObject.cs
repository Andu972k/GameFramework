﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GameLibrary.Interfaces
{
    public interface IAttackObject : IObjectInWorld, IIventoryItem
    {

        double AttackPoints { get;}

    }
}
