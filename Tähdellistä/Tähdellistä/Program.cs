using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tähdellistä
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Anna Luku: ");
            int X = int.Parse(Console.ReadLine());
            for(int Y=0;Y<X;Y++) // Y on laskuri joka kertoo loopille montako riviä looppi tulostaa. Rivejä on niin monta kuin käyttäjältä pyydetyssä X-arvossa sanotaan.
            {
                for(int i=-1;i<Y;i++) // i kertoo montako * merkkiä yhdelle riville tulee. i pyörii kunnes se on yhtä suuri kuin Y, eli * -merkkien määrä on sama kuin se monennessako loopin iteraatiossa ollaan.
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
