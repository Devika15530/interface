using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritH
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("menu \n 1.cricket player \n 2. Hockey player");
            int op = int.Parse(Console.ReadLine());
            Console.WriteLine("enter your name \n");
           string name = Console.ReadLine();
            Console.WriteLine("enter team name \n");
            string tname = Console.ReadLine();
            Console.WriteLine("enter number of matches played \n");
            int n = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                    Console.WriteLine("enter total runs scored \n");
                    int r = int.Parse(Console.ReadLine());
                    Console.WriteLine("enter total wickets taken \n");
                    int w = int.Parse(Console.ReadLine());
                    CricketPlayer cp = new CricketPlayer(name,tname,n,r, w);
                    cp.Display();
                    break;
                case 2:

                    Console.WriteLine("enter goals scored \n");
                    int g = int.Parse(Console.ReadLine());
                    Console.WriteLine("enter position \n");
                    int p = int.Parse(Console.ReadLine());
                    HockeyPlayer hp = new HockeyPlayer(name, tname,n, g, p);
                    hp.Display();
                    break;
            }


            Console.ReadKey();



        }
    }
}
