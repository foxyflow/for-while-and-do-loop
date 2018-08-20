using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forWhileDowhileLoopsPrac
{
    class Program
    {
        static void Main(string[] args)
        //execise from Moodle ... DO while loop ... take 1 
        

        {
            Console.WriteLine("enter number to start table");
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine("declare an end number");
            int end = int.Parse(Console.ReadLine());

            do {

                Console.WriteLine($"{k}\t{k * 10}\t\t{k * 100} ");
                    k++;
            }
            while (k <= end);
            Console.WriteLine("press enter");
        Console.ReadLine();

            //same thing but with a FOR loop...
            Console.WriteLine("enter a low number");
            int start = int.Parse(Console.ReadLine());
            Console.WriteLine("enter a higher number");
            int fin = int.Parse(Console.ReadLine());

            for (int o = start; o <= fin; o++)
                Console.WriteLine("{0} {1} {2}", (o * 10), (o * 100), o * 1000);
            Console.WriteLine("press enter");

                Console.ReadLine();
            // the first way is way faster.
            
            //last one: just the 'while' loop ... TOMORROW
            //AND DO LONG WAY WITH OUT: FOR WHILE AND DO WHILE
            







        }
    }
}
