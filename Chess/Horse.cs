namespace Chess
{
    public class Horse: Figure
    {
        public override void MoveTo(int x, int y)
        {
            throw new System.NotImplementedException();
        }

        public override FigureType GetFigureType()
        {
            return FigureType.Horse;
        }

        public override bool AbleMoveTo(int x, int y)
        {
            throw new System.NotImplementedException();
        }

        public Horse(Desk getDesk) : base(getDesk)
        {
        }
    }
}