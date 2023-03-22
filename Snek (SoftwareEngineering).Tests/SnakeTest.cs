using System;
using Xunit;

namespace Snek__SoftwareEngineering_.Tests
{
    public class SnakeTest
    {
        private readonly ISnake _snake;
        private const int GridSize = 10;
        public SnakeTest()
        {
            _snake = new Snake(GridSize, Direction.UP, 3);
        }

        [Fact]
        public void MoveHeadToNewPosition_MovesToNextPositionSuccess()
        {
            var headPreviousPosition = _snake.Head;
            var headNewPosition = new Position(headPreviousPosition.X, headPreviousPosition.Y + 1);
            var direction = Direction.UP;

            _snake.MoveHeadToNewPosition(headNewPosition, direction);

            Assert.Equal(_snake.Head.X, headNewPosition.X);
            Assert.Equal(_snake.Head.Y, headNewPosition.Y);
            Assert.Equal(_snake.Direction, direction);
        }
        [Fact]
        public void DeleteTail_MakesSecondLastElementTailSuccess()
        {
            var headPosition = _snake.Head;
            var getSecondLastNode = GetSecondLastElementFromLinkedList(headPosition);

            _snake.DeleteTail();

            Assert.Equal(getSecondLastNode.X, _snake.Tail.X);
            Assert.Equal(getSecondLastNode.Y, _snake.Tail.Y);
        }

        private Position GetSecondLastElementFromLinkedList(Position head)
        {
            var temp = head;
            var tempForward = head.Next;
            while (tempForward.Next != null)
            {
                tempForward = tempForward.Next;
                temp = temp.Next;
            }
            return temp;
        }
    }
}
