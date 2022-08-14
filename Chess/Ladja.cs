namespace Chess
{
    public class Ladja: Figure
    {
        public override void MoveTo(string coordinates)
        {
            throw new System.NotImplementedException();
        }

        public override FigureType GetFigureType()
        {
            return FigureType.Ladja;
        }

        public Ladja(Desk getDesk) : base(getDesk)
        {
        }
    }
}