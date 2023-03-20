using System;
using System.Collections.Generic;
using System.Text;

namespace Snek__SoftwareEngineering_
{
    public class Snake : ISnake
    {
        public Position Head { get; private set; }
        public Position Tail { get; private set; }
        public int Size { get; private set; }
        public Direction Direction { get; private set; }

        public Snake(int gridSize, Direction direction, int snakeSize = 3)
        {
            Size = snakeSize;
            Direction = direction;
            InitialSnakePosition(gridSize, snakeSize);
        }

        public void MoveHeadToNewPosition(Position newPosition, Direction direction)
        {
            Direction = direction;
            newPosition.Next = Head;
            Head = newPosition;
            Size++;
        }

        public void DeleteTail()
        {
            var temp = Head;
            var tempForward = Head.Next;
            while (tempForward.Next != null)
            {
                tempForward = tempForward.Next;
                temp = temp.Next;
            }
            temp.Next = null;
            Tail = temp;
            Size--;
        }

        private void InitialSnakePosition(int gridSize, int snakeSize)
        {
            int snakeX = gridSize - 1;
            int snakeY = snakeSize - 1;

            Head = new Position(snakeX, snakeY);
            var temp = Head;
            while (snakeSize > 1)
            {
                snakeY--;
                snakeSize--;
                temp.Next = new Position(snakeX, snakeY);
                temp = temp.Next;
            }
            Tail = temp;
        }
    }
}
