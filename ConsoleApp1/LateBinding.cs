using System;
using System.Reflection;

namespace XYZ
{
	
	class Access
	{
		public string LateBinding()
		{
			//public static void Main()
			//{
			//Employee emp = new Employee();
			//string res = emp.Disp();
			//Console.WriteLine(res);

			Assembly assembly = Assembly.LoadFrom("C:\\Practice Code\\EmployeeDC.dll");  // taking reference of assembly EmployeeDC.dll
			Type objType = assembly.GetType("ABC.EmployeeDC");  //using ABC;
			object obj = Activator.CreateInstance(objType);    //EmployeeDC emp = new EmployeeDC();
			MethodInfo methodInfo = objType.GetMethod("Disp");	
			object output = methodInfo.Invoke(obj, null);     //emp.Disp()
			Console.WriteLine(output.ToString());
			//}
			return output.ToString();
		}
	}
}
