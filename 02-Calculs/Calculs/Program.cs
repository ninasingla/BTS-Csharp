using System;

namespace Calculs
{
    /// <summary>
    /// Application Calculs : addition, soustraction ou multiplication de 2 nombres
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // Message de présentation au début
            Console.WriteLine("════════════════════════════════════════════════════════════════");
            Console.WriteLine("                 Bienvenue au jeu de Calculs !");
            Console.WriteLine("════════════════════════════════════════════════════════════════");
            Console.WriteLine("Testez vos compétences en calcul mental :");
            Console.WriteLine("- Choisissez entre addition, soustraction ou multiplication");
            Console.WriteLine("- Répondez aux calculs générés aléatoirement");
            Console.WriteLine("- Entraînez-vous autant que vous voulez !");
            Console.WriteLine();
            Console.WriteLine("Appuyez sur Entrée pour commencer...");
            Console.ReadLine();
            Console.Clear();

            // variables 
            Random rand = new Random();
            int val1, val2;
            int solution;
            int reponse = 0;
            string choix = "1";
            bool correct;

            // boucle sur le menu
            while (choix != "0")
            {
                // affiche le menu et saisi le choix
                Console.WriteLine("══════════════ MENU ══════════════");
                Console.WriteLine("Addition ....................... 1");
                Console.WriteLine("Soustraction ................... 2");
                Console.WriteLine("Multiplication ................. 3");
                Console.WriteLine("Quitter ........................ 0");
                Console.WriteLine("══════════════════════════════════");
                Console.Write("Choix :                          ");
                choix = (Console.ReadLine());
                Console.WriteLine();

                // traitement des choix
                switch (choix)
                {
                    case "0":
                        Console.WriteLine("\nAu revoir !");
                        Console.WriteLine();
                        break;
                    case "1":
                        // choix de l'addition
                        val1 = rand.Next(1, 10);
                        val2 = rand.Next(1, 10);
                        correct = false;

                        while (!correct)
                        {
                            try
                            {
                                // saisie de la réponse
                                Console.Write(val1 + " + " + val2 + " = ");
                                reponse = int.Parse(Console.ReadLine());
                                correct = true;
                            }
                            catch
                            {
                                Console.WriteLine();
                                Console.WriteLine("Erreur de saisie : veuillez saisir un nombre entier.");
                                Console.WriteLine();
                            }
                        }
                        // comparaison avec la bonne réponse
                        solution = val1 + val2;
                        if (reponse == solution)
                        {
                            Console.WriteLine("\nBravo !");
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("Faux : " + val1 + " + " + val2 + " = " + solution);
                            Console.WriteLine();
                        }
                        break;
                    case "2":
                        // choix de la soustraction
                        val1 = rand.Next(1, 10);
                        val2 = rand.Next(1, 10);
                        correct = false;

                        while (!correct)
                        {
                            try
                            {
                                // saisie de la réponse
                                Console.Write(val1 + " - " + val2 + " = ");
                                reponse = int.Parse(Console.ReadLine());
                                correct = true;
                            }
                            catch
                            {
                                Console.WriteLine();
                                Console.WriteLine("Erreur de saisie : veuillez saisir un nombre entier.");
                                Console.WriteLine();
                            }
                        }
                        // comparaison avec la bonne réponse
                        solution = val1 - val2;
                        if (reponse == solution)
                        {
                            Console.WriteLine("\nBravo !");
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("Faux : " + val1 + " - " + val2 + " = " + solution);
                            Console.WriteLine();
                        }
                        break;
                    case "3":
                        // choix de la multiplication
                        val1 = rand.Next(1, 10);
                        val2 = rand.Next(1, 10);
                        correct = false;

                        while (!correct)
                        {
                            try
                            {
                                // saisie de la réponse
                                Console.Write(val1 + " x " + val2 + " = ");
                                reponse = int.Parse(Console.ReadLine());
                                correct = true;
                            }
                            catch
                            {
                                Console.WriteLine();
                                Console.WriteLine("Erreur de saisie : veuillez saisir un nombre entier.");
                                Console.WriteLine();
                            }
                        }
                        // comparaison avec la bonne réponse
                        solution = val1 * val2;
                        if (reponse == solution)
                        {
                            Console.WriteLine("\nBravo !");
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("Faux : " + val1 + " x " + val2 + " = " + solution);
                            Console.WriteLine();
                        }
                        break;
                    default:
                        Console.WriteLine("erreur de saisie");
                        Console.WriteLine();
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}