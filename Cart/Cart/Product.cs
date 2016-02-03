using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cart
{
    class Product
    {
        public string Name { get; set; }
        public float Price { get; set; }

        public override string ToString()
        {
            return "Name " + Name + ", Price " + Price + " €";
        }
    }
}
