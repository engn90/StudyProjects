using System;
using System.Collections.Generic;
using System.Text;

namespace RoverNavigate.Model
{
    public static class TurnCommand
    {
        public const string Left = "L";
        public const string Right = "R";
    }

    public enum EnumDirection
    {
        North,
        South,
        West,
        East
    }
}
