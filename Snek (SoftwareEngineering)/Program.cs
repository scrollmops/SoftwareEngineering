﻿using System;

namespace Snek__SoftwareEngineering_
{
    class Program
    {
        static void Main(string[] args)
        {
            int gridSize = 10;
            ISnake snake = new Snake(gridSize, Direction.RIGHT, 3);
            IGrid grid = new Grid(gridSize, snake.Head);
            IGame game = new Game(grid, snake);

            grid.DisplayGrid();
        }
    }
}
