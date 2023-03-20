using System;
using System.Collections.Generic;
using System.Text;

namespace Snek__SoftwareEngineering_
{
    public static class Controls
    {
        public static Direction GetDirection(this ConsoleKey keyPress, Direction defaultDirection)
        {
            switch (keyPress)
            {
                case ConsoleKey.RightArrow:
                    return Direction.RIGHT;
                case ConsoleKey.LeftArrow:
                    return Direction.LEFT;
                case ConsoleKey.UpArrow:
                    return Direction.UP;
                case ConsoleKey.DownArrow:
                    return Direction.DOWN;
                default:
                    return defaultDirection;
            }
        }
    }
}
