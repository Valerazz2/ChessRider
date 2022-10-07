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
            throw new System.NotImplementedException();
        }

        public King(Desk getDesk) : base(getDesk)
        {
        }
    }
}