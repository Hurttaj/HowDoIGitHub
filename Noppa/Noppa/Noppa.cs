using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noppa
{
    class Noppa
    {
        
     public int Roll(Random rand)
        {
            int perkele = rand.Next(1, 7);
            return perkele;
        }

       
    }
}
