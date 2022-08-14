using System.Collections;
using System.Collections.Generic;
using Chess;

public class Peshka : Figure
{
    private bool wasMoved;
    public override void MoveTo(string coordinates)
    {
        ownTile.currentFigure = null;
        Desk.desk[coordinates[0] - 'a', coordinates[1]].currentFigure = this;
    }

    public override FigureType GetFigureType()
    {
        return FigureType.Peshka;
    }

    public Peshka(Desk getDesk) : base(getDesk)
    {
    }
}
