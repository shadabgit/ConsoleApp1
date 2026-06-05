using System;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ThreadSafe
    {
        public static int accessId = 0;
        [ThreadStatic]
        public static int accessCode = 0;
        public void ThFunctionOne()
        {
            accessId++;
            accessCode++;
            Console.WriteLine($"AccessId : {accessId}\nAccessCode with threadstatic : {accessCode}");
        }
        public void ThFunctionTwo()
        {
            accessId++;
            accessCode++;
            Console.WriteLine($"\nAccessId : {accessId}\nAccessCode with threadstatic : {accessCode}");
        }

        //public static void Main()
        //{
        //    ThreadSafe threads = new ThreadSafe();  
        //    Thread th1 = new Thread(threads.ThFunctionOne);
        //    Thread th2 = new Thread(threads.ThFunctionTwo);
        //    th1.Start();
        //    th2.Start();

        //    Console.ReadLine();
        //}
    }
}
