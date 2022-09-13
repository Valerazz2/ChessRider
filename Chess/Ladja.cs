using System;

namespace Chess
{
    public class Ladja: Figure
    {
        public override void MoveTo(int x, int y)
        {
            if (AbleMoveTo(x, y))
            {
                ownTile.currentFigure = null;
                Desk.desk[x, y].currentFigure = this;
                ownTile = Desk.desk[x, y];
            }
        }

        public override FigureType GetFigureType()
        {
            return FigureType.Ladja;
        }
        
        public override bool AbleMoveTo(int x, int y)
        {
            int distX = x - ownTile.posX;
            int distY = y - ownTile.posY;
            if (distX != 0 && distY == 0 || distX == 0 && distY != 0)
            {
                if (distX != 0)
                {
                    int minX, maxX;
                    minX = x < ownTile.posX ? x : ownTile.posX;
                    maxX = x < ownTile.posX ? ownTile.posX : x;
                    for (int i = (minX + 1); i < maxX; i++)
                    {
                        if (Desk.desk[i, y].currentFigure != null)
                        {
                            return false;
                        }
                    }
                }
                
                if (distY != 0)
                {
                    int minY, maxY;
                    minY = y < ownTile.posY ? y : ownTile.posY;
                    maxY = y < ownTile.posY ? ownTile.posY : y;
                    for (int i = (minY + 1); i < maxY; i++)
                    {
                        if (Desk.desk[x, i].currentFigure != null)
                        {
                            return false;
                        }
                    }
                }

                return Desk.desk[x, y] == null || Desk.desk[x, y].currentFigure.color != color;
                
            }
            return false;
        }

        public Ladja(Desk getDesk) : base(getDesk) { }
    }
}