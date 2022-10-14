using System;

namespace Chess
{
    public class Slon: Figure
    {
        public override FigureType GetFigureType()
        {
            return FigureType.Slon;
        }

        public override bool AbleMoveTo(Tile target)
        {
            var step = ownTile.pos.GetStep(target.pos);
            if (step.IsZero())
            {
                return false;
            }

            for (var pos = ownTile.pos + step; pos != target.pos; pos += step)
            {
                if (Desk.desk[pos.X, pos.Y].currentFigure != null)
                {
                    return false;
                }   
            }
            var dist = Vector2Int.Distance(target.pos, ownTile.pos);
            return CheckTile(target, color) && dist.X == dist.Y;
            
        }

        public Slon(Desk getDesk) : base(getDesk)
        {
        }
    }
}