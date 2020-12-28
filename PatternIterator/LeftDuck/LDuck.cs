using System;
using DuckAndTurkeyClasses;
using PatternIterator.CreateList;
using PatternIterator.Iterator;

namespace PatternIterator.LeftDuck
{
	class LDuck
	{
		IBaseDuck[] _baseDucks;

		public LDuck()
		{
			NewCreateList createList = new NewCreateList();
			_baseDucks = createList.CreatArray();
		}

		public IIterator CreateIterator()
		{
			return new NewIteratorArray(_baseDucks);
		}
	}
}
