using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp_DelegEvents
{
    class TPLAsyncExp
    {
        static async Task<int> AddTwoDigitAsync(int a, int b)
        {
            await Task.Delay(1000);     // Simulate a long-running operation (e.g., network request)
            return a + b;
        }
        static Func<int, int, Task<int>> AddTwoDigitAsyncUsingLambda = async (int a, int b) => 
        { 
            await Task.Delay(1000);
            return a + b; 
        };

        static async void AddTwoDigitAsyncV(int a, int b)
        {
            await Task.Delay(1000);
            Console.WriteLine($"Sum of numbers from void async fn : {a + b}");
        }
        /*
        static async Task Main()
        {
            var result1 = await AddTwoDigitAsync(300, 430);
            Console.WriteLine($"Sum of two numbers from first: {result1}");

            //var result2 = AddTwoDigitAsyncUsingLambda(400, 500).Result;    
            // using Result will block the whole program until it finishes the execution of current task. 

            var result2 = await AddTwoDigitAsyncUsingLambda(400, 500);
            Console.WriteLine($"Sum of two numbers from second: {result2}");

            //await AddTwoDigitAsync(300, 430);    
            // comple-time error:  In C#, an async function that returns void cannot be awaited directly.
            AddTwoDigitAsyncV(300, 430);


           
            //// Example: Task Cancellation 
            //CancellationTokenSource cancelSource = new CancellationTokenSource();

            //Task tasksrc = Task.Run(() =>
            //{
            //    for (int i = 0; i < 10; i++)
            //    {
            //        if (cancelSource.Token.IsCancellationRequested)
            //        { Console.WriteLine("Task is cancelled"); cancelSource.Token.ThrowIfCancellationRequested(); }
            //        Console.WriteLine($"Working {i}");
            //        Thread.Sleep(500);
            //    }
            //}
            //    , cancelSource.Token);
            //Thread.Sleep(2000);
            //cancelSource.Cancel(); // Cancel the task
            ////tasksrc.Wait();

            //try
            //{
            //    await tasksrc;
            //}
            //catch (OperationCanceledException)
            //{
            //    Console.WriteLine("Task was cancelled.");
            //}
            //finally
            //{
            //    tasksrc.Dispose();
            //}
        

            Console.ReadLine();
        } */
    }
}
