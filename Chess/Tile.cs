using System.Collections;
using System.Collections.Generic;
using Chess;

public class Tile
{
    public int posX, posY;
    public FigureColor color;
    public Figure currentFigure;
    
    public Tile(int X, int Y, FigureColor getColor, Figure figure)
    {
        posX = X;
        posY = Y;
        color = getColor;
        if (figure != null)
        {
            currentFigure = figure;
        }
    }

    public string GetRef()
    {
        return posX.ToString() + posY.ToString();
    }

    public Figure GetFigure()
    {
        return currentFigure;
    }
}
public class Solution {
    public static int[] TwoSum(int[] nums, int target)
    {
        for(int x = 0; x < nums.Length; x++)
        {
            for(int y = x + 1; y < nums.Length; y++)
            {
                if(nums[x] + nums[y] == target)
                {
                    return new int[]{x, y};
                }
            }
            
        }
        return null;
    }
}
