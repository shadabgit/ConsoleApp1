using System;
namespace ABC
{
    public class EmployeeDC
    {
        //~ internal EmployeeDC(){}  -- error.
        //public EmployeeDC()
        //{
        //} 
        public string Disp()
        { return "Shadab"; }
    }

    public class HCL
    {
        public HCL()
        {
            System.Console.WriteLine("from HCL"); 
        }
    }
    public class IT
    { 
        HCL hcl = new HCL();
        public void ShowIT() 
        {
            //hcl = new HCL();
            System.Console.WriteLine("From IT"); 
        }
    }

}

