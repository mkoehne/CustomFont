using System;
using CoreGraphics;
using UIKit;

namespace CustomFont
{
	public partial class ViewController : UIViewController
	{
		protected ViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			UILabel label = new UILabel(new CGRect(20, 100, 200, 40));
			label.Text = "OpenSans Font";
			label.Font = UIFont.FromName("OpenSans", 20f);
			this.View.Add(label);

			UILabel label2 = new UILabel(new CGRect(20, 160, 200, 40));
			label2.Text = "Standart Font";
			this.View.Add(label2);

			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}
