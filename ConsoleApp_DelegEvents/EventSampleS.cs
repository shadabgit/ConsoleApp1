using System;

namespace ConsoleApp_DelegEvents
{
    public delegate void MyEventHandler(string message);
    public class Publisher
    {
        public event MyEventHandler MyEvent; 
        public void startDataProcessing()
        {
            Console.WriteLine("Task processing from publishers initiated");
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("Task finished...");

            MyEvent?.Invoke("Data from Publisher!");    //// Null-safe invocation Or,
            //if (MyEvent != null)
            //    MyEvent("Data from Publisher !");
        }
    }

    public class Subscriber1
    {
        public void saveSubscriber1Lists() => Console.WriteLine("Subscriber saved !!");
        public void HandleEventForSubscriber1(string msg) => Console.WriteLine($"Subscriber-1 received: {msg}"); 
    }
    public class Subscriber2
    {
        public void HandleEventForSubscriber2(string msg) => Console.WriteLine($"Subscriber-2 received: {msg}");
    }

    public class EventSampleS
    {
        //public static void Main()
        //{
        //    Publisher publisher = new Publisher();
        //    Subscriber1 subscriber1 = new Subscriber1();
        //    Subscriber2 subscriber2 = new Subscriber2();

        //    // Register the event
        //    publisher.MyEvent += subscriber1.HandleEventForSubscriber1;
        //    //publisher.MyEvent += subscriber2.HandleEventForSubscriber2;           // Or , I can write as below:
        //    publisher.MyEvent += new MyEventHandler(subscriber2.HandleEventForSubscriber2); 

        //    // Raise the event
        //    publisher.startDataProcessing();
        //    Console.ReadKey();
        //}
    }
}

