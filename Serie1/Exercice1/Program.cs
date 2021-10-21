using System;

namespace Exercice1
{
    public struct Point3D
    {
        public Point3D(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public double DistanceToOrigin()
        {
            return Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2) + Math.Pow(Z, 2));
        }

        public override string ToString() => $"({X}, {Y}, {Z})";
    }

    class Program
    {
        public static void SwapPoints(ref Point3D p1, ref Point3D p2)
        {
            double tempX = p1.X;
            double tempY = p1.Y;
            double tempZ = p1.Z;
            p1.X = p2.X;
            p1.Y = p2.Y;
            p1.Z = p2.Z;
            p2.X = tempX;
            p2.Y = tempY;
            p2.Z = tempZ;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Exercice 1");

            Point3D p1 = new Point3D(2, 3, 4);
            Point3D p2 = new Point3D(5, 6, 7);

            Console.WriteLine("P1 : " + p1.X + ", " + p1.Y + ", " + p1.Z);
            Console.WriteLine("P1 distance to origin : " + p1.DistanceToOrigin() + "\n");

            Console.WriteLine("P2 : " + p2.X + ", " + p2.Y + ", " + p2.Z);
            Console.WriteLine("P2 distance to origin : " + p2.DistanceToOrigin() + "\n");

            SwapPoints(ref p1, ref p2);
            Console.WriteLine("Swap p1 with p2");
            Console.WriteLine("P1 : " + p1.X + ", " + p1.Y + ", " + p1.Z);
            Console.WriteLine("P2 : " + p2.X + ", " + p2.Y + ", " + p2.Z);


        }
    }
}
