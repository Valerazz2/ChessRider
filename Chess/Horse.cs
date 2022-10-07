namespace Chess
{
    public class Horse: Figure
    {
        public override FigureType GetFigureType()
        {
            return FigureType.Horse;
        }

        public override bool AbleMoveTo(Tile target)
        {
            throw new System.NotImplementedException();
        }

        public Horse(Desk getDesk) : base(getDesk)
        {
        }
    }
}