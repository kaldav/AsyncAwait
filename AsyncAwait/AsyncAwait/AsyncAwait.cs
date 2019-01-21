using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwait
{
    class AsyncAwait
    {
        internal void Test()
        {
            DoItAsync();
            Console.WriteLine(DoItAsyncWithTask().Result);
            Console.WriteLine("DoItWithTask Finished");
        }

        private async void DoItAsync()
        {
            Console.WriteLine("DOIT Started");
            Thread.Sleep(1000);
            Console.WriteLine("DOIT Finished");
        }

        private async Task<int> DoItAsyncWithTask()
        {
            Console.WriteLine("DoItWithTask Started");
            Thread.Sleep(2000);
            return 10;
        }

    }
}
