using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeForms.GameLogic
{
    public interface IPlayer
    {
        public double X { get; set; }
        public double Y { get; set; }

        public void CreatePlayer();
    }
}
