using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecris_vite
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int rndNumber;

            string[] secretWord =
                        {
               "trouillard", "rock", "voix", "clavier", "insect", "appendicite", "anticonstitutionnellement", "salutations"
            };

            /*aléatoire*/
            rndNumber = rand.Next(0, secretWord.Length);
            /*aléatoire*/
            string motAleatoire = secretWord[rndNumber];
            Console.WriteLine("{0}", motAleatoire);



            /*quitter le programme*/
            Console.Write("\nPresser une y pour terminer le programme ... ");
            while (true)
            {
                ConsoleKeyInfo result = Console.ReadKey();
                if (result.Key == ConsoleKey.Y)
                {
                    Console.ReadKey();
                    break;
                }

            }
            /*quitter le programme*/

        }
    }
}