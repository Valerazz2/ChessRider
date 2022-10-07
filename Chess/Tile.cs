using System.Collections;
using System.Collections.Generic;
using Chess;

public class Tile
{
    public Vector2Int pos;
    public FigureColor color;
    public Figure currentFigure;
    
    public Tile(Vector2Int getPos, FigureColor getColor, Figure figure)
    {
        pos = getPos;
        color = getColor;
        if (figure != null)
        {
            currentFigure = figure;
        }
    }

    public Vector2Int GetRef()
    {
        return pos;
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
