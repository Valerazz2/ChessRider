namespace Chess
{
    public class King : Figure
    {
        public override void MoveTo(string coordinates)
        {
            
        }

        public override FigureType GetFigureType()
        {
            return FigureType.King;
        }

        public King(Desk getDesk) : base(getDesk)
        {
        }
    }
}