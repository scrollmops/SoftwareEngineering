using System;
using System.Collections.Generic;
using System.Text;

namespace Snek__SoftwareEngineering_
{
    class Grid : IGrid
    {
        private char[,] _grid;

        public int Size { get; }

        public Grid(int size, Position snakeHead)
        {
            Size = size;
            _grid = new char[size, size];
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    _grid[i, j] = '+';
                }
            }
            AddSnakePosition(snakeHead);
        }

        public void DisplayGrid()
        {
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    Console.Write(_grid[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

        private void AddSnakePosition(Position snakeHead)
        {
            var temp = snakeHead;
            while (temp != null)
            {
                _grid[temp.X, temp.Y] = 'S';
                temp = temp.Next;
            }
        }

        public void AddPosition(Position position)
        {
            _grid[position.X, position.Y] = 'S';
        }

        public void DeletePosition(Position position)
        {
            _grid[position.X, position.Y] = '+';
        }

        public void SpawnMouse()
        {
            Random random = new Random();
            int x = random.Next(0, Size);
            int y = random.Next(0, Size);
            while (_grid[x, y] != '+')
            {
                x = random.Next(0, Size);
                y = random.Next(0, Size);
            }
            _grid[x, y] = 'M';
        }

        public bool IsMouseAvailable(Position position)
        {
            if (_grid[position.X, position.Y] == 'M')
                return true;
            return false;
        }



    }
}
