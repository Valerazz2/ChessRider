namespace Chess
{
    public class King : Figure
    {
        public override void MoveTo(int x, int y)
        {
            
        }

        public override FigureType GetFigureType()
        {
            return FigureType.King;
        }

        public override bool AbleMoveTo(int x, int y)
        {
            throw new System.NotImplementedException();
        }

        public King(Desk getDesk) : base(getDesk)
        {
        }
    }
}