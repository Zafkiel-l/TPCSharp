using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Personnages perso;
            string Guerrier1 = "Guerrier";
            string Chasseur1 = "Chasseur";

            Console.WriteLine("Bienvenu choisissez votre classe");
            Console.WriteLine("Ecrivez" + Guerrier1 + "pour être un guerrier ou" + Chasseur1 + "pour être chasseur");
            var result = Console.ReadLine();

            if (result ==Guerrier1)
            {
                Console.WriteLine("Vous choisissez Guerrier");
                perso = new Guerrier();

                if (perso.GetType() == typeof(Guerrier))
                {
                    Guerrier b = (Guerrier)perso;
           
                }

            }

        }
    }
}
