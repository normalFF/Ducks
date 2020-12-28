using System;

namespace DuckAndTurkeyClasses.InterfaceTurkey
{
	public interface IKudah
	{
		void Kudah();
	}

	public class CanKudah : IKudah
	{
		public void Kudah()
		{
			Console.WriteLine("I can kudah!");
		}
	}

	public class CantKudah : IKudah
	{
		public void Kudah()
		{
			Console.WriteLine("I can't kudah!");
		}
	}
}
