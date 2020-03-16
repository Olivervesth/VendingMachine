using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Vending_machine
{
    class Input
    {


        public void standbyeScreen (Vendingmachine vm)
        {
            //Console.Write("Starting vendingmachine");
            //for (int i = 0; i < 10; i++)
            //{
            //    Thread.Sleep(1000);
            //    Console.Write(".");

            //}
            Console.Clear();
            Console.WriteLine("Monstergreen $25");
            Console.WriteLine("Water $10");
            Console.WriteLine("Cola $15");
            Console.WriteLine("Monsterblue $25");
            Console.WriteLine("Orangejuice $20");
            Console.WriteLine("Saltychips $30");
            Console.WriteLine("Marsbar $25");
            Console.WriteLine("Swedishfish $100");
            Console.WriteLine("Sneakers $25");
            Console.WriteLine("Onionrings $30");



            Console.WriteLine("\nInsert Money!");

           int money = int.Parse(Console.ReadLine());
            Console.Clear();
            string machineitem =(Console.ReadLine());


            switch (machineitem)
            {
                case "Monstergreen":
                    if(money == 25)
                    {
                        Console.WriteLine("Here you go one {0}", machineitem);
                        Console.ReadKey();
                    }
                    else if (money < 25)
                    {
                        Console.WriteLine("Not enough money");
                        
                    }
                    
                    break;

                case "Water":
                    if (money == 10)
                    {
                        Console.WriteLine("Here you go one {0}",machineitem);
                        Console.ReadKey();
                    }
                    else if (money < 10)
                    {
                        Console.WriteLine("Not enough money");

                    }

                    break;

                case "Cola":
                    if (money == 15)
                    {
                        Console.WriteLine("Here you go one {0}", machineitem);
                        Console.ReadKey();
                    }
                    else if (money < 15)
                    {
                        Console.WriteLine("Not enough money");

                    }
                    break;

                case "Orangejuice":
                    if (money == 20)
                    {
                        Console.WriteLine("Here you go one {0}", machineitem);
                        Console.ReadKey();
                    }
                    else if (money < 20)
                    {
                        Console.WriteLine("Not enough money");

                    }

                    break;



                default:
                    break;
            }
            Console.ReadKey();
        }

    }
}
