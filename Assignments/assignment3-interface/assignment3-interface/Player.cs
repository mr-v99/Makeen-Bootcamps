using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3_interface
{
    internal class Player : Moveable
    {
        public int x { get; set; }

        public int y { get; set; }

        public Player(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void MoveDown(int y)
        {
            this.y += y;
        }

        public void MoveLeft(int x)
        {
            this.x -= x;
        }

        public void MoveRight(int x)
        {
            this.x += x;
        }

        public void MoveUp(int y)
        {
            this.y += y;
        }
    }
}
