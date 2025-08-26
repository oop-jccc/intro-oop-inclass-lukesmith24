namespace intro_oop
{
    public class Circle
    {
        private readonly double _radius = 1;

        public Circle(double radius)
        {
            _radius = radius;
        }

        public double Area()
        {
            return Math.PI * _radius * _radius;
        }
    }
}
