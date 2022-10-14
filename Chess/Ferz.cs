using System.IO;

namespace Chess
{
    public class Ferz: Figure
    {
        public override FigureType GetFigureType()
        {
            return FigureType.Ferz;
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
            if (dist.X == dist.Y || dist.Y == 0 && dist.X != 0 || dist.Y != 0 && dist.X == 0)
            {
                return CheckTile(target, color);
            }

            return false;
        }

        public Ferz(Desk getDesk) : base(getDesk) {}
    }
}