using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace MainAsyncMethod
{
    class Program
    {
        private static string url = "http://google.com/robots.txt";
        static async Task Main(string[] args)
        {
            await Task.CompletedTask;
            Console.WriteLine("Hello World!");
        }
        
        //before C# 7.1 we had to call async method in mail like this
        // private static async Task MainAsync()
        // {
        //     Console.WriteLine(await new HttpClient().GetStringAsync(url));
        // }
        //
        // static void Main(string[] args)
        // {
        //     MainAsync().GetAwaiter().GetResult();
        // }
    }
}