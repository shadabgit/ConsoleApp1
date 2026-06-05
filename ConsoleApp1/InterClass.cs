using System;
using System.Reflection;

namespace XYZ
{

	interface IRules 
	{
		string Name { get; set; }
		string policy();
	}
	class InterClass : IRules
	{
		string empName = "Shadab";
        //public string Name { get => empName; set => empName = "Shadab Ansari"; }
        public string Name { get; set; }

        public string LateBinding()
		{
			return "from base class ";
		}
		public string policy()
		{
			Name = empName;
			return "from base class policy employee Name : " + Name;
		}
    }
	class InterClassChild1 : InterClass
	{
		public string LateBindingC()
		{return "child class ";
		}
	}
	class InterClassChild2 : InterClassChild1
	{
		public new string LateBindingC()   //Warning CS0108	'InterClassChild2.LateBindingC()' hides inherited member 'InterClassChild1.LateBindingC()'.
										   //Use the new keyword if hiding was intended.

		{
			return "child class ";
		}
	}

}
