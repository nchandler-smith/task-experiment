using System;
using System.Threading;
using System.Threading.Tasks;

namespace task
{
    internal class Worker
    {
        private bool _continue;

        public Worker()
        {
            _continue = true;
        }

        private void writeDateTime()
        {
            var dateTime = DateTime.Now;
            Console.WriteLine($"Checkout the time yo! {dateTime}");
        }

        public async Task start()
        {
            while (_continue)
            {
                writeDateTime();
                await Task.Delay(1000);
            }
        }

        public void stop()
        {
            System.Console.WriteLine("Stopping yo!");
            _continue = false;
        }
    }
}