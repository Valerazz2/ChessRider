namespace Chess
{
    public class Slon: Figure
    {
        public override void MoveTo(string coordinates)
        {
            throw new System.NotImplementedException();
        }

        public override FigureType GetFigureType()
        {
            return FigureType.Slon;
        }

        public Slon(Desk getDesk) : base(getDesk)
        {
        }
    }
}