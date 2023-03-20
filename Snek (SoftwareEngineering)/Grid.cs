using System;
using System.Collections.Generic;
using System.Text;

namespace Snek__SoftwareEngineering_
{
    class Grid : IGrid
    {
        private char[,] _grid;

        public int Size { get; }

        public Grid(int size)
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
    }
}
