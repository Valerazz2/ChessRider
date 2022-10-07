using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using Chess;

public abstract class Figure : DeskObj
{
    
    public FigureColor color;
    public Tile ownTile;
    private Desk _desk;

    public void MoveTo(Tile target)
    {
        if (AbleMoveTo(target))
        {
            ownTile.currentFigure = null;
            target.currentFigure = this;
            ownTile = target;   
        }
    }
    public abstract FigureType GetFigureType();
    public abstract bool AbleMoveTo(Tile target);
    

    public bool CheckTile(Tile tile, FigureColor figureColor)
    {
        if (tile.currentFigure == null || tile.currentFigure.color != figureColor)
        {
            return true;
        }

        return false;
    }
    protected Figure(Desk getDesk) : base(getDesk) {}
}
