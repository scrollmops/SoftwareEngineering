using System;
using System.Collections.Generic;
using System.Text;

namespace Snek__SoftwareEngineering_
{
    public class Game : IGame
    {
        private readonly IGrid _grid;
        private readonly ISnake _snake;
        private bool isMouseSpawned;
        public Game(IGrid grid, ISnake snake)
        {
            _grid = grid;
            _snake = snake;
            _grid.SpawnMouse();
            isMouseSpawned = true;
        }
    }
}
