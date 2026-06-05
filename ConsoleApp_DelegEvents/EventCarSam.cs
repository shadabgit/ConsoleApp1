using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_DelegEvents
{
    public delegate void OwnerChangedHandler(string newOwner);
    public class Car
    {
        private string car_owner;
        public event OwnerChangedHandler changedOwnerEvent;
        public string Owner
        {
            get => car_owner;
            set
            {
                car_owner = value;
                if(changedOwnerEvent!=null)
                    changedOwnerEvent.Invoke(value); 
                    // Or, changedOwnerEvent(value);
            }
        }
        public Car()
        {
            car_owner = "BMW Manufacturing";
            Console.WriteLine($"{car_owner} is sole owner initially..");
        }
    }
    class CustomerNormal
    {
        public static void getCustomerName(string name) => Console.WriteLine($"Name of Normal owner : {name}");
    }

    class CustomerVIP
    {
        public static void getCustomerName(string name) => Console.WriteLine($"Name of VIP owner : {name}");
    }
    class CarProg
    {
        //public static void Main()
        //{
        //    Car myCar = new Car();

        //    //myCar.changedOwnerEvent += (string x) => Console.WriteLine($"New owner is {x}");    // Or, 
        //    //myCar.changedOwnerEvent += x => Console.WriteLine($"New owner is {x}");             // Or, define separate methods in subscriber classes like CustomerOld and CustomerNew

        //    myCar.changedOwnerEvent += CustomerNormal.getCustomerName;
        //    myCar.Owner = "Shadab";
        //    myCar.changedOwnerEvent -= CustomerNormal.getCustomerName;

        //    myCar.changedOwnerEvent += CustomerVIP.getCustomerName;
        //    myCar.Owner = "Mr Darab";

        //    Console.ReadKey();
        //}
    }

    /*public delegate void carEventHandler(string msg);
    class Car
    {
        string car_owner;
        public event carEventHandler changedOwnerEvent;
        public void CarExpoCall(string ownerparam)
        {
            Console.WriteLine("Car expo initiated..");
            System.Threading.Thread.Sleep(3000);                // Simulate car event delay
            Console.WriteLine("Car ownership transferred.");
            getCarOwnership(ownerparam);
        } 
        public virtual void getCarOwnership(string owner)
        {
            car_owner = owner;
            if (changedOwnerEvent != null) { changedOwnerEvent(car_owner); }
        }
    }

    class KIA : Car
    {
        public override void getCarOwnership(string owner) => Console.WriteLine($"KIA Car dealership at {owner}");
    }
    class Hyundai :Car
    {
        public override void getCarOwnership(string owner) => Console.WriteLine($"Hyundai Car dealership at {owner}");
    }

    class Expo
    {
        //public static void Main()
        //{
        //    Car shadab = new Car();

        //    KIA kiacars = new KIA();
        //    Hyundai hyundaicars = new Hyundai();

        //    shadab.changedOwnerEvent += new carEventHandler(kiacars.getCarOwnership);  // Subscribe to the event can be done either ways...
        //    shadab.changedOwnerEvent += hyundaicars.getCarOwnership;

        //    shadab.CarExpoCall("Auto expo 2025, Noida Expo Center !!");         // triggering events

        //    Console.ReadKey();
        //}
    }
    */
}
