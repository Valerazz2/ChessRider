using System.Collections;
using System.Collections.Generic;
using Chess;

public class Peshka : Figure
{
    private bool wasMoved;
    public override void MoveTo(int x, int y)
    {
        ownTile.currentFigure = null;
        Desk.desk[y, x].currentFigure = this;
        ownTile = Desk.desk[y, x];
    }

    public override FigureType GetFigureType()
    {
        return FigureType.Peshka;
    }

    public override bool AbleMoveTo(int x, int y)
    {
        throw new System.NotImplementedException();
    }

    public Peshka(Desk getDesk) : base(getDesk) { }
}
