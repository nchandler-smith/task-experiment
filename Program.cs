using System.Threading.Tasks;

namespace task
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Worker worker = new Worker();
            await Task.Run(() => worker.start().ConfigureAwait(false));
            await Task.Delay(5000);
            worker.stop();
        }
    }
}
