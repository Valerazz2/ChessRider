
using Chess;

public class Desk
{
    private static readonly int deskSizeX = 8, deskSizeY = 8;
    
    public Tile[,] desk = new Tile[deskSizeX, deskSizeY];

    private Figure[,] figuresSpots/* =
    {
        {new Ladja(this), new Horse(this), new Slon(this), new Ferz(this),
            new King(this), new Slon(this), new Horse(this), new Ladja(this)},
        {new Peshka(this), new Peshka(this), new Peshka(this), new Peshka(this), 
            new Peshka(this), new Peshka(this), new Peshka(this), new Peshka(this)},
        {null, null, null, null, null, null, null, null},
        {null, null, null, null, null, null, null, null},
        {null, null, null, null, null, null, null, null},
        {null, null, null, null, null, null, null, null},
        {null, null, null, null, null, null, null, null},
        {new Peshka(this), new Peshka(this), new Peshka(this), new Peshka(this), 
            new Peshka(this), new Peshka(this), new Peshka(this), new Peshka(this)},
        {new Ladja(this), new Horse(this), new Slon(this), new Ferz(this), 
            new King(this), new Slon(this), new Horse(this), new Ladja(this)},
    }*/;

    private void CreateMap()
    {
        for (int x = 0; x < deskSizeX; x++)
        {
            for (int y = 0; y < deskSizeY; y++)
            {
                desk[x, y] = new Tile(x, y, (x + y)  % 2 == 0 ? "black" : "white", figuresSpots[x, y]);
            }
        }
        figuresSpots =
    {
        {new Ladja(this), new Horse(this), new Slon(this), new Ferz(this),
            new King(this), new Slon(this), new Horse(this), new Ladja(this)},
        {new Peshka(this), new Peshka(this), new Peshka(this), new Peshka(this), 
            new Peshka(this), new Peshka(this), new Peshka(this), new Peshka(this)},
        {null, null, null, null, null, null, null, null},
        {null, null, null, null, null, null, null, null},
        {null, null, null, null, null, null, null, null},
        {null, null, null, null, null, null, null, null},
        {null, null, null, null, null, null, null, null},
        {new Peshka(this), new Peshka(this), new Peshka(this), new Peshka(this), 
            new Peshka(this), new Peshka(this), new Peshka(this), new Peshka(this)},
        {new Ladja(this), new Horse(this), new Slon(this), new Ferz(this), 
            new King(this), new Slon(this), new Horse(this), new Ladja(this)},
    }
    }

    public Figure GetFigureAt(string e2)
    {
        throw new System.NotImplementedException();
    }

    public Tile GetTileAt(string coordinats)
    {
        int x =  coordinats[0] - 'a';
        return desk[x, coordinats[1]];
    }
}
