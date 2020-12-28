using System;
using System.Collections.Generic;
using DuckAndTurkeyClasses;
using DuckAndTurkeyClasses.InterfaceDuck;

namespace PatternIterator.Iterator
{
	public interface IIterator
	{
		bool hasNext();
		IBaseDuck next();
	}

	public class NewIteratorArray : IIterator
	{
		IBaseDuck[] _baseDuck;
		int _index = 0;

		public NewIteratorArray(IBaseDuck[] _baseDucks)
		{
			this._baseDuck = _baseDucks;
		}

		public IBaseDuck next()
		{
			IBaseDuck duck = _baseDuck[_index];
			_index++;
			return duck;
		}

		public bool hasNext()
		{
			if (_index >= _baseDuck.Length || _baseDuck[_index] == null)
				return false;
			else
				return true;
		}
	}

	public class NewIteratorList : IIterator
	{
		List<IBaseDuck> _baseDuck;
		int _index = 0;

		public NewIteratorList(List<IBaseDuck> _baseDucks)
		{
			this._baseDuck = _baseDucks;
		}

		public IBaseDuck next()
		{
			IBaseDuck duck = _baseDuck[_index];
			_index++;
			return duck;
		}

		public bool hasNext()
		{
			if (_index >= _baseDuck.Count || _baseDuck[_index] == null)
				return false;
			else
				return true;
		}
	}
}