using System;
using System.Collections.Generic;
using System.Text;
using GameLibrary.Interfaces;

namespace GameLibrary.Weapons
{
    public class Weapon : IAttackObject
    {

        #region InstanceFields

        protected (int x, int y) _position;
        protected double _attackPoints;

        #endregion


        #region Properties

        public (int x, int y) Position
        {
            get => _position;
            set => _position = value;
        }

        public double AttackPoints
        {
            get => _attackPoints;
        }

        #endregion


        #region Constructor

        public Weapon(double attackPoints)
        {
            _attackPoints = attackPoints;
        }

        #endregion


    }
}
