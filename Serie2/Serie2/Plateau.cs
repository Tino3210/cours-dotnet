using System;
using System.Collections.Generic;
using System.Text;

namespace Serie2
{
    /// <summary>
    /// La classe <class>Plateau</class> représente le tableau deux dimensions qui contient les tokens
    /// </summary>
    class Plateau : Iterminable
    {
        private char[,] plateau;

        public Plateau()
        {
            plateau = new char[3,3];            
        }

        /// <summary>
        /// Initialise le tableau avec des char espace
        /// </summary>
        public void InitPlateau()
        {
            for(int j = 0; j < plateau.GetLength(0); j++)
            {
                for (int i = 0; i < plateau.GetLength(1); i++)
                {
                    plateau[j,i] = ' ';
                }
            }
        }

        public char this[int j, int i]
        {
            get { return plateau[j,i]; }
            set { plateau[j,i] = value; }
        }
        public char[,] GetPlateau()
        {
            return plateau;
        }

        /// <summary>
        /// Ajoute le token dans la case en paramètre si la place est libre
        /// </summary>
        /// <param name="idSquareToPlay"></param>
        /// <param name="token"></param>
        /// <returns></returns>
        public bool AddToken(int idSquareToPlay, char token)
        {
            bool isValid = true;
            int j = 0;
            int i = 0;

            switch (idSquareToPlay){
                case 7:
                    j = 0;
                    i = 0;
                    break;
                case 8:
                    j = 0;
                    i = 1;
                    break;
                case 9:
                    j = 0;
                    i = 2;
                    break;
                case 4:
                    j = 1;
                    i = 0;
                    break;
                case 5:
                    j = 1;
                    i = 1;
                    break;
                case 6:
                    j = 1;
                    i = 2;
                    break;
                case 1:
                    j = 2;
                    i = 0;
                    break;
                case 2:
                    j = 2;
                    i = 1;
                    break;
                case 3:
                    j = 2;
                    i = 2;
                    break;
                default:
                    isValid = false;
                    break;
            }
            if (isValid)
            {
                if (plateau[j, i] == ' ')
                {
                    plateau[j, i] = token;
                }
                else
                {
                    isValid = false;
                }             
            }
            return isValid;
        }

        /// <summary>
        /// Contrôle si un joueur à gagné
        /// Reférence : https://jayeshkawli.ghost.io/tic-tac-toe/
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        public bool IsWon(char token)
        {
            bool isWin = false;
            int[] columnsContainer = new int[3];
            int[] diagonalContainer = { 0, 0, 0 };
            int[] oppositeDiagonalContainer = { 0, 0, 0 };
            
            for (int j = 0; j < plateau.GetLength(0); j++)
            {
                bool winRow = true;
                for (int i = 0; i < plateau.GetLength(1); i++)
                {
                    if (plateau[j,i] != token)
                    {
                        winRow = false;
                    }
                    else
                    {
                        columnsContainer[i]++;
                        if (j == i)
                            diagonalContainer[i]++;
                        if (j + i + 1 == 3)
                            oppositeDiagonalContainer[i]++;
                    }                    
                }
                if (winRow)
                    return winRow;                
            }
            if (columnsContainer[0] == 3 || columnsContainer[1] == 3 || columnsContainer[2] == 3)
                return true;
            if (diagonalContainer[0] == 1 && diagonalContainer[1] == 1 && diagonalContainer[2] == 1)
                return true;
            if (oppositeDiagonalContainer[0] == 1 && oppositeDiagonalContainer[1] == 1 && oppositeDiagonalContainer[2] == 1)
                return true;
            
            return isWin;
        }
    }
}
