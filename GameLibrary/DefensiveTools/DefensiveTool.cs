using System;
using System.Collections.Generic;
using System.Text;
using GameLibrary.Interfaces;

namespace GameLibrary.DefensiveTools
{
    public class DefensiveTool : IDefenseObject, IIventoryItem
    {
        #region InstanceFields

        protected (int x, int y) _position;
        protected double _defensePoints;

        #endregion


        #region Properties

        public (int x, int y) Position
        {
            get => _position;
            set => _position = value;
        }

        public double DefensePoints
        {
            get => _defensePoints;
        }

        #endregion

        #region Constructor

        public DefensiveTool(double defensePoints)
        {
            _defensePoints = defensePoints;
        }

        #endregion

        #region Methods

        

        #endregion


    }
}
