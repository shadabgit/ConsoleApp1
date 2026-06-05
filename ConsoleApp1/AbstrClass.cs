using System;
using System.Reflection;

namespace XYZX
{
	abstract class AbstrClass 
	{
		 public abstract string policy();
		public string Display() { return "AbstrClass"; }
	}
	class ChildAbsClass : AbstrClass
	{
		public string LateBinding()
		{
			return "from base class";
		}
		public override string policy()
		{
			return "child ChildAbsClass policy";
		}
	}
	class Child2AbsClass : ChildAbsClass
	{
		public string LateBindingChild2()
		{
			return "from Child2AbsClass class";
		}
	}
	class Child3AbsClass : AbstrClass
	{
		public override string policy()
		{
			return "child Child3AbsClass policy";
		}
	} 
}
