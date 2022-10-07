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
            throw new System.NotImplementedException();
        }

        public Slon(Desk getDesk) : base(getDesk)
        {
        }
    }
}