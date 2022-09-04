namespace Chess
{
    public class Slon: Figure
    {
        public override void MoveTo(int x, int y)
        {
            throw new System.NotImplementedException();
        }

        public override FigureType GetFigureType()
        {
            return FigureType.Slon;
        }

        public override bool AbleMoveTo(int x, int y)
        {
            throw new System.NotImplementedException();
        }

        public Slon(Desk getDesk) : base(getDesk)
        {
        }
    }
}