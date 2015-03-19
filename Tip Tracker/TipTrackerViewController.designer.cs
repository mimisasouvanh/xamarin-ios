// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace TipTracker
{
	[Register ("TipTrackerViewController")]
	partial class TipTrackerViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton CalcEighteenPercentButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton CalcFifteenPercentButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton CalcTwentyPercentButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField FinalTipText { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField TipText { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField TotalText { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (CalcEighteenPercentButton != null) {
				CalcEighteenPercentButton.Dispose ();
				CalcEighteenPercentButton = null;
			}
			if (CalcFifteenPercentButton != null) {
				CalcFifteenPercentButton.Dispose ();
				CalcFifteenPercentButton = null;
			}
			if (CalcTwentyPercentButton != null) {
				CalcTwentyPercentButton.Dispose ();
				CalcTwentyPercentButton = null;
			}
			if (FinalTipText != null) {
				FinalTipText.Dispose ();
				FinalTipText = null;
			}
			if (TipText != null) {
				TipText.Dispose ();
				TipText = null;
			}
			if (TotalText != null) {
				TotalText.Dispose ();
				TotalText = null;
			}
		}
	}
}
