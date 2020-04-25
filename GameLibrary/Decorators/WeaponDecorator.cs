using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;
using GameLibrary.Interfaces;

namespace GameLibrary.Decorators
{
    public abstract class WeaponDecorator : IAttackObject
    {

        #region InstanceFields

        private IAttackObject _attackObject;
        private double _increaseDamageBy;

        #endregion

        #region Properties

        public double AttackPoints => EnhanceWeapon(_increaseDamageBy);

        public (int x, int y) Position 
        {
            get => _attackObject.Position; 
            set => _attackObject.Position = value;
        }

        #endregion

        #region Constructor

        public WeaponDecorator(IAttackObject attackObject, double increaseDamageBy)
        {
            _attackObject = attackObject;
            _increaseDamageBy = increaseDamageBy;
        }

        
        
        #endregion

        #region Methods

        protected virtual double EnhanceWeapon(double increaseDamageBy)
        {
            
            return _attackObject.AttackPoints * increaseDamageBy;
        }

        #endregion


    }
}
