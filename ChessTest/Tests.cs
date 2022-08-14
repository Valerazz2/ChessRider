using System;
using Chess;
using NUnit.Framework;

namespace ChessTest
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1()
        {
            var desk = new Desk();
            var figure = desk.GetFigureAt("e2");
            Assert.True(figure != null);
            Assert.True(figure.GetFigureType() == FigureType.Peshka);
            figure.MoveTo("e4");
            Assert.Equals(figure.GetOwnTile().GetRef(), "e4");
            Assert.True(desk.GetTileAt("e2").GetFigure() == null);
        }
    }

    
}