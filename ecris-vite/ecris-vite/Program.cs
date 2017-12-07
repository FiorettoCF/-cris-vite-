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
               "bill gates", "rock", "voix", "lady", "anti", "rare", "da", "salut"
            };

            /*aléatoire*/
            rndNumber = rand.Next(0, secretWord.Length);
            /*aléatoire*/
            string motAleatoire = secretWord[rndNumber];
            Console.WriteLine("{0}", motAleatoire);




            Console.Write("\nPresser une touche pour terminer le programme ... ");
            Console.ReadKey();
       
        }
    }
}
