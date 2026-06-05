using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp_DelegEvents
{
    internal class AsyncAwait
    {
        static void Main(string[] args)
        {
            //SyncTask1();
            //SyncTask2();
            //SyncTask3();

            Thread th1  = new Thread(new ThreadStart(TAsyncTask1));
            Thread th2 = new Thread(new ThreadStart(TAsyncTask2));
            Thread th3 = new Thread(new ThreadStart(TAsyncTask3));

            th1.Start();
            th2.Start();
            th3.Start();


            //AsyncTask1();
            //AsyncTask2();
            //AsyncTask3();

            Console.ReadLine();
        }

        public static void SyncTask1()
        {
            Console.WriteLine("SyncTask1 started.");
            Console.WriteLine("SyncTask1 completed.");
        }

        public static void SyncTask2()
        {
            Console.WriteLine("SyncTask2 started.");
            Task.Delay(4000).Wait(); // Simulate work
            Console.WriteLine("SyncTask2 completed.");
        }

        public static void SyncTask3()
        {
            Console.WriteLine("SyncTask3 started.");
            Task.Delay(2000).Wait(); // Simulate work
            Console.WriteLine("SyncTask3 completed.");
        }

        public static void TAsyncTask1()
        {
            Console.WriteLine("AsyncTask1 started.");
            Task.Delay(8000).Wait(); // Simulate work
            Console.WriteLine("AsyncTask1 completed.");
            Console.WriteLine("Testing Async Operation from AsyncTask1");
        }
        public static void TAsyncTask2()
        {
            Console.WriteLine("AsyncTask2 started.");
            Task.Delay(20000).Wait(); // Simulate work
            Console.WriteLine("AsyncTask2 completed.");
        }
        public static void TAsyncTask3()
        {
            Console.WriteLine("AsyncTask3 started.");
            Task.Delay(12000).Wait(); // Simulate work
            Console.WriteLine("AsyncTask3 completed."); 
        }



        public static async Task AsyncTask1()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("AsyncTask1 started.");
                Task.Delay(8000).Wait(); // Simulate work
                Console.WriteLine("AsyncTask1 completed.");
            }); 
            Console.WriteLine("Testing Async Operation from AsyncTask1");
        }
        public static async Task AsyncTask2()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("AsyncTask2 started.");
                Task.Delay(20000).Wait(); // Simulate work
                Console.WriteLine("AsyncTask2 completed.");
            });
        }
        public static async Task AsyncTask3()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("AsyncTask3 started.");
                Task.Delay(12000).Wait(); // Simulate work
                Console.WriteLine("AsyncTask3 completed.");
            });

            Console.WriteLine("Testing...");
        }
    }
}
