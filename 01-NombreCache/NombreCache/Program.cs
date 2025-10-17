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
                    Console.WriteLine("Erreur de saisie : saisissez un nombre entier");
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
                    Console.WriteLine("Erreur de saisie : saisissez un nombre entier");
                }
            }

            // boucle sur les essais
            while (essai != valeur)
            {
                // test de l'essai par rapport à la valeu à chercher
                if (essai > valeur)
                {
                    Console.WriteLine(" --> trop grand !");
                }
                else
                {
                    Console.WriteLine(" --> trop petit !");
                }
                // saisie d'un nouvel essai
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
                        Console.WriteLine("Erreur de saisie : saisissez un nombre entier");
                    }
                }
                // compteur d'essai
                nombre++;
            }

            // valeur trouvée
            Console.WriteLine("Bravo ! Vous avez trouvé en " + nombre + " fois !");

            Console.ReadLine();
        }
    }
}
