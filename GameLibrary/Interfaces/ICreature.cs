using System;
using System.Collections.Generic;
using System.Text;

namespace GameLibrary.Interfaces
{
    public interface ICreature : IObjectInWorld
    {

        double Hp { get; set; }
        IAttackObject Weapon { get; set; }
        IDefenseObject Defense { get; set; }
        bool IsDead { get; }

        void Hit(ICreature enemy);

        void ReceiveHit(double damage);

    }
}
