using System.Collections;
using System.Collections.Generic;
using Chess;

public abstract class Figure : DeskObj
{
    protected string color;
    protected FigureType _figureType;
    public Tile ownTile;
    private Desk _desk;
    
    public abstract void MoveTo(int x, int y);
    public abstract FigureType GetFigureType();
    public abstract bool AbleMoveTo(int x, int y);

    public Tile GetOwnTile()
    {
        return ownTile;
    }

    protected Figure(Desk getDesk) : base(getDesk) {}
}
