using System;

namespace Exercice2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nombre réel positif : ");
            double reel = 0;
            reel = Double.Parse(Console.ReadLine());
            DateTime dt1 = new DateTime();
            int nbApro = ApproSqrt(reel, reel);
            DateTime dt2 = new DateTime();
            Console.WriteLine("Temps écoulé : " + dt2.Subtract(dt1));
            Console.WriteLine("Nombre d'apporimation : " + nbApro);
        }

        public static int ApproSqrt(double A, double apro)
        {
            int nbApro = 1;
            double newApro = (apro + A / apro) / 2;
            Console.WriteLine("Approximation de la racine carrée de " + A + " est " + Math.Round(newApro,3));
            if (newApro - Math.Sqrt(A) > (A*Math.Pow(10, -9)))
            {
                nbApro++;
                ApproSqrt(A, newApro);
            }
            return nbApro;
        }
    }
}
