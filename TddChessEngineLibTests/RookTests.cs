using System;
using TddChessEngineLib;
using Xunit;
namespace TddChessEngineLibTests
{
    public class RookTests
    {
        [Fact]
        public void RookPosition()
        {
            string finalposition = "A1";
            Rook rook = new Rook(finalposition);
            Assert.Equal(finalposition, rook.CurrentPosition);
        }
    }
}