using System;
using Xunit;

namespace Snek__SoftwareEngineering_.Tests
{
    public class UnitTest1
    {
        private readonly IGrid _grid;
        private const int GridSize = 10;
        public UnitTest1()
        {
            Snake snake = new Snake(GridSize, Direction.UP, 3);
            _grid = new Grid(GridSize, snake.Head);
        }
    }
}
