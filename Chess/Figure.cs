using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using Chess;

public abstract class Figure : DeskObj
{
    
    public FigureColor color;
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
