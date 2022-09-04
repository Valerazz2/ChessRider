namespace Chess
{
    public class Ladja: Figure
    {
        public override void MoveTo(int x, int y)
        {
            throw new System.NotImplementedException();
        }

        public override FigureType GetFigureType()
        {
            return FigureType.Ladja;
        }

        public override bool AbleMoveTo(int x, int y)
        {
            throw new System.NotImplementedException();
        }

        public Ladja(Desk getDesk) : base(getDesk)
        {
        }
    }
}