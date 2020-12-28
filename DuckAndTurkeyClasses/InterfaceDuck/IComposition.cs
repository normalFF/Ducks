using System;

namespace DuckAndTurkeyClasses.InterfaceDuck
{
	public interface IComposition
	{
		void Composition();
	}

	public class Iron : IComposition
	{
		public void Composition()
		{
			Console.WriteLine("I'm composition of iron");
		}
	}

	public class Meat : IComposition
	{
		public void Composition()
		{
			Console.WriteLine("I'm composition of meat");
		}
	}

	public class Rubber : IComposition
	{
		public void Composition()
		{
			Console.WriteLine("I'm composition of rubber");
		}
	}

	public class Lead : IComposition
	{
		public void Composition()
		{
			Console.WriteLine("I'm composition of lead");
		}
	}
}
