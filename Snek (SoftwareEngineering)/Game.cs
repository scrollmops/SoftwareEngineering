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

        public bool Move(Direction direction)
        {
            if (!isMouseSpawned)
            {
                _grid.SpawnMouse();
                isMouseSpawned = true;
            }
            var startPosition = _snake.Head;
            var endPosition = _snake.Tail;
            var newStartPosition = new Position(startPosition.X, startPosition.Y);
            switch (direction)
            {
                case Direction.RIGHT:
                    {
                        newStartPosition.Y++;
                        break;
                    }

                case Direction.LEFT:
                    {
                        newStartPosition.Y--;
                        break;
                    }

                case Direction.UP:
                    {
                        newStartPosition.X--;
                        break;
                    }

                case Direction.DOWN:
                    {
                        newStartPosition.X++;
                        break;
                    }
            }
            if (IsValidMove(newStartPosition))
            {
                _snake.MoveHeadToNewPosition(newStartPosition, direction);
                if (!_grid.IsMouseAvailable(newStartPosition))
                {
                    _snake.DeleteTail();
                    _grid.DeletePosition(endPosition);
                }
                else
                {
                    isMouseSpawned = false;
                }
                _grid.AddPosition(newStartPosition);
                _grid.DisplayGrid();
                return true;
            }
            else
            {
                Console.WriteLine("Game Over!");
                return false;
            }
        }

        private bool IsValidMove(Position newHeadPosition)
        {
            if (newHeadPosition.X > _grid.Size - 1 || newHeadPosition.X < 0 ||
                newHeadPosition.Y > _grid.Size - 1 || newHeadPosition.Y < 0)
                return false;

            var temp = _snake.Head;

            while (temp != null)
            {
                if (temp.X == newHeadPosition.X && temp.Y == newHeadPosition.Y)
                    return false;
                temp = temp.Next;
            }

            return true;
        }
    }
}
