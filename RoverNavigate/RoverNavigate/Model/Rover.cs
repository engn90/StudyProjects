using System;
using System.Collections.Generic;
using System.Linq;
using RoverNavigate.Common;

namespace RoverNavigate.Model
{
    public class Rover
    {
        public string Name { get; set; }
        public int CurrentX { get; set; }
        public int CurrentY { get; set; }
        public EnumDirection Direction { get; set; }
        public Stack<string> CommandHistory { get; set; }

        public Rover()
        {
            CommandHistory = new Stack<string>();
        }
        public void Go(string command)
        {

            foreach (var item in command)
            {
                if (item.Equals('M'))
                {
                    MoveForward();
                }
                else if (item.Equals('L') || item.Equals('R'))
                {
                    Turn(item.ToString());
                }
            }
            CommandHistory.Push(command);
        }
        public void Back()
        {
            if (CommandHistory.Count > 0)
            {
                string previousCommand = CommandHistory.Pop();
                string reverseCommand = previousCommand.Reverse();
                foreach (var item in reverseCommand)
                {
                    if (item.Equals('M'))
                    {
                        MoveBack();
                    }
                    else if (item.Equals('L') || item.Equals('R'))
                    {
                        Turn(item.ToString(),true);
                    }
                }
            }
        }
        private void Turn(string command, bool isBack = false)
        {
            if (isBack)
            {
                if (command == TurnCommand.Right)
                    command = TurnCommand.Left;
                else if (command == TurnCommand.Left)
                    command = TurnCommand.Right;
            }

            if (command == TurnCommand.Right)
            {
                switch (Direction)
                {
                    case EnumDirection.North:
                        Direction = EnumDirection.East;
                        break;
                    case EnumDirection.South:
                        Direction = EnumDirection.West;
                        break;
                    case EnumDirection.West:
                        Direction = EnumDirection.North;
                        break;
                    case EnumDirection.East:
                        Direction = EnumDirection.South;
                        break;
                }
            }
            else if (command == TurnCommand.Left)
            {
                switch (Direction)
                {
                    case EnumDirection.North:
                        Direction = EnumDirection.West;
                        break;
                    case EnumDirection.South:
                        Direction = EnumDirection.East;
                        break;
                    case EnumDirection.West:
                        Direction = EnumDirection.South;
                        break;
                    case EnumDirection.East:
                        Direction = EnumDirection.North;
                        break;
                }
            }
            else
                throw new BusinessException("Undefined turn command");
        }
        private void MoveForward()
        {
            var currentArea = Plateau.Current.Areas.FirstOrDefault(a => a.X == CurrentX && a.Y == CurrentY);

            #region Find New Location
            int nextX = CurrentX;
            int nextY = CurrentY;

            switch (Direction)
            {
                case EnumDirection.North:
                    nextY = CurrentY + 1;
                    break;
                case EnumDirection.South:
                    nextY = CurrentY - 1;
                    break;
                case EnumDirection.West:
                    nextX = CurrentX - 1;
                    break;
                case EnumDirection.East:
                    nextX = CurrentX + 1;
                    break;
            }
            #endregion

            #region Move rover to new area
            var nextArea = Plateau.Current.Areas.FirstOrDefault(a => a.X == nextX && a.Y == nextY);
            if (nextArea == null)
                throw new BusinessException("Invalid area.");


            if (nextArea.Rover != null)
                throw new BusinessException("This area has rover.You cant move it.");

            currentArea.Rover = null;
            nextArea.Rover = this;

            CurrentX = nextX;
            CurrentY = nextY;
            #endregion

        }

        private void MoveBack()
        {
            var currentArea = Plateau.Current.Areas.FirstOrDefault(a => a.X == CurrentX && a.Y == CurrentY);

            #region Find Location
            int nextX = CurrentX;
            int nextY = CurrentY;
            switch (Direction)
            {
                case EnumDirection.North:
                    nextY = CurrentY - 1;
                    break;
                case EnumDirection.South:
                    nextY = CurrentY + 1;
                    break;
                case EnumDirection.West:
                    nextX = CurrentX + 1;
                    break;
                case EnumDirection.East:
                    nextX = CurrentX - 1;
                    break;
            }
            #endregion

            #region  Move rover to new area
            var nextArea = Plateau.Current.Areas.FirstOrDefault(a => a.X == nextX && a.Y == nextY);
            if (nextArea == null)
                throw new BusinessException("Invalid area.");


            if (nextArea.Rover != null)
                throw new BusinessException("This area has rover.You cant move it.");

            currentArea.Rover = null;
            nextArea.Rover = this;

            CurrentX = nextX;
            CurrentY = nextY;
            #endregion
        }
    }
}
