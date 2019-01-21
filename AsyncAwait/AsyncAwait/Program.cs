using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwait
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test started");

            AsyncAwait asyncAwait = new AsyncAwait();
            Task.Run(()=>asyncAwait.Test());

            Console.WriteLine("Test finished");
            Console.ReadKey();
        }
    }
}
