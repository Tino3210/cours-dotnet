using System;

namespace Exercice4
{
    class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            int[] numbersRNG = new int[20];

            Console.WriteLine("Valeurs à séparer : ");
            for (int i = 0; i < numbersRNG.Length; ++i)
            {
                numbersRNG[i] = rand.Next(100);
                Console.Write(numbersRNG[i] + " ");
            }

            int[] pairAndImpaire = PairImpair(numbersRNG);

            Console.WriteLine("\nPair : ");
            for (int i = 0; i < pairAndImpaire.Length; ++i)
            {
                
                if (pairAndImpaire[i] == -1)
                {
                    Console.WriteLine("\nImpaire : ");
                }
                else
                {
                    Console.Write(pairAndImpaire[i] + " ");
                }
            }
        }
        public static int[] PairImpair(int[] number)
        {
            int nbPair = 0;
            int nbImpair = 0;
            for (int i = 0; i < number.Length; ++i)
            {
                if (number[i] % 2 == 0)
                {
                    nbPair++;
                }
                else
                {
                    nbImpair++;
                }
            }

            int[] pair = new int[nbPair];
            int[] impair = new int[nbImpair];
            int[] pairAndImpaire = new int[nbImpair+nbPair+1];

            nbPair = 0;
            nbImpair = 0;
            for (int i = 0; i < number.Length; ++i)
            {
                if(number[i] % 2 == 0)
                {
                    pair[nbPair] = number[i];
                    nbPair++;
                }
                else
                {
                    impair[nbImpair] = number[i];
                    nbImpair++;
                }
            }
            pair.CopyTo(pairAndImpaire, 0);
            pairAndImpaire[nbPair] = -1;
            impair.CopyTo(pairAndImpaire, nbPair+1);
            return pairAndImpaire;
        }
    }
}
