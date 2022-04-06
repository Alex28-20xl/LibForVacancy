namespace LibForVacancy
{
    public class Triangle:Shape
    {
        private readonly bool _isTriangleRight;

        public double SideOne { get; }
        public double SideTwo { get; }
        public double SideThree { get; }
                
        public bool IsTriangleRight => _isTriangleRight;

        
        public Triangle(double sideOne, double sideTwo, double sideThree)
        {
            if(sideOne < 0 || sideTwo<0 || sideThree < 0)
            {
                throw new ArgumentException("ни одна из сторон треугольника не может быть отрицательной");
            }

            SideOne=sideOne;
            SideTwo=sideTwo;
            SideThree=sideThree;

            _isTriangleRight = CheckIsTriangleRight();
        }

        private bool CheckIsTriangleRight()
        {
            //написать функцию проверки 
            return true;
        }

        protected sealed override double CalcArea()
        {
            //написать функцию вычисления площади
            return 0.0;
        }
    }
}
