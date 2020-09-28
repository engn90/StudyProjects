using RoverNavigate.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RoverNavigate.Model
{
    public class Plateau
    {
        private static Plateau _current;
        private static object lockObj = new object();
        public static Plateau Current
        {
            get
            {
                if (_current == null)
                    throw new BusinessException("Could not be found plateau");

                return _current;
            }
            set
            {
                lock(lockObj)
                {
                    _current = value;
                }
            }
        }

        public Plateau(int totalX,int totalY)
        {
            _totalX = totalX;
            _totalY = totalY;

            Areas = new List<Area>();

            for (int i = 0; i <= totalX; i++)
            {
                for (int j = 0; j <= totalY; j++)
                {
                    Areas.Add(new Area(i,j));
                }
            }
            
        }

        private int _totalX;
        private int _totalY;

        public int TotalX { get { return _totalX; } }
        public int TotalY { get { return _totalY; } }
        public List<Area> Areas { get; set; }
        public Area GetAreaByCoordinate(int x,int y)
        {
            var selectedArea = Areas.FirstOrDefault(a=> a.X == x && a.Y == y);
            return selectedArea;
        }
        public List<Area> GetHasRoverAreas()
        {
            var roverAreas = Areas.Where(a => a.Rover != null).ToList();
            return roverAreas;
        }
        public Rover GetRoverByName(string name)
        {
            var hasRoverAreas = GetHasRoverAreas();
            if (hasRoverAreas == null || hasRoverAreas.Count == 0)
                throw new BusinessException("Could not be found "+name+" rover");

            var selectedArea = hasRoverAreas.FirstOrDefault(a=>a.Rover.Name == name);
            if(selectedArea == null)
                throw new BusinessException("Could not be found " + name + " rover");

            return selectedArea.Rover;
        }
        public int GetRoverCount()
        {
            return Areas.Where(a => a.Rover != null).ToList().Count;
        }
    }
}
