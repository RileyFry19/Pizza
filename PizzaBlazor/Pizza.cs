namespace PizzaBlazor
{
	public class Pizza
	{
		public Topping PizzaTopping { get; set; }
		public Crust PizzaCrust { get; set; }
		public Tip PizzaTip { get; set; }

		public Pizza() 
		{ 
			PizzaTopping = new Topping();
			PizzaCrust = new Crust();
			PizzaTip = new Tip();
		}
		public double GetToppingPrice()
		{
			double topPrice = PizzaTopping.ToppingPrice();

			return topPrice;
		}

		public double GetCrustPrice()
		{
			double crustPrice = PizzaCrust.CrustPrice();

			return crustPrice;
		}

		public double GetTipPrice()
		{
			double tip = PizzaTip.TipPercent() * (PizzaTopping.ToppingPrice() + PizzaCrust.CrustPrice() + 2);

			return tip;
		}

		public double PizzaTotal()
		{
			double total = 2 + PizzaTopping.ToppingPrice() + PizzaCrust.CrustPrice() + GetTipPrice();

			return total;
		}
	}

	public class Topping
	{
		public bool Pepperoni { get; set; }
		public bool ExtraCheese { get; set; }
		public bool Ham { get; set; }
		public bool Chicken { get; set; }
		public double ToppingPrice()
		{
			double toppingTotal = 0;

			if (Pepperoni)
			{
				toppingTotal += 1.50;
			}
			
			if (ExtraCheese)
			{
				toppingTotal += 2.00;
			}
			if (Ham)
			{
				toppingTotal += 1.79;
			}
			if (Chicken)
			{
				toppingTotal += 3;
			}
			return toppingTotal;
		}
	}

	public class Crust
	{
		public bool ThinCrust { get; set; }
		public bool PanCrust { get; set; }
		public bool HandTossed { get; set; }
		public double CrustPrice()
		{
			double crustTotal = 0;

			if (ThinCrust)
			{
				crustTotal += 5.99;
			}
			if (PanCrust)
			{
				crustTotal += 7.99;
			}
			if (HandTossed)
			{
				crustTotal += 6.99;
			}
			return crustTotal;
		}
	}

	public class Tip
	{
		public bool First { get; set; }
		public bool Second { get; set; }
		public bool Third { get; set; }
		public double TipPercent()
		{
			double tip = 0;

			if (First)
			{
				tip = 0.12;
			}
			if (Second)
			{
				tip = 0.15;
			}
			if (Third)
			{
				tip = 0.18;
			}
			return tip;
		}
	}
}
