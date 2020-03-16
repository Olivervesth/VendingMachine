using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_machine
{
    class Drinks
    {
        private string name;
        private int ml;


        public string Name { get => name; private set => name = value; }
        public int Ml { get => ml; private set => ml = value; }

        public Drinks(string name, int ml)
        {
            Name = name;
            Ml = ml;
        }

        public void deleteitem ()
        {

            name = null;
            
        }

        


    }
}
