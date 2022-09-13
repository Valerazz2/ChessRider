
using System;
using Chess;

public class Desk
{
    private static readonly int deskSizeX = 8, deskSizeY = 8;
    
    public Tile[,] desk = new Tile[deskSizeX, deskSizeY];

    private Figure[,] figuresSpots = new Figure[8,8];

    public void CreateMap()
    {
        figuresSpots = new Figure[,]
        {
            {new Ladja(this), new Peshka(this), null, null, null, null, new Peshka(this), new Ladja(this)},
            {new Horse(this), new Peshka(this), null, null, null, null, new Peshka(this), new Horse(this)},
            {new Slon(this), new Peshka(this), null, null, null, null, new Peshka(this), new Slon(this)},
            {new King(this), new Peshka(this), null, null, null, null, new Peshka(this), new King(this)},
            {new Ferz(this), new Peshka(this), null, null, null, null, new Peshka(this), new Ferz(this)},
            {new Slon(this), new Peshka(this), null, null, null, null, new Peshka(this), new Slon(this)},
            {new Horse(this), new Peshka(this), null, null, null, null, new Peshka(this), new Horse(this)},
            {new Ladja(this), new Peshka(this), null, null, null, null, new Peshka(this), new Ladja(this)}
        };
        
        for (int x = 0; x < deskSizeX; x++)
        {
            for (int y = 0; y < deskSizeY; y++)
            {
                desk[x, y] = new Tile(x, y, (x + y)  % 2 == 0 ? FigureColor.Black : FigureColor.White, figuresSpots[x, y]);
                if (figuresSpots[x, y] != null)
                {
                    figuresSpots[x, y].ownTile = desk[x, y];
                    figuresSpots[x, y].color = y <= 2 ? FigureColor.Black : FigureColor.White;
                }
            }
        }
    }
    public Figure GetFigureAt(int x, int y)
    {
        return desk[x, y].GetFigure();
    }

    public Tile GetTileAt(int x, int y)
    {
        return desk[x, y];
    }
}
