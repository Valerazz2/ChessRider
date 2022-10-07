using System;
using System.Collections;
using System.Collections.Generic;
using Chess;

public class Peshka : Figure
{
    private bool wasMoved;
    
    public override FigureType GetFigureType()
    {
        return FigureType.Peshka;
    }

    public override bool AbleMoveTo(Tile target)
    {
        if (MoveIsForward(target) && target.currentFigure == null
            || AbleEat(target))
        {
            return true;
        }
        return false;
    }

    private bool MoveIsForward(Tile targetTile)
    {
        var step = ownTile.pos.GetStep(targetTile.pos);
        if (color == FigureColor.Black && step == new Vector2Int(0, 1)
            || color == FigureColor.White && step == new Vector2Int(0, -1))
        {
            return true;
        }

        return false;
    }

    public bool AbleEat(Tile targetTile)
    {
        Vector2Int dist = Vector2Int.Distance(targetTile.pos, ownTile.pos);
        if (targetTile.currentFigure != null && Math.Abs(dist.X) == 1 && targetTile.currentFigure.color != color)
        {
            if (color == FigureColor.Black && dist.Y == 1 || color == FigureColor.White && dist.Y == -1)
            {
                return true;
            }
        }
        return false;
    }

    public Peshka(Desk getDesk) : base(getDesk) { }
}
