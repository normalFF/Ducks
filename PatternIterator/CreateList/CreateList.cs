using System;
using System.Collections.Generic;
using DuckAndTurkeyClasses;
using DuckAndTurkeyClasses.InterfaceDuck;
using DuckAndTurkeyClasses.InterfaceTurkey;
using PatternAdabter.Adabter;

namespace PatternIterator.CreateList
{
	public class NewCreateList
	{
		public IBaseDuck[] CreatArray()
		{
			Random rnd = new Random();
			IBaseDuck[] _baseDucks = new IBaseDuck[6];

			for (int i = 0; i < 6; i++)
			{
				IBaseDuck duck = null;

				if (rnd.Next(0,10) % 2 == 0)
				{
					IFly F = ReturnFly(rnd.Next(0, 2));
					IQuick Q = ReturnQuick(rnd.Next(0, 2));
					IComposition C = ReturnComposition(rnd.Next(0, 3));

					duck = new Duck(F, Q, C);
				}
				else
				{
					Turkey turkey;

					IKudah K = ReturnKudah(rnd.Next(0, 10) % 2);
					IFly2 F = ReturnFly2(rnd.Next(0, 10) % 2);
					IComposition C = ReturnComposition(rnd.Next(0, 3));

					turkey = new Turkey(F, K, C);

					duck = new CreateDuck(turkey);
				}

				_baseDucks[i] = duck;
			}

			return _baseDucks;
		}

		public List<IBaseDuck> CreatList()
		{
			Random rnd = new Random();
			List<IBaseDuck> _baseDucks = new List<IBaseDuck>();

			for (int i = 0; i < 6; i++)
			{
				IBaseDuck duck = null;

				if (rnd.Next(0, 10) % 2 == 0)
				{
					IFly F = ReturnFly(rnd.Next(0, 2));
					IQuick Q = ReturnQuick(rnd.Next(0, 2));
					IComposition C = ReturnComposition(rnd.Next(0, 3));

					duck = new Duck(F, Q, C);
				}
				else
				{
					Turkey turkey;

					IKudah K = ReturnKudah(rnd.Next(0, 10) % 2);
					IFly2 F = ReturnFly2(rnd.Next(0, 10) % 2);
					IComposition C = ReturnComposition(rnd.Next(0, 3));

					turkey = new Turkey(F, K, C);

					duck = new CreateDuck(turkey);
				}

				_baseDucks.Add(duck);
			}

			return _baseDucks;
		}

		private IFly ReturnFly(int Num)
		{
			if (Num == 0)
			{
				return new CanFly();
			}

			if (Num == 1)
			{
				return new CantFly();
			}

			else
			{
				return new CanFlyFast();
			}
		}

		private IFly2 ReturnFly2(int Num)
		{
			if (Num == 0)
			{
				return new CanFlyInShortDist();
			}
			else
			{
				return new CantFlyInShortDist();
			}
		}

		private IQuick ReturnQuick(int Num)
		{
			if (Num == 0)
			{
				return new CanQuick();
			}

			if (Num == 1)
			{
				return new CantQuick();
			}

			else
			{
				return new Beeping();
			}
		}

		private IKudah ReturnKudah(int Num)
		{
			if (Num == 0)
			{
				return new CanKudah();
			}
			else
			{
				return new CantKudah();
			}
		}

		private IComposition ReturnComposition(int Num)
		{
			if (Num == 0)
			{
				return new Iron();
			}

			if (Num == 1)
			{
				return new Meat();
			}

			if (Num == 2)
			{
				return new Rubber();
			}

			else
			{
				return new Lead();
			}
		}
	}
}
