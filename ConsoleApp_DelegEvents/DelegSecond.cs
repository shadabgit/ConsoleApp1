using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_DelegEvents
{
    /*
     - The Func delegate takes zero, one or more input parameters, and returns a value (with its out parameter).   
         // Func delegate takes upto 16 input parameters and one return type parameter.
     - The action takes zero, one or more input parameters, but does not return anything.   
        // Action delegate takes upto 16 input parameters and no return type parameter, means function returning void can be called by action delegate.
     - Predicate is a special kind of Func. It represents a method that contains a set of criteria mostly defined inside an if condition and checks whether the passed parameter meets
       those criteria or not.
       It takes one input parameter and returns a boolean - true or false.
         // Predicate takes one input parameter and always returns a Boolean value which is mandatory. This delegate can take a maximum of 1 input parameter and always return the value of the Boolean type.
        Note. You can use all three of them with anonymous methods and lambda expressions.
     */

    delegate List<string> myCustDeleg();
    class DelegSecond
    {
        public static string GetCustomerName() => "Customer Name from first function Shadab";
        public static List<string> GetCustomerList() 
        {
            System.Threading.Thread.Sleep(3000);
            return new List<string> { "Darab", "Resh", "Sab","Hasshu" };
        }
    }

    class SampleDeleg
    {
        public delegate int delOperation(int a, int b);
        //public int Operation(int m, int n) { return m * n; }
        public static int Operation(int m, int n) => m * n;
    }
    class AccessDelS
    {
        //public static void Main()
        //{
        //    //myCustDeleg myCust = new myCustDeleg(DelegSecond.GetCustomerList);
        //    //IAsyncResult asr = myCust.BeginInvoke(null, null);
        //    //List<string> lst = myCust.EndInvoke(asr);
        //    //foreach (string item in lst)
        //    //{ Console.WriteLine($"Name of customer from List function: {item}\n"); }

        //    //Console.WriteLine(DelegSecond.GetCustomerName());

        //    ////--------------------------------------------------- Func Delegate
        //    //int sumOfTwoDig(int a, int b)
        //    //{
        //    //    return a + b;
        //    //}

        //    //Func<int, int, int> twodigSum = sumOfTwoDig;     // SampleDeleg.Operation;    // signature mapping            

        //    ////Func<int, int, int> twodigSum = delegate (int x, int y) { return x + y; };  // anonymous method: func deleg taking 2 input and 1 out params
        //    ////Func<int, int, int> twodigSum = (int x, int y) => x + y;  // using lambda expression
        //    ////Func<int, int, int> twodigSum = (x, y) => x + y;  // using lambda expression

        //    //Console.WriteLine($"Sum of 2 numbers : {twodigSum(400, 300)}");

        //    //Func<int> func3 = () => { return 15; };
        //    //Func<int> func3 = () => 15;
        //    //Console.WriteLine("Result from Lambda Expression: " + func3());

        //    //Func<int, int> func2 = (int x) => {  return x + 1; };
        //    //Func<int, int> func2 = (x) => x + 1;
        //    //Console.WriteLine("Result from Lambda Expression: " + func2(20));



        //    ////---------------------------------------------------- Action Delegate
        //    //void sumOfTwoDigAct(int a, int b) => Console.WriteLine($"Sum of digits : {a + b}"); 

        //    //Action<int, int> acttwodigsum = sumOfTwoDigAct;

        //    //Action<int, int> acttwodigsum = delegate (int a, int b) { Console.WriteLine(a + b); };
        //    //Action<int, int> acttwodigsum = (int a, int b) => Console.WriteLine($"Sum of digits : {a + b}");

        //    //acttwodigsum(400, 300);

        //    // Action<int, string, string> act = (int a, string b, string c) => { Console.WriteLine(a + b + c); };
        //    //act(4, "2", "0");


        //    ////---------------------------------------------------- Predicate Delegate
        //    //bool IsApple(string modelName)
        //    //{
        //    //    if (modelName == "IPhoneX")
        //    //        return true;
        //    //    else
        //    //        return false;
        //    //}

        //    ////Predicate<string> predIsApple = IsApple;

        //    ////Predicate<string> predIsApple = delegate (string modelname) { if (modelname == "IPhoneX") return true; else return false; };
        //    ////Predicate<string> predIsApple = (string modelname) => { if (modelname == "IPhoneX") return true; else return false; };
        //    //Predicate<string> predIsApple = (modelname) => { if (modelname == "IPhoneXA") return true; else return false; };

        //    //Console.WriteLine($"Value passed found to be : {predIsApple("IPhoneX")}");

        //    //Predicate<string> predObj = (string a) =>
        //    //{
        //    //    bool tt = int.TryPars   e(a, out int aa); //Console.WriteLine( aa+" "+tt);
        //    //    return tt;
        //    //};
        //    //Console.WriteLine(predObj("99a"));


        //    //SampleDeleg.delOperation operation = new SampleDeleg.delOperation(SampleDeleg.Operation); // Using delegate instantiation ,When delegate is declared already 
        //    //Console.WriteLine($"Multiplication of number from SampleDeleg : {operation(30, 30)}");

        //    //SampleDeleg.delOperation operation = delegate (int x, int y) { return x * y; };   // Or,  When delegate is declared already 
        //    //Func<int, int, int> operation = delegate (int x, int y) { return x * y; };          // Or,  When delegate not declared at class or function level then use inbuilt delegate

        //    //Func<int, int, int> operation = (int x, int y) => x * y;                      // Or, when we want multiple stmt then put logic in brackets.

        //    //Func<int, int, int> operation = (int x, int y) => { x *= y; return x; };
        //    //Console.WriteLine($"Multiplication of number from SampleDeleg : {operation(30, 30)}");
        //    //Or,
        //    Func<int, int, int> operationS = (x, y) => { x = x * y; Console.WriteLine($"Multiplication of number from SampleDeleg : {x}"); return x; };
        //    operationS(30, 30);

        //    Console.ReadLine();
        //}
    }
}
