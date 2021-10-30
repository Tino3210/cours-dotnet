using System;
using System.Collections.Generic;
using System.Text;

namespace Serie2
{
    class Jeu
    {
        Joueur joueur1;
        Joueur joueur2;
        Plateau plateau;
        Joueur joueurTurn;
        int nbGame;


        public Jeu()
        {
            plateau = new Plateau();
            nbGame = 0;
        }

        public void StartJeu()
        {
            bool play = true;
            bool inGame = true;
            bool isErrorIdSquare = false;

            Console.WriteLine("Nouvelle partie tic-tac-toe !\n");
            Console.Write("Pseudo du joueur 1 (X) : ");
            string pseudoJoueur1 = Console.ReadLine();
            Console.Write("Pseudo du joueur 2 (O) : ");
            string pseudoJoueur2 = Console.ReadLine();
            joueur1 = new Joueur(pseudoJoueur1, 'X');
            joueur2 = new Joueur(pseudoJoueur2, 'O');
            joueurTurn = joueur1;

            while (play)
            {              
                plateau.InitPlateau();
                while (inGame)
                {
                    Console.Clear();
                    Console.WriteLine("--- tic-tac-toe --- \n");
                    Rendu.RenduPlateau(plateau.GetPlateau());                    
                    Console.WriteLine("\nC'est au tour de " + joueurTurn.Name + " ({0})", joueurTurn.Token);
                    if (isErrorIdSquare)
                        Console.WriteLine("Erreur ! Le numéro de la case doit être entre 1-9 ou être vide");
                    Console.Write("Numéro de la casse à jouer : ");
                    int idSquareToPlay;
                    int.TryParse(Console.ReadLine(), out idSquareToPlay);
                    if(plateau.AddToken(idSquareToPlay, joueurTurn.Token))
                    {
                        isErrorIdSquare = false;
                        if (plateau.IsWon(joueurTurn.Token))
                        {
                            Console.Clear();
                            Console.WriteLine("--- tic-tac-toe --- \n");
                            Rendu.RenduPlateau(plateau.GetPlateau());
                            Console.WriteLine("\nVictoire de {0} ({1}) !\n", joueurTurn.Name, joueurTurn.Token);
                            joueurTurn.NbVictory++;
                            nbGame++;
                            inGame = false;
                        }
                        SwapTurn();                        
                    }
                    else
                    {
                        isErrorIdSquare = true;
                    }
                }

                Console.WriteLine("--- Scores du jeu ---");
                Console.WriteLine("Nombre de partie : " + nbGame);
                Console.WriteLine("Nombre de victoire :");
                Console.WriteLine("\t{0} ({1}) : {2}", joueur1.Name, joueur1.Token, joueur1.NbVictory);
                Console.WriteLine("\t{0} ({1}) : {2}", joueur2.Name, joueur2.Token, joueur2.NbVictory);

                Console.Write("\nVoulez-vous faire une nouvelle partie ? (o/n) : ");
                string input = Console.ReadLine();
                if (input == "N" || input == "n")
                {
                    play = false;
                }
                else
                {
                    inGame = true;
                }
            }
            Console.WriteLine("Merci d'avoir joué !");
        }

        public void SwapTurn()
        {
            if(joueurTurn == joueur2)
            {
                joueurTurn = joueur1;
            }
            else
            {
                joueurTurn = joueur2;
            }
        }
    }
}
