using System;
using System.Collections.Generic;

namespace Examen2Pratique
{
    public class Question2
    {
        /// <summary>
        /// Affiche à la console une couleur qui se rapproche de la valeur r g b fournie.
        /// Pas toucher. Pas besoin de lire.
        /// </summary>
        /// <param name="r">Valeur rouge</param>
        /// <param name="g">Valeur vert</param>
        /// <param name="b">Valeur bleu</param>
        public static void AfficherCouleur(int r, int g, int b)
        {
            int index = (r > 128 | g > 128 | b > 128) ? 8 : 0;
            index |= (r > 64) ? 4 : 0;
            index |= (g > 64) ? 2 : 0;
            index |= (b > 64) ? 1 : 0;

            ConsoleColor couleurConsole = (ConsoleColor)index;
            Console.Write($"La couleur console qui se rapproche le plus de (R = {r}, G = {g}, B = {b}) est {couleurConsole} : ");
            Console.BackgroundColor = couleurConsole;
            Console.Write("          ");
            Console.ResetColor();
            Console.WriteLine();
        }

        // Programmation
        public static void MainQuestion2()
        {
            bool valide;
            int r; // Valeur en rouge
            int g; // Valeur en vert (green)
            int b; // Valeur en bleu

            // Saisir les trois valeurs pour une couleur
            do
            {
                Console.WriteLine("Entrez une valeur rouge (De 0 à 255)");
                valide = int.TryParse(Console.ReadLine(), out r);
            } 
			while (!valide || r < 0 || r > 255);

            do
            {
                Console.WriteLine("Entrez une valeur vert (De 0 à 255)");
                valide = int.TryParse(Console.ReadLine(), out g);
            } 
			while (!valide || g < 0 || g > 255);

            do
            {
                Console.WriteLine("Entrez une valeur bleu (De 0 à 255)");
                valide = int.TryParse(Console.ReadLine(), out b);
            } 
			while (!valide || b < 0 || b > 255);

            Console.WriteLine($"Couleur entrée :");
            AfficherCouleur(r, g, b);

			/************************************
			 * Amélioration #1 : Niveau de gris *
			 ************************************/
            // Teinte de gris correspondante : gris = 0.3 * r + 0.39 * g + 0.11 * b
 
			/************************************
			 * Amélioration #2 : Saturation     *
			 ************************************/
            //double max = Math.Max(r, Math.Max(g, b));
	        //double min = Math.Min(r, Math.Min(g, b));
	        //double saturation = (max - min) / (max + min);
			// Console.WriteLine($"Elle a une saturation de {Math.Round(saturation, 3)}");
        }
    }
}