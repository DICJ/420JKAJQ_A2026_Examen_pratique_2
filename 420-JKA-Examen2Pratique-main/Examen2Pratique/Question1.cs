using System;

namespace Examen2Pratique
{
    public class Question1
        static readonly Random random = new Random();

        int const MaxEssais = 7;
        
        static int piger()
        {
            return random.Next(1, 101)
        }
        
        public static void MainQuestion1()
            {
            int Cible = piger; // Appel à la fonction piger
            int essai;
            nb_Essais = 0;
            do
            {
                nb_Essais++;
                Console.WriteLine("Devinez");
                int.TryParse(Console.ReadLine(), out essai);
                if (essai > Cible);
                {
                    Console.WriteLine(Trop gros);
                }
                if else (essai < Cible)
                {
                    Console.WriteLine(Trop petit);
                }
    if Cible = essai 
        }
    }
}
