﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ecris_vite
{
    class Program
    {
        public static DateTime Now { get; private set; }

        static void Main(string[] args)
        {
            Random rand = new Random();
            int rndNumber;
            string strmotsaisie;
            int points = 0;
            bool fin = false;


            do
            {
                /*mots aléatoire normal*/
                string[] secretWordNormal =
                            {
               "trouillard", "rock", "voix", "clavier", "insect", "appendicite", "anticonstitutionnellement", "salutations", "trottinette", "intergouvernementalisations"
                            };
                /*aléatoire normal*/
                rndNumber = rand.Next(secretWordNormal.Length);
                /*aléatoire*/
                string motAleatoireNormal = secretWordNormal[rndNumber];
                /*mots aleatoire normal*/

                Console.WriteLine("\nRegles: vous devez écrire les mots qui s'afficheront a l'écran le plus vite possible. Si vous faîtes plus ou egal 5 secondes de temps vous perdez aucun point mais vous en gagnez pas non plus.\nAppuyez sur Enter pour commencer");
                Console.ReadLine();
                DateTime dateDebut = DateTime.Now;

                /*mots aléatoire normal*/
                Console.WriteLine("\n{0}", motAleatoireNormal);
                /*mots aléatoire normal*/
                Console.Write("\nECRIS:");

                strmotsaisie = Console.ReadLine();
                DateTime dateFin = DateTime.Now;
                TimeSpan elapsedTime = dateFin - dateDebut;

                if (strmotsaisie == motAleatoireNormal)
                {
                    Console.Clear();

                    Console.Write("\nPoints ");
                    points++;
                    Console.WriteLine(points);

                    Console.Write("\nTemps: {0} s", elapsedTime.TotalSeconds);
                    if (elapsedTime.TotalSeconds >= 5)
                    {
                        Console.Clear();
                        Console.Write("\nPoints ");
                        points--;
                        Console.WriteLine(points);
                        Console.Write("\nTemps: {0} s", elapsedTime.TotalSeconds);
                        Console.WriteLine();
                    }

                    Console.WriteLine();
                    if (points == 10)
                    {
                        fin = true;
                        Console.WriteLine("\n Vous avez Gagné, bien joué");
                    }
                }
                else
                {
                    Console.Clear();

                    Console.Write("\nPoints ");
                    
                    
                    points--;
                    Console.WriteLine(points);
                    Console.Write("\nTemps: {0} s", elapsedTime.TotalSeconds);
                    Console.WriteLine();
                    if (points == -10)
                    {
                        fin = true;
                        Console.WriteLine("\n Vous avez PERDU");
                    }

                }

            } while (fin != true);

            
            
            /*quitter le programme*/
            Console.Write("\nPresser sur Espace deux fois pour terminer le programme");
            while (true)
            {
                ConsoleKeyInfo result = Console.ReadKey();
                if (result.Key == ConsoleKey.Spacebar)
                {
                    Console.ReadKey();
                    break;
                }

            }
            /*quitter le programme*/
           

        }
    }
}
