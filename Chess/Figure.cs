using System.Collections;
using System.Collections.Generic;
using Chess;

public abstract class Figure : DeskObj
{
    protected string color;
    protected FigureType _figureType;
    protected Tile ownTile;
    private Desk _desk;
    
    public abstract void MoveTo(string coordinates);
    public abstract FigureType GetFigureType();

    public Tile GetOwnTile()
    {
        return ownTile;
    }

    protected Figure(Desk getDesk) : base(getDesk)
    { }
}
