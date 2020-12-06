using System;

namespace TddChessEngineLib
{
    public class Pawn
    {
        public string CurentPosition { get; private set;}
        public FigureColor FigureColor {get;}
        public Pawn(string initialPosition, FigureColor figureColor)
        {
            CurentPosition = initialPosition;
            FigureColor = figureColor;
        }

        // возможножсть первого хода
        // 1. Есть-ли кто-то в точке назначения.
        // 2. Границы карты.
        // 3. Направление.
        // 4. Ввести переменную, сходила-ли пешка или нет.
        // 5. (Живая или нет)
        public void Turn(string startPosition, string finalPosition)
        {
            if(FigureColor == FigureColor.Black)
            {
                if(Convert.ToInt32(finalPosition[1]) < Convert.ToInt32(startPosition[1]))
                {
                    CurentPosition = finalPosition;
                }
            }
            throw new ArgumentException("Black Pawn can't go back");

        }
        
    }

        public enum FigureColor
    {
        White,
        Black
    }

}
