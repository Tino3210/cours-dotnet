using System;
using System.IO;

namespace Exercice3
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            
            string path = @".\Mesures.txt";
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    while (sr.Peek() >= 0)
                    {
                        counter++;
                        String mesure = sr.ReadLine();
                        if (counter % 10 == 0)
                        {
                            Console.WriteLine($"{@mesure}");
                        }
                        else
                        {
                            Console.Write($"{@mesure}" + ", ");
                        }                       
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
            }
        }
    }
}
