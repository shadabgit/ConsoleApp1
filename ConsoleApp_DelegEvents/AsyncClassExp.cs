using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_DelegEvents
{
    class AsyncClassExp
    {
        public async Task<string> GetDataAsync()
        {
            // Simulate a long-running operation (e.g., network request)
            Console.WriteLine("I am in GetDataAsync..");
            await Task.Delay(2000);
            return "Data Retrieved";
        }
        public async Task ProcessDataAsync()
        {
            Console.WriteLine("Starting...");
            string data = await GetDataAsync();
            Console.WriteLine($"Result: {data}");
            Console.WriteLine("Finished.");
        }
        public async Task<string> DispAsync() => "From DispAsync.....";

        //static async Task Main(string[] args)
        //{
        //    AsyncClassExp asyncClassExp = new AsyncClassExp();
        //    await asyncClassExp.ProcessDataAsync();
        //    Console.WriteLine(await asyncClassExp.DispAsync());
        //    Console.ReadLine();
        //}
    }
}
