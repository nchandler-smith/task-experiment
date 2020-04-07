using System;
using Microsoft.Extensions.Logging;

namespace task
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker worker = new Worker();
            worker.start();
        }
    }
}
