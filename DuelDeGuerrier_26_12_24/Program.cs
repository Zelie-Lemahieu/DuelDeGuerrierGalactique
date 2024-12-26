using System;
using DuelDeGuerrier_26_12_24.classes.Guerrier;
using DuelDeGuerrier_26_12_24.classes.Guerrier.Gliesean;
using DuelDeGuerrier_26_12_24.classes.Guerrier.Keplerien;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Initialisation des variables:
            Random aleatoire = new Random();
            int nombreAleatoire = 0;

            //Affichage du titre en ASCII:
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" ____  __  ____ __  __ __ __  ____ __  __ __ __  ____     ___  __ __\r\n || )) || ||    ||\\ || || || ||    ||\\ || || || ||       // \\\\ || ||\r\n ||=)  || ||==  ||\\\\|| \\\\ // ||==  ||\\\\|| || || ||==     ||=|| || ||\r\n ||_)) || ||___ || \\||  \\V/  ||___ || \\|| \\\\_// ||___    || || \\\\_//");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("      ___           ___                                     ___           ___           ___     \r\n     /\\__\\         /\\  \\                                   /\\__\\         /\\__\\         /\\__\\    \r\n    /:/  /        /::\\  \\                     ___         /:/ _/_       /:/ _/_       /:/ _/_   \r\n   /:/  /        /:/\\:\\  \\                   /\\__\\       /:/ /\\  \\     /:/ /\\__\\     /:/ /\\__\\  \r\n  /:/  /  ___   /:/  \\:\\  \\   ___     ___   /:/__/      /:/ /::\\  \\   /:/ /:/ _/_   /:/ /:/ _/_ \r\n /:/__/  /\\__\\ /:/__/ \\:\\__\\ /\\  \\   /\\__\\ /::\\  \\     /:/_/:/\\:\\__\\ /:/_/:/ /\\__\\ /:/_/:/ /\\__\\\r\n \\:\\  \\ /:/  / \\:\\  \\ /:/  / \\:\\  \\ /:/  / \\/\\:\\  \\__  \\:\\/:/ /:/  / \\:\\/:/ /:/  / \\:\\/:/ /:/  /\r\n  \\:\\  /:/  /   \\:\\  /:/  /   \\:\\  /:/  /   ~~\\:\\/\\__\\  \\::/ /:/  /   \\::/_/:/  /   \\::/_/:/  / \r\n   \\:\\/:/  /     \\:\\/:/  /     \\:\\/:/  /       \\::/  /   \\/_/:/  /     \\:\\/:/  /     \\:\\/:/  /  \r\n    \\::/  /       \\::/  /       \\::/  /        /:/  /      /:/  /       \\::/  /       \\::/  /   \r\n     \\/__/         \\/__/         \\/__/         \\/__/       \\/__/         \\/__/         \\/__/");
            Console.WriteLine("      ___           ___                         ___           ___                                                   ___           ___     \r\n     /\\__\\         /\\  \\                       /\\  \\         /\\__\\                                                 /\\  \\         /\\__\\    \r\n    /:/ _/_       /::\\  \\                     /::\\  \\       /:/  /          ___         ___           ___          \\:\\  \\       /:/ _/_   \r\n   /:/ /\\  \\     /:/\\:\\  \\                   /:/\\:\\  \\     /:/  /          /\\__\\       /\\__\\         /\\  \\          \\:\\  \\     /:/ /\\__\\  \r\n  /:/ /::\\  \\   /:/ /::\\  \\   ___     ___   /:/ /::\\  \\   /:/  /  ___     /:/  /      /:/__/        /::\\  \\     ___  \\:\\  \\   /:/ /:/ _/_ \r\n /:/__\\/\\:\\__\\ /:/_/:/\\:\\__\\ /\\  \\   /\\__\\ /:/_/:/\\:\\__\\ /:/__/  /\\__\\   /:/__/      /::\\  \\       /:/\\:\\  \\   /\\  \\  \\:\\__\\ /:/_/:/ /\\__\\\r\n \\:\\  \\ /:/  / \\:\\/:/  \\/__/ \\:\\  \\ /:/  / \\:\\/:/  \\/__/ \\:\\  \\ /:/  /  /::\\  \\      \\/\\:\\  \\__   /:/ /::\\  \\  \\:\\  \\ /:/  / \\:\\/:/ /:/  /\r\n  \\:\\  /:/  /   \\::/__/       \\:\\  /:/  /   \\::/__/       \\:\\  /:/  /  /:/\\:\\  \\      ~~\\:\\/\\__\\ /:/_/:/\\:\\__\\  \\:\\  /:/  /   \\::/_/:/  / \r\n   \\:\\/:/  /     \\:\\  \\        \\:\\/:/  /     \\:\\  \\        \\:\\/:/  /   \\/__\\:\\  \\        \\::/  / \\:\\/:/  \\/__/   \\:\\/:/  /     \\:\\/:/  /  \r\n    \\::/  /       \\:\\__\\        \\::/  /       \\:\\__\\        \\::/  /         \\:\\__\\       /:/  /   \\::/  /         \\::/  /       \\::/  /   \r\n     \\/__/         \\/__/         \\/__/         \\/__/         \\/__/           \\/__/       \\/__/     \\/__/           \\/__/         \\/__/");
            Console.WriteLine(""); //<-- Passage de ligne.
            Console.ResetColor();

            //Initialisation des guerriers:
            Gliesean BogosB = new Gliesean("Bogos Booboozorp", 21, 3, true);
            Keplerien ZiggiZ = new Keplerien("Ziggi Zop Glerp", 30, 2);

            //Affichage du message d'introduction du présentateur:
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\t\t\"En direct du colisée spatiale Znivob Marpglip sur la station Gagamob-15XD en orbite autour de la planète Gor-Glibp, le combat du jour opposera " + BogosB.Nom + " à " + ZiggiZ.Nom + ", sans règle\n\t\tet sans merci !" +
                "\n\t\tMoi, Znerpbi Pastis, commenterai ce duel haletant. Je rappelle qu'il s'agit d'un combat à mort, et que le vainqueur remporte l'honneur d'être sacrifié à la gloire de Spode !" +
                "\n\t\tQUE LE COMBAT COMMEEEEENCE !!!\"");
            Console.ResetColor();

            //Affichage des infos avant le combat:
            Titrage(BogosB.AffichageInfo());
            Titrage(ZiggiZ.AffichageInfo());

            //Déroulé du combat:
            nombreAleatoire = aleatoire.Next(1, 3);
            if (nombreAleatoire == 1)//<--Premier guerrier à attaquer choisi aléatoirement.
            {
                //Message présentateur:
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"\t\t\"Et c'est {BogosB.Nom} qui porte le premier coup !\"");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"Attaque de {BogosB.Nom}:");//<--Affichage du nom de l'attaquant
                Console.ResetColor();
                ZiggiZ.DegatsSubis(BogosB.Attaque());//<--Attaque de BogosB.


                //Affichage des infos:
                Titrage(BogosB.AffichageInfo());
                Titrage(ZiggiZ.AffichageInfo());
            }
            else
            {
                //Message présentateur:
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"\t\t\"Et c'est {ZiggiZ.Nom} qui porte le premier coup !\"");
                Console.ResetColor();
            };

            while (BogosB.PointDeSante > 0 && ZiggiZ.PointDeSante > 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"Attaque de {ZiggiZ.Nom}:");//<--Affichage du nom de l'attaquant
                Console.ResetColor();
                BogosB.DegatsSubis(ZiggiZ.Attaque());//<--Attaque de ZiggiZ
                //Affichage des infos:
                Titrage(BogosB.AffichageInfo());
                Titrage(ZiggiZ.AffichageInfo());
                if (BogosB.PointDeSante > 0)//<--Cette condition empêche le guerrier d'attaquer s'il a zéro PS ou moins.
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine($"Attaque de {BogosB.Nom}:");//<--Affichage du nom de l'attaquant
                    Console.ResetColor();
                    ZiggiZ.DegatsSubis(BogosB.Attaque());//<--Attaque de BogosB.
                    //Affichage des infos:
                    Titrage(BogosB.AffichageInfo());
                    Titrage(ZiggiZ.AffichageInfo());
                };
            };

            //Fin du combat:
            if (BogosB.PointDeSante > 0)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"\t\t\"ET LE VAINQUEUR EST {BogosB.Nom} !!!\n");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"\t\t\"ET LE VAINQUEUR EST {ZiggiZ.Nom} !!!\n");
                Console.ResetColor();
            }


            //FONCTION TITRAGE:
            //Affichage d'un titre encadré en DarkYellow
            void Titrage(string titre)
            {
                titre = $"║ {titre} ║";
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("╔");
                for (int i = 0; i < titre.Length - 2; i++)
                {
                    Console.Write("═");
                };
                Console.WriteLine("╗");
                Console.WriteLine(titre);
                Console.Write("╚");
                for (int i = 0; i < titre.Length - 2; i++)
                {
                    Console.Write("═");
                };
                Console.WriteLine("╝");
                Console.ResetColor();
            }
        }
    }
}