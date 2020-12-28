using System;
using DuckAndTurkeyClasses;
using DuckAndTurkeyClasses.InterfaceDuck;

namespace Ducks
{
	class Program
	{
		static void Main(string[] args)
		{
			Duck duck = new Duck(new CanFly(), new CanQuick(), new Iron());
			Duck duck2 = new Duck(new CantFly(), new CantQuick(), new Meat());

			Console.WriteLine("Duck1:");
			Info(duck);

			Console.WriteLine();
			Console.WriteLine("Duck1:");
			Info(duck2);

			Console.ReadKey();
		}

		static void Info(Duck duck)
		{
			duck.Fly();
			duck.Quick();
			duck.Composition();
		}
	}
}