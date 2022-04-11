
namespace LibForVacancy
{
    public class Triangle : IShape
    {
        private double _area;
        private readonly bool _isTriangleRight;

        public double SideOne { get; }
        public double SideTwo { get; }
        public double SideThree { get; }

        public double Area { get { return _area; } }

        public bool IsTriangleRight => _isTriangleRight;


        public Triangle(double sideOne, double sideTwo, double sideThree)
        {
            if (sideOne < 0 || sideTwo < 0 || sideThree < 0)
            {
                throw new ArgumentException("ни одна из сторон треугольника не может быть отрицательной");
            }

            SideOne = sideOne;
            SideTwo = sideTwo;
            SideThree = sideThree;

            _area = CalcArea();
            _isTriangleRight = CheckIsTriangleRight();
        }


        private bool CheckIsTriangleRight() //проверка треугольника на нормальность
        {
            return SideOne == Math.Sqrt(SideTwo * SideTwo + SideThree * SideThree)
                || SideTwo == Math.Sqrt(SideOne * SideOne + SideThree * SideThree)
                || SideThree == Math.Sqrt(SideOne * SideOne + SideTwo * SideTwo);
        }


        public double CalcArea() //реализация интерфейса для треугольника
        {
            double sPerim = (SideOne + SideTwo + SideThree) / 2; //находим полупериметр
            return Math.Sqrt(sPerim * (sPerim - SideOne) * (sPerim - SideTwo) * (sPerim - SideThree));
        }
    }
}
