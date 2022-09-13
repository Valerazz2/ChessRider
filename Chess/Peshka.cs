using System;
using System.Collections;
using System.Collections.Generic;
using Chess;

public class Peshka : Figure
{
    private bool wasMoved;
    
    public override void MoveTo(int x, int y)
    {
        if (AbleMoveTo(x, y) || AbleEat(x, y))
        {
            ownTile.currentFigure = null;
            Desk.desk[x, y].currentFigure = this;
            ownTile = Desk.desk[x, y];
            wasMoved = true;
        }
    }

    public override FigureType GetFigureType()
    {
        return FigureType.Peshka;
    }

    public override bool AbleMoveTo(int x, int y)
    {
        if (Desk.desk[x, y].currentFigure != null)
            return false;
        
        if (MoveIsForward(color, x, y))
        {
            return true;
        }
        return false;
    }

    private bool MoveIsForward(FigureColor getColor, int getX, int getY)
    {
        int distY = getY - ownTile.posY;
        if (Math.Abs(distY) == 2 && !wasMoved)
            distY /= 2;
        
        if (getColor == FigureColor.Black && getX - ownTile.posX == 0 && distY == 1)
        {
            return true;
        }
        if (getColor == FigureColor.White && getX - ownTile.posX == 0 && distY == -1)
        {
            return true;
        }
        return false;
    }
    
    public bool AbleEat(int x, int y)
    {
        if (Desk.GetFigureAt(x, y) != null && Desk.desk[x, y].currentFigure.color != color && Math.Abs(x - ownTile.posX) == 1)
        {
            if (color == FigureColor.Black && y - ownTile.posY == 1 || color == FigureColor.White && y - ownTile.posY == -1)
            {
                return true;
            }
        }
        return false;
    }

    public Peshka(Desk getDesk) : base(getDesk) { }
}
