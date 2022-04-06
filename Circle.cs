namespace LibForVacancy
{
    public class Circle:Shape
    {
        public double Radius { get; }

                
        public Circle(double rad)
        {
            if(rad < 0)
            {
                throw new ArgumentOutOfRangeException("Радиус не может быть отрицательным");
            }
            
            Radius = rad;
        }

        protected sealed override double CalcArea()
        {
           return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
