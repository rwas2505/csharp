namespace Packt.Shared
{
    public struct DisplacementVector
    {
        public int X;
        public int Y;
        
        public DisplacementVector(int initialX, int initialY)
        {
            X = initialX;
            Y = initialY;
        }

        public static DisplacementVector operator +(DisplacementVector Vector1, DisplacementVector Vector2)
        {
            return new DisplacementVector(Vector1.X + Vector2.X, Vector1.Y + Vector2.Y);
        }
    }
}