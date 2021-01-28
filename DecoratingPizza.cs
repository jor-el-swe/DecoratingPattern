using System;

namespace DecoratingPattern{
	public static class Program2 {

		public interface IPizza {
			int GetCosts();
			string GetName();
		}

		public class ItalianPizza : IPizza {
			public int GetCosts() {
				return 4;
			}

			public string GetName() {
				return "Italian Pizza";
			}
		}
		
		public class AmericanPizza : IPizza {
			public int GetCosts() {
				return 8;
			}

			public string GetName() {
				return "American Pizza";
			}
		}

		public abstract class PizzaDecorator : IPizza {
			protected readonly IPizza pizza;

			public PizzaDecorator(IPizza pizza) {
				this.pizza = pizza;
			}

			public abstract int GetCosts();
			public abstract string GetName();
		}

		public class CheeseDecorator : PizzaDecorator {
			public CheeseDecorator(IPizza pizza) : base(pizza) { }

			public override int GetCosts() {
				return 2 + this.pizza.GetCosts();
			}

			public override string GetName() {
				return this.pizza.GetName() + " + Cheese";
			}
		}
		
		public class MushroomDecorator : PizzaDecorator {
			public MushroomDecorator(IPizza pizza) : base(pizza) { }

			public override int GetCosts() {
				return 1 + this.pizza.GetCosts();
			}

			public override string GetName() {
				return this.pizza.GetName() + " + Mushrooms";
			}
		}
		
		public static void Main2() {
			IPizza pizza = new ItalianPizza(); // 4
			pizza = new CheeseDecorator(pizza); // 6
			pizza = new MushroomDecorator(pizza); // 7
			pizza = new MushroomDecorator(pizza); // 8
			Console.WriteLine(pizza.GetName() + " costs: " + pizza.GetCosts());
			IPizza pizza2 = new ItalianPizza();
			Console.WriteLine(pizza2.GetName() + " costs: " + pizza2.GetCosts());
		}
	}
}
