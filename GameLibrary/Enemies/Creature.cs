using System;
using GameLibrary.Interfaces;

namespace GameLibrary.Enemies
{
    public class Creature : ICreature
    {

        #region InstanceFields

        protected double _hp;
        protected (int x, int y) _position;
        protected IAttackObject _weapon;
        protected IDefenseObject _defense;
        


        #endregion
        

        #region Properties

        public double Hp
        {
            get => _hp;
            set => _hp = value;
        }

        public (int x, int y) Position
        {
            get => _position;
            set => _position = value;
        }

        public IAttackObject Weapon
        {
            get => _weapon;
            set => _weapon = value;
        }

        public IDefenseObject Defense
        {
            get => _defense;
            set => _defense = value;
        }

        public bool IsDead => _hp <= 0;

        #endregion

        #region Constructor

        public Creature(double hp)
        {
            _hp = hp;
        }

        #endregion

        #region Methods

        public virtual void Hit(ICreature enemy)
        {
            double damage = Weapon.AttackPoints;
            enemy.ReceiveHit(damage);
        }

        public virtual void ReceiveHit(double damage)
        {
            double damagePoints =  damage - Defense.DefensePoints;
            if (damagePoints > 0)
            {
                _hp = _hp - damagePoints;
            }
        }

        public virtual void PickUp()
        {

        }


        #endregion

    }
}
