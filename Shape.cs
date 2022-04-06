namespace LibForVacancy
{
    public abstract class Shape
    {
        private readonly double _area;
        
        public double Area => _area;


        protected Shape()
        {
            _area = CalcArea();
        }

        protected abstract double CalcArea();
    }
}
