using System;
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
            Stopwatch stopWatch = new Stopwatch();
            TimeSpan ts = stopWatch.Elapsed;

            do
            {
                /*mots aléatoire normal*/
                string[] secretWordNormal =
                            {
               "trouillard", "rock", "voix", "clavier", "insect", "appendicite", "anticonstitutionnellement", "salutations", "trottinette"
                            };
                /*aléatoire normal*/
                rndNumber = rand.Next(0, secretWordNormal.Length);
                /*aléatoire*/
                string motAleatoireNormal = secretWordNormal[rndNumber];
                /*mots aleatoire normal*/

                Console.WriteLine("\nRegles: vous devez écrire les mots qui s'afficheront a l'écran le plus vite possible.");

                ConsoleKeyInfo result = Console.ReadKey();
                if (result.Key == ConsoleKey.Enter)
                {
                    /*mots aléatoire normal*/
                    Console.WriteLine("\n{0}", motAleatoireNormal);
                    /*mots aléatoire normal*/
                    Console.Write("\nECRIS:");
                    stopWatch.Start();
                }
                    strmotsaisie = Console.ReadLine();

                    if (strmotsaisie == motAleatoireNormal)
                    {
                        Console.Clear();
                        stopWatch.Stop();
                        Console.Write("\nPoints ");
                    Console.Write("\nTemps: {0}", elapsedTime);
                    string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
                    points++;
                        Console.WriteLine(points);

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
                        stopWatch.Stop();
                        Console.Write("\nPoints ");
                    string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
                    points--;
                        Console.WriteLine(points);
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
