using System;
public enum Sice { d4, d6, d8, d10, d12, d20, d100 }

public class Dice
{
	private int dice;

	public Dice()
	{
		Sice d = (Sice)(new Random()).Next(0, 5);
			switch (d)
	        {
			case Sice.d4:
				return Sice.d4;

			case Sice.d6:
				return Sice.d6;

			case Sice.d8:
				return Sice.d8;

			case Sice.d10:
				return Sice.d10;

			case Sice.d12:
				return Sice.d12;

			case Sice.d20:
				return Sice.d20;

			case Sice.d100:
				return Sice.d100;
			}
	}
}
