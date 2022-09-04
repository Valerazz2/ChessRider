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
            desk.CreateMap();
            var figure = desk.GetFigureAt(3,1);
            Assert.True(figure != null);
            Assert.True(figure.GetFigureType() == FigureType.Peshka);
            figure.MoveTo(3,4);
            Assert.True(figure.GetOwnTile().GetRef() == "43");
            Assert.True(desk.GetTileAt(3, 1).GetFigure() == null);
        }
    }

    
}