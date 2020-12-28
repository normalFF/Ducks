using System;
using DuckAndTurkeyClasses.InterfaceDuck;

namespace DuckAndTurkeyClasses
{
	public class Duck : BaseDuck
	{
		public Duck(IFly _fly, IQuick _quick, IComposition _composition) : base(_fly, _quick, _composition) { }
	}
}
