using System;
using System.Collections;
using System.Collections.Generic;
using DuckAndTurkeyClasses;
using PatternIterator.CreateList;
using PatternIterator.Iterator;

namespace PatternIterator.RightDuck
{
	class RDuck
	{
		List<IBaseDuck> _baseDucks;

		public RDuck()
		{
			NewCreateList createList = new NewCreateList();
			_baseDucks = createList.CreatList();
		}

		public IIterator CreateIterator()
		{
			return new NewIteratorList(_baseDucks);
		}
	}
}
