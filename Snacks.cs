using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_machine
{
    class Snacks
    {
        private string name;
        private int gram;

        public string Name { get => name; private set => name = value; }
        public int Gram { get => gram; private set => gram = value; }
        
        public Snacks(string name,int gram)
        {

            Name = name;
            Gram = gram;
        }

    }
}
