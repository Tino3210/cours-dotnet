using System;

namespace Exercice5
{
    class Program
    {
        static void Main(string[] args)
        {
            String s1 = "Hello World";
            String s2 = " Hello World";
            String s3 = s1;

            /*
             * Equals : compare le contenu
             * CompareTo : plus petit que zero -> si s1 précède s2
             *             Zero -> si s1 et s2 ont la même position de caractère
             *             Plus grand -> s1 suit s2
             * ReferenceEquals : Regarde si les deux objets on la même références
             */

            //s1-s2

            if (s1.Equals(s2))
            {
                Console.WriteLine("Equals (s1-s2) : true");
            }
            else
            {
                Console.WriteLine("Equals (s1-s2) : false");
            }

            if (s1.CompareTo(s2) == 0)
            {
                Console.WriteLine("CompareTo (s1-s2) : Zero");
            }
            else if(s1.CompareTo(s2) > 0)
            {
                Console.WriteLine("CompareTo (s1-s2) : 1");
            }
            else if (s1.CompareTo(s2) < 0)
            {
                Console.WriteLine("CompareTo (s1-s2) : -1");
            }

            if (ReferenceEquals(s1, s2))
            {
                Console.WriteLine("ReferenceEquals (s1-s2) : true");
            }
            else
            {
                Console.WriteLine("ReferenceEquals (s1-s2) : false");
            }

            //s1-s3

            if (s1.Equals(s3))
            {
                Console.WriteLine("Equals (s1-s3) : true");
            }
            else
            {
                Console.WriteLine("Equals (s1-s3) : false");
            }

            if (s1.CompareTo(s3) == 0)
            {
                Console.WriteLine("CompareTo (s1-s3) : true");
            }
            else
            {
                Console.WriteLine("CompareTo (s1-s3) : false");
            }

            if (ReferenceEquals(s1, s3))
            {
                Console.WriteLine("ReferenceEquals (s1-s3) : true");
            }
            else
            {
                Console.WriteLine("ReferenceEquals (s1-s3) : false");
            }

            //s2-s3

            if (s2.Equals(s3))
            {
                Console.WriteLine("Equals (s2-s3) : true");
            }
            else
            {
                Console.WriteLine("Equals (s2-s3) : false");
            }

            if (s2.CompareTo(s3) == 0)
            {
                Console.WriteLine("CompareTo (s2-s3) : true");
            }
            else
            {
                Console.WriteLine("CompareTo (s2-s3) : false");
            }

            if (ReferenceEquals(s2, s3))
            {
                Console.WriteLine("ReferenceEquals (s2-s3) : true");
            }
            else
            {
                Console.WriteLine("ReferenceEquals (s2-s3) : false");
            }

        }
    }
}
