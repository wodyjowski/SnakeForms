using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeForms.GameLogic
{
    class Player : IPlayer
    {
        private int x;
        public int X { get => x; set => x = value; }

        private int y;
        public int Y { get => y; set => y = value; }

        public Player()
        {

        }
    }
}
