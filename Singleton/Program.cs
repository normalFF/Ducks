using System;
using DuckAndTurkeyClasses;
using Singletoon.Class_Singleton;
using PatternIterator.Iterator;

namespace Singletoon
{
	class Program
	{
		static void Main(string[] args)
		{
			Singleton singleton = Singleton.GetSingleton();

			IIterator iterator = singleton.CreateIterator();
			singleton.DuckItem(iterator);

			Console.ReadKey();
		}
	}
}