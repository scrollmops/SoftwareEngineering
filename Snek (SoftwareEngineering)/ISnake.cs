using System;
using System.Collections.Generic;
using System.Text;

namespace Snek__SoftwareEngineering_
{
    public interface ISnake
    {
        Position Head { get; }
        Position Tail { get; }
        int Size { get; }
        Direction Direction { get; }

        void MoveHeadToNewPosition(Position newPosition, Direction direction);
        void DeleteTail();
    }
}
