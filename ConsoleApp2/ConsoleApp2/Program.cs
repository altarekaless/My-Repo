using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("This is Manipulation Table ");
            Console.ReadLine();

            for (int i = 1; i<=10; i++) {

                for (int g = 1; g<=10; g++) {


                    Console.WriteLine(i+"x"+g+"= "+ (i*g));




                }

            }


            Console.ReadLine();
            
        }
    }
}
