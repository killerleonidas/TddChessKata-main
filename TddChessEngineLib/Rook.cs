using System;

namespace TddChessEngineLib
{
    public class Rook
    {
        public string CurrentPosition {get;set;}
        public Rook(string position)
        {
            CurrentPosition = position;
        }
    }
}