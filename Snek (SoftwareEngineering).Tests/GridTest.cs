using System;
using Xunit;

namespace Snek__SoftwareEngineering_.Tests
{
    public class GridTest
    {
        private readonly IGrid _grid;
        private const int GridSize = 10;
        public GridTest()
        {
            Snake snake = new Snake(GridSize, Direction.UP, 3);
            _grid = new Grid(GridSize, snake.Head);
        }

        [Fact]
        public void DisplayGrid_TestPassed()
        {
            _grid.DisplayGrid();
        }

        [Fact]
        public void AddPosition_TestPassed()
        {
            var position = new Position(2, 3);
            _grid.AddPosition(position);
        }

        [Fact]
        public void DeletePosition_TestPassed()
        {
            var position = new Position(2, 3);
            _grid.DeletePosition(position);
        }

        [Fact]
        public void SpawnMouse_TestPassed()
        {
            _grid.SpawnMouse();
        }

        [Fact]
        public void IsMouseAvailable_Success()
        {
            var grid = new Grid(GridSize, new Position(0, 0));
            var position = new Position(3, 3);

            var isMouseAvailable = grid.IsMouseAvailable(position);

            Assert.False(isMouseAvailable);
        }
    }
}
