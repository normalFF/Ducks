using DuckAndTurkeyClasses;

namespace PatternAdabter.Adabter
{
	public class CreateDuck : IBaseDuck
	{
		IBaseTurkey _turkey;

		public CreateDuck(IBaseTurkey _turkey)
		{
			this._turkey = _turkey;
		}

		public void Fly()
		{
			_turkey.Fly();
		}

		public void Quick()
		{
			_turkey.Kudah();
		}

		public void Composition()
		{
			_turkey.Composition();
		}
	}
}
