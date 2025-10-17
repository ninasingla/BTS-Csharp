using System;

namespace NombreCache
{
    /// <summary>
    /// Jeu du nombre caché
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // déclaration de la variable pour rejouer
            string rejouer;

            // message de bienvenue
            Console.WriteLine("══════════════════════════════════════════════");
            Console.WriteLine("     Bienvenue au jeu du Nombre Caché !");
            Console.WriteLine("══════════════════════════════════════════════");
            Console.WriteLine("\nLe but du jeu est simple :");
            Console.WriteLine("- Un premier joueur choisit un nombre");
            Console.WriteLine("- Un deuxième joueur doit le deviner");
            Console.WriteLine("- Des indices seront donnés à chaque essai");
            Console.WriteLine();
            Console.WriteLine("Appuyez sur Entrée pour commencer...");
            Console.ReadLine();
            Console.Clear();

            do
            {
                // déclaration
                int valeur = 0, essai = 0, nombre = 1;
                bool correct;

                // saisie du nombre à chercher
                correct = false;
                while (!correct)
                {
                    try
                    {
                        Console.Write("Entrez le nombre à chercher : ");
                        valeur = int.Parse(Console.ReadLine());
                        correct = true;
                    }
                    catch
                    {
                        Console.WriteLine("\nErreur de saisie : saisissez un nombre entier");
                        Console.WriteLine();
                    }
                }
                Console.Clear();

                // saisie du premier essai
                correct = false;
                while (!correct)
                {
                    try
                    {
                        Console.Write("Entrez un essai : ");
                        essai = int.Parse(Console.ReadLine());
                        correct = true;
                    }
                    catch
                    {
                        Console.WriteLine("\nErreur de saisie : saisissez un nombre entier");
                        Console.WriteLine();
                    }
                }

                // boucle sur les essais
                while (essai != valeur)
                {
                    // test de l'essai par rapport à la valeu à chercher
                    if (essai > valeur)
                    {
                        Console.WriteLine("\n --> trop grand !");
                    }
                    else
                    {
                        Console.WriteLine("\n --> trop petit !");
                    }
                    // saisie d'un nouvel essai
                    correct = false;
                    while (!correct)
                    {
                        try
                        {
                            Console.Write("\nEntrez un nouvel essai : ");
                            essai = int.Parse(Console.ReadLine());
                            correct = true;
                        }
                        catch
                        {
                            Console.WriteLine("\nErreur de saisie : saisissez un nombre entier");
                        }
                    }
                    // compteur d'essai
                    nombre++;
                }

                // valeur trouvée
                Console.WriteLine("\nBravo ! Vous avez trouvé en " + nombre + " fois !");

                // rejouer ? 
                Console.WriteLine("\nVoulez-vous rejouer ? (o/n)");
                rejouer = Console.ReadLine().ToLower();
                Console.Clear();
            }
            while (rejouer == "o" || rejouer == "oui");

            // message de fin
            Console.WriteLine("Merci d'avoir joué !");
            Console.ReadLine();
        }
    }
}
