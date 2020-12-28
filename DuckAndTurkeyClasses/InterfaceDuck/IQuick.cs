using System;

namespace DuckAndTurkeyClasses.InterfaceDuck
{
	public interface IQuick
	{
		void Quick();
	}

	public class CanQuick : IQuick
	{
		public void Quick()
		{
			Console.WriteLine("I Can Quick!");
		}
	}

	public class CantQuick : IQuick
	{
		public void Quick()
		{
			Console.WriteLine("I can't Quick!");
		}
	}

	public class Beeping : IQuick
	{
		public void Quick()
		{
			Console.WriteLine("I Can beeping!");
		}
	}
}