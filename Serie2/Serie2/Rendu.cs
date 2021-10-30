using System;
using System.Collections.Generic;
using System.Text;

namespace Serie2
{
    /// <summary>
    /// La classe <class>Rendu</class> permet d'afficher le plateau 
    /// </summary>
    class Rendu
    {
        public static void RenduPlateau(char[,] plateau)
        {
            for (int j = 0; j < plateau.GetLength(0); j++)
            {
                Console.WriteLine(" {0} | {1} | {2} ", plateau[j,0], plateau[j, 1], plateau[j, 2]);
                if (j < plateau.GetLength(0)-1)
                {
                    Console.WriteLine("---+---+---");
                }                
            }
        }
    }
}
