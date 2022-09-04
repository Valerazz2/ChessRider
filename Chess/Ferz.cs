namespace Chess
{
    public class Ferz: Figure
    {
        public override void MoveTo(int x, int y)
        {
            throw new System.NotImplementedException();
        }

        public override FigureType GetFigureType()
        {
            return FigureType.Ferz;
        }

        public override bool AbleMoveTo(int x, int y)
        {
            throw new System.NotImplementedException();
        }

        public Ferz(Desk getDesk) : base(getDesk) {}
    }
}