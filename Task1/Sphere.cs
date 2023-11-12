namespace Task1
{
    internal class Sphere
    {
        private double x, y, z, radius;
        public Sphere(double x = 0, double y = 0, double z = 0, double radius = 1)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.radius = radius;
        }

        public double Radius
        {
            get { return radius; }
            set
            {
                if (value > 0)
                {
                    radius = value;
                }
                else
                {
                    Console.WriteLine("Введён радиус меньше допустимого.Установлен радиус равный 1 ");
                    radius = 1;
                }
            }
        }

        public double GetVolume()
        {
            return 4.0 / 3.0 * Math.PI * radius * radius * radius;
        }

        public double GetSquare()
        {
            return 4 * Math.PI * (radius * radius);
        }

        public string GetCenter()
        {
            return $"{x} {y} {z}";
        }

        public void SetCenter(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public bool IsPointInside(double x, double y, double z)
        {
            double newRadius = Math.Sqrt(
                  ((x - this.x) * (x - this.x))
                + ((y - this.y) * (y - this.y))
                + ((z - this.z) * (z - this.z)));
            if (newRadius <= radius)
            {
                return true;
            }
            return false;
        }
    }
}
