using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_machine
{
    class Program
    {
        static void Main(string[] args)
        {



            Input InterfaceInput = new Input();

            WorkerRefil machine = new WorkerRefil();




            Vendingmachine vm = machine.Refill();

            


            Console.ReadKey();
            machine.Refill();
            InterfaceInput.standbyeScreen(vm);


        }
    }
}
