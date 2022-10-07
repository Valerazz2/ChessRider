using System;

namespace Chess
{
    public class Ladja: Figure
    {
        public override FigureType GetFigureType()
        {
            return FigureType.Ladja;
        }
        
        public override bool AbleMoveTo(Tile target)
        {
            var step = ownTile.pos.GetStep(target.pos);
            if (step.IsZero() || step.X != 0 && step.Y != 0) 
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
            
            return CheckTile(target, color);
        }

        public Ladja(Desk getDesk) : base(getDesk) { }
    }
}