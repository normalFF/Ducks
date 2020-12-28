using System;

namespace PatternDecorator
{
	class Program
	{
		static void Main(string[] args)
		{
			Beverage beverage = new FriDuck();
			Console.WriteLine(beverage.GetDescription() + "\nCost: " + beverage.cost());

			beverage = new WithApples(beverage);
			beverage = new Sause(beverage);

			Console.WriteLine("\n" + beverage.GetDescription() + "\nCost: " + beverage.cost());

			Beverage beverage1 = new SrewDuck();
			beverage1 = new SauseMushroom(beverage1);
			beverage1 = new WithApples(beverage1);

			Console.WriteLine("\n" + beverage1.GetDescription() + "\nCost: " + beverage1.cost());

			Console.ReadKey();
		}
	}

	public abstract class Beverage
	{
		protected string _description;

		public string GetDescription()
		{
			return _description;
		}

		public abstract double cost();
	}

	public abstract class CocreteDecorator : Beverage
	{
		public abstract new string GetDescription();
	}

	public class FriDuck : Beverage
	{
		public FriDuck()
		{
			_description = "Fried Duck";
		}

		public override double cost()
		{
			return 1.90;
		}
	}

	public class BoiledDuck : Beverage
	{
		public BoiledDuck()
		{
			_description = "Boiled Duck";
		}

		public override double cost()
		{
			return 2.90;
		}
	}

	public class SrewDuck : Beverage
	{
		public SrewDuck()
		{
			_description = "Srew Duck";
		}

		public override double cost()
		{
			return 1.80;
		}
	}

	public class Sause : CocreteDecorator
	{
		Beverage _beverage;

		public Sause(Beverage beverage)
		{
			_beverage = beverage;
			_description = GetDescription();
		}

		public override string GetDescription()
		{
			return _beverage.GetDescription() + " With Sauce";
		}

		public override double cost()
		{
			return 0.35 + _beverage.cost();
		}
	}

	public class SauseMushroom : CocreteDecorator
	{
		Beverage _beverage;

		public SauseMushroom(Beverage beverage)
		{
			_beverage = beverage;
			_description = GetDescription();
		}

		public override string GetDescription()
		{
			return _beverage.GetDescription() + " With Mushroom Sauce";
		}

		public override double cost()
		{
			return 0.50 + _beverage.cost();
		}
	}

	public class WithApples : CocreteDecorator
	{
		Beverage _beverage;

		public WithApples(Beverage beverage)
		{
			_beverage = beverage;
			_description = GetDescription();
		}

		public override string GetDescription()
		{
			return _beverage.GetDescription() + " With Apples";
		}

		public override double cost()
		{
			return 0.20 + _beverage.cost();
		}
	}
}