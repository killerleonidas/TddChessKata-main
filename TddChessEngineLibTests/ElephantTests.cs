using System;
using TddChessEngineLib;
using Xunit;
namespace TddChessEngineLibTests
{
    public class ElephantTests
    {
        [Fact]
        public void WhenCreatingElephantOnE2_ThenItCurrentPositionE2()
        {
            string finalPosition = "E2";
            Elephant elephant = new Elephant(finalPosition);
            Assert.Equal(finalPosition, elephant.CurentPosition);
        }

        [Fact]
        public void WhenTryCreatingElephantOnE9_ThenItThrowsArgumentException()
        {
            string startPosition = "E9";
            Elephant elephant = new Elephant(startPosition);
            Assert.Throws<ArgumentException>(() => elephant(startPosition));
        }
    }
}