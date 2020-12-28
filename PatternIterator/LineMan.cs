using System;
using System.Collections.Generic;
using DuckAndTurkeyClasses;
using DuckAndTurkeyClasses.InterfaceDuck;
using PatternIterator.Iterator;
using PatternIterator.LeftDuck;
using PatternIterator.RightDuck;

namespace PatternIterator
{
	class LineMan
	{
		RDuck _rDuck;
		LDuck _lDuck;

		public LineMan(RDuck rDuck, LDuck lDuck)
		{
			_rDuck = rDuck;
			_lDuck = lDuck;
		}

		public void ListDuck()
		{
			IIterator iterator = _lDuck.CreateIterator();
			IIterator iterator1 = _rDuck.CreateIterator();

			Console.WriteLine("Right Duck:");
			ReadDuckMenu(iterator1);
			Console.WriteLine("\n\nLeft Duck:");
			ReadDuckMenu(iterator);
		}

		public void ReadDuckMenu(IIterator iterator)
		{
			int Item = 1;
			while (iterator.hasNext())
			{
				Console.WriteLine("Элемент меню: " + Item);
				IBaseDuck baseDuck = (IBaseDuck)iterator.next();
				baseDuck.Fly();
				baseDuck.Quick();
				baseDuck.Composition();
				Console.WriteLine();
				Item++;
			}
		}
	}
}