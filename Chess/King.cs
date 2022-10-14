namespace Chess
{
    public class King : Figure
    {
        public override FigureType GetFigureType()
        {
            return FigureType.King;
        }

        public override bool AbleMoveTo(Tile target)
        {
            var dist = Vector2Int.Distance(target.pos, ownTile.pos);
            if (dist.X < 2 && dist.Y < 2 && dist != new Vector2Int(0,0))
            {
                return CheckTile(target, color);
            }

            return false;
        }

        public King(Desk getDesk) : base(getDesk)
        {
        }
    }
}