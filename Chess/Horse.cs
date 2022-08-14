namespace Chess
{
    public class Horse: Figure
    {
        public override void MoveTo(string coordinates)
        {
            throw new System.NotImplementedException();
        }

        public override FigureType GetFigureType()
        {
            return FigureType.Horse;
        }

        public Horse(Desk getDesk) : base(getDesk)
        {
        }
    }
}