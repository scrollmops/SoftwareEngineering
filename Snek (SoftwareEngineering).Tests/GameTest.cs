using System;
using Xunit;

namespace Snek__SoftwareEngineering_.Tests
{
    public class GameTest
    {
        private readonly IGame _game;
        private const int GridSize = 10;

        public GameTest()
        {
            ISnake snake = new Snake(GridSize, Direction.UP, 3);
            IGrid grid = new Grid(GridSize, snake.Head);
            _game = new Game(grid, snake);
        }

        [Theory]
        [InlineData(Direction.UP, true)]
        [InlineData(Direction.RIGHT, true)]
        [InlineData(Direction.DOWN, false)]
        [InlineData(Direction.LEFT, false)]
        public void Move_Success(Direction direction, bool success)
        {
            var wasSuccess = _game.Move(direction);

            Assert.Equal(success, wasSuccess);
        }
    }
}
