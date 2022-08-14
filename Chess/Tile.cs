using System.Collections;
using System.Collections.Generic;

public class Tile
{
    public int posX, posY;
    public string color;
    public Figure currentFigure;
    
    public Tile(int X, int Y, string GetColor, Figure figure)
    {
        posX = X;
        posY = Y;
        color = GetColor;
        if (figure != null)
        {
            currentFigure = figure;
        }
    }

    public string GetRef()
    {
        return (char)(posX + 'a') + posY.ToString();
    }

    public Figure GetFigure()
    {
        return currentFigure;
    }
}
