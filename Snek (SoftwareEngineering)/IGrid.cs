using System;
using System.Collections.Generic;
using System.Text;

namespace Snek__SoftwareEngineering_
{
    public interface IGrid
    {
        public int Size { get; }

        void DisplayGrid();
    }
}
