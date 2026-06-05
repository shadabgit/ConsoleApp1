using System;
using System.Collections.Generic;
using System.Threading; 

namespace ConsoleApp_DelegEvents
{
    delegate IEnumerable<Person> myPersonDel();
    delegate void mySampleDeleg();
    delegate string mySampleDelgStr(string str);
    class Person {
        public int Age { get; set; } 
        public string Name { get; set; }
    }
    class UI
    {
        //List<string> names = new List<string> { "ABC","EFD","ACV"};
        List<Person> item = new List<Person> { new Person() {Age=10, Name="Sam1"}, new Person() { Age = 15, Name = "Sam2" }, new Person() { Age = 20, Name = "Sam3" } };
        public IEnumerable<Person> PersonList() {
            //List<Person> item = new List<Person>();
            //item.Add(new Person() { Age = 10, Name = "Shadab" });
            //item.Add(new Person() { Age = 12, Name = "Darab" });
            Thread.Sleep(4000);
            return item;
        }
        public Person PersonDetails()
        { 
            Person p = new Person();
            p.Age = 50;
            p.Name = "Abida";
            return p;
        }
    }
    class DelegateFirst
    {
        public static void DisplaySample() => Console.WriteLine("Sample Delegate...");
        //{
        //    Console.WriteLine("Sample Delegate...");
        //}

        public static string DisplaySampleStr(string dis) => dis;
        //{
        //    return dis;
        //}

        //static void Main(string[] args)
        //{
        //    UI uiobj = new UI();

        //    myPersonDel deleg = new myPersonDel(uiobj.PersonList);
        //    IAsyncResult asyr = deleg.BeginInvoke(null, null);          // BeginInvoke will provide a delegate thread to run in background for performing long running task.

        //    Person perDet = uiobj.PersonDetails();
        //    Console.WriteLine($"Age of person: {perDet.Age}  Name of person: {perDet.Name}");  // Main thread involve to execute this light running task on single processor.
        //                                                                                       //However when called before EndInvoke it will give feel of asynchronous call.  
        //                                                                                       // Delegate thread will remain enagaged to process the long running task in same processor.

        //    IEnumerable<Person> personLst = deleg.EndInvoke(asyr); //var personLst = deleg.EndInvoke(asyr);   // EndInvoke will terminate the thread after succesfully executing long running task.
        //    foreach (var items in personLst)
        //    {
        //        Console.WriteLine($"Age of person: {items.Age}  Name of person: {items.Name}");
        //    }

        //    //mySampleDeleg mySample = new mySampleDeleg(DisplaySample);
        //    //mySample();

        //    //mySampleDelgStr mySamplestr = new mySampleDelgStr(DisplaySampleStr);
        //    ////Console.WriteLine(mySamplestr("Shadab from Display."));
        //    //IAsyncResult asyr1 =  mySamplestr.BeginInvoke("Shadab from Display.", null, null);
        //    //string result1 = mySamplestr.EndInvoke(asyr1);
        //    //Console.WriteLine(result1);


        //    //Person perDet = uiobj.PersonDetails();
        //    //Console.WriteLine($"Age of person: {perDet.Age}  Name of person: {perDet.Name}");

        //    //var listperson = uiobj.PersonList();
        //    //foreach (var items in listperson)
        //    //{
        //    //    Console.WriteLine($"Age of person: {items.Age}  Name of person: {items.Name}");
        //    //}

        //    Console.ReadLine();
        //}
    }
}
