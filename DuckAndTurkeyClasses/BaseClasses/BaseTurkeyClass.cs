using DuckAndTurkeyClasses.InterfaceDuck;
using DuckAndTurkeyClasses.InterfaceTurkey;

namespace DuckAndTurkeyClasses
{
	public interface IBaseTurkey
	{
		void Fly();
		void Kudah();
		void Composition();
	}

	public abstract class BaseTurkey : IBaseTurkey
	{
		readonly IFly2 _fly;
		readonly IKudah _kudah;
		readonly IComposition _composition;

		protected BaseTurkey(IFly2 _fly, IKudah _kudah, IComposition _composition)
		{
			this._fly = _fly;
			this._kudah = _kudah;
			this._composition = _composition;
		}

		public void Fly()
		{
			_fly.Fly();
		}

		public void Kudah()
		{
			_kudah.Kudah();
		}

		public void Composition()
		{
			_composition.Composition();
		}
	}
}
