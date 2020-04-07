using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace task
{
    internal class Worker
    {
        private bool _continue;
        private ILogger _logger;

        public Worker()
        {
            _continue = true;
            ILoggerFactory loggerFactory = LoggerFactory.Create(builder => {
                builder
                    .AddFile("app.log", append:true);
            });
            _logger = loggerFactory.CreateLogger<Worker>();
        }

        private void writeDateTime()
        {
            var dateTime = DateTime.Now;
            string logEntry = $"The time is: {dateTime}";
            Console.WriteLine(logEntry);
            _logger.LogInformation(logEntry);
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