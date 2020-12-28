using DuckAndTurkeyClasses.InterfaceDuck;

namespace DuckAndTurkeyClasses
{
	public interface IBaseDuck
	{
		void Fly();
		void Quick();
		void Composition();
	}

	public abstract class BaseDuck : IBaseDuck
	{
		readonly IFly _fly;
		readonly IQuick _quick;
		readonly IComposition _composition;

		protected BaseDuck(IFly _fly, IQuick _quick, IComposition _composition)
		{
			this._fly = _fly;
			this._quick = _quick;
			this._composition = _composition;
		}

		public void Fly()
		{
			_fly.Fly();
		}

		public void Quick()
		{
			_quick.Quick();
		}

		public void Composition()
		{
			_composition.Composition();
		}
	}
}