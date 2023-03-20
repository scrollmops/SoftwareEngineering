using System;

namespace Snek__SoftwareEngineering_
{
    class Program
    {
        static void Main(string[] args)
        {
            int gridSize = 10;
            IGrid grid = new Grid(gridSize);

            grid.DisplayGrid();
        }
    }
}
