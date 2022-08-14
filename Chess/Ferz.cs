namespace Chess
{
    public class Ferz: Figure
    {
        public override void MoveTo(string coordinates)
        {
            throw new System.NotImplementedException();
        }

        public override FigureType GetFigureType()
        {
            return FigureType.Ferz;
        }

        public Ferz(Desk getDesk) : base(getDesk) {}
    }
}