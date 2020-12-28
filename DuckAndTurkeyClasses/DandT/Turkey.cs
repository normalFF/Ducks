using DuckAndTurkeyClasses.InterfaceTurkey;
using DuckAndTurkeyClasses.InterfaceDuck;

namespace DuckAndTurkeyClasses
{
	public class Turkey : BaseTurkey
	{
		public Turkey(IFly2 _fly, IKudah _kudah, IComposition _composition) : base(_fly, _kudah, _composition) { }
	}
}
