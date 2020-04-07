using System;
using System.Threading;
using System.Threading.Tasks;

namespace task
{
    internal class Worker
    {
        public Worker()
        {}

        private void writeDateTime()
        {
            var dateTime = DateTime.Now;
            Console.WriteLine($"Checkout the time yo! {dateTime}");
        }

        internal async Task start()
        {
            while(true){
                writeDateTime();
                await Task.Delay(1000);
            }
        }
    }
}