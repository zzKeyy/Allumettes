using System;

class Program
{
    public static void Main(string[] args)
    {
        int nbAllumettes;
        int nbAllumettesRestantes;
        Console.WriteLine("Combien d'allumettes voulez-vous utiliser ?");
        nbAllumettes = int.Parse(Console.ReadLine());
        nbAllumettesRestantes = nbAllumettes;
        Console.WriteLine(string.Concat(Enumerable.Repeat("|", nbAllumettes)));

        while (nbAllumettesRestantes > 0)
        {
            int choixJoueur;
            Console.WriteLine("Combien d'allumettes voulez-vous prendre ? 1 2 3");
            choixJoueur = int.Parse(Console.ReadLine());
            if (choixJoueur > 0 && choixJoueur < 4 && choixJoueur < nbAllumettesRestantes + 1)
            {
                nbAllumettesRestantes -= choixJoueur;
                Console.WriteLine("Vous avez retiré {0} allumette(s)", choixJoueur);
                Console.Write(string.Concat(Enumerable.Repeat(" ", choixJoueur)));
                Console.WriteLine(string.Concat(Enumerable.Repeat("|", nbAllumettesRestantes)));

            }
            else
            {
                Console.WriteLine("Veuillez choisir un nombre valide d'allumettes");
                continue;
            }
            if (nbAllumettesRestantes == 0)
            {
                Console.WriteLine("Vous avez perdu !");
                break;
            }

            int choixOrdinateur;
            if (nbAllumettesRestantes < 4 && nbAllumettesRestantes > 1)
            {
                choixOrdinateur = nbAllumettesRestantes - 1;
                nbAllumettesRestantes -= choixOrdinateur;
                Console.WriteLine("L'ordinateur a retiré {0} allumette(s)", choixOrdinateur);
                Console.Write(string.Concat(Enumerable.Repeat(" ", choixOrdinateur)));
                Console.WriteLine(string.Concat(Enumerable.Repeat("|", nbAllumettesRestantes)));
            }
            else
            {
                if (nbAllumettesRestantes == 1)
                {
                    choixOrdinateur = 1;
                    nbAllumettesRestantes -= choixOrdinateur;
                    Console.WriteLine("L'ordinateur a retiré {0} allumette(s)", choixOrdinateur);
                    Console.Write(string.Concat(Enumerable.Repeat(" ", choixOrdinateur)));
                    Console.WriteLine(string.Concat(Enumerable.Repeat("|", nbAllumettesRestantes)));
                }
                if (nbAllumettesRestantes == 0)
                {
                    Console.WriteLine("Vous avez gagné ! L'ordinateur a retiré la dernière allumette");
                    break;
                }
                else
                {
                    Random rnd = new Random();
                    choixOrdinateur = rnd.Next(1, 3);
                    nbAllumettesRestantes -= choixOrdinateur;
                    Console.WriteLine("L'ordinateur a retiré {0} allumette(s)", choixOrdinateur);
                    Console.Write(string.Concat(Enumerable.Repeat(" ", choixOrdinateur)));
                    Console.WriteLine(string.Concat(Enumerable.Repeat("|", nbAllumettesRestantes)));
                }

            }





        }
    }
}
