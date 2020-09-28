using System;
using System.Collections.Generic;
using System.Text;

namespace RoverNavigate.Model
{
    public class Area
    {
        private int _x;
        private int _y;
        public int X { get { return _x; } }
        public int Y { get { return _y; } }
        public bool isActive { get; set; }
        public Rover Rover { get; set; }

        public Area(int x, int y)
        {
            _x = x;
            _y = y;
        }
    }
}
