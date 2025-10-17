using System;

namespace Calculs
{
    /// <summary>
    /// Application Calculs : addition ou multiplication de 2 nombres
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
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
                Console.WriteLine("Addition ....................... 1");
                Console.WriteLine("Multiplication ................. 2");
                Console.WriteLine("Quitter ........................ 0");
                Console.Write("Choix :                          ");
                choix = (Console.ReadLine());

                // traitement des choix
                switch (choix)
                {
                    case "0":
                        Console.WriteLine("Au revoir !");
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
                                Console.WriteLine("erreur de saisie : veuillez saisir un nombre entier.");
                            }
                        }
                        // comparaison avec la bonne réponse
                        solution = val1 + val2;
                        if (reponse == solution)
                        {
                            Console.WriteLine("Bravo !");
                        }
                        else
                        {
                            Console.WriteLine("Faux : " + val1 + " + " + val2 + " = " + solution);
                        }
                        break;
                    case "2":
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
                                Console.WriteLine("erreur de saisie : veuillez saisir un nombre entier.");
                            }
                        }
                        // comparaison avec la bonne réponse
                        solution = val1 * val2;
                        if (reponse == solution)
                        {
                            Console.WriteLine("Bravo !");
                        }
                        else
                        {
                            Console.WriteLine("Faux : " + val1 + " x " + val2 + " = " + solution);
                        }
                        break;
                    default:
                        Console.WriteLine("erreur de saisie");
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}
