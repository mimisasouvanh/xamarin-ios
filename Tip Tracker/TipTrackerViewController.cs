﻿using System;
using System.Drawing;

using Foundation;
using UIKit;

namespace TipTracker
{
	public partial class TipTrackerViewController : UIViewController
	{
		static bool UserInterfaceIdiomIsPhone {
			get { return UIDevice.CurrentDevice.UserInterfaceIdiom == UIUserInterfaceIdiom.Phone; }
		}

		public TipTrackerViewController (IntPtr handle) : base (handle)
		{
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		#region View lifecycle

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			
			// Perform any additional setup after loading the view, typically from a nib.
			//string displayTip = "";
			//string totalBill = "";

			var thisTip = new Core.Tip ();

			CalcFifteenPercentButton.TouchUpInside += (object sender, EventArgs e) => {
				thisTip = Core.TipCalculator.CalculateFifteenPercent(TipText.Text);
				TipText.ResignFirstResponder();
				if(thisTip.tipCost == ""){
					FinalTipText.Text = "Invalid";
				}
				else { 
					TotalText.Text = thisTip.totalCost;
					FinalTipText.Text = thisTip.tipCost; 
				}
			};

			CalcEighteenPercentButton.TouchUpInside += (object sender, EventArgs e) => {
				thisTip = Core.TipCalculator.CalculateEighteenPercent(TipText.Text);
				TipText.ResignFirstResponder();
				if(thisTip == ""){
					FinalTipText.Text = "Invalid";
				}
				else { 
					TotalText.Text = thisTip.totalCost;
					FinalTipText.Text = thisTip.tipCost; 
				}
			};

			CalcTwentyPercentButton.TouchUpInside += (object sender, EventArgs e) => {
				thisTip = Core.TipCalculator.CalculateTwentyPercent(TipText.Text);
				TipText.ResignFirstResponder();
				if(displayTip == ""){
					FinalTipText.Text = "Invalid";
				}
				else { 
					TotalText.Text = thisTip.totalCost;
					FinalTipText.Text = thisTip.tipCost; 
				}
			};
		}

		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);
		}

		public override void ViewDidAppear (bool animated)
		{
			base.ViewDidAppear (animated);
		}

		public override void ViewWillDisappear (bool animated)
		{
			base.ViewWillDisappear (animated);
		}

		public override void ViewDidDisappear (bool animated)
		{
			base.ViewDidDisappear (animated);
		}

		#endregion
	}
}

