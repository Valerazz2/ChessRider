using System;
using System.Linq.Expressions;
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
            var figure = desk.desk[3, 6].currentFigure;
            Assert.True(figure.GetFigureType() == FigureType.Peshka);
            figure.MoveTo(desk.desk[3,3]);
            figure = desk.desk[2, 7].currentFigure;
            Assert.True(figure.GetFigureType() == FigureType.Slon);
            Assert.True(!figure.AbleMoveTo(desk.desk[2,6]));
            Assert.True(figure.AbleMoveTo(desk.desk[4,5]));
            figure.MoveTo(desk.desk[4,5]);
            Assert.True(desk.desk[0,1].currentFigure.GetFigureType() == FigureType.Peshka);
            Assert.True(desk.desk[0,1].currentFigure.color == FigureColor.Black);
            Assert.True(figure.AbleMoveTo(desk.desk[0,1]));
            figure.MoveTo(desk.desk[0,1]);
            figure = desk.desk[0, 0].currentFigure;
            Assert.True(figure.GetFigureType() == FigureType.Ladja);
            Assert.True(figure.AbleMoveTo(desk.desk[0,1]));
            figure = desk.desk[1, 7].currentFigure;
            Assert.True(figure.GetFigureType() == FigureType.Horse);
            Assert.True(figure.AbleMoveTo(desk.desk[2,5]));
            Assert.True(!figure.AbleMoveTo(desk.desk[3,5]));
            Assert.True(!figure.AbleMoveTo(desk.desk[2,6]));
            Assert.True(!figure.AbleMoveTo(desk.desk[1,5]));
            Assert.True(!figure.AbleMoveTo(desk.desk[2,4]));
            figure.MoveTo(desk.desk[2,5]);
            figure.MoveTo(desk.desk[4,4]);
            figure.MoveTo(desk.desk[6,3]);
            figure.MoveTo(desk.desk[5,1]);
            Assert.True(figure.GetFigureType() == FigureType.Horse);
            Assert.True(figure.ownTile.pos == new Vector2Int(5,1));
            figure = desk.desk[4, 7].currentFigure;
            Assert.True(figure.GetFigureType() == FigureType.King);
            Assert.True(figure.color == FigureColor.White);
            Assert.True(figure.AbleMoveTo(desk.desk[3,6]));
            Assert.True(!figure.AbleMoveTo(desk.desk[3,7]));
            Assert.True(!figure.AbleMoveTo(desk.desk[5,5]));
            Assert.True(!figure.AbleMoveTo(desk.desk[4,6]));
            figure.MoveTo(desk.desk[3,6]);
            Assert.True(figure.AbleMoveTo(desk.desk[2,5]));
            figure.MoveTo(desk.desk[2,5]);
            Assert.True(figure.AbleMoveTo(desk.desk[2,4]));
            figure.MoveTo(desk.desk[2,4]);
            Assert.True(desk.desk[2,4].currentFigure.GetFigureType() == FigureType.King);
        }
    }

    
}