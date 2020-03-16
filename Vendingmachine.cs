using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_machine
{
    class Vendingmachine
    {








        Products[,] row1;
        Products[,] row2;
        Products[,] row3;
        Products[,] row4;
        Products[,] row5;
        internal Products[,] Row1 { get => row1; set => row1 = value; }
        internal Products[,] Row2 { get => row2; set => row2 = value; }
        internal Products[,] Row3 { get => row3; set => row3 = value; }
        internal Products[,] Row4 { get => row4; set => row4 = value; }
        internal Products[,] Row5 { get => row5; set => row5 = value; }
        public Vendingmachine()
        {
            Row1 = new Products[5, 10];
            Row2 = new Products[5, 10];
            Row3 = new Products[5, 10];
            Row4 = new Products[5, 10];
            Row5 = new Products[5, 10];
        }              

    }
}
