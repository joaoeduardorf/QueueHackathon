using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creates and initializes a new Queue.
            
            Queue myQ = new Queue();
            for (long i = 0; i < 10000000; i++)
            {
                myQ.Enqueue(i + 1);
            }

            var dataDoInicio = DateTime.Now.Ticks;

            while (myQ.Count != 2)
            {
                var firstElement = myQ.Dequeue();
                myQ.Dequeue();
                myQ.Enqueue(firstElement);
            }

            var dataFinal = DateTime.Now.Ticks;

            Console.WriteLine("Tempo decorrido: " + new DateTime((dataFinal - dataDoInicio)).ToString());

            Console.WriteLine("Elemento: " + myQ.Dequeue());

            Console.ReadLine();
        }


        public static void PrintValues(IEnumerable myCollection)
        {
            foreach (Object obj in myCollection)
                Console.Write("    {0}\n", obj);
            Console.WriteLine();
        }

    }
}
