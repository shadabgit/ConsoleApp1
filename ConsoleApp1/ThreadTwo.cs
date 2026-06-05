using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /*
    internal class ThreadTwo
    {
        static int num1, num2 = 0;
        public static void Main()
        {         
            Thread thread = new Thread(FunctionIncrement);
            thread.Name = "childForegroundThread";
            thread.Start();

            FunctionIncrement();

            Console.WriteLine("Main thread exited.");
        } 
        static void FunctionIncrement()
        {
            Random random = new Random();

            for (long x=0; x<100000; x++)
            {
                num1 = random.Next(1, 2);
                num2 = random.Next(1, 2);

                int result = num1 / num2;

                num1 = 0;
                num2 = 0;
            }
            Console.WriteLine("completed processing");
        }
    }
    */
    // The above code will throw DivideByZeroException because other thread can set num2 to 0 after the check and before the division operation.
    // Solution 1 : We can use lock to synchronize the access to shared variables num1 and num2.
    // This will ensure that only one thread can access the critical section of code that modifies these variables at a time, preventing the race condition

    /*
    internal class ThreadTwo
    {
        static int num1, num2 = 0;
        // Add a private static object to use as the lock
        private static readonly object _lockObj = new object();

        public static void Main()
        {
            Thread thread = new Thread(FunctionIncrement);
            thread.Name = "childForegroundThread";
            thread.Start();

            FunctionIncrement();

            Console.WriteLine("Main thread exited.");
            Console.ReadLine();
        }
        static void FunctionIncrement()
        {
            Random random = new Random();

            // Use the lock object instead of the thread variable
            lock (_lockObj)
            {
                for (long x = 0; x < 100000; x++)
                {
                    num1 = random.Next(1, 2);
                    num2 = random.Next(1, 2);

                    int result = num1 / num2;

                    num1 = 0;
                    num2 = 0;
                }
                Console.WriteLine("completed processing");
            }
        }
    }
    */
    // Solution 2 : We can also lock on the instance of the class that contains the shared variables.
    // In this case, we can lock on the instance of MathClass to ensure that only one thread can execute the FunctionIncrement method at a time for the same
    // instance of MathClass.
    // 
    internal class ThreadTwo
    {
        static MathClass math = new MathClass();
        public static void Main()
        {
            Thread thread = new Thread(math.FunctionIncrement);
            thread.Name = "childForegroundThread";
            thread.Start();

            math.FunctionIncrement();

            Console.WriteLine("Main thread exited.");
            Console.ReadLine();
        }  
    }

    internal class MathClass
    {
        int num1, num2 = 0;
        public void FunctionIncrement()
        {
            Random random = new Random();

            lock (this)
            // Locking on the instance of MathClass to ensure that only one thread can execute this method at a time for the same instance.
            {
                for (long x = 0; x < 100000; x++)
                {
                    num1 = random.Next(1, 2);
                    num2 = random.Next(1, 2);

                    int result = num1 / num2;

                    num1 = 0;
                    num2 = 0;
                }
                Console.WriteLine("completed processing");
            }
        }
    }
}
