using System;
using System.Collections.Generic;
using System.Text;

namespace Snek__SoftwareEngineering_
{
    public interface IGrid
    {
        public int Size { get; }

        void DisplayGrid();
        void SpawnMouse();
        void AddPosition(Position position);
        void DeletePosition(Position position);
        bool IsMouseAvailable(Position position);
    }
}
