using System;
using DuckAndTurkeyClasses;
using PatternIterator.CreateList;
using PatternIterator.Iterator;

namespace Singletoon.Class_Singleton
{
	class Singleton
	{
		private static Singleton _singleton;
		IBaseDuck[] _baseDucks;

		private Singleton()
		{
			NewCreateList create = new NewCreateList();
			_baseDucks = create.CreatArray();
		}

		public static Singleton GetSingleton()
		{
			if (_singleton == null)
			{
				_singleton = new Singleton();
			}

			return _singleton;
		}

		public IIterator CreateIterator()
		{
			return new NewIteratorArray(_baseDucks);
		}

		public void DuckItem(IIterator iterator)
		{
			int Item = 1;
			while (iterator.hasNext())
			{
				Console.WriteLine("Элемент меню: " + Item);
				IBaseDuck baseDuck = iterator.next();
				baseDuck.Fly();
				baseDuck.Quick();
				baseDuck.Composition();
				Console.WriteLine();
				Item++;
			}
		}
	}
}