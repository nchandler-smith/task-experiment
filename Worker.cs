using System;

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

        internal void start()
        {
            while(true){
                writeDateTime();
            }
        }
    }
}