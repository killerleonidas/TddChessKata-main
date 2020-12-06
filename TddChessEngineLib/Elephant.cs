using System;

namespace TddChessEngineLib
{
    public class Elephant
    {
        public string CurentPosition { get; private set;}
        public Elephant(string initialPosition)
        {
            CurentPosition = initialPosition;
        }
    }
}
