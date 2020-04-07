using System;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace task
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Worker worker = new Worker();
            await worker.start();
        }
    }
}
