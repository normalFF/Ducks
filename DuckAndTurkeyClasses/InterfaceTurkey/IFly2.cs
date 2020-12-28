using System;
using System.Collections.Generic;
using System.Text;

namespace DuckAndTurkeyClasses.InterfaceTurkey
{
	public interface IFly2
	{
		void Fly();
	}

	public class CanFlyInShortDist : IFly2
	{
		public void Fly()
		{
			Console.WriteLine("I can fly in short distance!");
		}
	}

	public class CantFlyInShortDist : IFly2
	{
		public void Fly()
		{
			Console.WriteLine("I can't fly in short distance!");
		}
	}
}
