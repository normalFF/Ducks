using System;
using DuckAndTurkeyClasses;
using DuckAndTurkeyClasses.InterfaceDuck;
using DuckAndTurkeyClasses.InterfaceTurkey;
using PatternAdabter.Adabter;

namespace PatternAdabter
{
	class Program
	{
		static void Main(string[] args)
		{
			Turkey turkey = new Turkey(new CanFlyInShortDist(), new CanKudah(), new Meat());
			Duck duck = new Duck(new CanFly(), new CanQuick(), new Meat());

			Console.WriteLine("Duck said:");

			duck.Fly();
			duck.Quick();
			duck.Composition();

			Console.WriteLine("Turkey said:");

			turkey.Fly();
			turkey.Kudah();
			duck.Composition();

			IBaseDuck duck1 = new CreateDuck(turkey);

			Console.WriteLine("Duck(Turkey) said:");

			duck1.Fly();
			duck1.Quick();
			duck1.Composition();

			Console.ReadKey();
		}
	}
}