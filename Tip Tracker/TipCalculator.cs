using System;
using System.Text;


namespace Core
{
	public static class TipCalculator
	{
		public static Tip CalculateFifteenPercent(string total)
		{
			if (string.IsNullOrEmpty (total))
				return null;
			else {
				Tip myTip = new Tip ();
				double newDecimal = double.Parse(total);
				const double d = .15;
				//make the tip calculation and then return only 2 decimal places
				double tip = newDecimal * d;
				myTip.tipCost = tip.ToString("F");
				myTip.totalCost = (tip + newDecimal).ToString ("F");
				return myTip;
			}
			
		}

		public static Tip CalculateEighteenPercent(string total)
		{
			if (string.IsNullOrEmpty (total))
				return null;
			else {
				Tip myTip = new Tip ();
				double newDecimal = double.Parse(total);
				const double d = .18;
				//make the tip calculation and then return only 2 decimal places
				double tip = newDecimal * d;
				myTip.tipCost = tip.ToString("F");
				myTip.totalCost = (tip + newDecimal).ToString ("F");
				return myTip;
			}

		}

		public static Tip CalculateTwentyPercent(string total)
		{
			if (string.IsNullOrEmpty (total))
				return null;
			else {
				Tip myTip = new Tip ();
				double newDecimal = double.Parse(total);
				const double d = .20;
				//make the tip calculation and then return only 2 decimal places
				double tip = newDecimal * d;
				myTip.tipCost = tip.ToString("F");
				myTip.totalCost = (tip + newDecimal).ToString ("F");
				return myTip;
			}

		}
/*		private decimal ConvertStringDecimal(string stringVal) {
			decimal decimalVal = 0;

			try {
				decimalVal = System.Convert.ToDecimal(stringVal);
				return decimalVal;
			}
			catch (System.OverflowException){
				return null;
			}
			catch (System.FormatException) {
				return null;
			}
			catch (System.ArgumentNullException) {
				return null;
			}

			// Decimal to string conversion will not overflow.
			stringVal = System.Convert.ToString(decimalVal);
			return decimalVal;
		}   

*/
	} 
}

