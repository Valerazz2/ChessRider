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
            var figure = desk.GetFigureAt(0, 7);
            Assert.True(figure.color == FigureColor.White);
            Assert.True(figure.GetFigureType() == FigureType.Ladja);
            Assert.True(!figure.AbleMoveTo(0,5));
            figure = desk.GetFigureAt(0, 6);
            Assert.True(figure.GetFigureType() == FigureType.Peshka);
            Assert.True(figure.AbleMoveTo(0, 4));
            figure.MoveTo(0,4);
            figure = desk.GetFigureAt(0, 7);
            Assert.True(figure.GetFigureType() == FigureType.Ladja);
            Assert.True(figure.AbleMoveTo(0,5));
            figure.MoveTo(0,5);
            figure.MoveTo(4,5);
            Assert.True(figure.ownTile.GetRef() == "45");
            Assert.True(figure.AbleMoveTo(4,1));
            Assert.True(!figure.AbleMoveTo(4,0));
            
        }
    }

    
}