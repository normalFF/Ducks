using System;
using PatternIterator.LeftDuck;
using PatternIterator.RightDuck;
using System.Collections.Generic;

namespace PatternIterator
{
	class Program
	{
		static void Main(string[] args)
		{
			LDuck lDuck = new LDuck();
			RDuck rDuck = new RDuck();
			LineMan LN = new LineMan(rDuck, lDuck);

			LN.ListDuck();

			Console.ReadKey();
		}
	}
}
