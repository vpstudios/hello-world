using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* A Hello World! program in C#.
This program displays the string "Hello World!" on the screen with greats hints. */

namespace Hello_World
{
    class Hello
    {
        static void Main(string[] args)
        {      
            // Change la propriété du texte ForegroundColor et BackgroundColor pour le titre.
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            // Centre le texte "Hello World!" dans la console
            CentrerLeTexte("*****************************");            
            CentrerLeTexte("*  Verts Pâturages Studios  *");
            CentrerLeTexte("*  =======================  *");
            CentrerLeTexte("*   Multimedia Conception   *"); 
            CentrerLeTexte("*****************************");
            CentrerLeTexte("");
            // Affiche la date courante.
            CentrerLeTexte(" Aujourd'hui nous sommes le " + DateTime.Now);
            // Reset la propriété ForegroundColor et BackgroundColor pour le texte "Hello World!"
            Console.ResetColor();
            CentrerLeTexte("Hello world!");
            CentrerLeTexte("");

            // Défini à quel moment de la journée et de la semaine nous sommes.
            DateTime dateCourante = DateTime.Now;
            if (dateCourante.DayOfWeek == DayOfWeek.Saturday ||
                dateCourante.DayOfWeek == DayOfWeek.Sunday ||
               (dateCourante.DayOfWeek == DayOfWeek.Monday && dateCourante.Hour < 9) ||
               (dateCourante.DayOfWeek == DayOfWeek.Friday && dateCourante.Hour >= 18))
            {
            // Si nous sommes le week-end
            AfficherBonWeekEnd();
            }
            else
            {
            // Si nous sommes en semaine
            if (dateCourante.Hour >= 9 && dateCourante.Hour < 18)
            {
            // Si nous sommes dans la journée
            AfficherBonjour();
            }
            else
            {
            AfficherBonsoir();
            }

           // Jeu du plus-moins
           // Utilisation de break et continue
           int valeurATrouver = new Random().Next(0, 100);
           int nombreDeCoups = 0;
           CentrerLeTexte("");
           Console.ForegroundColor = ConsoleColor.White;
           Console.BackgroundColor = ConsoleColor.DarkGreen;
           Console.SetCursorPosition(0, 15);
           CentrerLeTexte("Veuillez saisir un nombre compris entre 0 et 100");
           while (true)
           {
           // Contrôler si la saisie de l'utilisateur se trouve entre 0 et 100.
           // Rappeler à l'utilisateur les bornes du jeu si nécessaire.
           string saisie = Console.ReadLine();
           int valeurSaisie;
           if (!int.TryParse(saisie, out valeurSaisie))
           {
           Console.ForegroundColor = ConsoleColor.White;
           Console.BackgroundColor = ConsoleColor.DarkRed;
           CentrerLeTexte("La valeur saisie est incorrecte, veuillez recommencer ...");
           continue;
           }
           if (valeurSaisie < 0 || valeurSaisie > 100)
           {
           Console.ForegroundColor = ConsoleColor.White;
           Console.BackgroundColor = ConsoleColor.DarkRed;
           CentrerLeTexte("Vous devez saisir un nombre entre 0 et 100...");
           continue;
           }
           // Afficher un message pour indiquer si la saisie est trop grande ou
           // trop petite en fonction du résultat de la comparaison.
           // Incrémenter le nombre de coup utilisé.
           Console.ForegroundColor = ConsoleColor.White;
           Console.BackgroundColor = ConsoleColor.DarkMagenta;
               nombreDeCoups++;
           if (valeurSaisie == valeurATrouver)
           break;
           if (valeurSaisie < valeurATrouver)
           CentrerLeTexte("Trop petit ...");
           else
           CentrerLeTexte("Trop grand ...");
           }
           Console.ForegroundColor = ConsoleColor.White;
           Console.BackgroundColor = ConsoleColor.DarkGreen;
           if (nombreDeCoups == 1)
           // Tester la valeur de coup, afficher au singulier ou au pluriel selon le résultat.
           CentrerLeTexte("Vous avez trouvé en " + nombreDeCoups + " coup");
           else
           CentrerLeTexte("Vous avez trouvé en " + nombreDeCoups + " coups");

           // Garder la console window ouverte en mode debug.
           Console.ResetColor();
           Console.WriteLine("Pressez une touche du clavier pour sortir.");
           Console.ReadKey();
           }
        }

        private static void CentrerLeTexte(string texte)
        {
            // Centrer le texte dans la console
            int nbEspaces = (Console.WindowWidth - texte.Length) / 2;
            Console.SetCursorPosition(nbEspaces, Console.CursorTop);
            Console.WriteLine(texte);
        }
    
        static void AfficherBonWeekEnd()
        {
            // Afficher Bon week-end suivi du nom de l'utilisateur
            Console.SetCursorPosition(34, 8);
            CentrerLeTexte("Bon week-end " + Environment.UserName + "!");
        }

        static void AfficherBonjour()
        {
            // Afficher Bonjour suivi du nom de l'utilisateur
            Console.SetCursorPosition(34, 8);
            CentrerLeTexte("Bonjour " + Environment.UserName + "!");
        }

        static void AfficherBonsoir()
        {
            // Afficher Bonsoir suivi du nom de l'utilisateur
            Console.SetCursorPosition(34, 8);
            CentrerLeTexte("Bonsoir " + Environment.UserName + "!");
        }

    }
}
