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
            set { radius = value; }
        }

        public double GetVolume()
        {
            return 4.0 / 3.0 * Math.PI * Math.Pow(radius, 3);
        }

        public double GetSquare()
        {
            return 4 * Math.PI * Math.Pow(radius, 2);
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
            bool result = false;
            double newRadius = Math.Sqrt(
                  ((x - this.x) * (x - this.x))
                + ((y - this.y) * (y - this.y))
                + ((z - this.z) * (z - this.z)));
            if (newRadius <= radius)
            {
                result = true;
            }
            return result;
        }
    }
}
