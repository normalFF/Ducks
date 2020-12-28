using System;

namespace DuckAndTurkeyClasses.InterfaceDuck
{
	public interface IFly
	{
		void Fly();
	}

	public class CanFly : IFly
	{
		public void Fly()
		{
			Console.WriteLine("I can fly!");
		}
	}

	public class CantFly : IFly
	{
		public void Fly()
		{
			Console.WriteLine("I can't fly!");
		}
	}

	public class CanFlyFast : IFly
	{
		public void Fly()
		{
			Console.WriteLine("I can fly very fast!");
		}
	}
}