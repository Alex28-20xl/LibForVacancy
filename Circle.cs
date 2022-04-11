
namespace LibForVacancy
{
    
        public class Circle : IShape
        {
            private double _area;

            public double Radius { get; }
            public double Area { get { return _area; } }


            public Circle(double rad)
            {
                if (rad < 0)
                {
                    throw new ArgumentException("Радиус не может быть отрицательным");
                }

                Radius = rad;
                _area = CalcArea();
            }

        public double CalcArea() //реализация для круга
        {
            return Math.PI * Radius * Radius;
        }
    }        
 }

