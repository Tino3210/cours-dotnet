using System;
using System.Collections.Generic;
using System.Text;

namespace Serie2
{
    /// <summary>
    /// La classe <class>Joueur</class> représente le nom d'un joueur avec son token
    /// </summary>
    class Joueur
    {
        /// <summary>
        /// Constructeur de la classe Joueur
        /// </summary>
        /// <param name="name"></param>
        /// <param name="token"></param>
        public Joueur(string name, char token)
        {
            Name = name;
            Token = token;
            NbVictory = 0;
        }

        public string Name { get; set; }
        public char Token { get; set; }
        public int NbVictory { get; set; }
    }
}
